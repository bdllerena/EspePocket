package md54aebcf0699d682e0a1ce37a8ee487172;


public class SwitchCompatCellView
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.BaseCellView
	implements
		mono.android.IGCUserPeer,
		android.widget.CompoundButton.OnCheckedChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCheckedChanged:(Landroid/widget/CompoundButton;Z)V:GetOnCheckedChanged_Landroid_widget_CompoundButton_ZHandler:Android.Widget.CompoundButton/IOnCheckedChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("XFGloss.Droid.Renderers.SwitchCompatCellView, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", SwitchCompatCellView.class, __md_methods);
	}


	public SwitchCompatCellView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == SwitchCompatCellView.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Renderers.SwitchCompatCellView, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public SwitchCompatCellView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == SwitchCompatCellView.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Renderers.SwitchCompatCellView, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public SwitchCompatCellView (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == SwitchCompatCellView.class)
			mono.android.TypeManager.Activate ("XFGloss.Droid.Renderers.SwitchCompatCellView, XFGloss.Droid, Version=1.0.6.59, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onCheckedChanged (android.widget.CompoundButton p0, boolean p1)
	{
		n_onCheckedChanged (p0, p1);
	}

	private native void n_onCheckedChanged (android.widget.CompoundButton p0, boolean p1);

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
