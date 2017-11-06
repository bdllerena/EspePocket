package md546c06bd645a1215106524147032ed669;


public class XFGlossPaintDrawable
	extends android.graphics.drawable.PaintDrawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XFGloss.Droid.Drawables.XFGlossPaintDrawable, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", XFGlossPaintDrawable.class, __md_methods);
	}


	public XFGlossPaintDrawable () throws java.lang.Throwable
	{
		super ();
		if (getClass () == XFGlossPaintDrawable.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Drawables.XFGlossPaintDrawable, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public XFGlossPaintDrawable (int p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == XFGlossPaintDrawable.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Drawables.XFGlossPaintDrawable, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", "Android.Graphics.Color, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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
