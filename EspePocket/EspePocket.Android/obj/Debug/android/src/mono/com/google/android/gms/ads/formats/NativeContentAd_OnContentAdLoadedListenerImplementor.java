package mono.com.google.android.gms.ads.formats;


public class NativeContentAd_OnContentAdLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.formats.NativeContentAd.OnContentAdLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onContentAdLoaded:(Lcom/google/android/gms/ads/formats/NativeContentAd;)V:GetOnContentAdLoaded_Lcom_google_android_gms_ads_formats_NativeContentAd_Handler:Android.Gms.Ads.Formats.NativeContentAd/IOnContentAdLoadedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Formats.NativeContentAd+IOnContentAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NativeContentAd_OnContentAdLoadedListenerImplementor.class, __md_methods);
	}


	public NativeContentAd_OnContentAdLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == NativeContentAd_OnContentAdLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Formats.NativeContentAd+IOnContentAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onContentAdLoaded (com.google.android.gms.ads.formats.NativeContentAd p0)
	{
		n_onContentAdLoaded (p0);
	}

	private native void n_onContentAdLoaded (com.google.android.gms.ads.formats.NativeContentAd p0);

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
