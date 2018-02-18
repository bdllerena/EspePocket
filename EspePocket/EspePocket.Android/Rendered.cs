using Android.Widget;
using EspePocket.Droid;
using EspePocket.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PersonWebView), typeof(CustomWebA19))]
[assembly: ExportRendererAttribute(typeof(PersonButton), typeof(CustomButtonRenderer))]
[assembly: ExportRenderer(typeof(WebView), typeof(CustomWebA20))]
[assembly: Dependency(typeof(FileHelper))]

namespace EspePocket.Droid
{
    /// <summary>
    /// Render website and opens Google Chrome or Google Drive if Api level is 19 or lower
    /// </summary>
    public class CustomWebA19 : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                if (Android.OS.Build.VERSION.SdkInt < Android.OS.BuildVersionCodes.Kitkat)
                {
                    var customWebView = Element as PersonWebView;
                    Control.Settings.AllowUniversalAccessFromFileURLs = true;
                    Device.OpenUri(new Uri(customWebView.Uri));
                    Toast.MakeText(Android.App.Application.Context, "Abrir en Google Chrome/Google Drive", ToastLength.Short).Show();
                }
                else
                {
                    if (e.NewElement != null)
                    {
                        var customWebView = Element as PersonWebView;
                        Control.Settings.BuiltInZoomControls = true;
                        Control.Settings.DisplayZoomControls = false;
                        Control.Settings.JavaScriptEnabled = true;
                        Control.Settings.DomStorageEnabled = true;
                        Control.Settings.UseWideViewPort = true;
                        Control.Settings.AllowUniversalAccessFromFileURLs = true;
                        Control.SetInitialScale(25);
                        Control.LoadUrl(customWebView.Uri);
                    }
                }
            }
        }
    }
    /// <summary>
    /// Render website on a webview if Api level is more than 20
    /// </summary>
    public class CustomWebA20 : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.BuiltInZoomControls = true;
            Control.Settings.DisplayZoomControls = false;
            Control.Settings.JavaScriptEnabled = true;
            Control.Settings.DomStorageEnabled = true;
            Control.Settings.UseWideViewPort = true;
            Control.Settings.LoadWithOverviewMode = true;
            Control.Settings.AllowUniversalAccessFromFileURLs = true;
            Control.SetInitialScale(1);
        }
    }
    /// <summary>
    /// This method set letters of a button as lowercase
    /// </summary>
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetAllCaps(false);
            }
        }
    }
    /// <summary>
    /// This method gets the total file path name of a file located in resources
    /// </summary>
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}