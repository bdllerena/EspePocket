package mono.com.google.android.gms.ads.mediation;


public class MediationNativeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.mediation.MediationNativeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdClicked:(Lcom/google/android/gms/ads/mediation/MediationNativeAdapter;)V:GetOnAdClicked_Lcom_google_android_gms_ads_mediation_MediationNativeAdapter_Handler:Android.Gms.Ads.Mediation.IMediationNativeListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdClosed:(Lcom/google/android/gms/ads/mediation/MediationNativeAdapter;)V:GetOnAdClosed_Lcom_google_android_gms_ads_mediation_MediationNativeAdapter_Handler:Android.Gms.Ads.Mediation.IMediationNativeListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdFailedToLoad:(Lcom/google/android/gms/ads/mediation/MediationNativeAdapter;I)V:GetOnAdFailedToLoad_Lcom_google_android_gms_ads_mediation_MediationNativeAdapter_IHandler:Android.Gms.Ads.Mediation.IMediationNativeListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdImpression:(Lcom/google/android/gms/ads/mediation/MediationNativeAdapter;)V:GetOnAdImpression_Lcom_google_android_gms_ads_mediation_MediationNativeAdapter_Handler:Android.Gms.Ads.Mediation.IMediationNativeListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdLeftApplication:(Lcom/google/android/gms/ads/mediation/MediationNativeAdapter;)V:GetOnAdLeftApplication_Lcom_google_android_gms_ads_mediation_MediationNativeAdapter_Handler:Android.Gms.Ads.Mediation.IMediationNativeListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdLoaded:(Lcom/google/android/gms/ads/mediation/MediationNativeAdapter;Lcom/google/android/gms/ads/mediation/NativeAdMapper;)V:GetOnAdLoaded_Lcom_google_android_gms_ads_mediation_MediationNativeAdapter_Lcom_google_android_gms_ads_mediation_NativeAdMapper_Handler:Android.Gms.Ads.Mediation.IMediationNativeListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdOpened:(Lcom/google/android/gms/ads/mediation/MediationNativeAdapter;)V:GetOnAdOpened_Lcom_google_android_gms_ads_mediation_MediationNativeAdapter_Handler:Android.Gms.Ads.Mediation.IMediationNativeListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Mediation.IMediationNativeListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MediationNativeListenerImplementor.class, __md_methods);
	}


	public MediationNativeListenerImplementor ()
	{
		super ();
		if (getClass () == MediationNativeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Mediation.IMediationNativeListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAdClicked (com.google.android.gms.ads.mediation.MediationNativeAdapter p0)
	{
		n_onAdClicked (p0);
	}

	private native void n_onAdClicked (com.google.android.gms.ads.mediation.MediationNativeAdapter p0);


	public void onAdClosed (com.google.android.gms.ads.mediation.MediationNativeAdapter p0)
	{
		n_onAdClosed (p0);
	}

	private native void n_onAdClosed (com.google.android.gms.ads.mediation.MediationNativeAdapter p0);


	public void onAdFailedToLoad (com.google.android.gms.ads.mediation.MediationNativeAdapter p0, int p1)
	{
		n_onAdFailedToLoad (p0, p1);
	}

	private native void n_onAdFailedToLoad (com.google.android.gms.ads.mediation.MediationNativeAdapter p0, int p1);


	public void onAdImpression (com.google.android.gms.ads.mediation.MediationNativeAdapter p0)
	{
		n_onAdImpression (p0);
	}

	private native void n_onAdImpression (com.google.android.gms.ads.mediation.MediationNativeAdapter p0);


	public void onAdLeftApplication (com.google.android.gms.ads.mediation.MediationNativeAdapter p0)
	{
		n_onAdLeftApplication (p0);
	}

	private native void n_onAdLeftApplication (com.google.android.gms.ads.mediation.MediationNativeAdapter p0);


	public void onAdLoaded (com.google.android.gms.ads.mediation.MediationNativeAdapter p0, com.google.android.gms.ads.mediation.NativeAdMapper p1)
	{
		n_onAdLoaded (p0, p1);
	}

	private native void n_onAdLoaded (com.google.android.gms.ads.mediation.MediationNativeAdapter p0, com.google.android.gms.ads.mediation.NativeAdMapper p1);


	public void onAdOpened (com.google.android.gms.ads.mediation.MediationNativeAdapter p0)
	{
		n_onAdOpened (p0);
	}

	private native void n_onAdOpened (com.google.android.gms.ads.mediation.MediationNativeAdapter p0);

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
