package mono.com.google.android.gms.ads.formats;


public class NativeCustomTemplateAd_OnCustomTemplateAdLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.formats.NativeCustomTemplateAd.OnCustomTemplateAdLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCustomTemplateAdLoaded:(Lcom/google/android/gms/ads/formats/NativeCustomTemplateAd;)V:GetOnCustomTemplateAdLoaded_Lcom_google_android_gms_ads_formats_NativeCustomTemplateAd_Handler:Android.Gms.Ads.Formats.INativeCustomTemplateAdOnCustomTemplateAdLoadedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Formats.INativeCustomTemplateAdOnCustomTemplateAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NativeCustomTemplateAd_OnCustomTemplateAdLoadedListenerImplementor.class, __md_methods);
	}


	public NativeCustomTemplateAd_OnCustomTemplateAdLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == NativeCustomTemplateAd_OnCustomTemplateAdLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Formats.INativeCustomTemplateAdOnCustomTemplateAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCustomTemplateAdLoaded (com.google.android.gms.ads.formats.NativeCustomTemplateAd p0)
	{
		n_onCustomTemplateAdLoaded (p0);
	}

	private native void n_onCustomTemplateAdLoaded (com.google.android.gms.ads.formats.NativeCustomTemplateAd p0);

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
