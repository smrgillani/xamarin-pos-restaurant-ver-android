package md5499a6e3b6edc0cc5af5780076c2e1d37;


public class HoraERowViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Carlos.HoraERowViewHolder, Carlos", HoraERowViewHolder.class, __md_methods);
	}


	public HoraERowViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == HoraERowViewHolder.class)
			mono.android.TypeManager.Activate ("Carlos.HoraERowViewHolder, Carlos", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
