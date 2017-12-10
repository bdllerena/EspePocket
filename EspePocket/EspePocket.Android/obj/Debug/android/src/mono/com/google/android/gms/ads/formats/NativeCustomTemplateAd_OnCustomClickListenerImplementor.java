package mono.com.google.android.gms.ads.formats;


public class NativeCustomTemplateAd_OnCustomClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.formats.NativeCustomTemplateAd.OnCustomClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCustomClick:(Lcom/google/android/gms/ads/formats/NativeCustomTemplateAd;Ljava/lang/String;)V:GetOnCustomClick_Lcom_google_android_gms_ads_formats_NativeCustomTemplateAd_Ljava_lang_String_Handler:Android.Gms.Ads.Formats.INativeCustomTemplateAdOnCustomClickListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Formats.INativeCustomTemplateAdOnCustomClickListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NativeCustomTemplateAd_OnCustomClickListenerImplementor.class, __md_methods);
	}


	public NativeCustomTemplateAd_OnCustomClickListenerImplementor ()
	{
		super ();
		if (getClass () == NativeCustomTemplateAd_OnCustomClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Formats.INativeCustomTemplateAdOnCustomClickListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCustomClick (com.google.android.gms.ads.formats.NativeCustomTemplateAd p0, java.lang.String p1)
	{
		n_onCustomClick (p0, p1);
	}

	private native void n_onCustomClick (com.google.android.gms.ads.formats.NativeCustomTemplateAd p0, java.lang.String p1);

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
