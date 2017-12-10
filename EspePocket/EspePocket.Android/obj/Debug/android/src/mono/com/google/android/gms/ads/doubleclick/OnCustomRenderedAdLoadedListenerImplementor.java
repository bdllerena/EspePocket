package mono.com.google.android.gms.ads.doubleclick;


public class OnCustomRenderedAdLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.doubleclick.OnCustomRenderedAdLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCustomRenderedAdLoaded:(Lcom/google/android/gms/ads/doubleclick/CustomRenderedAd;)V:GetOnCustomRenderedAdLoaded_Lcom_google_android_gms_ads_doubleclick_CustomRenderedAd_Handler:Android.Gms.Ads.DoubleClick.IOnCustomRenderedAdLoadedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.DoubleClick.IOnCustomRenderedAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnCustomRenderedAdLoadedListenerImplementor.class, __md_methods);
	}


	public OnCustomRenderedAdLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == OnCustomRenderedAdLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.DoubleClick.IOnCustomRenderedAdLoadedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCustomRenderedAdLoaded (com.google.android.gms.ads.doubleclick.CustomRenderedAd p0)
	{
		n_onCustomRenderedAdLoaded (p0);
	}

	private native void n_onCustomRenderedAdLoaded (com.google.android.gms.ads.doubleclick.CustomRenderedAd p0);

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
