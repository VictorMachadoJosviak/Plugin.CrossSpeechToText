package md5d355385f2e36ff41f50b7b20a32b6a89;


public class SpeechActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Plugin.CrossSpeechToText.Droid.SpeechActivity, Plugin.CrossSpeechToText.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SpeechActivity.class, __md_methods);
	}


	public SpeechActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SpeechActivity.class)
			mono.android.TypeManager.Activate ("Plugin.CrossSpeechToText.Droid.SpeechActivity, Plugin.CrossSpeechToText.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
