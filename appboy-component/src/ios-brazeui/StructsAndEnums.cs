using ObjCRuntime;

namespace BrazeUI
{
	[Native]
	public enum BRZInAppMessageUIStatusBarHideBehavior : long
	{
		Auto = 0,
		Hidden = 1,
		Visible = 2
	}

	[Native]
	public enum BRZInAppMessageUIDisplayChoice : long
	{
		Now = 0,
		Reenqueue = 1,
		Discard = 2
	}
}
