using System;
using BrazeKit;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace BrazeKit
{
	// @interface BRZConfigurationApi : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZConfigurationApi
	{
		// @property (copy, nonatomic) NSString * _Nullable key;
		[NullAllowed, Export ("key")]
		string Key { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable endpoint;
		[NullAllowed, Export ("endpoint")]
		string Endpoint { get; set; }

		// @property (nonatomic) NSTimeInterval flushInterval;
		[Export ("flushInterval")]
		double FlushInterval { get; set; }

		// @property (nonatomic) BOOL sdkAuthentication;
		[Export ("sdkAuthentication")]
		bool SdkAuthentication { get; set; }

		//  (nonatomic) enum BRZRequestPolicy requestPolicy;
		[Export ("requestPolicy", ArgumentSemantic.Assign)]
		BRZRequestPolicy RequestPolicy { get; set; }

		//  (nonatomic) enum BRZSDKFlavor sdkFlavor;
		[Export ("sdkFlavor", ArgumentSemantic.Assign)]
		BRZSDKFlavor SdkFlavor { get; set; }

		//  (readonly, copy, nonatomic) NSArray<BRZSDKMetadata *> * _Nonnull sdkMetadata;
		[Export ("sdkMetadata", ArgumentSemantic.Copy)]
		BRZSDKMetadata[] SdkMetadata { get; }

		// -(void)addSDKMetadata:(NSArray<BRZSDKMetadata *> * _Nonnull)sdkMetadata;
		[Export ("addSDKMetadata:")]
		void AddSDKMetadata (BRZSDKMetadata[] sdkMetadata);

		//  (copy, nonatomic) NSSet<BRZTrackingProperty *> * _Nonnull trackingPropertyAllowList;
		[Export ("trackingPropertyAllowList", ArgumentSemantic.Copy)]
		NSSet<BRZTrackingProperty> TrackingPropertyAllowList { get; set; }
	}

	// @interface Braze : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC8BrazeKit5Braze")]
	[DisableDefaultCtor]
	interface Braze
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull sdkVersion;
		[Static]
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// @property (nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (readonly, nonatomic, strong) BRZConfiguration * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		BRZConfiguration Configuration { get; }

		// @property (readonly, nonatomic, strong) BRZUser * _Nonnull user;
		[Export ("user", ArgumentSemantic.Strong)]
		BRZUser User { get; }

		// @property (readonly, nonatomic, strong) BRZNotifications * _Nonnull notifications;
		[Export ("notifications", ArgumentSemantic.Strong)]
		BRZNotifications Notifications { get; }

		// @property (readonly, nonatomic, strong) BRZContentCards * _Nonnull contentCards;
		[Export ("contentCards", ArgumentSemantic.Strong)]
		BRZContentCards ContentCards { get; }

		// @property (readonly, nonatomic, strong) BRZNewsFeed * _Nonnull newsFeed;
		[Export ("newsFeed", ArgumentSemantic.Strong)]
		BRZNewsFeed NewsFeed { get; }

		// @property (readonly, nonatomic, strong) BRZFeatureFlags * _Nonnull featureFlags;
		[Export ("featureFlags", ArgumentSemantic.Strong)]
		BRZFeatureFlags FeatureFlags { get; }

		[Wrap ("WeakSdkAuthDelegate")]
		[NullAllowed]
		BrazeSDKAuthDelegate SdkAuthDelegate { get; set; }

		// @property (nonatomic, weak) id<BrazeSDKAuthDelegate> _Nullable sdkAuthDelegate;
		[NullAllowed, Export ("sdkAuthDelegate", ArgumentSemantic.Weak)]
		NSObject WeakSdkAuthDelegate { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull deviceId;
		[Export ("deviceId")]
		string DeviceId { get; }

		// -(instancetype _Nonnull)initWithConfiguration:(BRZConfiguration * _Nonnull)configuration __attribute__((objc_designated_initializer));
		[Export ("initWithConfiguration:")]
		[DesignatedInitializer]
		NativeHandle Constructor (BRZConfiguration configuration);

		// -(void)deviceIdOnQueue:(dispatch_queue_t _Nonnull)queue completion:(void (^ _Nonnull)(NSString * _Nonnull))completion __attribute__((deprecated("", "deviceId")));
		[Obsolete("renamed: 'deviceId'")]
		[Export ("deviceIdOnQueue:completion:")]
		void DeviceIdOnQueue (DispatchQueue queue, Action<NSString> completion);

		// -(void)deviceIdWithCompletion:(void (^ _Nonnull)(NSString * _Nonnull))completion __attribute__((deprecated("", "deviceId")));
		[Obsolete("renamed: 'deviceId'")]
		[Export ("deviceIdWithCompletion:")]
		void DeviceIdWithCompletion (Action<NSString> completion);
		// -(void)_requestEnableSDKOnNextAppRun;
		[Export ("_requestEnableSDKOnNextAppRun")]
		void _requestEnableSDKOnNextAppRun ();

		// +(NSString * _Nonnull)_localize:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Static]
		[Export ("_localize:")]
		string _localize (string key);

		// -(void)_contentCardsApplyLocalCards;
		[Export ("_contentCardsApplyLocalCards")]
		void _contentCardsApplyLocalCards ();

		// -(void)_newsFeedApplyLocalCards;
		[Export ("_newsFeedApplyLocalCards")]
		void _newsFeedApplyLocalCards ();
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		BrazeDelegate Delegate { get; set; }

		//  (nonatomic, strong) id<BrazeDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		//  (nonatomic, strong) id<BrazeInAppMessagePresenter> _Nullable inAppMessagePresenter;
		[NullAllowed, Export ("inAppMessagePresenter", ArgumentSemantic.Strong)]
		NSObject InAppMessagePresenter { get; set; }

		// -(void)updateTrackingAllowListAdding:(NSSet<BRZTrackingProperty *> * _Nullable)adding removing:(NSSet<BRZTrackingProperty *> * _Nullable)removing;
		[Export ("updateTrackingAllowListAdding:removing:")]
		void UpdateTrackingAllowListAdding ([NullAllowed] NSSet<BRZTrackingProperty> adding, [NullAllowed] NSSet<BRZTrackingProperty> removing);
		// -(void)logCustomEvent:(NSString * _Nonnull)name;
		[Export ("logCustomEvent:")]
		void LogCustomEvent (string name);

		// -(void)logCustomEvent:(NSString * _Nonnull)name properties:(NSDictionary<NSString *,id> * _Nullable)properties;
		[Export ("logCustomEvent:properties:")]
		void LogCustomEvent (string name, [NullAllowed] NSDictionary<NSString, NSObject> properties);

		// -(void)logPurchase:(NSString * _Nonnull)productId currency:(NSString * _Nonnull)currency price:(double)price;
		[Export ("logPurchase:currency:price:")]
		void LogPurchase (string productId, string currency, double price);

		// -(void)logPurchase:(NSString * _Nonnull)productId currency:(NSString * _Nonnull)currency price:(double)price quantity:(NSInteger)quantity;
		[Export ("logPurchase:currency:price:quantity:")]
		void LogPurchase (string productId, string currency, double price, nint quantity);

		// -(void)logPurchase:(NSString * _Nonnull)productId currency:(NSString * _Nonnull)currency price:(double)price properties:(NSDictionary<NSString *,id> * _Nullable)properties;
		[Export ("logPurchase:currency:price:properties:")]
		void LogPurchase (string productId, string currency, double price, [NullAllowed] NSDictionary<NSString, NSObject> properties);

		// -(void)logPurchase:(NSString * _Nonnull)productId currency:(NSString * _Nonnull)currency price:(double)price quantity:(NSInteger)quantity properties:(NSDictionary<NSString *,id> * _Nullable)properties;
		[Export ("logPurchase:currency:price:quantity:properties:")]
		void LogPurchase (string productId, string currency, double price, nint quantity, [NullAllowed] NSDictionary<NSString, NSObject> properties);

		// -(void)changeUser:(NSString * _Nonnull)userId;
		[Export ("changeUser:")]
		void ChangeUser (string userId);

		// -(void)changeUser:(NSString * _Nonnull)userId sdkAuthSignature:(NSString * _Nullable)sdkAuthSignature;
		[Export ("changeUser:sdkAuthSignature:")]
		void ChangeUser (string userId, [NullAllowed] string sdkAuthSignature);

		// -(void)requestGeofencesWithLatitude:(double)latitude longitude:(double)longitude;
		[Export ("requestGeofencesWithLatitude:longitude:")]
		void RequestGeofencesWithLatitude (double latitude, double longitude);
		// -(void)setSDKAuthenticationSignature:(NSString * _Nonnull)signature;
		[Export ("setSDKAuthenticationSignature:")]
		void SetSDKAuthenticationSignature (string signature);

		// -(void)requestImmediateDataFlush;
		[Export ("requestImmediateDataFlush")]
		void RequestImmediateDataFlush ();

		// -(void)wipeData;
		[Export ("wipeData")]
		void WipeData ();

		// -(void)setIdentifierForVendor:(NSString * _Nonnull)identifierForVendor;
		[Export ("setIdentifierForVendor:")]
		void SetIdentifierForVendor (string identifierForVendor);

		// -(void)setIdentifierForAdvertiser:(NSString * _Nonnull)identifierForAdvertiser;
		[Export ("setIdentifierForAdvertiser:")]
		void SetIdentifierForAdvertiser (string identifierForAdvertiser);

		// -(void)setAdTrackingEnabled:(BOOL)adTrackingEnabled;
		[Export ("setAdTrackingEnabled:")]
		void SetAdTrackingEnabled (bool adTrackingEnabled);
		//  (copy, nonatomic, class) NSDictionary<NSString *,NSURL *> * _Nonnull acknowledgments;
		[Static]
		[Export ("acknowledgments", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSUrl> Acknowledgments { get; set; }

		//  (copy, nonatomic, class) NSURL * _Nullable license;
		[Static]
		[NullAllowed, Export ("license", ArgumentSemantic.Copy)]
		NSUrl License { get; set; }
		// +(Braze * _Nullable)sharedInstance __attribute__((warn_unused_result(""))) __attribute__((deprecated("BrazeKit does not provide a singleton instance. You are now expected to keep a reference of the Braze instance yourself after initialization.")));
		[Obsolete("BrazeKit does not provide a singleton instance. You are now expected to keep a reference of the Braze instance yourself after initialization.")]
		[Static]
		[NullAllowed, Export ("sharedInstance")]
		Braze SharedInstance { get; }

		// +(Braze * _Nonnull)unsafeInstance __attribute__((warn_unused_result(""))) __attribute__((deprecated("BrazeKit does not provide a singleton instance. You are now expected to keep a reference of the Braze instance yourself after initialization.")));
		[Obsolete("BrazeKit does not provide a singleton instance. You are now expected to keep a reference of the Braze instance yourself after initialization.")]
		[Static]
		[Export ("unsafeInstance")]
		Braze UnsafeInstance { get; }

		// +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions __attribute__((deprecated("")));
		[Obsolete("See https://braze-inc.github.io/braze-swift-sdk/documentation/braze/appboy-migration-guide/#SDK-initialization-and-configuration")]
		[Static]
		[Export ("startWithApiKey:inApplication:withLaunchOptions:")]
		void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions);

		// +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions withAppboyOptions:(NSDictionary * _Nullable)appboyOptions __attribute__((deprecated("")));
		[Obsolete("See https://braze-inc.github.io/braze-swift-sdk/documentation/braze/appboy-migration-guide/#SDK-initialization-and-configuration")]
		[Static]
		[Export ("startWithApiKey:inApplication:withLaunchOptions:withAppboyOptions:")]
		void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions, [NullAllowed] NSDictionary appboyOptions);

		//  (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("", "newsFeed") id feedController __attribute__((deprecated("", "newsFeed")));
		[Obsolete("renamed: 'newsFeed'")]
		[Export ("feedController", ArgumentSemantic.Strong)]
		NSObject FeedController { get; }

		//  (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("", "contentCards") id contentCardsController __attribute__((deprecated("", "contentCards")));
		[Obsolete("renamed: 'contentCards'")]
		[Export ("contentCardsController", ArgumentSemantic.Strong)]
		NSObject ContentCardsController { get; }

		//  (nonatomic) enum _COMPAT_ABKRequestProcessingPolicy requestProcessingPolicy __attribute__((deprecated("request processing policy must be set using the 'Braze.Configuration' object at SDK initialization")));
		[Obsolete("request processing policy must be set using the 'Braze.Configuration' object at SDK initialization")]
		[Export ("requestProcessingPolicy", ArgumentSemantic.Assign)]
		_COMPAT_ABKRequestProcessingPolicy RequestProcessingPolicy { get; set; }

		[Wrap ("WeakIdfaDelegate")]
		NSObject IdfaDelegate { get; set; }

		//  (nonatomic, strong) SWIFT_DEPRECATED_MSG("use 'set(identifierForAdvertiser:)' and 'set(adTrackingEnabled:)' instead") id idfaDelegate __attribute__((deprecated("use 'set(identifierForAdvertiser:)' and 'set(adTrackingEnabled:)' instead")));
		[Obsolete("use 'set(identifierForAdvertiser:)' and 'set(adTrackingEnabled:)' instead")]
		[NullAllowed, Export ("idfaDelegate", ArgumentSemantic.Strong)]
		NSObject WeakIdfaDelegate { get; set; }

		[Wrap ("WeakSdkAuthenticationDelegate")]
		NSObject SdkAuthenticationDelegate { get; set; }

		//  (nonatomic, strong) SWIFT_DEPRECATED_MSG("", "delegate") id sdkAuthenticationDelegate __attribute__((deprecated("", "delegate")));
		[Obsolete("renamed: 'delegate'")]
		[NullAllowed, Export ("sdkAuthenticationDelegate", ArgumentSemantic.Strong)]
		NSObject WeakSdkAuthenticationDelegate { get; set; }

		//  (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("", "inAppMessagePresenter") id inAppMessageController __attribute__((deprecated("", "inAppMessagePresenter")));
		[Obsolete("renamed: 'inAppMessagePresenter'")]
		[Export ("inAppMessageController", ArgumentSemantic.Strong)]
		NSObject InAppMessageController { get; }

		//  (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("use 'configuration.location' to access location analytics settings") id locationManager __attribute__((deprecated("use 'configuration.location' to access location analytics settings")));
		[Obsolete("use 'configuration.location' to access location analytics settings")]
		[Export ("locationManager", ArgumentSemantic.Strong)]
		NSObject LocationManager { get; }

		[Wrap ("WeakAppboyUrlDelegate")]
		NSObject AppboyUrlDelegate { get; set; }

		//  (nonatomic, weak) SWIFT_DEPRECATED_MSG("", "delegate") id appboyUrlDelegate __attribute__((deprecated("", "delegate")));
		[Obsolete("renamed: 'delegate'")]
		[NullAllowed, Export ("appboyUrlDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppboyUrlDelegate { get; set; }

		[Wrap ("WeakImageDelegate")]
		NSObject ImageDelegate { get; set; }

		//  (nonatomic, strong) SWIFT_DEPRECATED_MSG("imageDelegate is not needed anymore") id imageDelegate __attribute__((deprecated("imageDelegate is not needed anymore")));
		[Obsolete("imageDelegate is not needed anymore")]
		[NullAllowed, Export ("imageDelegate", ArgumentSemantic.Strong)]
		NSObject WeakImageDelegate { get; set; }

		//  (nonatomic) enum _COMPAT_ABKSDKFlavor sdkFlavor __attribute__((deprecated("SDK flavor must be set using the 'Braze.Configuration' object at SDK initialization")));
		[Obsolete("SDK flavor must be set using the 'Braze.Configuration' object at SDK initialization")]
		[Export ("sdkFlavor", ArgumentSemantic.Assign)]
		_COMPAT_ABKSDKFlavor SdkFlavor { get; set; }

		// -(void)flushDataAndProcessRequestQueue __attribute__((deprecated("", "requestImmediateDataFlush")));
		[Obsolete("renamed: 'requestImmediateDataFlush'")]
		[Export ("flushDataAndProcessRequestQueue")]
		void FlushDataAndProcessRequestQueue ();

		// -(void)setSdkAuthenticationSignature:(NSString * _Nonnull)signature __attribute__((deprecated("", "setSDKAuthenticationSignature:")));
		[Obsolete("renamed: 'setSDKAuthenticationSignature:'")]
		[Export ("setSdkAuthenticationSignature:")]
		void SetSdkAuthenticationSignature (string signature);

		// -(void)unsubscribeFromSdkAuthenticationErrors __attribute__((deprecated("unsubscribing from SDK authentication errors is not needed anymore")));
		[Obsolete("unsubscribing from SDK authentication errors is not needed anymore")]
		[Export ("unsubscribeFromSdkAuthenticationErrors")]
		void UnsubscribeFromSdkAuthenticationErrors ();

		// -(void)logCustomEvent:(NSString * _Nonnull)eventName withProperties:(NSDictionary * _Nullable)properties __attribute__((deprecated("", "logCustomEvent(name:properties:)")));
		[Obsolete("renamed: 'logCustomEvent(name:properties:)'")]
		[Export ("logCustomEvent:withProperties:")]
		void LogCustomEvent (string eventName, [NullAllowed] NSDictionary properties);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price __attribute__((deprecated("", "logPurchase(productId:currency:price:)")));
		[Obsolete("renamed: 'logPurchase(productId:currency:price:)'")]
		[Export ("logPurchase:inCurrency:atPrice:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withProperties:(NSDictionary * _Nullable)properties __attribute__((deprecated("", "logPurchase(productId:currency:price:properties:)")));
		[Obsolete("renamed: 'logPurchase(productId:currency:price:properties:)'")]
		[Export ("logPurchase:inCurrency:atPrice:withProperties:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, [NullAllowed] NSDictionary properties);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withQuantity:(NSUInteger)quantity __attribute__((deprecated("", "logPurchase(productId:currency:price:quantity:)")));
		[Obsolete("renamed: 'logPurchase(productId:currency:price:quantity:)'")]
		[Export ("logPurchase:inCurrency:atPrice:withQuantity:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withQuantity:(NSUInteger)quantity andProperties:(NSDictionary * _Nullable)properties __attribute__((deprecated("", "logPurchase(productId:currency:price:quantity:properties:)")));
		[Obsolete("renamed: 'logPurchase(productId:currency:price:quantity:properties:)'")]
		[Export ("logPurchase:inCurrency:atPrice:withQuantity:andProperties:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity, [NullAllowed] NSDictionary properties);

		// -(void)logFeedDisplayed __attribute__((deprecated("logging the feed displayed event is not needed anymore")));
		[Obsolete("logging the feed displayed event is not needed anymore")]
		[Export ("logFeedDisplayed")]
		void LogFeedDisplayed ();

		// -(void)logContentCardsDisplayed __attribute__((deprecated("logging the content cards displayed event is not needed anymore")));
		[Obsolete("logging the content cards displayed event is not needed anymore")]
		[Export ("logContentCardsDisplayed")]
		void LogContentCardsDisplayed ();

		// -(void)requestFeedRefresh __attribute__((deprecated("renamed to 'newsFeed.requestRefresh(_:)'")));
		[Obsolete("renamed to 'newsFeed.requestRefresh(_:)'")]
		[Export ("requestFeedRefresh")]
		void RequestFeedRefresh ();

		// -(void)requestContentCardsRefresh __attribute__((deprecated("renamed to 'contentCards.requestRefresh(_:)'")));
		[Obsolete("renamed to 'contentCards.requestRefresh(_:)'")]
		[Export ("requestContentCardsRefresh")]
		void RequestContentCardsRefresh ();

		// -(void)requestGeofencesWithLongitude:(double)longitude latitude:(double)latitude __attribute__((deprecated("renamed to 'requestGeofences(latitude:longitude:)'. ⚠️ Important: the order of the parameters have been changed")));
		[Obsolete("renamed to 'requestGeofences(latitude:longitude:)'. ⚠️ Important: the order of the parameters have been changed")]
		[Export ("requestGeofencesWithLongitude:latitude:")]
		void RequestGeofencesWithLongitude (double longitude, double latitude);

		// -(void)registerDeviceToken:(NSData * _Nonnull)deviceToken __attribute__((deprecated("renamed to 'notifications.register(deviceToken:)'")));
		[Obsolete("renamed to 'notifications.register(deviceToken:)'")]
		[Export ("registerDeviceToken:")]
		void RegisterDeviceToken (NSData deviceToken);

		// -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler __attribute__((deprecated("renamed to 'notifications.handleBackgroundNotification(userInfo:fetchCompletionHandler:)'")));
		[Obsolete("renamed to 'notifications.handleBackgroundNotification(userInfo:fetchCompletionHandler:)'")]
		[Export ("registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:")]
		void RegisterApplication (UIApplication application, NSDictionary notification, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

		// -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nullable)(void))completionHandler __attribute__((deprecated("renamed to 'notifications.handleUserNotification(response:withCompletionHandler:)'"))) __attribute__((availability(ios, introduced=10.0)));
		[Obsolete("renamed to 'notifications.handleUserNotification(response:withCompletionHandler:)'")]
		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenter (UNUserNotificationCenter center, UNNotificationResponse response, [NullAllowed] Action completionHandler);

		// -(void)pushAuthorizationFromUserNotificationCenter:(BOOL)pushAuthGranted __attribute__((deprecated("not needed anymore. Braze automatically retrieves the push notification authorization settings after the user interacts with the permission prompt.")));
		[Obsolete("not needed anymore. Braze automatically retrieves the push notification authorization settings after the user interacts with the permission prompt.")]
		[Export ("pushAuthorizationFromUserNotificationCenter:")]
		void PushAuthorizationFromUserNotificationCenter (bool pushAuthGranted);

		// -(void)addSdkMetadata:(NSArray<NSString *> * _Nonnull)metadata __attribute__((deprecated("SDK metadata must be set using the 'Braze.Configuration' object at SDK initialization")));
		[Obsolete("SDK metadata must be set using the 'Braze.Configuration' object at SDK initialization")]
		[Export ("addSdkMetadata:")]
		void AddSdkMetadata (string[] metadata);

		// +(void)wipeDataAndDisableForAppRun __attribute__((deprecated("renamed to 'wipeData()' on the Braze instance")));
		[Obsolete("renamed to 'wipeData()' on the Braze instance")]
		[Static]
		[Export ("wipeDataAndDisableForAppRun")]
		void WipeDataAndDisableForAppRun ();

		// +(void)disableSDK __attribute__((deprecated("renamed to the 'enabled' boolean property")));
		[Obsolete("renamed to the 'enabled' boolean property")]
		[Static]
		[Export ("disableSDK")]
		void DisableSDK ();

		// +(void)requestEnableSDKOnNextAppRun __attribute__((deprecated("use the 'enabled' boolean property to disable / enable the SDK")));
		[Obsolete("use the 'enabled' boolean property to disable / enable the SDK")]
		[Static]
		[Export ("requestEnableSDKOnNextAppRun")]
		void RequestEnableSDKOnNextAppRun ();
	}

	// @interface BRZConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZConfiguration
	{
		// @property (nonatomic, strong) BRZConfigurationApi * _Nonnull api;
		[Export ("api", ArgumentSemantic.Strong)]
		BRZConfigurationApi Api { get; set; }

		// @property (nonatomic, strong) BRZConfigurationPush * _Nonnull push;
		[Export ("push", ArgumentSemantic.Strong)]
		BRZConfigurationPush Push { get; set; }

		// @property (nonatomic, strong) BRZConfigurationLocation * _Nonnull location;
		[Export ("location", ArgumentSemantic.Strong)]
		BRZConfigurationLocation Location { get; set; }

		// @property (nonatomic, strong) BRZConfigurationLogger * _Nonnull logger;
		[Export ("logger", ArgumentSemantic.Strong)]
		BRZConfigurationLogger Logger { get; set; }

		// @property (nonatomic) NSTimeInterval sessionTimeout;
		[Export ("sessionTimeout")]
		double SessionTimeout { get; set; }

		// @property (nonatomic) NSTimeInterval triggerMinimumTimeInterval;
		[Export ("triggerMinimumTimeInterval")]
		double TriggerMinimumTimeInterval { get; set; }

		// @property (nonatomic) BOOL useUUIDAsDeviceId;
		[Export ("useUUIDAsDeviceId")]
		bool UseUUIDAsDeviceId { get; set; }

		// @property (nonatomic) BOOL forwardUniversalLinks;
		[Export ("forwardUniversalLinks")]
		bool ForwardUniversalLinks { get; set; }

		// @property (nonatomic) BOOL optInWhenPushAuthorized;
		[Export ("optInWhenPushAuthorized")]
		bool OptInWhenPushAuthorized { get; set; }

		// @property (nonatomic) uint64_t tvOSPersistedSizeLimit;
		[Export ("tvOSPersistedSizeLimit")]
		ulong TvOSPersistedSizeLimit { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull ephemeralEvents;
		[Export ("ephemeralEvents", ArgumentSemantic.Copy)]
		string[] EphemeralEvents { get; set; }

		// -(instancetype _Nonnull)initWithApiKey:(NSString * _Nonnull)apiKey endpoint:(NSString * _Nonnull)endpoint __attribute__((objc_designated_initializer));
		[Export ("initWithApiKey:endpoint:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string apiKey, string endpoint);

		//  (copy, nonatomic) NSArray<BRZDeviceProperty *> * _Nonnull devicePropertyAllowList;
		[Export ("devicePropertyAllowList", ArgumentSemantic.Copy)]
		BRZDeviceProperty[] DevicePropertyAllowList { get; set; }
	}

	// @interface BRZContentCardRaw : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZContentCardRaw: INativeObject
	{
		// @property (copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Copy)]
		NSUrl Image { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cardDescription;
		[NullAllowed, Export ("cardDescription")]
		string CardDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (nonatomic) BOOL useWebView;
		[Export ("useWebView")]
		bool UseWebView { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull extras;
		[Export ("extras", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Extras { get; set; }

		// @property (nonatomic) BOOL viewed;
		[Export ("viewed")]
		bool Viewed { get; set; }

		// @property (nonatomic) BOOL dismissible;
		[Export ("dismissible")]
		bool Dismissible { get; set; }

		// @property (nonatomic) BOOL removed;
		[Export ("removed")]
		bool Removed { get; set; }

		// @property (nonatomic) BOOL pinned;
		[Export ("pinned")]
		bool Pinned { get; set; }

		// @property (nonatomic) BOOL clicked;
		[Export ("clicked")]
		bool Clicked { get; set; }

		// @property (nonatomic) BOOL test;
		[Export ("test")]
		bool Test { get; set; }

		// @property (nonatomic) NSTimeInterval createdAt;
		[Export ("createdAt")]
		double CreatedAt { get; set; }

		// @property (nonatomic) NSTimeInterval expiresAt;
		[Export ("expiresAt")]
		double ExpiresAt { get; set; }

		// @property (nonatomic, strong) BRZContentCardContext * _Nullable context;
		[NullAllowed, Export ("context", ArgumentSemantic.Strong)]
		BRZContentCardContext Context { get; set; }

		// -(NSData * _Nullable)json __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("json")]
		NSData Json { get; }

		// +(instancetype _Nullable)decodingWithJson:(NSData * _Nonnull)json __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodingWithJson:")]
		[return: NullAllowed]
		BRZContentCardRaw DecodingWithJson (NSData json);
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// +(BRZContentCardRaw * _Nullable)fromJson:(NSData * _Nonnull)json __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fromJson:")]
		[return: NullAllowed]
		BRZContentCardRaw FromJson (NSData json);

		// -(void)logImpressionUsing:(Braze * _Nonnull)braze;
		[Export ("logImpressionUsing:")]
		void LogImpressionUsing (Braze braze);

		// -(void)logClickUsing:(Braze * _Nonnull)braze;
		[Export ("logClickUsing:")]
		void LogClickUsing (Braze braze);

		// -(void)logDismissedUsing:(Braze * _Nonnull)braze;
		[Export ("logDismissedUsing:")]
		void LogDismissedUsing (Braze braze);
		//  (nonatomic) enum BRZContentCardRawType type;
		[Export ("type", ArgumentSemantic.Assign)]
		BRZContentCardRawType Type { get; set; }

		//  (nonatomic) double imageAspectRatio;
		[Export ("imageAspectRatio")]
		double ImageAspectRatio { get; set; }
	}

	// @interface BRZURLContext : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZURLContext
	{
		// @property (copy, nonatomic) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (nonatomic) BOOL useWebView;
		[Export ("useWebView")]
		bool UseWebView { get; set; }

		// @property (nonatomic) BOOL isUniversalLink;
		[Export ("isUniversalLink")]
		bool IsUniversalLink { get; set; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull extras;
		[Export ("extras", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Extras { get; }
		// @property (nonatomic, strong) UIViewController * _Nullable targetViewController;
		[NullAllowed, Export ("targetViewController", ArgumentSemantic.Strong)]
		UIViewController TargetViewController { get; set; }

		//  (readonly, nonatomic) enum BRZChannel channel;
		[Export ("channel")]
		BRZChannel Channel { get; }
		//  (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }
	}

	// @interface BRZSDKAuthenticationError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZSDKAuthenticationError
	{
		// @property (readonly, nonatomic) NSInteger code;
		[Export ("code")]
		nint Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable reason;
		[NullAllowed, Export ("reason")]
		string Reason { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable userId;
		[NullAllowed, Export ("userId")]
		string UserId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable signature;
		[NullAllowed, Export ("signature")]
		string Signature { get; }

	}

	// @interface BRZContentCards : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZContentCards
	{
		// @property (readonly, copy, nonatomic) NSDate * _Nullable lastUpdate;
		[NullAllowed, Export ("lastUpdate", ArgumentSemantic.Copy)]
		NSDate LastUpdate { get; }

		//  (readonly, copy, nonatomic) NSArray<BRZContentCardRaw *> * _Nonnull cards;
		[Export ("cards", ArgumentSemantic.Copy)]
		BRZContentCardRaw[] Cards { get; }

		//  (readonly, copy, nonatomic) NSArray<BRZContentCardRaw *> * _Nonnull unviewedCards;
		[Export ("unviewedCards", ArgumentSemantic.Copy)]
		BRZContentCardRaw[] UnviewedCards { get; }

		// -(void)requestRefresh;
		[Export ("requestRefresh")]
		void RequestRefresh ();

		// -(void)requestRefreshWithCompletion:(void (^ _Nonnull)(NSArray<BRZContentCardRaw *> * _Nullable, NSError * _Nullable))completion;
		[Export ("requestRefreshWithCompletion:")]
		void RequestRefreshWithCompletion (Action<NSArray<BRZContentCardRaw>, NSError> completion);

		// -(BRZCancellable * _Nonnull)subscribeToUpdates:(void (^ _Nonnull)(NSArray<BRZContentCardRaw *> * _Nonnull))update __attribute__((warn_unused_result("")));
		[Export ("subscribeToUpdates:")]
		BRZCancellable SubscribeToUpdates (Action<NSArray<BRZContentCardRaw>> update);
	}

	// @interface BRZNewsFeedCard : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZNewsFeedCard: INativeObject
	{
		// @property (copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Copy)]
		NSUrl Image { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cardDescription;
		[NullAllowed, Export ("cardDescription")]
		string CardDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (nonatomic) BOOL useWebView;
		[Export ("useWebView")]
		bool UseWebView { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull extras;
		[Export ("extras", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Extras { get; set; }

		// @property (nonatomic) BOOL viewed;
		[Export ("viewed")]
		bool Viewed { get; set; }

		// @property (nonatomic) NSTimeInterval created;
		[Export ("created")]
		double Created { get; set; }

		// @property (nonatomic) NSTimeInterval updated;
		[Export ("updated")]
		double Updated { get; set; }

		// @property (nonatomic) NSTimeInterval expires;
		[Export ("expires")]
		double Expires { get; set; }

		// @property (nonatomic, strong) BRZNewsFeedCardContext * _Nullable context;
		[NullAllowed, Export ("context", ArgumentSemantic.Strong)]
		BRZNewsFeedCardContext Context { get; set; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSData * _Nullable)json __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("json")]
		NSData Json { get; }

		// +(instancetype _Nullable)decodingWithJson:(NSData * _Nonnull)json __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodingWithJson:")]
		[return: NullAllowed]
		BRZNewsFeedCard DecodingWithJson (NSData json);
		// -(void)logImpressionUsing:(Braze * _Nonnull)braze;
		[Export ("logImpressionUsing:")]
		void LogImpressionUsing (Braze braze);

		// -(void)logClickUsing:(Braze * _Nonnull)braze;
		[Export ("logClickUsing:")]
		void LogClickUsing (Braze braze);
		//  (nonatomic) enum BRZNewsFeedCardType type;
		[Export ("type", ArgumentSemantic.Assign)]
		BRZNewsFeedCardType Type { get; set; }

		//  (copy, nonatomic) NSArray<BRZNewsFeedCardCategory *> * _Nonnull categories;
		[Export ("categories", ArgumentSemantic.Copy)]
		BRZNewsFeedCardCategory[] Categories { get; set; }

		//  (nonatomic) double imageAspectRatio;
		[Export ("imageAspectRatio")]
		double ImageAspectRatio { get; set; }
	}

	// @interface BRZCancellable : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZCancellable
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// @property (readonly, nonatomic, strong, class) BRZCancellable * _Nonnull empty;
		[Static]
		[Export ("empty", ArgumentSemantic.Strong)]
		BRZCancellable Empty { get; }

	}

	// @interface BRZUser : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZUser
	{
		// -(void)idOnQueue:(dispatch_queue_t _Nonnull)queue completion:(void (^ _Nonnull)(NSString * _Nullable))completion;
		[Export ("idOnQueue:completion:")]
		void IdOnQueue (DispatchQueue queue, Action<NSString> completion);

		// -(void)setFirstName:(NSString * _Nullable)firstName;
		[Export ("setFirstName:")]
		void SetFirstName ([NullAllowed] string firstName);

		// -(void)setLastName:(NSString * _Nullable)lastName;
		[Export ("setLastName:")]
		void SetLastName ([NullAllowed] string lastName);

		// -(void)setDateOfBirth:(NSDate * _Nullable)dateOfBirth;
		[Export ("setDateOfBirth:")]
		void SetDateOfBirth ([NullAllowed] NSDate dateOfBirth);

		// -(void)setCountry:(NSString * _Nullable)country;
		[Export ("setCountry:")]
		void SetCountry ([NullAllowed] string country);

		// -(void)setHomeCity:(NSString * _Nullable)homeCity;
		[Export ("setHomeCity:")]
		void SetHomeCity ([NullAllowed] string homeCity);

		// -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber;
		[Export ("setPhoneNumber:")]
		void SetPhoneNumber ([NullAllowed] string phoneNumber);

		// -(void)addToCustomAttributeArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value __attribute__((deprecated("", "addToCustomAttributeStringArrayWithKey")));
		[Obsolete("renamed: 'addToCustomAttributeStringArrayWithKey'")]
		[Export ("addToCustomAttributeArrayWithKey:value:")]
		void AddToCustomAttributeArrayWithKey (string key, string value);

		// -(void)removeFromCustomAttributeArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value __attribute__((deprecated("", "removeFromCustomAttributeStringArrayWithKey")));
		[Obsolete("renamed: 'removeFromCustomAttributeStringArrayWithKey'")]
		[Export ("removeFromCustomAttributeArrayWithKey:value:")]
		void RemoveFromCustomAttributeArrayWithKey (string key, string value);
		// -(void)idWithCompletion:(void (^ _Nonnull)(NSString * _Nullable))completion;
		[Export ("idWithCompletion:")]
		void IdWithCompletion (Action<NSString> completion);

		// -(void)setEmail:(NSString * _Nullable)email;
		[Export ("setEmail:")]
		void SetEmail ([NullAllowed] string email);

		// -(void)setLanguage:(NSString * _Nullable)language;
		[Export ("setLanguage:")]
		void SetLanguage ([NullAllowed] string language);

		// -(void)setGender:(BRZUserGender * _Nullable)gender;
		[Export ("setGender:")]
		void SetGender ([NullAllowed] BRZUserGender gender);

		// -(void)setEmailSubscriptionState:(enum BRZUserSubscriptionState)emailSubscriptionState;
		[Export ("setEmailSubscriptionState:")]
		void SetEmailSubscriptionState (BRZUserSubscriptionState emailSubscriptionState);

		// -(void)setPushNotificationSubscriptionState:(enum BRZUserSubscriptionState)pushNotificationSubscriptionState;
		[Export ("setPushNotificationSubscriptionState:")]
		void SetPushNotificationSubscriptionState (BRZUserSubscriptionState pushNotificationSubscriptionState);

		// -(void)setAttributionData:(BRZUserAttributionData * _Nullable)attributionData;
		[Export ("setAttributionData:")]
		void SetAttributionData ([NullAllowed] BRZUserAttributionData attributionData);

		// -(void)addAlias:(NSString * _Nonnull)alias label:(NSString * _Nonnull)label;
		[Export ("addAlias:label:")]
		void AddAlias (string alias, string label);

		// -(void)setCustomAttributeWithKey:(NSString * _Nonnull)key boolValue:(BOOL)boolValue;
		[Export ("setCustomAttributeWithKey:boolValue:")]
		void SetCustomAttributeWithKey (string key, bool boolValue);

		// -(void)setCustomAttributeWithKey:(NSString * _Nonnull)key doubleValue:(double)doubleValue;
		[Export ("setCustomAttributeWithKey:doubleValue:")]
		void SetCustomAttributeWithKey (string key, double doubleValue);

		// -(void)setCustomAttributeWithKey:(NSString * _Nonnull)key intValue:(NSInteger)intValue;
		[Export ("setCustomAttributeWithKey:intValue:")]
		void SetCustomAttributeWithKey (string key, nint intValue);

		// -(void)setCustomAttributeWithKey:(NSString * _Nonnull)key stringValue:(NSString * _Nonnull)stringValue;
		[Export ("setCustomAttributeWithKey:stringValue:")]
		void SetCustomAttributeWithKey (string key, string stringValue);

		// -(void)setCustomAttributeWithKey:(NSString * _Nonnull)key dateValue:(NSDate * _Nonnull)dateValue;
		[Export ("setCustomAttributeWithKey:dateValue:")]
		void SetCustomAttributeWithKey (string key, NSDate dateValue);

		// -(void)unsetCustomAttributeWithKey:(NSString * _Nonnull)key;
		[Export ("unsetCustomAttributeWithKey:")]
		void UnsetCustomAttributeWithKey (string key);

		// -(void)incrementCustomUserAttribute:(NSString * _Nonnull)key;
		[Export ("incrementCustomUserAttribute:")]
		void IncrementCustomUserAttribute (string key);

		// -(void)incrementCustomUserAttribute:(NSString * _Nonnull)key by:(NSInteger)amount;
		[Export ("incrementCustomUserAttribute:by:")]
		void IncrementCustomUserAttribute (string key, nint amount);

		// -(void)addToCustomAttributeStringArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export ("addToCustomAttributeStringArrayWithKey:value:")]
		void AddToCustomAttributeStringArrayWithKey (string key, string value);

		// -(void)removeFromCustomAttributeStringArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export ("removeFromCustomAttributeStringArrayWithKey:value:")]
		void RemoveFromCustomAttributeStringArrayWithKey (string key, string value);

		// -(void)setCustomAttributeArrayWithKey:(NSString * _Nonnull)key array:(NSArray<NSString *> * _Nullable)array;
		[Export ("setCustomAttributeArrayWithKey:array:")]
		void SetCustomAttributeArrayWithKey (string key, [NullAllowed] string[] array);

		// -(void)setNestedCustomAttributeArrayWithKey:(NSString * _Nonnull)key value:(NSArray<NSDictionary<NSString *,id> *> * _Nullable)array;
		[Export ("setNestedCustomAttributeArrayWithKey:value:")]
		void SetNestedCustomAttributeArrayWithKey (string key, [NullAllowed] NSDictionary<NSString, NSObject>[] array);

		// -(void)setNestedCustomAttributeDictionaryWithKey:(NSString * _Nonnull)key value:(NSDictionary<NSString *,id> * _Nullable)dictionary;
		[Export ("setNestedCustomAttributeDictionaryWithKey:value:")]
		void SetNestedCustomAttributeDictionaryWithKey (string key, [NullAllowed] NSDictionary<NSString, NSObject> dictionary);

		// -(void)setNestedCustomAttributeDictionaryWithKey:(NSString * _Nonnull)key value:(NSDictionary<NSString *,id> * _Nullable)dictionary merge:(BOOL)merge;
		[Export ("setNestedCustomAttributeDictionaryWithKey:value:merge:")]
		void SetNestedCustomAttributeDictionaryWithKey (string key, [NullAllowed] NSDictionary<NSString, NSObject> dictionary, bool merge);

		// -(void)setLastKnownLocationWithLatitude:(double)latitude longitude:(double)longitude horizontalAccuracy:(double)horizontalAccuracy;
		[Export ("setLastKnownLocationWithLatitude:longitude:horizontalAccuracy:")]
		void SetLastKnownLocationWithLatitude (double latitude, double longitude, double horizontalAccuracy);

		// -(void)setLastKnownLocationWithLatitude:(double)latitude longitude:(double)longitude altitude:(double)altitude horizontalAccuracy:(double)horizontalAccuracy verticalAccuracy:(double)verticalAccuracy;
		[Export ("setLastKnownLocationWithLatitude:longitude:altitude:horizontalAccuracy:verticalAccuracy:")]
		void SetLastKnownLocationWithLatitude (double latitude, double longitude, double altitude, double horizontalAccuracy, double verticalAccuracy);

		// -(void)setLocationCustomAttributeWithKey:(NSString * _Nonnull)key latitude:(double)latitude longitude:(double)longitude;
		[Export ("setLocationCustomAttributeWithKey:latitude:longitude:")]
		void SetLocationCustomAttributeWithKey (string key, double latitude, double longitude);

		// -(void)unsetLocationCustomAttributeWithKey:(NSString * _Nonnull)key;
		[Export ("unsetLocationCustomAttributeWithKey:")]
		void UnsetLocationCustomAttributeWithKey (string key);

		// -(void)addToSubscriptionGroupWithGroupId:(NSString * _Nonnull)id;
		[Export ("addToSubscriptionGroupWithGroupId:")]
		void AddToSubscriptionGroupWithGroupId (string id);

		// -(void)removeFromSubscriptionGroupWithGroupId:(NSString * _Nonnull)id;
		[Export ("removeFromSubscriptionGroupWithGroupId:")]
		void RemoveFromSubscriptionGroupWithGroupId (string id);
		//  (copy, nonatomic, setter = _compat_setFirstName:) SWIFT_DEPRECATED_MSG("", "set(firstName:)") NSString * firstName __attribute__((deprecated("", "set(firstName:)")));
		[Obsolete("renamed: 'set(firstName:)'")]
		[Export ("firstName")]
		string FirstName { get; [Bind ("_compat_setFirstName:")] set; }

		//  (copy, nonatomic, setter = _compat_setLastName:) SWIFT_DEPRECATED_MSG("", "set(lastName:)") NSString * lastName __attribute__((deprecated("", "set(lastName:)")));
		[Obsolete("renamed: 'set(lastName:)'")]
		[Export ("lastName")]
		string LastName { get; [Bind ("_compat_setLastName:")] set; }

		//  (copy, nonatomic, setter = _compat_setEmail:) SWIFT_DEPRECATED_MSG("", "set(email:)") NSString * email __attribute__((deprecated("", "set(email:)")));
		[Obsolete("renamed: 'set(email:)'")]
		[Export ("email")]
		string Email { get; [Bind ("_compat_setEmail:")] set; }

		//  (copy, nonatomic, setter = _compat_setDateOfBirth:) SWIFT_DEPRECATED_MSG("", "set(dateOfBirth:)") NSDate * dateOfBirth __attribute__((deprecated("", "set(dateOfBirth:)")));
		[Obsolete("renamed: 'set(dateOfBirth:)'")]
		[Export ("dateOfBirth", ArgumentSemantic.Copy)]
		NSDate DateOfBirth { get; [Bind ("_compat_setDateOfBirth:")] set; }

		//  (copy, nonatomic, setter = _compat_setCountry:) SWIFT_DEPRECATED_MSG("", "set(country:)") NSString * country __attribute__((deprecated("", "set(country:)")));
		[Obsolete("renamed: 'set(country:)'")]
		[Export ("country")]
		string Country { get; [Bind ("_compat_setCountry:")] set; }

		//  (copy, nonatomic, setter = _compat_setHomeCity:) SWIFT_DEPRECATED_MSG("", "set(homeCity:)") NSString * homeCity __attribute__((deprecated("", "set(homeCity:)")));
		[Obsolete("renamed: 'set(homeCity:)'")]
		[Export ("homeCity")]
		string HomeCity { get; [Bind ("_compat_setHomeCity:")] set; }

		//  (copy, nonatomic, setter = _compat_setLanguage:) SWIFT_DEPRECATED_MSG("", "set(language:)") NSString * language __attribute__((deprecated("", "set(language:)")));
		[Obsolete("renamed: 'set(language:)'")]
		[Export ("language")]
		string Language { get; [Bind ("_compat_setLanguage:")] set; }

		//  (copy, nonatomic, setter = _compat_setPhone:) SWIFT_DEPRECATED_MSG("", "set(phoneNumber:)") NSString * phone __attribute__((deprecated("", "set(phoneNumber:)")));
		[Obsolete("renamed: 'set(phoneNumber:)'")]
		[Export ("phone")]
		string Phone { get; [Bind ("_compat_setPhone:")] set; }

		//  (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("", "id(queue:completion:)") NSString * userID __attribute__((deprecated("", "id(queue:completion:)")));
		[Obsolete("renamed: 'id(queue:completion:)'")]
		[Export ("userID")]
		string UserID { get; }

		//  (copy, nonatomic) SWIFT_DEPRECATED_MSG("avatarImageURL is not supported by Braze anymore") NSString * avatarImageURL __attribute__((deprecated("avatarImageURL is not supported by Braze anymore")));
		[Obsolete("avatarImageURL is not supported by Braze anymore")]
		[Export ("avatarImageURL")]
		string AvatarImageURL { get; set; }

		//  (nonatomic, strong) SWIFT_DEPRECATED_MSG("facebookUser is not supported by Braze anymore") id facebookUser __attribute__((deprecated("facebookUser is not supported by Braze anymore")));
		[Obsolete("facebookUser is not supported by Braze anymore")]
		[Export ("facebookUser", ArgumentSemantic.Strong)]
		NSObject FacebookUser { get; set; }

		//  (nonatomic, strong) SWIFT_DEPRECATED_MSG("twitterUser is not supported by Braze anymore") id twitterUser __attribute__((deprecated("twitterUser is not supported by Braze anymore")));
		[Obsolete("twitterUser is not supported by Braze anymore")]
		[Export ("twitterUser", ArgumentSemantic.Strong)]
		NSObject TwitterUser { get; set; }

		//  (nonatomic, setter = _compat_setAttributionData:, strong) SWIFT_DEPRECATED_MSG("", "set(attributionData:)") id attributionData __attribute__((deprecated("", "set(attributionData:)")));
		[Obsolete("renamed: 'set(attributionData:)'")]
		[Export ("attributionData", ArgumentSemantic.Strong)]
		NSObject AttributionData { get; [Bind ("_compat_setAttributionData:")] set; }

		// -(BOOL)setEmailNotificationSubscriptionType:(NSInteger)emailNotificationSubscriptionType __attribute__((warn_unused_result(""))) __attribute__((deprecated("", "set(emailSubscriptionState:)")));
		[Obsolete("renamed: 'set(emailSubscriptionState:)'")]
		[Export ("setEmailNotificationSubscriptionType:")]
		bool SetEmailNotificationSubscriptionType (nint emailNotificationSubscriptionType);

		// -(BOOL)setPushNotificationSubscriptionType:(NSInteger)pushNotificationSubscriptionType __attribute__((warn_unused_result(""))) __attribute__((deprecated("", "set(pushNotificationSubscriptionState:)")));
		[Obsolete("renamed: 'set(pushNotificationSubscriptionState:)'")]
		[Export ("setPushNotificationSubscriptionType:")]
		bool SetPushNotificationSubscriptionType (nint pushNotificationSubscriptionType);

		// -(BOOL)addLocationCustomAttributeWithKey:(NSString * _Nonnull)key latitude:(double)latitude longitude:(double)longitude __attribute__((warn_unused_result(""))) __attribute__((deprecated("", "setLocationCustomAttribute(key:latitude:longitude:)")));
		[Obsolete("renamed: 'setLocationCustomAttribute(key:latitude:longitude:)'")]
		[Export ("addLocationCustomAttributeWithKey:latitude:longitude:")]
		bool AddLocationCustomAttributeWithKey (string key, double latitude, double longitude);

		// -(BOOL)removeLocationCustomAttributeWithKey:(NSString * _Nonnull)key __attribute__((warn_unused_result(""))) __attribute__((deprecated("", "unsetLocationCustomAttribute(key:)")));
		[Obsolete("renamed: 'unsetLocationCustomAttribute(key:)'")]
		[Export ("removeLocationCustomAttributeWithKey:")]
		bool RemoveLocationCustomAttributeWithKey (string key);
	}

	// @interface BRZNewsFeed : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZNewsFeed
	{
		// @property (readonly, copy, nonatomic) NSArray<BRZNewsFeedCard *> * _Nonnull cards;
		[Export ("cards", ArgumentSemantic.Copy)]
		BRZNewsFeedCard[] Cards { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable lastUpdate;
		[NullAllowed, Export ("lastUpdate", ArgumentSemantic.Copy)]
		NSDate LastUpdate { get; }

		// -(BRZCancellable * _Nonnull)subscribeToUpdates:(void (^ _Nonnull)(NSArray<BRZNewsFeedCard *> * _Nonnull))update __attribute__((warn_unused_result("")));
		[Export ("subscribeToUpdates:")]
		BRZCancellable SubscribeToUpdates (Action<NSArray<BRZNewsFeedCard>> update);

		// -(void)requestRefresh;
		[Export ("requestRefresh")]
		void RequestRefresh ();

		// -(void)requestRefreshWithCompletion:(void (^ _Nonnull)(NSArray<BRZNewsFeedCard *> * _Nullable, NSError * _Nullable))completion;
		[Export ("requestRefreshWithCompletion:")]
		void RequestRefreshWithCompletion (Action<NSArray<BRZNewsFeedCard>, NSError> completion);
	}

	// @interface BRZWebViewController : UIViewController <WKNavigationDelegate>
	[BaseType (typeof(UIViewController))]
	interface BRZWebViewController : IWKNavigationDelegate
	{
		// @property (copy, nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (nonatomic) BOOL animateDismissal;
		[Export ("animateDismissal")]
		bool AnimateDismissal { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(NSURL * _Nonnull) systemOpenURL;
		[NullAllowed, Export ("systemOpenURL", ArgumentSemantic.Copy)]
		Action<NSUrl> SystemOpenURL { get; set; }
		// -(void)webView:(WKWebView * _Nonnull)webView decidePolicyForNavigationAction:(WKNavigationAction * _Nonnull)navigationAction decisionHandler:(void (^ _Nonnull)(WKNavigationActionPolicy))decisionHandler __attribute__((swift_async("not_swift_private", 3)));
		[Export ("webView:decidePolicyForNavigationAction:decisionHandler:")]
		void WebView (WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler);

		// -(void)webView:(WKWebView * _Nonnull)webView didFinishNavigation:(WKNavigation * _Null_unspecified)navigation;
		[Export ("webView:didFinishNavigation:")]
		void WebView (WKWebView webView, WKNavigation navigation);

		// -(void)webView:(WKWebView * _Nonnull)webView didFailProvisionalNavigation:(WKNavigation * _Null_unspecified)navigation withError:(NSError * _Nonnull)error;
		[Export ("webView:didFailProvisionalNavigation:withError:")]
		void WebView (WKWebView webView, WKNavigation navigation, NSError error);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);
	}

	// @interface BRZNotifications : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZNotifications
	{
		// @property (readonly, copy, nonatomic) NSData * _Nullable deviceToken;
		[NullAllowed, Export ("deviceToken", ArgumentSemantic.Copy)]
		NSData DeviceToken { get; }

		// -(BOOL)handleBackgroundNotificationWithUserInfo:(NSDictionary * _Nonnull)userInfo fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler __attribute__((warn_unused_result("")));
		[Export ("handleBackgroundNotificationWithUserInfo:fetchCompletionHandler:")]
		bool HandleBackgroundNotificationWithUserInfo (NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);

		// -(BOOL)handleUserNotificationWithResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler __attribute__((warn_unused_result("")));
		[Export ("handleUserNotificationWithResponse:withCompletionHandler:")]
		bool HandleUserNotificationWithResponse (UNNotificationResponse response, Action completionHandler);

		// -(BRZCancellable * _Nonnull)subscribeToUpdates:(void (^ _Nonnull)(BRZNotificationsPayload * _Nonnull))update __attribute__((warn_unused_result("")));
		[Export ("subscribeToUpdates:")]
		BRZCancellable SubscribeToUpdates (Action<BRZNotificationsPayload> update);

		// +(BOOL)isBrazeNotification:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
		[Static]
		[Export ("isBrazeNotification:")]
		bool IsBrazeNotification (NSDictionary userInfo);

		// +(BOOL)isInternalNotification:(NSDictionary * _Nonnull)userInfo __attribute__((warn_unused_result("")));
		[Static]
		[Export ("isInternalNotification:")]
		bool IsInternalNotification (NSDictionary userInfo);

		// -(void)registerDeviceToken:(NSData * _Nonnull)deviceToken;
		[Export ("registerDeviceToken:")]
		void RegisterDeviceToken (NSData deviceToken);
		//  (copy, nonatomic, class) NSSet<UNNotificationCategory *> * _Nonnull categories;
		[Static]
		[Export ("categories", ArgumentSemantic.Copy)]
		NSSet<UNNotificationCategory> Categories { get; set; }
	}

	// @interface BRZFeatureFlags : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZFeatureFlags
	{
		// @property (readonly, copy, nonatomic) NSArray<BRZFeatureFlag *> * _Nonnull featureFlags;
		[Export ("featureFlags", ArgumentSemantic.Copy)]
		BRZFeatureFlag[] FeatureFlags { get; }

		// -(BRZFeatureFlag * _Nullable)featureFlagWithId:(NSString * _Nonnull)id __attribute__((warn_unused_result("")));
		[Export ("featureFlagWithId:")]
		[return: NullAllowed]
		BRZFeatureFlag FeatureFlagWithId (string id);

		// -(BRZCancellable * _Nonnull)subscribeToUpdates:(void (^ _Nonnull)(NSArray<BRZFeatureFlag *> * _Nonnull))update __attribute__((warn_unused_result("")));
		[Export ("subscribeToUpdates:")]
		BRZCancellable SubscribeToUpdates (Action<NSArray<BRZFeatureFlag>> update);

		// -(void)logFeatureFlagImpressionWithId:(NSString * _Nonnull)id;
		[Export ("logFeatureFlagImpressionWithId:")]
		void LogFeatureFlagImpressionWithId (string id);

		// -(void)requestRefresh;
		[Export ("requestRefresh")]
		void RequestRefresh ();

		// -(void)requestRefreshWithCompletion:(void (^ _Nonnull)(NSArray<BRZFeatureFlag *> * _Nullable, NSError * _Nullable))completion;
		[Export ("requestRefreshWithCompletion:")]
		void RequestRefreshWithCompletion (Action<NSArray<BRZFeatureFlag>, NSError> completion);
	}

	// @interface BRZFeatureFlag : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZFeatureFlag: INativeObject
	{
		// @property (copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; set; }

		// @property (nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull properties;
		[Export ("properties", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Properties { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable flagTrackingString;
		[NullAllowed, Export ("flagTrackingString")]
		string FlagTrackingString { get; set; }

		// -(NSString * _Nullable)stringPropertyForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("stringPropertyForKey:")]
		[return: NullAllowed]
		string StringPropertyForKey (string key);
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(NSData * _Nullable)json __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("json")]
		NSData Json { get; }

		// +(instancetype _Nullable)decodingWithJson:(NSData * _Nonnull)json __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodingWithJson:")]
		[return: NullAllowed]
		BRZFeatureFlag DecodingWithJson (NSData json);
		// -(NSNumber * _Nullable)numberPropertyForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("numberPropertyForKey:")]
		[return: NullAllowed]
		NSNumber NumberPropertyForKey (string key);

		// -(NSNumber * _Nullable)boolPropertyForKey:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
		[Export ("boolPropertyForKey:")]
		[return: NullAllowed]
		NSNumber BoolPropertyForKey (string key);
	}

	// @interface BRZInAppMessageRaw : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZInAppMessageRaw
	{
		// @property (copy, nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (nonatomic) BOOL useWebView;
		[Export ("useWebView")]
		bool UseWebView { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable message;
		[NullAllowed, Export ("message")]
		string Message { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable header;
		[NullAllowed, Export ("header")]
		string Header { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable imageURL;
		[NullAllowed, Export ("imageURL", ArgumentSemantic.Copy)]
		NSUrl ImageURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable icon;
		[NullAllowed, Export ("icon")]
		string Icon { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,BRZInAppMessageRawTheme *> * _Nullable themes;
		[NullAllowed, Export ("themes", ArgumentSemantic.Copy)]
		NSDictionary<NSString, BRZInAppMessageRawTheme> Themes { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor TextColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nullable headerTextColor;
		[NullAllowed, Export ("headerTextColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor HeaderTextColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nullable iconColor;
		[NullAllowed, Export ("iconColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor IconColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nullable iconBackgroundColor;
		[NullAllowed, Export ("iconBackgroundColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor IconBackgroundColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nullable frameColor;
		[NullAllowed, Export ("frameColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor FrameColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nullable closeButtonColor;
		[NullAllowed, Export ("closeButtonColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor CloseButtonColor { get; set; }

		// @property (copy, nonatomic) NSArray<BRZInAppMessageRawButton *> * _Nullable buttons;
		[NullAllowed, Export ("buttons", ArgumentSemantic.Copy)]
		BRZInAppMessageRawButton[] Buttons { get; set; }

		// @property (nonatomic) BOOL animateIn;
		[Export ("animateIn")]
		bool AnimateIn { get; set; }

		// @property (nonatomic) BOOL animateOut;
		[Export ("animateOut")]
		bool AnimateOut { get; set; }

		// @property (readonly, nonatomic) BOOL isTestSend;
		[Export ("isTestSend")]
		bool IsTestSend { get; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull extras;
		[Export ("extras", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Extras { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable baseURL;
		[NullAllowed, Export ("baseURL", ArgumentSemantic.Copy)]
		NSUrl BaseURL { get; set; }

		// @property (copy, nonatomic) NSArray<NSURL *> * _Nullable assetURLs;
		[NullAllowed, Export ("assetURLs", ArgumentSemantic.Copy)]
		NSUrl[] AssetURLs { get; set; }

		// @property (nonatomic) BOOL isControl;
		[Export ("isControl")]
		bool IsControl { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nullable messageFields;
		[NullAllowed, Export ("messageFields", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> MessageFields { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageContext * _Nullable context;
		[NullAllowed, Export ("context", ArgumentSemantic.Strong)]
		BRZInAppMessageContext Context { get; set; }

		// -(NSData * _Nullable)json __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("json")]
		NSData Json { get; }

		// +(instancetype _Nullable)decodingWithJson:(NSData * _Nonnull)json __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodingWithJson:")]
		[return: NullAllowed]
		BRZInAppMessageRaw DecodingWithJson (NSData json);
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// -(void)logImpressionUsing:(Braze * _Nonnull)braze;
		[Export ("logImpressionUsing:")]
		void LogImpressionUsing (Braze braze);

		// -(void)logClickWithButtonId:(NSString * _Nullable)buttonId using:(Braze * _Nonnull)braze;
		[Export ("logClickWithButtonId:using:")]
		void LogClickWithButtonId ([NullAllowed] string buttonId, Braze braze);
		//  (nonatomic) BOOL _compat_hideChevron;
		[Export ("_compat_hideChevron")]
		bool _compat_hideChevron { get; set; }

		//  (nonatomic) NSInteger _compat_overrideUserInterfaceStyle;
		[Export ("_compat_overrideUserInterfaceStyle")]
		nint _compat_overrideUserInterfaceStyle { get; set; }
		//  (nonatomic) enum BRZInAppMessageRawType type;
		[Export ("type", ArgumentSemantic.Assign)]
		BRZInAppMessageRawType Type { get; set; }

		//  (nonatomic) enum BRZInAppMessageRawClickAction clickAction;
		[Export ("clickAction", ArgumentSemantic.Assign)]
		BRZInAppMessageRawClickAction ClickAction { get; set; }

		//  (nonatomic) enum BRZInAppMessageRawClose messageClose;
		[Export ("messageClose", ArgumentSemantic.Assign)]
		BRZInAppMessageRawClose MessageClose { get; set; }

		//  (nonatomic) enum BRZInAppMessageRawOrientation orientation;
		[Export ("orientation", ArgumentSemantic.Assign)]
		BRZInAppMessageRawOrientation Orientation { get; set; }

		//  (nonatomic) enum BRZInAppMessageRawTextAlignment messageTextAlignment;
		[Export ("messageTextAlignment", ArgumentSemantic.Assign)]
		BRZInAppMessageRawTextAlignment MessageTextAlignment { get; set; }

		//  (nonatomic) enum BRZInAppMessageRawTextAlignment headerTextAlignment;
		[Export ("headerTextAlignment", ArgumentSemantic.Assign)]
		BRZInAppMessageRawTextAlignment HeaderTextAlignment { get; set; }

		//  (nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }

		//  (nonatomic) enum BRZInAppMessageRawImageStyle imageStyle;
		[Export ("imageStyle", ArgumentSemantic.Assign)]
		BRZInAppMessageRawImageStyle ImageStyle { get; set; }

		//  (nonatomic) enum BRZInAppMessageRawSlideFrom slideFrom;
		[Export ("slideFrom", ArgumentSemantic.Assign)]
		BRZInAppMessageRawSlideFrom SlideFrom { get; set; }
	}

	// @interface BRZModalContext : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZModalContext
	{
		// @property (nonatomic, strong) UIViewController * _Nonnull presentingViewController;
		[Export ("presentingViewController", ArgumentSemantic.Strong)]
		UIViewController PresentingViewController { get; set; }

		// @property (nonatomic) BOOL animatePresentation;
		[Export ("animatePresentation")]
		bool AnimatePresentation { get; set; }

		// @property (nonatomic) BOOL animateDismissal;
		[Export ("animateDismissal")]
		bool AnimateDismissal { get; set; }

		//  (readonly, nonatomic) enum BRZChannel channel;
		[Export ("channel")]
		BRZChannel Channel { get; }
	}

	// @protocol BrazeInAppMessageWindowType
	[BaseType(typeof(NSObject))]
	[Model][Protocol]
	interface BrazeInAppMessageWindowType
	{

	}

	// @protocol BrazeSDKAuthDelegate
	[BaseType(typeof(NSObject))]
	[Model][Protocol]
	interface BrazeSDKAuthDelegate
	{
		// @required -(void)braze:(Braze * _Nonnull)braze sdkAuthenticationFailedWithError:(BRZSDKAuthenticationError * _Nonnull)error;
		[Abstract]
		[Export ("braze:sdkAuthenticationFailedWithError:")]
		void SdkAuthenticationFailedWithError (Braze braze, BRZSDKAuthenticationError error);

	}

	// @interface BRZInAppMessageRawButton : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZInAppMessageRawButton
	{
		// @property (nonatomic) NSInteger identifier;
		[Export ("identifier")]
		nint Identifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (copy, nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (nonatomic) BOOL useWebView;
		[Export ("useWebView")]
		bool UseWebView { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor TextColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor BorderColor { get; set; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		//  (nonatomic) enum BRZInAppMessageRawClickAction clickAction;
		[Export ("clickAction", ArgumentSemantic.Assign)]
		BRZInAppMessageRawClickAction ClickAction { get; set; }

		// -(instancetype _Nonnull)initWithId:(NSInteger)id text:(NSString * _Nonnull)text clickAction:(enum BRZInAppMessageRawClickAction)clickAction url:(NSURL * _Nullable)url useWebView:(BOOL)useWebView;
		[Export ("initWithId:text:clickAction:url:useWebView:")]
		NativeHandle Constructor (nint id, string text, BRZInAppMessageRawClickAction clickAction, [NullAllowed] NSUrl url, bool useWebView);

		// -(instancetype _Nonnull)initWithId:(NSInteger)id text:(NSString * _Nonnull)text clickAction:(enum BRZInAppMessageRawClickAction)clickAction url:(NSURL * _Nullable)url useWebView:(BOOL)useWebView textColor:(BRZInAppMessageRawColor * _Nonnull)textColor backgroundColor:(BRZInAppMessageRawColor * _Nonnull)backgroundColor borderColor:(BRZInAppMessageRawColor * _Nonnull)borderColor;
		[Export ("initWithId:text:clickAction:url:useWebView:textColor:backgroundColor:borderColor:")]
		NativeHandle Constructor (nint id, string text, BRZInAppMessageRawClickAction clickAction, [NullAllowed] NSUrl url, bool useWebView, BRZInAppMessageRawColor textColor, BRZInAppMessageRawColor backgroundColor, BRZInAppMessageRawColor borderColor);
	}

	// @interface BRZInAppMessageRawColor : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZInAppMessageRawColor
	{
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		//  (readonly, nonatomic, strong) UIColor * _Nonnull uiColor;
		[Export ("uiColor", ArgumentSemantic.Strong)]
		UIColor UiColor { get; }

		// -(instancetype _Nonnull)init:(UIColor * _Nonnull)color;
		[Export ("init:")]
		NativeHandle Constructor (UIColor color);
	}

	// @interface BRZConfigurationLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZConfigurationLogger
	{
		// @property (nonatomic) enum BRZLoggerLevel level;
		[Export ("level", ArgumentSemantic.Assign)]
		BRZLoggerLevel Level { get; set; }

		// @property (nonatomic) BOOL signposts;
		[Export ("signposts")]
		bool Signposts { get; set; }

		// @property (copy, nonatomic) BOOL (^ _Nullable)(NSString * _Nonnull, enum BRZLoggerLevel) print;
		[NullAllowed, Export ("print", ArgumentSemantic.Copy)]
		Func<NSString, BRZLoggerLevel, bool> Print { get; set; }

	}

	// @interface BRZConfigurationPush : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZConfigurationPush
	{
		// @property (copy, nonatomic) NSString * _Nullable appGroup;
		[NullAllowed, Export ("appGroup")]
		string AppGroup { get; set; }

		// @property (nonatomic, strong) BRZConfigurationPushAutomation * _Nonnull automation;
		[Export ("automation", ArgumentSemantic.Strong)]
		BRZConfigurationPushAutomation Automation { get; set; }

	}

	// @interface BRZConfigurationLocation : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZConfigurationLocation
	{
		// @property (nonatomic) BOOL automaticLocationCollection;
		[Export ("automaticLocationCollection")]
		bool AutomaticLocationCollection { get; set; }

		// @property (nonatomic) BOOL geofencesEnabled;
		[Export ("geofencesEnabled")]
		bool GeofencesEnabled { get; set; }

		// @property (nonatomic) BOOL automaticGeofenceRequests;
		[Export ("automaticGeofenceRequests")]
		bool AutomaticGeofenceRequests { get; set; }

		// @property (nonatomic, strong) id _Nullable brazeLocationProvider;
		[NullAllowed, Export ("brazeLocationProvider", ArgumentSemantic.Strong)]
		NSObject BrazeLocationProvider { get; set; }

		//  (nonatomic, strong) SWIFT_DEPRECATED_MSG("", "brazeLocationProvider") id brazeLocation __attribute__((deprecated("", "brazeLocationProvider")));
		[Obsolete("renamed: 'brazeLocationProvider'")]
		[Export ("brazeLocation", ArgumentSemantic.Strong)]
		NSObject BrazeLocation { get; set; }
	}

	// @interface BRZDeviceProperty : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZDeviceProperty
	{
		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull model;
		[Static]
		[Export ("model", ArgumentSemantic.Strong)]
		BRZDeviceProperty Model { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull osVersion;
		[Static]
		[Export ("osVersion", ArgumentSemantic.Strong)]
		BRZDeviceProperty OsVersion { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull resolution;
		[Static]
		[Export ("resolution", ArgumentSemantic.Strong)]
		BRZDeviceProperty Resolution { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull timeZone;
		[Static]
		[Export ("timeZone", ArgumentSemantic.Strong)]
		BRZDeviceProperty TimeZone { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull locale;
		[Static]
		[Export ("locale", ArgumentSemantic.Strong)]
		BRZDeviceProperty Locale { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull carrier;
		[Static]
		[Export ("carrier", ArgumentSemantic.Strong)]
		BRZDeviceProperty Carrier { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull pushEnabled;
		[Static]
		[Export ("pushEnabled", ArgumentSemantic.Strong)]
		BRZDeviceProperty PushEnabled { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull pushAuthStatus;
		[Static]
		[Export ("pushAuthStatus", ArgumentSemantic.Strong)]
		BRZDeviceProperty PushAuthStatus { get; }

		// @property (readonly, nonatomic, strong, class) BRZDeviceProperty * _Nonnull pushDisplayOptions __attribute__((deprecated("Push display options are no longer supported. Providing this value will have no effect.")));
		[Obsolete("Push display options are no longer supported. Providing this value will have no effect.")]
		[Static]
		[Export ("pushDisplayOptions", ArgumentSemantic.Strong)]
		BRZDeviceProperty PushDisplayOptions { get; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

	}

	// @ : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZContentCardContext
	{
		// -(void)logImpression;
		[Export ("logImpression")]
		void LogImpression ();

		// -(void)logClick;
		[Export ("logClick")]
		void LogClick ();

		// -(void)processClickActionWithURL:(NSURL * _Nonnull)url useWebView:(BOOL)useWebView;
		[Export ("processClickActionWithURL:useWebView:")]
		void ProcessClickActionWithURL (NSUrl url, bool useWebView);

		// -(void)logDismissed;
		[Export ("logDismissed")]
		void LogDismissed ();

		// -(void)logError:(NSError * _Nonnull)error;
		[Export ("logError:")]
		void LogError (NSError error);

		// -(instancetype _Nullable)initWithCardRaw:(BRZContentCardRaw * _Nonnull)cardRaw using:(Braze * _Nonnull)braze;
		[Export ("initWithCardRaw:using:")]
		NativeHandle Constructor (BRZContentCardRaw cardRaw, Braze braze);

		// -(BRZCancellable * _Nonnull)loadImageWithCompletion:(void (^ _Nonnull)(NSURL * _Nullable, NSError * _Nullable))completion __attribute__((warn_unused_result("")));
		[Export ("loadImageWithCompletion:")]
		BRZCancellable LoadImageWithCompletion (Action<NSUrl, NSError> completion);
	}

	// @interface BRZInAppMessageContext : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZInAppMessageContext
	{
		// @property (readonly, nonatomic) BOOL valid;
		[Export ("valid")]
		bool Valid { get; }

		// @property (readonly, nonatomic) id _Nullable braze;
		[NullAllowed, Export ("braze")]
		NSObject Braze { get; }

		// -(void)logImpression;
		[Export ("logImpression")]
		void LogImpression ();

		// -(void)logError:(NSError * _Nonnull)error;
		[Export ("logError:")]
		void LogError (NSError error);

		// -(void)logErrorFlattened:(NSString * _Nonnull)error;
		[Export ("logErrorFlattened:")]
		void LogErrorFlattened (string error);

		// -(void)discard;
		[Export ("discard")]
		void Discard ();
		// -(instancetype _Nullable)initWithMessageRaw:(BRZInAppMessageRaw * _Nonnull)messageRaw using:(Braze * _Nonnull)braze;
		[Export ("initWithMessageRaw:using:")]
		NativeHandle Constructor (BRZInAppMessageRaw messageRaw, Braze braze);

		// -(void)logClick;
		[Export ("logClick")]
		void LogClick ();

		// -(void)logClickWithButtonId:(NSString * _Nonnull)buttonId;
		[Export ("logClickWithButtonId:")]
		void LogClickWithButtonId (string buttonId);

		// -(void)processClickAction:(enum BRZInAppMessageRawClickAction)clickAction url:(NSURL * _Nullable)url useWebView:(BOOL)useWebView;
		[Export ("processClickAction:url:useWebView:")]
		void ProcessClickAction (BRZInAppMessageRawClickAction clickAction, [NullAllowed] NSUrl url, bool useWebView);

		// -(void)processClickAction:(enum BRZInAppMessageRawClickAction)clickAction url:(NSURL * _Nullable)url useWebView:(BOOL)useWebView target:(id _Nullable)target;
		[Export ("processClickAction:url:useWebView:target:")]
		void ProcessClickAction (BRZInAppMessageRawClickAction clickAction, [NullAllowed] NSUrl url, bool useWebView, [NullAllowed] NSObject target);

		// -(BRZCancellable * _Nonnull)getLocalAssets:(NSArray<NSURL *> * _Nonnull)urls destinationURL:(NSURL * _Nonnull)destinationURL completionHandler:(void (^ _Nonnull)(NSDictionary<NSURL *,NSURL *> * _Nullable, NSError * _Nullable))completionHandler __attribute__((warn_unused_result("")));
		[Export ("getLocalAssets:destinationURL:completionHandler:")]
		BRZCancellable GetLocalAssets (NSUrl[] urls, NSUrl destinationURL, Action<NSDictionary<NSUrl, NSUrl>, NSError> completionHandler);

		// -(BRZCancellable * _Nonnull)withLocalAssets:(BRZInAppMessageRaw * _Nonnull)message destinationURL:(NSURL * _Nonnull)destinationURL completionHandler:(void (^ _Nonnull)(BRZInAppMessageRaw * _Nullable, NSError * _Nullable))completionHandler __attribute__((warn_unused_result("")));
		[Export ("withLocalAssets:destinationURL:completionHandler:")]
		BRZCancellable WithLocalAssets (BRZInAppMessageRaw message, NSUrl destinationURL, Action<BRZInAppMessageRaw, NSError> completionHandler);
	}

	// @interface BRZInAppMessageRawTheme : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZInAppMessageRawTheme: INativeObject
	{
		// @property (readonly, nonatomic, strong, class) BRZInAppMessageRawTheme * _Nonnull defaultLight;
		[Static]
		[Export ("defaultLight", ArgumentSemantic.Strong)]
		BRZInAppMessageRawTheme DefaultLight { get; }

		// @property (readonly, nonatomic, strong, class) BRZInAppMessageRawTheme * _Nonnull defaultDark;
		[Static]
		[Export ("defaultDark", ArgumentSemantic.Strong)]
		BRZInAppMessageRawTheme DefaultDark { get; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor TextColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull iconColor;
		[Export ("iconColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor IconColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull iconBackgroundColor;
		[Export ("iconBackgroundColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor IconBackgroundColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull headerTextColor;
		[Export ("headerTextColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor HeaderTextColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull closeButtonColor;
		[Export ("closeButtonColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor CloseButtonColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull frameColor;
		[Export ("frameColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor FrameColor { get; set; }

		// @property (copy, nonatomic) NSArray<BRZInAppMessageRawButtonTheme *> * _Nonnull buttons;
		[Export ("buttons", ArgumentSemantic.Copy)]
		BRZInAppMessageRawButtonTheme[] Buttons { get; set; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

	}

	// @interface BRZInAppMessageRawButtonTheme : NSObject
	[BaseType (typeof(NSObject))]
	interface BRZInAppMessageRawButtonTheme
	{
		// @property (readonly, nonatomic, strong, class) BRZInAppMessageRawButtonTheme * _Nonnull defaultLight;
		[Static]
		[Export ("defaultLight", ArgumentSemantic.Strong)]
		BRZInAppMessageRawButtonTheme DefaultLight { get; }

		// @property (readonly, nonatomic, strong, class) BRZInAppMessageRawButtonTheme * _Nonnull defaultDark;
		[Static]
		[Export ("defaultDark", ArgumentSemantic.Strong)]
		BRZInAppMessageRawButtonTheme DefaultDark { get; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor TextColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor BorderColor { get; set; }

		// @property (nonatomic, strong) BRZInAppMessageRawColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		BRZInAppMessageRawColor BackgroundColor { get; set; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

	}

	// @interface BRZNewsFeedCardContext : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZNewsFeedCardContext
	{
		// -(instancetype _Nonnull)initWithCard:(BRZNewsFeedCard * _Nonnull)card using:(Braze * _Nonnull)braze;
		[Export ("initWithCard:using:")]
		NativeHandle Constructor (BRZNewsFeedCard card, Braze braze);

		// -(void)logImpression;
		[Export ("logImpression")]
		void LogImpression ();

		// -(void)logClick;
		[Export ("logClick")]
		void LogClick ();

		// -(void)processClickActionWithURL:(NSURL * _Nonnull)url useWebView:(BOOL)useWebView;
		[Export ("processClickActionWithURL:useWebView:")]
		void ProcessClickActionWithURL (NSUrl url, bool useWebView);

	}

	// @interface BRZNewsFeedCardCategory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZNewsFeedCardCategory
	{
		// @property (readonly, nonatomic, strong, class) BRZNewsFeedCardCategory * _Nonnull none;
		[Static]
		[Export ("none", ArgumentSemantic.Strong)]
		BRZNewsFeedCardCategory None { get; }

		// @property (readonly, nonatomic, strong, class) BRZNewsFeedCardCategory * _Nonnull news;
		[Static]
		[Export ("news", ArgumentSemantic.Strong)]
		BRZNewsFeedCardCategory News { get; }

		// @property (readonly, nonatomic, strong, class) BRZNewsFeedCardCategory * _Nonnull advertising;
		[Static]
		[Export ("advertising", ArgumentSemantic.Strong)]
		BRZNewsFeedCardCategory Advertising { get; }

		// @property (readonly, nonatomic, strong, class) BRZNewsFeedCardCategory * _Nonnull announcements;
		[Static]
		[Export ("announcements", ArgumentSemantic.Strong)]
		BRZNewsFeedCardCategory Announcements { get; }

		// @property (readonly, nonatomic, strong, class) BRZNewsFeedCardCategory * _Nonnull social;
		[Static]
		[Export ("social", ArgumentSemantic.Strong)]
		BRZNewsFeedCardCategory Social { get; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

	}

	// @interface BRZNotificationsPayload : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZNotificationsPayload
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
		[NullAllowed, Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable body;
		[NullAllowed, Export ("body")]
		string Body { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull date;
		[Export ("date", ArgumentSemantic.Copy)]
		NSDate Date { get; }

		// @property (readonly, nonatomic, strong) BRZURLContext * _Nullable urlContext;
		[NullAllowed, Export ("urlContext", ArgumentSemantic.Strong)]
		BRZURLContext UrlContext { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull actionIdentifier;
		[Export ("actionIdentifier")]
		string ActionIdentifier { get; }

		// @property (readonly, nonatomic) BOOL isSilent;
		[Export ("isSilent")]
		bool IsSilent { get; }

		// @property (readonly, nonatomic) BOOL isInternal;
		[Export ("isInternal")]
		bool IsInternal { get; }

		// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(ios,introduced=13.0) UIScene * targetScene __attribute__((availability(ios, introduced=13.0)));
		[Export ("targetScene", ArgumentSemantic.Strong)]
		UIScene TargetScene { get; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull userInfo;
		[Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> UserInfo { get; }

		// -(NSData * _Nullable)json __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("json")]
		NSData Json { get; }

		// -(NSData * _Nullable)userInfoJSON __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("userInfoJSON")]
		NSData UserInfoJSON { get; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		//  (readonly, nonatomic, strong) NSNumber * _Nullable badge;
		[NullAllowed, Export ("badge", ArgumentSemantic.Strong)]
		NSNumber Badge { get; }
	}

	// @interface BRZConfigurationPushAutomation : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZConfigurationPushAutomation
	{
		// @property (readonly, nonatomic, class) UNNotificationPresentationOptions defaultForegroundPresentationOptions;
		[Static]
		[Export ("defaultForegroundPresentationOptions")]
		UNNotificationPresentationOptions DefaultForegroundPresentationOptions { get; }

		// @property (nonatomic) BOOL automaticSetup;
		[Export ("automaticSetup")]
		bool AutomaticSetup { get; set; }

		// @property (nonatomic) BOOL requestAuthorizationAtLaunch;
		[Export ("requestAuthorizationAtLaunch")]
		bool RequestAuthorizationAtLaunch { get; set; }

		// @property (nonatomic) UNAuthorizationOptions authorizationOptions;
		[Export ("authorizationOptions", ArgumentSemantic.Assign)]
		UNAuthorizationOptions AuthorizationOptions { get; set; }

		// @property (nonatomic) UNNotificationPresentationOptions foregroundPresentationOptions;
		[Export ("foregroundPresentationOptions", ArgumentSemantic.Assign)]
		UNNotificationPresentationOptions ForegroundPresentationOptions { get; set; }

		// @property (nonatomic) BOOL setNotificationCategories;
		[Export ("setNotificationCategories")]
		bool SetNotificationCategories { get; set; }

		// @property (nonatomic) BOOL registerDeviceToken;
		[Export ("registerDeviceToken")]
		bool RegisterDeviceToken { get; set; }

		// @property (nonatomic) BOOL handleBackgroundNotification;
		[Export ("handleBackgroundNotification")]
		bool HandleBackgroundNotification { get; set; }

		// @property (nonatomic) BOOL handleNotificationResponse;
		[Export ("handleNotificationResponse")]
		bool HandleNotificationResponse { get; set; }

		// @property (nonatomic) BOOL willPresentNotification;
		[Export ("willPresentNotification")]
		bool WillPresentNotification { get; set; }

		// -(instancetype _Nonnull)initWithAutomaticSetup:(BOOL)automaticSetup requestAuthorizationAtLaunch:(BOOL)requestAuthorizationAtLaunch authorizationOptions:(UNAuthorizationOptions)authorizationOptions foregroundPresentationOptions:(UNNotificationPresentationOptions)foregroundPresentationOptions setNotificationCategories:(BOOL)setNotificationCategories registerDeviceToken:(BOOL)registerDeviceToken handleBackgroundNotification:(BOOL)handleBackgroundNotification handleNotificationResponse:(BOOL)handleNotificationResponse willPresentNotification:(BOOL)willPresentNotification __attribute__((objc_designated_initializer));
		[Export ("initWithAutomaticSetup:requestAuthorizationAtLaunch:authorizationOptions:foregroundPresentationOptions:setNotificationCategories:registerDeviceToken:handleBackgroundNotification:handleNotificationResponse:willPresentNotification:")]
		[DesignatedInitializer]
		NativeHandle Constructor (bool automaticSetup, bool requestAuthorizationAtLaunch, UNAuthorizationOptions authorizationOptions, UNNotificationPresentationOptions foregroundPresentationOptions, bool setNotificationCategories, bool registerDeviceToken, bool handleBackgroundNotification, bool handleNotificationResponse, bool willPresentNotification);

		// -(instancetype _Nonnull)initEnablingAllAutomations:(BOOL)enabled;
		[Export ("initEnablingAllAutomations:")]
		NativeHandle Constructor (bool enabled);

	}

	// @interface BRZWebViewBridgeScriptMessageHandler : NSObject <WKScriptMessageHandler>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZWebViewBridgeScriptMessageHandler : IWKScriptMessageHandler
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull name;
		[Static]
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic, strong, class) WKUserScript * _Nonnull script;
		[Static]
		[Export ("script", ArgumentSemantic.Strong)]
		WKUserScript Script { get; }

		// -(instancetype _Nonnull)initWithLogClick:(void (^ _Nonnull)(NSString * _Nullable))logClick logError:(void (^ _Nonnull)(NSError * _Nonnull))logError showNewsFeed:(void (^ _Nonnull)(void))showNewsFeed closeMessage:(void (^ _Nonnull)(void))closeMessage braze:(Braze * _Nullable)braze;
		[Export ("initWithLogClick:logError:showNewsFeed:closeMessage:braze:")]
		NativeHandle Constructor (Action<NSString> logClick, Action<NSError> logError, Action showNewsFeed, Action closeMessage, [NullAllowed] Braze braze);
	}

	// @interface BRZSDKMetadata : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZSDKMetadata
	{
		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull adjust;
		[Static]
		[Export ("adjust", ArgumentSemantic.Strong)]
		BRZSDKMetadata Adjust { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull airbridge;
		[Static]
		[Export ("airbridge", ArgumentSemantic.Strong)]
		BRZSDKMetadata Airbridge { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull appsflyer;
		[Static]
		[Export ("appsflyer", ArgumentSemantic.Strong)]
		BRZSDKMetadata Appsflyer { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull bluedot;
		[Static]
		[Export ("bluedot", ArgumentSemantic.Strong)]
		BRZSDKMetadata Bluedot { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull branch;
		[Static]
		[Export ("branch", ArgumentSemantic.Strong)]
		BRZSDKMetadata Branch { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull cordova;
		[Static]
		[Export ("cordova", ArgumentSemantic.Strong)]
		BRZSDKMetadata Cordova { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull carthage;
		[Static]
		[Export ("carthage", ArgumentSemantic.Strong)]
		BRZSDKMetadata Carthage { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull cocoapods;
		[Static]
		[Export ("cocoapods", ArgumentSemantic.Strong)]
		BRZSDKMetadata Cocoapods { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull cordovapm;
		[Static]
		[Export ("cordovapm", ArgumentSemantic.Strong)]
		BRZSDKMetadata Cordovapm { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull expo;
		[Static]
		[Export ("expo", ArgumentSemantic.Strong)]
		BRZSDKMetadata Expo { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull foursquare;
		[Static]
		[Export ("foursquare", ArgumentSemantic.Strong)]
		BRZSDKMetadata Foursquare { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull flutter;
		[Static]
		[Export ("flutter", ArgumentSemantic.Strong)]
		BRZSDKMetadata Flutter { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull googletagmanager;
		[Static]
		[Export ("googletagmanager", ArgumentSemantic.Strong)]
		BRZSDKMetadata Googletagmanager { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull gimbal;
		[Static]
		[Export ("gimbal", ArgumentSemantic.Strong)]
		BRZSDKMetadata Gimbal { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull gradle;
		[Static]
		[Export ("gradle", ArgumentSemantic.Strong)]
		BRZSDKMetadata Gradle { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull ionic;
		[Static]
		[Export ("ionic", ArgumentSemantic.Strong)]
		BRZSDKMetadata Ionic { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull kochava;
		[Static]
		[Export ("kochava", ArgumentSemantic.Strong)]
		BRZSDKMetadata Kochava { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull manual;
		[Static]
		[Export ("manual", ArgumentSemantic.Strong)]
		BRZSDKMetadata Manual { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull maccatalyst;
		[Static]
		[Export ("maccatalyst", ArgumentSemantic.Strong)]
		BRZSDKMetadata Maccatalyst { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull mparticle;
		[Static]
		[Export ("mparticle", ArgumentSemantic.Strong)]
		BRZSDKMetadata Mparticle { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull nativescript;
		[Static]
		[Export ("nativescript", ArgumentSemantic.Strong)]
		BRZSDKMetadata Nativescript { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull npm;
		[Static]
		[Export ("npm", ArgumentSemantic.Strong)]
		BRZSDKMetadata Npm { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull nuget;
		[Static]
		[Export ("nuget", ArgumentSemantic.Strong)]
		BRZSDKMetadata Nuget { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull pub;
		[Static]
		[Export ("pub", ArgumentSemantic.Strong)]
		BRZSDKMetadata Pub { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull radar;
		[Static]
		[Export ("radar", ArgumentSemantic.Strong)]
		BRZSDKMetadata Radar { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull reactnative;
		[Static]
		[Export ("reactnative", ArgumentSemantic.Strong)]
		BRZSDKMetadata Reactnative { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull reactnativenewarch;
		[Static]
		[Export ("reactnativenewarch", ArgumentSemantic.Strong)]
		BRZSDKMetadata Reactnativenewarch { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull segment;
		[Static]
		[Export ("segment", ArgumentSemantic.Strong)]
		BRZSDKMetadata Segment { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull singular;
		[Static]
		[Export ("singular", ArgumentSemantic.Strong)]
		BRZSDKMetadata Singular { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull swiftpm;
		[Static]
		[Export ("swiftpm", ArgumentSemantic.Strong)]
		BRZSDKMetadata Swiftpm { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull tealium;
		[Static]
		[Export ("tealium", ArgumentSemantic.Strong)]
		BRZSDKMetadata Tealium { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull unreal;
		[Static]
		[Export ("unreal", ArgumentSemantic.Strong)]
		BRZSDKMetadata Unreal { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull unitypm;
		[Static]
		[Export ("unitypm", ArgumentSemantic.Strong)]
		BRZSDKMetadata Unitypm { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull unity;
		[Static]
		[Export ("unity", ArgumentSemantic.Strong)]
		BRZSDKMetadata Unity { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull vizbee;
		[Static]
		[Export ("vizbee", ArgumentSemantic.Strong)]
		BRZSDKMetadata Vizbee { get; }

		// @property (readonly, nonatomic, strong, class) BRZSDKMetadata * _Nonnull xamarin;
		[Static]
		[Export ("xamarin", ArgumentSemantic.Strong)]
		BRZSDKMetadata Xamarin { get; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

	}

	// @interface BRZTrackingProperty : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZTrackingProperty: INativeObject
	{
		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull deviceData;
		[Static]
		[Export ("deviceData", ArgumentSemantic.Strong)]
		BRZTrackingProperty DeviceData { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull firstName;
		[Static]
		[Export ("firstName", ArgumentSemantic.Strong)]
		BRZTrackingProperty FirstName { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull lastName;
		[Static]
		[Export ("lastName", ArgumentSemantic.Strong)]
		BRZTrackingProperty LastName { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull email;
		[Static]
		[Export ("email", ArgumentSemantic.Strong)]
		BRZTrackingProperty Email { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull dateOfBirth;
		[Static]
		[Export ("dateOfBirth", ArgumentSemantic.Strong)]
		BRZTrackingProperty DateOfBirth { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull country;
		[Static]
		[Export ("country", ArgumentSemantic.Strong)]
		BRZTrackingProperty Country { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull language;
		[Static]
		[Export ("language", ArgumentSemantic.Strong)]
		BRZTrackingProperty Language { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull homeCity;
		[Static]
		[Export ("homeCity", ArgumentSemantic.Strong)]
		BRZTrackingProperty HomeCity { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull gender;
		[Static]
		[Export ("gender", ArgumentSemantic.Strong)]
		BRZTrackingProperty Gender { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull phoneNumber;
		[Static]
		[Export ("phoneNumber", ArgumentSemantic.Strong)]
		BRZTrackingProperty PhoneNumber { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull emailSubscriptionState;
		[Static]
		[Export ("emailSubscriptionState", ArgumentSemantic.Strong)]
		BRZTrackingProperty EmailSubscriptionState { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull notificationSubscriptionState;
		[Static]
		[Export ("notificationSubscriptionState", ArgumentSemantic.Strong)]
		BRZTrackingProperty NotificationSubscriptionState { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull attributionData;
		[Static]
		[Export ("attributionData", ArgumentSemantic.Strong)]
		BRZTrackingProperty AttributionData { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull pushToken;
		[Static]
		[Export ("pushToken", ArgumentSemantic.Strong)]
		BRZTrackingProperty PushToken { get; }

		// +(BRZTrackingProperty * _Nonnull)customAttributeWithAttributes:(NSSet<NSString *> * _Nonnull)attributes __attribute__((warn_unused_result("")));
		[Static]
		[Export ("customAttributeWithAttributes:")]
		BRZTrackingProperty CustomAttributeWithAttributes (NSSet<NSString> attributes);

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull allCustomAttributes;
		[Static]
		[Export ("allCustomAttributes", ArgumentSemantic.Strong)]
		BRZTrackingProperty AllCustomAttributes { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull analyticsEvents;
		[Static]
		[Export ("analyticsEvents", ArgumentSemantic.Strong)]
		BRZTrackingProperty AnalyticsEvents { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull purchases;
		[Static]
		[Export ("purchases", ArgumentSemantic.Strong)]
		BRZTrackingProperty Purchases { get; }

		// +(BRZTrackingProperty * _Nonnull)customEventWithEvents:(NSSet<NSString *> * _Nonnull)events __attribute__((warn_unused_result("")));
		[Static]
		[Export ("customEventWithEvents:")]
		BRZTrackingProperty CustomEventWithEvents (NSSet<NSString> events);

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull allCustomEvents;
		[Static]
		[Export ("allCustomEvents", ArgumentSemantic.Strong)]
		BRZTrackingProperty AllCustomEvents { get; }

		// @property (readonly, nonatomic, strong, class) BRZTrackingProperty * _Nonnull everything;
		[Static]
		[Export ("everything", ArgumentSemantic.Strong)]
		BRZTrackingProperty Everything { get; }
		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

	}

	// @interface BRZUserAttributionData : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZUserAttributionData
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable network;
		[NullAllowed, Export ("network")]
		string Network { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable campaign;
		[NullAllowed, Export ("campaign")]
		string Campaign { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable adGroup;
		[NullAllowed, Export ("adGroup")]
		string AdGroup { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable creative;
		[NullAllowed, Export ("creative")]
		string Creative { get; }

		// -(instancetype _Nonnull)initWithNetwork:(NSString * _Nullable)network campaign:(NSString * _Nullable)campaign adGroup:(NSString * _Nullable)adGroup creative:(NSString * _Nullable)creative __attribute__((objc_designated_initializer));
		[Export ("initWithNetwork:campaign:adGroup:creative:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string network, [NullAllowed] string campaign, [NullAllowed] string adGroup, [NullAllowed] string creative);

	}

	// @interface BRZUserGender : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface BRZUserGender
	{
		// @property (readonly, nonatomic, strong, class) BRZUserGender * _Nonnull male;
		[Static]
		[Export ("male", ArgumentSemantic.Strong)]
		BRZUserGender Male { get; }

		// @property (readonly, nonatomic, strong, class) BRZUserGender * _Nonnull female;
		[Static]
		[Export ("female", ArgumentSemantic.Strong)]
		BRZUserGender Female { get; }

		// @property (readonly, nonatomic, strong, class) BRZUserGender * _Nonnull other;
		[Static]
		[Export ("other", ArgumentSemantic.Strong)]
		BRZUserGender Other { get; }

		// @property (readonly, nonatomic, strong, class) BRZUserGender * _Nonnull unknown;
		[Static]
		[Export ("unknown", ArgumentSemantic.Strong)]
		BRZUserGender Unknown { get; }

		// @property (readonly, nonatomic, strong, class) BRZUserGender * _Nonnull notApplicable;
		[Static]
		[Export ("notApplicable", ArgumentSemantic.Strong)]
		BRZUserGender NotApplicable { get; }

		// @property (readonly, nonatomic, strong, class) BRZUserGender * _Nonnull preferNotToSay;
		[Static]
		[Export ("preferNotToSay", ArgumentSemantic.Strong)]
		BRZUserGender PreferNotToSay { get; }

	}

	// @protocol BrazeDelegate
	[BaseType(typeof(NSObject))]
	[Model][Protocol]
	interface BrazeDelegate
	{
		// @optional -(BOOL)braze:(Braze * _Nonnull)braze shouldOpenURL:(BRZURLContext * _Nonnull)context __attribute__((warn_unused_result("")));
		[Export ("braze:shouldOpenURL:")]
		bool Braze (Braze braze, BRZURLContext context);

		// @optional -(void)braze:(Braze * _Nonnull)braze willPresentModalWithContext:(BRZModalContext * _Nonnull)context;
		[Export ("braze:willPresentModalWithContext:")]
		void Braze (Braze braze, BRZModalContext context);

		// @optional -(void)braze:(Braze * _Nonnull)braze noMatchingTriggerForEvent:(enum BRZTriggerEvent)event name:(NSString * _Nullable)name properties:(NSDictionary<NSString *,id> * _Nullable)properties;
		[Export ("braze:noMatchingTriggerForEvent:name:properties:")]
		void Braze (Braze braze, BRZTriggerEvent @event, [NullAllowed] string name, [NullAllowed] NSDictionary<NSString, NSObject> properties);

		// @optional -(void)braze:(Braze * _Nonnull)braze sdkAuthenticationFailedWithError:(BRZSDKAuthenticationError * _Nonnull)error;
		[Export ("braze:sdkAuthenticationFailedWithError:")]
		void Braze (Braze braze, BRZSDKAuthenticationError error);

	}

	// @protocol BrazeInAppMessagePresenter
	[BaseType(typeof(NSObject))]
	[Model][Protocol]
	interface BrazeInAppMessagePresenter
	{
		// @required -(void)presentMessage:(BRZInAppMessageRaw * _Nonnull)message;
		[Abstract]
		[Export ("presentMessage:")]
		void PresentMessage (BRZInAppMessageRaw message);

	}
}
