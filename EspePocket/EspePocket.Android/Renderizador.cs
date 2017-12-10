﻿using Android.Gms.Ads;
using Android.Widget;
using EspePocket.Droid;
using EspePocket.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PersonaWebView), typeof(CustomWebA19))]
[assembly: ExportRendererAttribute(typeof(PersonaBoton), typeof(CustomButtonRenderer))]
[assembly: ExportRenderer(typeof(WebView), typeof(CustomWebA20))]
[assembly: Dependency(typeof(FileHelper))]
[assembly: ExportRenderer(typeof(AdControlView), typeof(AdViewRenderer))]

namespace EspePocket.Droid
{
    public class CustomWebA19 : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                if (Android.OS.Build.VERSION.SdkInt < Android.OS.BuildVersionCodes.Kitkat)
                {
                    var customWebView = Element as PersonaWebView;
                    Control.Settings.AllowUniversalAccessFromFileURLs = true;
                    Device.OpenUri(new Uri(customWebView.Uri));
                    Toast.MakeText(Android.App.Application.Context, "Abrir en Google Chrome/Google Drive", ToastLength.Short).Show();
                }
                else
                {
                    if (e.NewElement != null)
                    {
                        var customWebView = Element as PersonaWebView;
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
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }

    public class AdViewRenderer : ViewRenderer<AdControlView, AdView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var ad = new Android.Gms.Ads.AdView(Forms.Context);
                ad.AdSize = Android.Gms.Ads.AdSize.Banner;
                ad.AdUnitId = "ca-app-pub-4439565908148332/2255513008";

                var requestbuilder = new Android.Gms.Ads.AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());

                SetNativeControl(ad);
            }
        }
    }
}