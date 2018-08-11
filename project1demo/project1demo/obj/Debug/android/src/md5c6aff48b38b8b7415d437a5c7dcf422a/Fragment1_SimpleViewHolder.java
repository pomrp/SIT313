package md5c6aff48b38b8b7415d437a5c7dcf422a;


public class Fragment1_SimpleViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("project1demo.Fragments.Fragment1+SimpleViewHolder, project1demo", Fragment1_SimpleViewHolder.class, __md_methods);
	}


	public Fragment1_SimpleViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == Fragment1_SimpleViewHolder.class)
			mono.android.TypeManager.Activate ("project1demo.Fragments.Fragment1+SimpleViewHolder, project1demo", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

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
