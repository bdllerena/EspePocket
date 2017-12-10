using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Gms.Ads;

namespace EspePocket.Droid
{
    [Activity(Label = "EspePocket", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            MobileAds.Initialize(ApplicationContext, "ca-app-pub-4439565908148332~2659433183");
        }

    }
}

