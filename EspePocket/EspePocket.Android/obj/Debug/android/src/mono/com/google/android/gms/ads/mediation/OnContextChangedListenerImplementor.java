package mono.com.google.android.gms.ads.mediation;


public class OnContextChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.ads.mediation.OnContextChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onContextChanged:(Landroid/content/Context;)V:GetOnContextChanged_Landroid_content_Context_Handler:Android.Gms.Ads.Mediation.IOnContextChangedListenerInvoker, Xamarin.GooglePlayServices.Ads.Lite\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Ads.Mediation.IOnContextChangedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnContextChangedListenerImplementor.class, __md_methods);
	}


	public OnContextChangedListenerImplementor ()
	{
		super ();
		if (getClass () == OnContextChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Ads.Mediation.IOnContextChangedListenerImplementor, Xamarin.GooglePlayServices.Ads.Lite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onContextChanged (android.content.Context p0)
	{
		n_onContextChanged (p0);
	}

	private native void n_onContextChanged (android.content.Context p0);

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
