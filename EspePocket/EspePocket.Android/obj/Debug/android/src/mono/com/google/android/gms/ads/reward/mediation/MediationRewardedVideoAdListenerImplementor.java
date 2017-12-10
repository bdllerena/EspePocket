package mono.com.google.android.gms.ads.reward.mediation;


public class MediationRewardedVideoAdListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdClicked:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;)V:GetOnAdClicked_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdClosed:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;)V:GetOnAdClosed_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdFailedToLoad:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;I)V:GetOnAdFailedToLoad_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_IHandler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdLeftApplication:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;)V:GetOnAdLeftApplication_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdLoaded:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;)V:GetOnAdLoaded_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onAdOpened:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;)V:GetOnAdOpened_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onInitializationFailed:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;I)V:GetOnInitializationFailed_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_IHandler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onInitializationSucceeded:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;)V:GetOnInitializationSucceeded_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onRewarded:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;Lcom/google/android/gms/ads/reward/RewardItem;)V:GetOnRewarded_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Lcom_google_android_gms_ads_reward_RewardItem_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"n_onVideoStarted:(Lcom/google/android/gms/ads/reward/mediation/MediationRewardedVideoAdAdapter;)V:GetOnVideoStarted_Lcom_google_android_gms_ads_reward_mediation_MediationRewardedVideoAdAdapter_Handler:Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MediationRewardedVideoAdListenerImplementor.class, __md_methods);
	}


	public MediationRewardedVideoAdListenerImplementor ()
	{
		super ();
		if (getClass () == MediationRewardedVideoAdListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Reward.Mediation.IMediationRewardedVideoAdListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAdClicked (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0)
	{
		n_onAdClicked (p0);
	}

	private native void n_onAdClicked (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0);


	public void onAdClosed (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0)
	{
		n_onAdClosed (p0);
	}

	private native void n_onAdClosed (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0);


	public void onAdFailedToLoad (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0, int p1)
	{
		n_onAdFailedToLoad (p0, p1);
	}

	private native void n_onAdFailedToLoad (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0, int p1);


	public void onAdLeftApplication (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0)
	{
		n_onAdLeftApplication (p0);
	}

	private native void n_onAdLeftApplication (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0);


	public void onAdLoaded (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0)
	{
		n_onAdLoaded (p0);
	}

	private native void n_onAdLoaded (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0);


	public void onAdOpened (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0)
	{
		n_onAdOpened (p0);
	}

	private native void n_onAdOpened (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0);


	public void onInitializationFailed (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0, int p1)
	{
		n_onInitializationFailed (p0, p1);
	}

	private native void n_onInitializationFailed (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0, int p1);


	public void onInitializationSucceeded (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0)
	{
		n_onInitializationSucceeded (p0);
	}

	private native void n_onInitializationSucceeded (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0);


	public void onRewarded (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0, com.google.android.gms.ads.reward.RewardItem p1)
	{
		n_onRewarded (p0, p1);
	}

	private native void n_onRewarded (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0, com.google.android.gms.ads.reward.RewardItem p1);


	public void onVideoStarted (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0)
	{
		n_onVideoStarted (p0);
	}

	private native void n_onVideoStarted (com.google.android.gms.ads.reward.mediation.MediationRewardedVideoAdAdapter p0);

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
