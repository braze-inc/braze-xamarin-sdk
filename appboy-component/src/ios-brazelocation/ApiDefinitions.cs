using Foundation;
using ObjCRuntime;

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

	// @interface BRZLocationResources : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZLocationResources
	{
		// @property (readonly, nonatomic, strong, class) NSBundle * _Nullable bundle;
		[Static]
		[NullAllowed, Export ("bundle", ArgumentSemantic.Strong)]
		NSBundle Bundle { get; }

	}
}
