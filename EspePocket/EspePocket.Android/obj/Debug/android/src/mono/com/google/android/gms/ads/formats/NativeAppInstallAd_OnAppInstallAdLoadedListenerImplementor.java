package mono.com.google.android.gms.ads.formats;


public class NativeAppInstallAd_OnAppInstallAdLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.formats.NativeAppInstallAd.OnAppInstallAdLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAppInstallAdLoaded:(Lcom/google/android/gms/ads/formats/NativeAppInstallAd;)V:GetOnAppInstallAdLoaded_Lcom_google_android_gms_ads_formats_NativeAppInstallAd_Handler:Android.Gms.Ads.Formats.NativeAppInstallAd/IOnAppInstallAdLoadedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Formats.NativeAppInstallAd+IOnAppInstallAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NativeAppInstallAd_OnAppInstallAdLoadedListenerImplementor.class, __md_methods);
	}


	public NativeAppInstallAd_OnAppInstallAdLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == NativeAppInstallAd_OnAppInstallAdLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Formats.NativeAppInstallAd+IOnAppInstallAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAppInstallAdLoaded (com.google.android.gms.ads.formats.NativeAppInstallAd p0)
	{
		n_onAppInstallAdLoaded (p0);
	}

	private native void n_onAppInstallAdLoaded (com.google.android.gms.ads.formats.NativeAppInstallAd p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
