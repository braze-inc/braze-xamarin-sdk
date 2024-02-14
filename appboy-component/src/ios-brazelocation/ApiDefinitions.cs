using Foundation;

namespace BrazeLocation
{
	// @interface BrazeLocationProvider : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13BrazeLocation21BrazeLocationProvider")]
	interface BrazeLocationProvider
	{
		// @property (readonly, nonatomic) id _Nonnull dependency;
		[Export ("dependency")]
		NSObject Dependency { get; }

	}
}
