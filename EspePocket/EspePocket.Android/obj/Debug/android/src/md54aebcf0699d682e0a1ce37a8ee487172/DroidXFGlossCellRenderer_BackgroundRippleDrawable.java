package md54aebcf0699d682e0a1ce37a8ee487172;


public class DroidXFGlossCellRenderer_BackgroundRippleDrawable
	extends android.graphics.drawable.RippleDrawable
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnTouchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("XFGloss.Droid.Renderers.DroidXFGlossCellRenderer+BackgroundRippleDrawable, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", DroidXFGlossCellRenderer_BackgroundRippleDrawable.class, __md_methods);
	}


	public DroidXFGlossCellRenderer_BackgroundRippleDrawable (android.content.res.ColorStateList p0, android.graphics.drawable.Drawable p1, android.graphics.drawable.Drawable p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == DroidXFGlossCellRenderer_BackgroundRippleDrawable.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Renderers.DroidXFGlossCellRenderer+BackgroundRippleDrawable, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", "Android.Content.Res.ColorStateList, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Graphics.Drawables.Drawable, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Graphics.Drawables.Drawable, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);

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
