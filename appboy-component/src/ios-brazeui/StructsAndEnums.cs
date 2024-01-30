using ObjCRuntime;

namespace BrazeUI
{
	[Native]
	public enum BRZInAppMessageUIDisplayChoice : long
	{
		Now = 0,
		Reenqueue = 1,
		Discard = 2
	}
}
