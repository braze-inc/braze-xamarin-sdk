using Foundation;

namespace BrazeLocation
{
	// @interface BrazeLocation : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13BrazeLocation13BrazeLocation")]
	interface BrazeLocation
	{
		// @property (readonly, nonatomic) id _Nonnull dependency;
		[Export ("dependency")]
		NSObject Dependency { get; }

	}

	// @interface BrazeLocationProvider : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13BrazeLocation21BrazeLocationProvider")]
	interface BrazeLocationProvider
	{
		// @property (readonly, nonatomic) id _Nonnull dependency;
		[Export ("dependency")]
		NSObject Dependency { get; }

	}
}
