using System;
using BrazeKitCompat;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace BrazeKitCompat
{
	[Static]
	interface ABKSdkMetadata
	{
		// extern const ABKSdkMetadata ABKSdkMetadataAdjust __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.adjust'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.adjust'")]
		[Field ("ABKSdkMetadataAdjust", "__Internal")]
		NSString ABKSdkMetadataAdjust { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataAirBridge __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.airbridge'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.airbridge'")]
		[Field ("ABKSdkMetadataAirBridge", "__Internal")]
		NSString ABKSdkMetadataAirBridge { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataAppsFlyer __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.appsflyer'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.appsflyer'")]
		[Field ("ABKSdkMetadataAppsFlyer", "__Internal")]
		NSString ABKSdkMetadataAppsFlyer { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataBluedot __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.bluedot'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.bluedot'")]
		[Field ("ABKSdkMetadataBluedot", "__Internal")]
		NSString ABKSdkMetadataBluedot { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataBranch __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.branch'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.branch'")]
		[Field ("ABKSdkMetadataBranch", "__Internal")]
		NSString ABKSdkMetadataBranch { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataCordova __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.cordova'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.cordova'")]
		[Field ("ABKSdkMetadataCordova", "__Internal")]
		NSString ABKSdkMetadataCordova { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataCarthage __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.carthage'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.carthage'")]
		[Field ("ABKSdkMetadataCarthage", "__Internal")]
		NSString ABKSdkMetadataCarthage { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataCocoaPods __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.cocoapods'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.cocoapods'")]
		[Field ("ABKSdkMetadataCocoaPods", "__Internal")]
		NSString ABKSdkMetadataCocoaPods { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataCordovaPM __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.cordovapm'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.cordovapm'")]
		[Field ("ABKSdkMetadataCordovaPM", "__Internal")]
		NSString ABKSdkMetadataCordovaPM { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataExpo __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.expo'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.expo'")]
		[Field ("ABKSdkMetadataExpo", "__Internal")]
		NSString ABKSdkMetadataExpo { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataFoursquare __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.foursquare'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.foursquare'")]
		[Field ("ABKSdkMetadataFoursquare", "__Internal")]
		NSString ABKSdkMetadataFoursquare { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataFlutter __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.flutter'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.flutter'")]
		[Field ("ABKSdkMetadataFlutter", "__Internal")]
		NSString ABKSdkMetadataFlutter { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataGoogleTagManager __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.googletagmanager'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.googletagmanager'")]
		[Field ("ABKSdkMetadataGoogleTagManager", "__Internal")]
		NSString ABKSdkMetadataGoogleTagManager { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataGimbal __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.gimbal'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.gimbal'")]
		[Field ("ABKSdkMetadataGimbal", "__Internal")]
		NSString ABKSdkMetadataGimbal { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataGradle __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.gradle'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.gradle'")]
		[Field ("ABKSdkMetadataGradle", "__Internal")]
		NSString ABKSdkMetadataGradle { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataIonic __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.ionic'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.ionic'")]
		[Field ("ABKSdkMetadataIonic", "__Internal")]
		NSString ABKSdkMetadataIonic { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataKochava __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.kochava'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.kochava'")]
		[Field ("ABKSdkMetadataKochava", "__Internal")]
		NSString ABKSdkMetadataKochava { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataManual __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.manual'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.manual'")]
		[Field ("ABKSdkMetadataManual", "__Internal")]
		NSString ABKSdkMetadataManual { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataMParticle __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.mparticle'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.mparticle'")]
		[Field ("ABKSdkMetadataMParticle", "__Internal")]
		NSString ABKSdkMetadataMParticle { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataNativeScript __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.nativescript'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.nativescript'")]
		[Field ("ABKSdkMetadataNativeScript", "__Internal")]
		NSString ABKSdkMetadataNativeScript { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataNPM __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.npm'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.npm'")]
		[Field ("ABKSdkMetadataNPM", "__Internal")]
		NSString ABKSdkMetadataNPM { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataNuGet __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.nuget'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.nuget'")]
		[Field ("ABKSdkMetadataNuGet", "__Internal")]
		NSString ABKSdkMetadataNuGet { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataPub __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.pub'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.pub'")]
		[Field ("ABKSdkMetadataPub", "__Internal")]
		NSString ABKSdkMetadataPub { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataRadar __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.radar'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.radar'")]
		[Field ("ABKSdkMetadataRadar", "__Internal")]
		NSString ABKSdkMetadataRadar { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataReactNative __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.reactnative'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.reactnative'")]
		[Field ("ABKSdkMetadataReactNative", "__Internal")]
		NSString ABKSdkMetadataReactNative { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataReactNativeNewArch __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.reactnativenewarch'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.reactnativenewarch'")]
		[Field ("ABKSdkMetadataReactNativeNewArch", "__Internal")]
		NSString ABKSdkMetadataReactNativeNewArch { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataSegment __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.segment'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.segment'")]
		[Field ("ABKSdkMetadataSegment", "__Internal")]
		NSString ABKSdkMetadataSegment { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataSingular __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.singular'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.singular'")]
		[Field ("ABKSdkMetadataSingular", "__Internal")]
		NSString ABKSdkMetadataSingular { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataSwiftPM __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.swiftpm'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.swiftpm'")]
		[Field ("ABKSdkMetadataSwiftPM", "__Internal")]
		NSString ABKSdkMetadataSwiftPM { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataTealium __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.tealium'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.tealium'")]
		[Field ("ABKSdkMetadataTealium", "__Internal")]
		NSString ABKSdkMetadataTealium { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataUnreal __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.unreal'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.unreal'")]
		[Field ("ABKSdkMetadataUnreal", "__Internal")]
		NSString ABKSdkMetadataUnreal { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataUnityPM __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.unitypm'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.unitypm'")]
		[Field ("ABKSdkMetadataUnityPM", "__Internal")]
		NSString ABKSdkMetadataUnityPM { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataUnity __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.unity'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.unity'")]
		[Field ("ABKSdkMetadataUnity", "__Internal")]
		NSString ABKSdkMetadataUnity { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataVizbee __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.vizbee'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.vizbee'")]
		[Field ("ABKSdkMetadataVizbee", "__Internal")]
		NSString ABKSdkMetadataVizbee { get; }

		// extern const ABKSdkMetadata ABKSdkMetadataXamarin __attribute__((deprecated("renamed to 'Braze.Configuration.Api.SDKMetadata.xamarin'")));
		[Obsolete("renamed to 'Braze.Configuration.Api.SDKMetadata.xamarin'")]
		[Field ("ABKSdkMetadataXamarin", "__Internal")]
		NSString ABKSdkMetadataXamarin { get; }
	}

	[Static]
	partial interface Constants
	{

		// extern NSString *const _Nonnull ABKRequestProcessingPolicyOptionKey;
		[Field ("ABKRequestProcessingPolicyOptionKey", "__Internal")]
		NSString ABKRequestProcessingPolicyOptionKey { get; }

		// extern NSString *const _Nonnull ABKFlushIntervalOptionKey;
		[Field ("ABKFlushIntervalOptionKey", "__Internal")]
		NSString ABKFlushIntervalOptionKey { get; }

		// extern NSString *const _Nonnull ABKEnableAutomaticLocationCollectionKey;
		[Field ("ABKEnableAutomaticLocationCollectionKey", "__Internal")]
		NSString ABKEnableAutomaticLocationCollectionKey { get; }

		// extern NSString *const _Nonnull ABKEnableGeofencesKey;
		[Field ("ABKEnableGeofencesKey", "__Internal")]
		NSString ABKEnableGeofencesKey { get; }

		// extern NSString *const _Nonnull ABKDisableAutomaticGeofenceRequestsKey;
		[Field ("ABKDisableAutomaticGeofenceRequestsKey", "__Internal")]
		NSString ABKDisableAutomaticGeofenceRequestsKey { get; }

		// extern NSString *const _Nonnull ABKIDFADelegateKey;
		[Field ("ABKIDFADelegateKey", "__Internal")]
		NSString ABKIDFADelegateKey { get; }

		// extern NSString *const _Nonnull ABKEndpointKey;
		[Field ("ABKEndpointKey", "__Internal")]
		NSString ABKEndpointKey { get; }

		// extern NSString *const _Nonnull ABKURLDelegateKey;
		[Field ("ABKURLDelegateKey", "__Internal")]
		NSString ABKURLDelegateKey { get; }

		// extern NSString *const _Nonnull ABKImageDelegateKey;
		[Field ("ABKImageDelegateKey", "__Internal")]
		NSString ABKImageDelegateKey { get; }

		// extern NSString *const _Nonnull ABKInAppMessageControllerDelegateKey;
		[Field ("ABKInAppMessageControllerDelegateKey", "__Internal")]
		NSString ABKInAppMessageControllerDelegateKey { get; }

		// extern NSString *const _Nonnull ABKEnableDismissModalOnOutsideTapKey;
		[Field ("ABKEnableDismissModalOnOutsideTapKey", "__Internal")]
		NSString ABKEnableDismissModalOnOutsideTapKey { get; }

		// extern NSString *const _Nonnull ABKEnableSDKAuthenticationKey;
		[Field ("ABKEnableSDKAuthenticationKey", "__Internal")]
		NSString ABKEnableSDKAuthenticationKey { get; }

		// extern NSString *const _Nonnull ABKSdkAuthenticationDelegateKey;
		[Field ("ABKSdkAuthenticationDelegateKey", "__Internal")]
		NSString ABKSdkAuthenticationDelegateKey { get; }

		// extern NSString *const _Nonnull ABKSessionTimeoutKey;
		[Field ("ABKSessionTimeoutKey", "__Internal")]
		NSString ABKSessionTimeoutKey { get; }

		// extern NSString *const _Nonnull ABKMinimumTriggerTimeIntervalKey;
		[Field ("ABKMinimumTriggerTimeIntervalKey", "__Internal")]
		NSString ABKMinimumTriggerTimeIntervalKey { get; }

		// extern NSString *const _Nonnull ABKSDKFlavorKey;
		[Field ("ABKSDKFlavorKey", "__Internal")]
		NSString ABKSDKFlavorKey { get; }

		// extern NSString *const _Nonnull ABKDeviceAllowlistKey;
		[Field ("ABKDeviceAllowlistKey", "__Internal")]
		NSString ABKDeviceAllowlistKey { get; }

		// extern __deprecated_msg("ABKDeviceWhitelistKey is deprecated. Please use ABKDeviceAllowlistKey instead.") NSString *const ABKDeviceWhitelistKey __attribute__((deprecated("ABKDeviceWhitelistKey is deprecated. Please use ABKDeviceAllowlistKey instead.")));
		[Obsolete("ABKDeviceWhitelistKey is deprecated. Please use ABKDeviceAllowlistKey instead.")]
		[Field ("ABKDeviceWhitelistKey", "__Internal")]
		NSString ABKDeviceWhitelistKey { get; }

		// extern NSString *const _Nonnull ABKEphemeralEventsKey;
		[Field ("ABKEphemeralEventsKey", "__Internal")]
		NSString ABKEphemeralEventsKey { get; }

		// extern NSString *const _Nonnull ABKPushStoryAppGroupKey;
		[Field ("ABKPushStoryAppGroupKey", "__Internal")]
		NSString ABKPushStoryAppGroupKey { get; }

		// extern NSString *const _Nonnull ABKLogLevelKey;
		[Field ("ABKLogLevelKey", "__Internal")]
		NSString ABKLogLevelKey { get; }
	}

	// @interface Appboy : NSObject
	[BaseType (typeof(NSObject))]
	interface Appboy
	{
		// +(Appboy * _Nullable)sharedInstance;
		[Static]
		[NullAllowed, Export ("sharedInstance")]
		Appboy SharedInstance { get; }

		// +(Appboy * _Nonnull)unsafeInstance;
		[Static]
		[Export ("unsafeInstance")]
		Appboy UnsafeInstance { get; }

		// +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions;
		[Static]
		[Export ("startWithApiKey:inApplication:withLaunchOptions:")]
		void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions);

		// +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions withAppboyOptions:(NSDictionary * _Nullable)appboyOptions;
		[Static]
		[Export ("startWithApiKey:inApplication:withLaunchOptions:withAppboyOptions:")]
		void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions, [NullAllowed] NSDictionary appboyOptions);

		// @property (readonly) ABKUser * _Nonnull user;
		[Export ("user")]
		ABKUser User { get; }

		// @property (readonly) ABKFeedController * _Nonnull feedController;
		[Export ("feedController")]
		ABKFeedController FeedController { get; }

		// @property (readonly) ABKContentCardsController * _Nonnull contentCardsController;
		[Export ("contentCardsController")]
		ABKContentCardsController ContentCardsController { get; }

		// @property ABKRequestProcessingPolicy requestProcessingPolicy;
		[Export ("requestProcessingPolicy", ArgumentSemantic.Assign)]
		ABKRequestProcessingPolicy RequestProcessingPolicy { get; set; }

		[Wrap ("WeakIdfaDelegate")]
		[NullAllowed]
		ABKIDFADelegate IdfaDelegate { get; set; }

		// @property (nonatomic, strong) id<ABKIDFADelegate> _Nullable idfaDelegate;
		[NullAllowed, Export ("idfaDelegate", ArgumentSemantic.Strong)]
		NSObject WeakIdfaDelegate { get; set; }

		[Wrap ("WeakSdkAuthenticationDelegate")]
		[NullAllowed]
		ABKSdkAuthenticationDelegate SdkAuthenticationDelegate { get; set; }

		// @property (nonatomic, strong) id<ABKSdkAuthenticationDelegate> _Nullable sdkAuthenticationDelegate;
		[NullAllowed, Export ("sdkAuthenticationDelegate", ArgumentSemantic.Strong)]
		NSObject WeakSdkAuthenticationDelegate { get; set; }

		// @property (readonly) ABKInAppMessageController * _Nonnull inAppMessageController;
		[Export ("inAppMessageController")]
		ABKInAppMessageController InAppMessageController { get; }

		// @property (readonly, nonatomic) ABKLocationManager * _Nonnull locationManager;
		[Export ("locationManager")]
		ABKLocationManager LocationManager { get; }

		[Wrap ("WeakAppboyUrlDelegate")]
		[NullAllowed]
		ABKURLDelegate AppboyUrlDelegate { get; set; }

		// @property (nonatomic, weak) id<ABKURLDelegate> _Nullable appboyUrlDelegate;
		[NullAllowed, Export ("appboyUrlDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAppboyUrlDelegate { get; set; }

		[Wrap ("WeakImageDelegate")]
		[NullAllowed]
		ABKImageDelegate ImageDelegate { get; set; }

		// @property (nonatomic, strong) id<ABKImageDelegate> _Nullable imageDelegate;
		[NullAllowed, Export ("imageDelegate", ArgumentSemantic.Strong)]
		NSObject WeakImageDelegate { get; set; }

		// @property (nonatomic) ABKSDKFlavor sdkFlavor;
		[Export ("sdkFlavor", ArgumentSemantic.Assign)]
		ABKSDKFlavor SdkFlavor { get; set; }

		// -(void)requestImmediateDataFlush;
		[Export ("requestImmediateDataFlush")]
		void RequestImmediateDataFlush ();

		// -(void)flushDataAndProcessRequestQueue __attribute__((deprecated("Please use `requestImmediateDataFlush` instead.")));
		[Obsolete("Please use `requestImmediateDataFlush` instead.")]
		[Export ("flushDataAndProcessRequestQueue")]
		void FlushDataAndProcessRequestQueue ();

		// -(void)changeUser:(NSString * _Nonnull)userId;
		[Export ("changeUser:")]
		void ChangeUser (string userId);

		// -(void)changeUser:(NSString * _Nonnull)userId sdkAuthSignature:(NSString * _Nullable)signature;
		[Export ("changeUser:sdkAuthSignature:")]
		void ChangeUser (string userId, [NullAllowed] string signature);

		// -(void)setSdkAuthenticationSignature:(NSString * _Nonnull)signature;
		[Export ("setSdkAuthenticationSignature:")]
		void SetSdkAuthenticationSignature (string signature);

		// -(void)unsubscribeFromSdkAuthenticationErrors;
		[Export ("unsubscribeFromSdkAuthenticationErrors")]
		void UnsubscribeFromSdkAuthenticationErrors ();

		// -(void)logCustomEvent:(NSString * _Nonnull)eventName;
		[Export ("logCustomEvent:")]
		void LogCustomEvent (string eventName);

		// -(void)logCustomEvent:(NSString * _Nonnull)eventName withProperties:(NSDictionary * _Nullable)properties;
		[Export ("logCustomEvent:withProperties:")]
		void LogCustomEvent (string eventName, [NullAllowed] NSDictionary properties);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price;
		[Export ("logPurchase:inCurrency:atPrice:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withProperties:(NSDictionary * _Nullable)properties;
		[Export ("logPurchase:inCurrency:atPrice:withProperties:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, [NullAllowed] NSDictionary properties);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withQuantity:(NSUInteger)quantity;
		[Export ("logPurchase:inCurrency:atPrice:withQuantity:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity);

		// -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withQuantity:(NSUInteger)quantity andProperties:(NSDictionary * _Nullable)properties;
		[Export ("logPurchase:inCurrency:atPrice:withQuantity:andProperties:")]
		void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity, [NullAllowed] NSDictionary properties);

		// -(void)logFeedDisplayed;
		[Export ("logFeedDisplayed")]
		void LogFeedDisplayed ();

		// -(void)logContentCardsDisplayed;
		[Export ("logContentCardsDisplayed")]
		void LogContentCardsDisplayed ();

		// -(void)requestFeedRefresh;
		[Export ("requestFeedRefresh")]
		void RequestFeedRefresh ();

		// -(void)requestContentCardsRefresh;
		[Export ("requestContentCardsRefresh")]
		void RequestContentCardsRefresh ();

		// -(void)requestGeofencesWithLongitude:(double)longitude latitude:(double)latitude;
		[Export ("requestGeofencesWithLongitude:latitude:")]
		void RequestGeofencesWithLongitude (double longitude, double latitude);

		// -(NSString * _Nonnull)getDeviceId;
		[Export ("getDeviceId")]
		string DeviceId { get; }

		// -(void)registerDeviceToken:(NSData * _Nonnull)deviceToken;
		[Export ("registerDeviceToken:")]
		void RegisterDeviceToken (NSData deviceToken);

		// -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
		[Export ("registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:")]
		void RegisterApplicationWithFetchCompletionHandler (UIApplication application, NSDictionary notification, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

		// -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nullable)(void))completionHandler __attribute__((availability(ios, introduced=10.0)));
		[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenter (UNUserNotificationCenter center, UNNotificationResponse response, [NullAllowed] Action completionHandler);

		// -(void)pushAuthorizationFromUserNotificationCenter:(BOOL)pushAuthGranted;
		[Export ("pushAuthorizationFromUserNotificationCenter:")]
		void PushAuthorizationFromUserNotificationCenter (bool pushAuthGranted);

		// -(void)addSdkMetadata:(NSArray<ABKSdkMetadata> * _Nonnull)metadata;
		[Export ("addSdkMetadata:")]
		void AddSdkMetadata (NSString[] metadata);

		// +(void)wipeDataAndDisableForAppRun;
		[Static]
		[Export ("wipeDataAndDisableForAppRun")]
		void WipeDataAndDisableForAppRun ();

		// +(void)disableSDK;
		[Static]
		[Export ("disableSDK")]
		void DisableSDK ();

		// +(void)requestEnableSDKOnNextAppRun;
		[Static]
		[Export ("requestEnableSDKOnNextAppRun")]
		void RequestEnableSDKOnNextAppRun ();

	}

	// @interface ABKUser : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKUser
	{
		// @property (copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName")]
		string FirstName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName")]
		string LastName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSDate * _Nullable dateOfBirth;
		[NullAllowed, Export ("dateOfBirth", ArgumentSemantic.Copy)]
		NSDate DateOfBirth { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable homeCity;
		[NullAllowed, Export ("homeCity")]
		string HomeCity { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable language;
		[NullAllowed, Export ("language")]
		string Language { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable userID;
		[NullAllowed, Export ("userID")]
		string UserID { get; }

		// @property (copy, nonatomic) NSString * _Nullable avatarImageURL;
		[NullAllowed, Export ("avatarImageURL")]
		string AvatarImageURL { get; set; }

		// @property (strong) ABKFacebookUser * _Nullable facebookUser;
		[NullAllowed, Export ("facebookUser", ArgumentSemantic.Strong)]
		ABKFacebookUser FacebookUser { get; set; }

		// @property (strong) ABKTwitterUser * _Nullable twitterUser;
		[NullAllowed, Export ("twitterUser", ArgumentSemantic.Strong)]
		ABKTwitterUser TwitterUser { get; set; }

		// @property (strong) ABKAttributionData * _Nullable attributionData;
		[NullAllowed, Export ("attributionData", ArgumentSemantic.Strong)]
		ABKAttributionData AttributionData { get; set; }

		// -(BOOL)addAlias:(NSString * _Nonnull)alias withLabel:(NSString * _Nonnull)label;
		[Export ("addAlias:withLabel:")]
		bool AddAlias (string alias, string label);

		// -(BOOL)setGender:(ABKUserGenderType)gender;
		[Export ("setGender:")]
		bool SetGender (ABKUserGenderType gender);

		// -(BOOL)setEmailNotificationSubscriptionType:(ABKNotificationSubscriptionType)emailNotificationSubscriptionType;
		[Export ("setEmailNotificationSubscriptionType:")]
		bool SetEmailNotificationSubscriptionType (ABKNotificationSubscriptionType emailNotificationSubscriptionType);

		// -(BOOL)setPushNotificationSubscriptionType:(ABKNotificationSubscriptionType)pushNotificationSubscriptionType;
		[Export ("setPushNotificationSubscriptionType:")]
		bool SetPushNotificationSubscriptionType (ABKNotificationSubscriptionType pushNotificationSubscriptionType);

		// -(BOOL)addToSubscriptionGroupWithGroupId:(NSString * _Nonnull)groupId;
		[Export ("addToSubscriptionGroupWithGroupId:")]
		bool AddToSubscriptionGroupWithGroupId (string groupId);

		// -(BOOL)removeFromSubscriptionGroupWithGroupId:(NSString * _Nonnull)groupId;
		[Export ("removeFromSubscriptionGroupWithGroupId:")]
		bool RemoveFromSubscriptionGroupWithGroupId (string groupId);

		// -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andBOOLValue:(BOOL)value;
		[Export ("setCustomAttributeWithKey:andBOOLValue:")]
		bool SetCustomAttributeWithKey (string key, bool value);

		// -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andIntegerValue:(NSInteger)value;
		[Export ("setCustomAttributeWithKey:andIntegerValue:")]
		bool SetCustomAttributeWithKey (string key, nint value);

		// -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andDoubleValue:(double)value;
		[Export ("setCustomAttributeWithKey:andDoubleValue:")]
		bool SetCustomAttributeWithKey (string key, double value);

		// -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andStringValue:(NSString * _Nonnull)value;
		[Export ("setCustomAttributeWithKey:andStringValue:")]
		bool SetCustomAttributeWithKey (string key, string value);

		// -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andDateValue:(NSDate * _Nonnull)value;
		[Export ("setCustomAttributeWithKey:andDateValue:")]
		bool SetCustomAttributeWithKey (string key, NSDate value);

		// -(BOOL)unsetCustomAttributeWithKey:(NSString * _Nonnull)key;
		[Export ("unsetCustomAttributeWithKey:")]
		bool UnsetCustomAttributeWithKey (string key);

		// -(BOOL)incrementCustomUserAttribute:(NSString * _Nonnull)key;
		[Export ("incrementCustomUserAttribute:")]
		bool IncrementCustomUserAttribute (string key);

		// -(BOOL)incrementCustomUserAttribute:(NSString * _Nonnull)key by:(NSInteger)incrementValue;
		[Export ("incrementCustomUserAttribute:by:")]
		bool IncrementCustomUserAttribute (string key, nint incrementValue);

		// -(BOOL)addToCustomAttributeArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export ("addToCustomAttributeArrayWithKey:value:")]
		bool AddToCustomAttributeArrayWithKey (string key, string value);

		// -(BOOL)removeFromCustomAttributeArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
		[Export ("removeFromCustomAttributeArrayWithKey:value:")]
		bool RemoveFromCustomAttributeArrayWithKey (string key, string value);

		// -(BOOL)setCustomAttributeArrayWithKey:(NSString * _Nonnull)key array:(NSArray * _Nullable)valueArray;
		[Export ("setCustomAttributeArrayWithKey:array:")]
		bool SetCustomAttributeArrayWithKey (string key, [NullAllowed] NSObject[] valueArray);

		// -(BOOL)setLastKnownLocationWithLatitude:(double)latitude longitude:(double)longitude horizontalAccuracy:(double)horizontalAccuracy;
		[Export ("setLastKnownLocationWithLatitude:longitude:horizontalAccuracy:")]
		bool SetLastKnownLocationWithLatitude (double latitude, double longitude, double horizontalAccuracy);

		// -(BOOL)setLastKnownLocationWithLatitude:(double)latitude longitude:(double)longitude horizontalAccuracy:(double)horizontalAccuracy altitude:(double)altitude verticalAccuracy:(double)verticalAccuracy;
		[Export ("setLastKnownLocationWithLatitude:longitude:horizontalAccuracy:altitude:verticalAccuracy:")]
		bool SetLastKnownLocationWithLatitude (double latitude, double longitude, double horizontalAccuracy, double altitude, double verticalAccuracy);

		// -(BOOL)addLocationCustomAttributeWithKey:(NSString * _Nonnull)key latitude:(double)latitude longitude:(double)longitude;
		[Export ("addLocationCustomAttributeWithKey:latitude:longitude:")]
		bool AddLocationCustomAttributeWithKey (string key, double latitude, double longitude);

		// -(BOOL)removeLocationCustomAttributeWithKey:(NSString * _Nonnull)key;
		[Export ("removeLocationCustomAttributeWithKey:")]
		bool RemoveLocationCustomAttributeWithKey (string key);

	}

	partial interface Constants
	{
		// extern const NSInteger DefaultNumberOfFriends;
		[Field ("DefaultNumberOfFriends", "__Internal")]
		nint DefaultNumberOfFriends { get; }
	}

	// @interface ABKFacebookUser : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKFacebookUser
	{
		// -(instancetype _Nonnull)initWithFacebookUserDictionary:(NSDictionary * _Nullable)facebookUserDictionary numberOfFriends:(NSInteger)numberOfFriends likes:(NSArray * _Nullable)likes;
		[Export ("initWithFacebookUserDictionary:numberOfFriends:likes:")]
		NativeHandle Constructor ([NullAllowed] NSDictionary facebookUserDictionary, nint numberOfFriends, [NullAllowed] NSObject[] likes);

		// @property (readonly) NSDictionary * _Nullable facebookUserDictionary;
		[NullAllowed, Export ("facebookUserDictionary")]
		NSDictionary FacebookUserDictionary { get; }

		// @property (readonly) NSInteger numberOfFriends;
		[Export ("numberOfFriends")]
		nint NumberOfFriends { get; }

		// @property (readonly) NSArray * _Nullable likes;
		[NullAllowed, Export ("likes")]
		NSObject[] Likes { get; }

	}

	// @interface ABKTwitterUser : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKTwitterUser
	{
		// @property (copy) NSString * _Nullable userDescription;
		[NullAllowed, Export ("userDescription")]
		string UserDescription { get; set; }

		// @property (copy) NSString * _Nullable twitterName;
		[NullAllowed, Export ("twitterName")]
		string TwitterName { get; set; }

		// @property (copy) NSString * _Nullable profileImageUrl;
		[NullAllowed, Export ("profileImageUrl")]
		string ProfileImageUrl { get; set; }

		// @property (copy) NSString * _Nullable screenName;
		[NullAllowed, Export ("screenName")]
		string ScreenName { get; set; }

		// @property NSInteger followersCount;
		[Export ("followersCount")]
		nint FollowersCount { get; set; }

		// @property NSInteger friendsCount;
		[Export ("friendsCount")]
		nint FriendsCount { get; set; }

		// @property NSInteger statusesCount;
		[Export ("statusesCount")]
		nint StatusesCount { get; set; }

		// @property NSInteger twitterID;
		[Export ("twitterID")]
		nint TwitterID { get; set; }

	}

	// @interface ABKAttributionData : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKAttributionData
	{
		// -(instancetype _Nonnull)initWithNetwork:(NSString * _Nullable)network campaign:(NSString * _Nullable)campaign adGroup:(NSString * _Nullable)adGroup creative:(NSString * _Nullable)creative;
		[Export ("initWithNetwork:campaign:adGroup:creative:")]
		NativeHandle Constructor ([NullAllowed] string network, [NullAllowed] string campaign, [NullAllowed] string adGroup, [NullAllowed] string creative);

		// @property (readonly, nonatomic) NSString * _Nullable network;
		[NullAllowed, Export ("network")]
		string Network { get; }

		// @property (readonly, nonatomic) NSString * _Nullable campaign;
		[NullAllowed, Export ("campaign")]
		string Campaign { get; }

		// @property (readonly, nonatomic) NSString * _Nullable adGroup;
		[NullAllowed, Export ("adGroup")]
		string AdGroup { get; }

		// @property (readonly, nonatomic) NSString * _Nullable creative;
		[NullAllowed, Export ("creative")]
		string Creative { get; }

	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull ABKFeedUpdatedNotification;
		[Field ("ABKFeedUpdatedNotification", "__Internal")]
		NSString ABKFeedUpdatedNotification { get; }

		// extern NSString *const _Nonnull ABKFeedUpdatedIsSuccessfulKey;
		[Field ("ABKFeedUpdatedIsSuccessfulKey", "__Internal")]
		NSString ABKFeedUpdatedIsSuccessfulKey { get; }
	}

	// @interface ABKFeedController : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKFeedController
	{
		// @property (readonly, getter = getNewsFeedCards) NSArray * _Nonnull newsFeedCards;
		[Export ("newsFeedCards")]
		NSObject[] NewsFeedCards { [Bind ("getNewsFeedCards")] get; }

		// @property (readonly) NSDate * _Nullable lastUpdate;
		[NullAllowed, Export ("lastUpdate")]
		NSDate LastUpdate { get; }

		// -(NSInteger)unreadCardCountForCategories:(ABKCardCategory)categories;
		[Export ("unreadCardCountForCategories:")]
		nint UnreadCardCountForCategories (ABKCardCategory categories);

		// -(NSInteger)cardCountForCategories:(ABKCardCategory)categories;
		[Export ("cardCountForCategories:")]
		nint CardCountForCategories (ABKCardCategory categories);

		// -(NSArray * _Nonnull)getCardsInCategories:(ABKCardCategory)categories;
		[Export ("getCardsInCategories:")]
		NSObject[] GetCardsInCategories (ABKCardCategory categories);

	}

	// @interface ABKCard : NSObject <NSCopying, NSCoding>
	[BaseType (typeof(NSObject))]
	interface ABKCard : INSCopying, INSCoding
	{
		// @property (readonly) NSString * _Nonnull idString;
		[Export ("idString")]
		string IdString { get; }

		// @property (nonatomic) BOOL viewed;
		[Export ("viewed")]
		bool Viewed { get; set; }

		// @property (readonly, nonatomic) double created;
		[Export ("created")]
		double Created { get; }

		// @property (readonly, nonatomic) double updated;
		[Export ("updated")]
		double Updated { get; }

		// @property ABKCardCategory categories;
		[Export ("categories", ArgumentSemantic.Assign)]
		ABKCardCategory Categories { get; set; }

		// @property (readonly) double expiresAt;
		[Export ("expiresAt")]
		double ExpiresAt { get; }

		// @property (strong) NSDictionary * _Nullable extras;
		[NullAllowed, Export ("extras", ArgumentSemantic.Strong)]
		NSDictionary Extras { get; set; }

		// @property (copy) NSString * _Nullable urlString;
		[NullAllowed, Export ("urlString")]
		string UrlString { get; set; }

		// @property BOOL openUrlInWebView;
		[Export ("openUrlInWebView")]
		bool OpenUrlInWebView { get; set; }

		// +(ABKCard * _Nullable)deserializeCardFromDictionary:(NSDictionary * _Nullable)cardDictionary;
		[Static]
		[Export ("deserializeCardFromDictionary:")]
		[return: NullAllowed]
		ABKCard DeserializeCardFromDictionary ([NullAllowed] NSDictionary cardDictionary);

		// -(NSData * _Nullable)serializeToData;
		[NullAllowed, Export ("serializeToData")]
		NSData SerializeToData { get; }

		// -(void)logCardImpression;
		[Export ("logCardImpression")]
		void LogCardImpression ();

		// -(void)logCardClicked;
		[Export ("logCardClicked")]
		void LogCardClicked ();

		// -(BOOL)hasSameId:(ABKCard * _Nonnull)card;
		[Export ("hasSameId:")]
		bool HasSameId (ABKCard card);

	}

	// @interface ABKBannerCard : ABKCard <NSCoding>
	[BaseType (typeof(ABKCard))]
	interface ABKBannerCard : INSCoding
	{
		// @property (copy) NSString * _Nonnull image;
		[Export ("image")]
		string Image { get; set; }

		// @property (copy) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

		// @property float imageAspectRatio;
		[Export ("imageAspectRatio")]
		float ImageAspectRatio { get; set; }

	}

	// @interface ABKCaptionedImageCard : ABKCard <NSCoding>
	[BaseType (typeof(ABKCard))]
	interface ABKCaptionedImageCard : INSCoding
	{
		// @property (copy) NSString * _Nonnull image;
		[Export ("image")]
		string Image { get; set; }

		// @property float imageAspectRatio;
		[Export ("imageAspectRatio")]
		float ImageAspectRatio { get; set; }

		// @property (copy) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy) NSString * _Nonnull cardDescription;
		[Export ("cardDescription")]
		string CardDescription { get; set; }

		// @property (copy) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

	}

	// @interface ABKClassicCard : ABKCard <NSCoding>
	[BaseType (typeof(ABKCard))]
	interface ABKClassicCard : INSCoding
	{
		// @property (copy) NSString * _Nullable image;
		[NullAllowed, Export ("image")]
		string Image { get; set; }

		// @property (copy) NSString * _Nonnull cardDescription;
		[Export ("cardDescription")]
		string CardDescription { get; set; }

		// @property (copy) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

	}

	// @interface ABKTextAnnouncementCard : ABKCard <NSCoding>
	[BaseType (typeof(ABKCard))]
	interface ABKTextAnnouncementCard : INSCoding
	{
		// @property (copy) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy) NSString * _Nonnull cardDescription;
		[Export ("cardDescription")]
		string CardDescription { get; set; }

		// @property (copy) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

	}

	// @interface ABKContentCard : NSObject <NSCopying, NSCoding>
	[BaseType (typeof(NSObject))]
	interface ABKContentCard : INSCopying, INSCoding
	{
		// @property (readonly) NSString * _Nonnull idString;
		[Export ("idString")]
		string IdString { get; }

		// @property (nonatomic) BOOL viewed;
		[Export ("viewed")]
		bool Viewed { get; set; }

		// @property (readonly, nonatomic) double created;
		[Export ("created")]
		double Created { get; }

		// @property (readonly) double expiresAt;
		[Export ("expiresAt")]
		double ExpiresAt { get; }

		// @property (nonatomic) BOOL dismissible;
		[Export ("dismissible")]
		bool Dismissible { get; set; }

		// @property (nonatomic) BOOL pinned;
		[Export ("pinned")]
		bool Pinned { get; set; }

		// @property (nonatomic) BOOL dismissed;
		[Export ("dismissed")]
		bool Dismissed { get; set; }

		// @property (nonatomic) BOOL clicked;
		[Export ("clicked")]
		bool Clicked { get; set; }

		// @property (strong) NSDictionary * _Nullable extras;
		[NullAllowed, Export ("extras", ArgumentSemantic.Strong)]
		NSDictionary Extras { get; set; }

		// @property (readonly, nonatomic) BOOL isTest;
		[Export ("isTest")]
		bool IsTest { get; }

		// @property (copy) NSString * _Nullable urlString;
		[NullAllowed, Export ("urlString")]
		string UrlString { get; set; }

		// @property BOOL openUrlInWebView;
		[Export ("openUrlInWebView")]
		bool OpenUrlInWebView { get; set; }

		// +(ABKContentCard * _Nullable)deserializeCardFromDictionary:(NSDictionary * _Nullable)cardDictionary;
		[Static]
		[Export ("deserializeCardFromDictionary:")]
		[return: NullAllowed]
		ABKContentCard DeserializeCardFromDictionary ([NullAllowed] NSDictionary cardDictionary);

		// -(NSData * _Nullable)serializeToData;
		[NullAllowed, Export ("serializeToData")]
		NSData SerializeToData { get; }

		// -(void)logContentCardImpression;
		[Export ("logContentCardImpression")]
		void LogContentCardImpression ();

		// -(void)logContentCardClicked;
		[Export ("logContentCardClicked")]
		void LogContentCardClicked ();

		// -(void)logContentCardDismissed;
		[Export ("logContentCardDismissed")]
		void LogContentCardDismissed ();

		// -(BOOL)isControlCard;
		[Export ("isControlCard")]
		bool IsControlCard { get; }

		// -(BOOL)hasSameId:(ABKContentCard * _Nonnull)card;
		[Export ("hasSameId:")]
		bool HasSameId (ABKContentCard card);

	}

	// @interface ABKBannerContentCard : ABKContentCard <NSCoding>
	[BaseType (typeof(ABKContentCard))]
	interface ABKBannerContentCard : INSCoding
	{
		// @property (copy) NSString * image;
		[Export ("image")]
		string Image { get; set; }

		// @property float imageAspectRatio;
		[Export ("imageAspectRatio")]
		float ImageAspectRatio { get; set; }

	}

	// @interface ABKCaptionedImageContentCard : ABKContentCard <NSCoding>
	[BaseType (typeof(ABKContentCard))]
	interface ABKCaptionedImageContentCard : INSCoding
	{
		// @property (copy) NSString * _Nonnull image;
		[Export ("image")]
		string Image { get; set; }

		// @property float imageAspectRatio;
		[Export ("imageAspectRatio")]
		float ImageAspectRatio { get; set; }

		// @property (copy) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy) NSString * _Nonnull cardDescription;
		[Export ("cardDescription")]
		string CardDescription { get; set; }

		// @property (copy) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

	}

	// @interface ABKClassicContentCard : ABKContentCard <NSCoding>
	[BaseType (typeof(ABKContentCard))]
	interface ABKClassicContentCard : INSCoding
	{
		// @property (copy) NSString * _Nullable image;
		[NullAllowed, Export ("image")]
		string Image { get; set; }

		// @property (copy) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (copy) NSString * _Nonnull cardDescription;
		[Export ("cardDescription")]
		string CardDescription { get; set; }

		// @property (copy) NSString * _Nullable domain;
		[NullAllowed, Export ("domain")]
		string Domain { get; set; }

	}

	// @interface ABKSdkAuthenticationError : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKSdkAuthenticationError
	{
		// @property (readonly) NSInteger code;
		[Export ("code")]
		nint Code { get; }

		// @property (readonly) NSString * _Nullable reason;
		[NullAllowed, Export ("reason")]
		string Reason { get; }

		// @property (readonly) NSString * _Nullable userId;
		[NullAllowed, Export ("userId")]
		string UserId { get; }

		// @property (readonly) NSString * _Nonnull signature;
		[Export ("signature")]
		string Signature { get; }

	}

	// @protocol ABKSdkAuthenticationDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ABKSdkAuthenticationDelegate
	{
		// @required -(void)handleSdkAuthenticationError:(ABKSdkAuthenticationError * _Nonnull)authError;
		[Abstract]
		[Export ("handleSdkAuthenticationError:")]
		void HandleSdkAuthenticationError (ABKSdkAuthenticationError authError);

	}

	// @interface ABKInAppMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessage
	{
		// @property (copy) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; set; }

		// @property (strong) NSDictionary * _Nullable extras;
		[NullAllowed, Export ("extras", ArgumentSemantic.Strong)]
		NSDictionary Extras { get; set; }

		// @property (nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (readonly) ABKInAppMessageClickActionType inAppMessageClickActionType;
		[Export ("inAppMessageClickActionType")]
		ABKInAppMessageClickActionType InAppMessageClickActionType { get; }

		// @property (readonly, copy) NSURL * _Nullable uri;
		[NullAllowed, Export ("uri", ArgumentSemantic.Copy)]
		NSUrl Uri { get; }

		// @property BOOL openUrlInWebView;
		[Export ("openUrlInWebView")]
		bool OpenUrlInWebView { get; set; }

		// @property ABKInAppMessageDismissType inAppMessageDismissType;
		[Export ("inAppMessageDismissType", ArgumentSemantic.Assign)]
		ABKInAppMessageDismissType InAppMessageDismissType { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable icon;
		[NullAllowed, Export ("icon")]
		string Icon { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable iconColor;
		[NullAllowed, Export ("iconColor", ArgumentSemantic.Strong)]
		UIColor IconColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable iconBackgroundColor;
		[NullAllowed, Export ("iconBackgroundColor", ArgumentSemantic.Strong)]
		UIColor IconBackgroundColor { get; set; }

		// @property (assign, nonatomic) BOOL enableDarkTheme;
		[Export ("enableDarkTheme")]
		bool EnableDarkTheme { get; set; }

		// @property (nonatomic, strong) ABKInAppMessageDarkTheme * _Nullable darkTheme;
		[NullAllowed, Export ("darkTheme", ArgumentSemantic.Strong)]
		ABKInAppMessageDarkTheme DarkTheme { get; set; }

		// @property (nonatomic) NSInteger overrideUserInterfaceStyle;
		[Export ("overrideUserInterfaceStyle")]
		nint OverrideUserInterfaceStyle { get; set; }

		// @property (copy) NSURL * _Nullable imageURI;
		[NullAllowed, Export ("imageURI", ArgumentSemantic.Copy)]
		NSUrl ImageURI { get; set; }

		// @property UIViewContentMode imageContentMode;
		[Export ("imageContentMode", ArgumentSemantic.Assign)]
		UIViewContentMode ImageContentMode { get; set; }

		// @property ABKInAppMessageOrientation orientation;
		[Export ("orientation", ArgumentSemantic.Assign)]
		ABKInAppMessageOrientation Orientation { get; set; }

		// @property UITextAlignment messageTextAlignment;
		[Export ("messageTextAlignment", ArgumentSemantic.Assign)]
		UITextAlignment MessageTextAlignment { get; set; }

		// @property BOOL animateIn;
		[Export ("animateIn")]
		bool AnimateIn { get; set; }

		// @property BOOL animateOut;
		[Export ("animateOut")]
		bool AnimateOut { get; set; }

		// @property BOOL isControl;
		[Export ("isControl")]
		bool IsControl { get; set; }

		// -(void)logInAppMessageImpression;
		[Export ("logInAppMessageImpression")]
		void LogInAppMessageImpression ();

		// -(void)logInAppMessageClicked;
		[Export ("logInAppMessageClicked")]
		void LogInAppMessageClicked ();

		// -(void)setInAppMessageClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSURL * _Nullable)uri;
		[Export ("setInAppMessageClickAction:withURI:")]
		void SetInAppMessageClickAction (ABKInAppMessageClickActionType clickActionType, [NullAllowed] NSUrl uri);

		// -(NSData * _Nullable)serializeToData;
		[NullAllowed, Export ("serializeToData")]
		NSData SerializeToData { get; }

	}

	// @interface ABKInAppMessageSlideup : ABKInAppMessage
	[BaseType (typeof(ABKInAppMessage))]
	interface ABKInAppMessageSlideup
	{
		// @property BOOL hideChevron;
		[Export ("hideChevron")]
		bool HideChevron { get; set; }

		// @property ABKInAppMessageSlideupAnchor inAppMessageSlideupAnchor;
		[Export ("inAppMessageSlideupAnchor", ArgumentSemantic.Assign)]
		ABKInAppMessageSlideupAnchor InAppMessageSlideupAnchor { get; set; }

		// @property (strong) UIColor * _Nullable chevronColor;
		[NullAllowed, Export ("chevronColor", ArgumentSemantic.Strong)]
		UIColor ChevronColor { get; set; }

	}

	// @interface ABKInAppMessageImmersive : ABKInAppMessage
	[BaseType (typeof(ABKInAppMessage))]
	interface ABKInAppMessageImmersive
	{
		// @property (copy) NSString * _Nullable header;
		[NullAllowed, Export ("header")]
		string Header { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable headerTextColor;
		[NullAllowed, Export ("headerTextColor", ArgumentSemantic.Strong)]
		UIColor HeaderTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable closeButtonColor;
		[NullAllowed, Export ("closeButtonColor", ArgumentSemantic.Strong)]
		UIColor CloseButtonColor { get; set; }

		// @property (readonly, copy) NSArray<ABKInAppMessageButton *> * _Nullable buttons;
		[NullAllowed, Export ("buttons", ArgumentSemantic.Copy)]
		ABKInAppMessageButton[] Buttons { get; }

		// @property (nonatomic, strong) UIColor * _Nullable frameColor;
		[NullAllowed, Export ("frameColor", ArgumentSemantic.Strong)]
		UIColor FrameColor { get; set; }

		// @property UITextAlignment headerTextAlignment;
		[Export ("headerTextAlignment", ArgumentSemantic.Assign)]
		UITextAlignment HeaderTextAlignment { get; set; }

		// @property ABKInAppMessageImmersiveImageStyle imageStyle;
		[Export ("imageStyle", ArgumentSemantic.Assign)]
		ABKInAppMessageImmersiveImageStyle ImageStyle { get; set; }

		// -(void)logInAppMessageClickedWithButtonID:(NSInteger)buttonId;
		[Export ("logInAppMessageClickedWithButtonID:")]
		void LogInAppMessageClickedWithButtonID (nint buttonId);

		// -(void)setInAppMessageButtons:(NSArray * _Nonnull)buttonArray;
		[Export ("setInAppMessageButtons:")]
		void SetInAppMessageButtons (NSObject[] buttonArray);

	}

	// @interface ABKInAppMessageModal : ABKInAppMessageImmersive
	[BaseType (typeof(ABKInAppMessageImmersive))]
	interface ABKInAppMessageModal
	{

	}

	// @interface ABKInAppMessageFull : ABKInAppMessageImmersive
	[BaseType (typeof(ABKInAppMessageImmersive))]
	interface ABKInAppMessageFull
	{

	}

	// @interface ABKInAppMessageHTMLBase : ABKInAppMessage
	[BaseType (typeof(ABKInAppMessage))]
	interface ABKInAppMessageHTMLBase
	{
		// @property (nonatomic, strong) NSURL * _Nonnull assetsLocalDirectoryPath;
		[Export ("assetsLocalDirectoryPath", ArgumentSemantic.Strong)]
		NSUrl AssetsLocalDirectoryPath { get; set; }

		// -(void)logInAppMessageHTMLClickWithButtonID:(NSString * _Nonnull)buttonId;
		[Export ("logInAppMessageHTMLClickWithButtonID:")]
		void LogInAppMessageHTMLClickWithButtonID (string buttonId);

	}

	// @interface ABKInAppMessageHTML : ABKInAppMessageHTMLBase
	[BaseType (typeof(ABKInAppMessageHTMLBase))]
	interface ABKInAppMessageHTML
	{
		// @property (nonatomic) BOOL trusted;
		[Export ("trusted")]
		bool Trusted { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable assetUrls;
		[NullAllowed, Export ("assetUrls", ArgumentSemantic.Strong)]
		NSObject[] AssetUrls { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable messageFields;
		[NullAllowed, Export ("messageFields", ArgumentSemantic.Strong)]
		NSDictionary MessageFields { get; set; }

	}

	// @interface ABKInAppMessageHTMLFull : ABKInAppMessageHTMLBase
	[BaseType (typeof(ABKInAppMessageHTMLBase))]
	interface ABKInAppMessageHTMLFull
	{
		// @property (nonatomic, strong) NSURL * _Nullable assetsZipRemoteUrl;
		[NullAllowed, Export ("assetsZipRemoteUrl", ArgumentSemantic.Strong)]
		NSUrl AssetsZipRemoteUrl { get; set; }

	}

	// @interface ABKInAppMessageControl : ABKInAppMessage
	[BaseType (typeof(ABKInAppMessage))]
	interface ABKInAppMessageControl
	{

	}

	// @protocol ABKInAppMessageControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageControllerDelegate
	{
		// @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage * _Nonnull)inAppMessage;
		[Export ("beforeInAppMessageDisplayed:")]
		ABKInAppMessageDisplayChoice BeforeInAppMessageDisplayed (ABKInAppMessage inAppMessage);

		// @optional -(ABKInAppMessageDisplayChoice)beforeControlMessageImpressionLogged:(ABKInAppMessage * _Nonnull)inAppMessage;
		[Export ("beforeControlMessageImpressionLogged:")]
		ABKInAppMessageDisplayChoice BeforeControlMessageImpressionLogged (ABKInAppMessage inAppMessage);

		// @optional -(void)noMatchingTriggerForEvent:(ABKTriggerEventType)eventType name:(NSString * _Nullable)name;
		[Export ("noMatchingTriggerForEvent:name:")]
		void NoMatchingTriggerForEvent (ABKTriggerEventType eventType, [NullAllowed] string name);

	}

	// @protocol ABKInAppMessageUIControlling <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageUIControlling
	{
		// @optional -(void)setInAppMessageUIDelegate:(id)uiDelegate;
		[Export ("setInAppMessageUIDelegate:")]
		void SetInAppMessageUIDelegate (NSObject uiDelegate);

		// @optional -(void)hideCurrentInAppMessage:(BOOL)animated;
		[Export ("hideCurrentInAppMessage:")]
		void HideCurrentInAppMessage (bool animated);

		// @optional -(ABKInAppMessageDisplayChoice)getCurrentDisplayChoiceForInAppMessage:(ABKInAppMessage *)inAppMessage;
		[Export ("getCurrentDisplayChoiceForInAppMessage:")]
		ABKInAppMessageDisplayChoice GetCurrentDisplayChoiceForInAppMessage (ABKInAppMessage inAppMessage);

		// @optional -(ABKInAppMessageDisplayChoice)getCurrentDisplayChoiceForControlInAppMessage:(ABKInAppMessage *)controlInAppMessage;
		[Export ("getCurrentDisplayChoiceForControlInAppMessage:")]
		ABKInAppMessageDisplayChoice GetCurrentDisplayChoiceForControlInAppMessage (ABKInAppMessage controlInAppMessage);

		// @optional -(void)showInAppMessage:(ABKInAppMessage *)inAppMessage;
		[Export ("showInAppMessage:")]
		void ShowInAppMessage (ABKInAppMessage inAppMessage);

		// @optional -(BOOL)inAppMessageCurrentlyVisible;
		[Export ("inAppMessageCurrentlyVisible")]
		bool InAppMessageCurrentlyVisible { get; }

	}

	// @interface ABKInAppMessageController : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageController
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ABKInAppMessageControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ABKInAppMessageControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) id<ABKInAppMessageUIControlling> _Nullable inAppMessageUIController;
		[NullAllowed, Export ("inAppMessageUIController", ArgumentSemantic.Strong)]
		ABKInAppMessageUIControlling InAppMessageUIController { get; set; }

		// @property BOOL enableDismissModalOnOutsideTap;
		[Export ("enableDismissModalOnOutsideTap")]
		bool EnableDismissModalOnOutsideTap { get; set; }

		// -(void)displayNextInAppMessageWithDelegate:(id<ABKInAppMessageControllerDelegate> _Nullable)delegate __attribute__((deprecated("Please use 'displayNextInAppMessage' instead.")));
		[Obsolete("Please use 'displayNextInAppMessage' instead.")]
		[Export ("displayNextInAppMessageWithDelegate:")]
		void DisplayNextInAppMessageWithDelegate ([NullAllowed] ABKInAppMessageControllerDelegate @delegate);

		// -(void)displayNextInAppMessage;
		[Export ("displayNextInAppMessage")]
		void DisplayNextInAppMessage ();

		// -(NSInteger)inAppMessagesRemainingOnStack;
		[Export ("inAppMessagesRemainingOnStack")]
		nint InAppMessagesRemainingOnStack { get; }

		// -(void)addInAppMessage:(ABKInAppMessage * _Nonnull)newInAppMessage;
		[Export ("addInAppMessage:")]
		void AddInAppMessage (ABKInAppMessage newInAppMessage);

	}

	// @interface ABKInAppMessageButton : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageButton
	{
		// @property (copy) NSString * _Nullable buttonText;
		[NullAllowed, Export ("buttonText")]
		string ButtonText { get; set; }

		// @property (strong) UIColor * _Nullable buttonBackgroundColor;
		[NullAllowed, Export ("buttonBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ButtonBackgroundColor { get; set; }

		// @property (strong) UIColor * _Nullable buttonBorderColor;
		[NullAllowed, Export ("buttonBorderColor", ArgumentSemantic.Strong)]
		UIColor ButtonBorderColor { get; set; }

		// @property (strong) UIColor * _Nullable buttonTextColor;
		[NullAllowed, Export ("buttonTextColor", ArgumentSemantic.Strong)]
		UIColor ButtonTextColor { get; set; }

		// @property (copy) UIFont * _Nullable buttonTextFont;
		[NullAllowed, Export ("buttonTextFont", ArgumentSemantic.Copy)]
		UIFont ButtonTextFont { get; set; }

		// @property (readonly) ABKInAppMessageClickActionType buttonClickActionType;
		[Export ("buttonClickActionType")]
		ABKInAppMessageClickActionType ButtonClickActionType { get; }

		// @property (readonly, copy) NSURL * _Nullable buttonClickedURI;
		[NullAllowed, Export ("buttonClickedURI", ArgumentSemantic.Copy)]
		NSUrl ButtonClickedURI { get; }

		// @property BOOL buttonOpenUrlInWebView;
		[Export ("buttonOpenUrlInWebView")]
		bool ButtonOpenUrlInWebView { get; set; }

		// @property (readonly) NSInteger buttonID;
		[Export ("buttonID")]
		nint ButtonID { get; }

		// -(void)setButtonClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSURL * _Nullable)uri;
		[Export ("setButtonClickAction:withURI:")]
		void SetButtonClickAction (ABKInAppMessageClickActionType clickActionType, [NullAllowed] NSUrl uri);

	}

	// @interface ABKInAppMessageWebViewBridge : NSObject <WKScriptMessageHandler>
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageWebViewBridge : IWKScriptMessageHandler
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ABKInAppMessageWebViewBridgeDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ABKInAppMessageWebViewBridgeDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithWebView:(WKWebView * _Nonnull)webView inAppMessage:(ABKInAppMessageHTML * _Nonnull)inAppMessage appboyInstance:(Appboy * _Nonnull)appboy;
		[Export ("initWithWebView:inAppMessage:appboyInstance:")]
		NativeHandle Constructor (WKWebView webView, ABKInAppMessageHTML inAppMessage, Appboy appboy);

	}

	// @protocol ABKInAppMessageWebViewBridgeDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageWebViewBridgeDelegate
	{
		// @required -(void)webViewBridge:(ABKInAppMessageWebViewBridge * _Nonnull)webViewBridge receivedClickAction:(ABKInAppMessageClickActionType)clickAction;
		[Abstract]
		[Export ("webViewBridge:receivedClickAction:")]
		void WebViewBridge (ABKInAppMessageWebViewBridge webViewBridge, ABKInAppMessageClickActionType clickAction);

		// @required -(void)closeMessageWithWebViewBridge:(ABKInAppMessageWebViewBridge * _Nonnull)webViewBridge;
		[Abstract]
		[Export ("closeMessageWithWebViewBridge:")]
		void CloseMessageWithWebViewBridge (ABKInAppMessageWebViewBridge webViewBridge);

	}

	// @interface ABKInAppMessageDarkTheme : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageDarkTheme
	{
		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable iconColor;
		[NullAllowed, Export ("iconColor", ArgumentSemantic.Strong)]
		UIColor IconColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable iconBackgroundColor;
		[NullAllowed, Export ("iconBackgroundColor", ArgumentSemantic.Strong)]
		UIColor IconBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable headerTextColor;
		[NullAllowed, Export ("headerTextColor", ArgumentSemantic.Strong)]
		UIColor HeaderTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable closeButtonColor;
		[NullAllowed, Export ("closeButtonColor", ArgumentSemantic.Strong)]
		UIColor CloseButtonColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable frameColor;
		[NullAllowed, Export ("frameColor", ArgumentSemantic.Strong)]
		UIColor FrameColor { get; set; }

		// @property (nonatomic, strong) NSArray<ABKInAppMessageDarkButtonTheme *> * _Nullable buttons;
		[NullAllowed, Export ("buttons", ArgumentSemantic.Strong)]
		ABKInAppMessageDarkButtonTheme[] Buttons { get; set; }

		// -(instancetype _Nonnull)initWithFields:(NSDictionary<NSString *,NSString *> * _Nonnull)darkThemeFields;
		[Export ("initWithFields:")]
		NativeHandle Constructor (NSDictionary<NSString, NSString> darkThemeFields);

		// -(UIColor * _Nonnull)getColorForKey:(NSString * _Nonnull)key;
		[Export ("getColorForKey:")]
		UIColor GetColorForKey (string key);

	}

	// @interface ABKInAppMessageDarkButtonTheme : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageDarkButtonTheme
	{
		// @property (strong) UIColor * _Nonnull buttonBackgroundColor;
		[Export ("buttonBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ButtonBackgroundColor { get; set; }

		// @property (strong) UIColor * _Nonnull buttonBorderColor;
		[Export ("buttonBorderColor", ArgumentSemantic.Strong)]
		UIColor ButtonBorderColor { get; set; }

		// @property (strong) UIColor * _Nonnull buttonTextColor;
		[Export ("buttonTextColor", ArgumentSemantic.Strong)]
		UIColor ButtonTextColor { get; set; }

		// -(instancetype _Nonnull)initWithFields:(NSDictionary * _Nonnull)darkButtonFields;
		[Export ("initWithFields:")]
		NativeHandle Constructor (NSDictionary darkButtonFields);

	}

	partial interface Constants
	{
		// extern NSString *const _Nonnull ABKContentCardsProcessedNotification;
		[Field ("ABKContentCardsProcessedNotification", "__Internal")]
		NSString ABKContentCardsProcessedNotification { get; }

		// extern NSString *const _Nonnull ABKContentCardsProcessedIsSuccessfulKey;
		[Field ("ABKContentCardsProcessedIsSuccessfulKey", "__Internal")]
		NSString ABKContentCardsProcessedIsSuccessfulKey { get; }
	}

	// @interface ABKContentCardsController : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKContentCardsController
	{
		// @property (readonly, getter = getContentCards) NSArray * _Nonnull contentCards;
		[Export ("contentCards")]
		NSObject[] ContentCards { [Bind ("getContentCards")] get; }

		// @property (readonly) NSDate * _Nullable lastUpdate;
		[NullAllowed, Export ("lastUpdate")]
		NSDate LastUpdate { get; }

		// -(NSInteger)unviewedContentCardCount;
		[Export ("unviewedContentCardCount")]
		nint UnviewedContentCardCount { get; }

		// -(NSInteger)contentCardCount;
		[Export ("contentCardCount")]
		nint ContentCardCount { get; }

	}

	// @protocol ABKIDFADelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ABKIDFADelegate
	{
		// @required -(NSString * _Nonnull)advertisingIdentifierString;
		[Abstract]
		[Export ("advertisingIdentifierString")]
		string AdvertisingIdentifierString { get; }

		// @required -(BOOL)isAdvertisingTrackingEnabledOrATTAuthorized;
		[Abstract]
		[Export ("isAdvertisingTrackingEnabledOrATTAuthorized")]
		bool IsAdvertisingTrackingEnabledOrATTAuthorized { get; }

	}

	// @interface ABKSDWebImageProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKSDWebImageProxy
	{
		// +(void)setImageForView:(UIImageView * _Nonnull)imageView showActivityIndicator:(BOOL)showActivityIndicator withURL:(NSURL * _Nullable)imageURL imagePlaceHolder:(UIImage * _Nullable)placeHolder completed:(void (^ _Nullable)(UIImage * _Nullable, NSError * _Nullable, NSInteger, NSURL * _Nullable))completion;
		[Static]
		[Export ("setImageForView:showActivityIndicator:withURL:imagePlaceHolder:completed:")]
		void SetImageForView (UIImageView imageView, bool showActivityIndicator, [NullAllowed] NSUrl imageURL, [NullAllowed] UIImage placeHolder, [NullAllowed] Action<UIImage, NSError, nint, NSUrl> completion);

		// +(void)loadImageWithURL:(NSURL * _Nullable)url options:(NSInteger)options completed:(void (^ _Nullable)(UIImage * _Nonnull, NSData * _Nonnull, NSError * _Nonnull, NSInteger, BOOL, NSURL * _Nonnull))completion;
		[Static]
		[Export ("loadImageWithURL:options:completed:")]
		void LoadImageWithURL ([NullAllowed] NSUrl url, nint options, [NullAllowed] Action<UIImage, NSData, NSError, nint, bool, NSUrl> completion);

		// +(void)diskImageExistsForURL:(NSURL * _Nullable)url completed:(void (^ _Nullable)(BOOL))completion;
		[Static]
		[Export ("diskImageExistsForURL:completed:")]
		void DiskImageExistsForURL ([NullAllowed] NSUrl url, [NullAllowed] Action<bool> completion);

		// +(NSString * _Nullable)cacheKeyForURL:(NSURL * _Nullable)url;
		[Static]
		[Export ("cacheKeyForURL:")]
		[return: NullAllowed]
		string CacheKeyForURL ([NullAllowed] NSUrl url);

		// +(void)removeSDWebImageForKey:(NSString * _Nullable)key;
		[Static]
		[Export ("removeSDWebImageForKey:")]
		void RemoveSDWebImageForKey ([NullAllowed] string key);

		// +(UIImage * _Nullable)imageFromCacheForKey:(NSString * _Nullable)key;
		[Static]
		[Export ("imageFromCacheForKey:")]
		[return: NullAllowed]
		UIImage ImageFromCacheForKey ([NullAllowed] string key);

		// +(void)clearSDWebImageCache;
		[Static]
		[Export ("clearSDWebImageCache")]
		void ClearSDWebImageCache ();

		// +(BOOL)isSupportedSDWebImageVersion;
		[Static]
		[Export ("isSupportedSDWebImageVersion")]
		bool IsSupportedSDWebImageVersion { get; }

	}

	// @protocol ABKImageDelegate
	[BaseType(typeof(NSObject))]
	[Model][Protocol]
	interface ABKImageDelegate
	{
		// @required -(void)setImageForView:(UIImageView * _Nonnull)imageView showActivityIndicator:(BOOL)showActivityIndicator withURL:(NSURL * _Nullable)imageURL imagePlaceHolder:(UIImage * _Nullable)placeHolder completed:(void (^ _Nullable)(UIImage * _Nullable, NSError * _Nullable, NSInteger, NSURL * _Nullable))completion;
		[Abstract]
		[Export ("setImageForView:showActivityIndicator:withURL:imagePlaceHolder:completed:")]
		void SetImageForView (UIImageView imageView, bool showActivityIndicator, [NullAllowed] NSUrl imageURL, [NullAllowed] UIImage placeHolder, [NullAllowed] Action<UIImage, NSError, nint, NSUrl> completion);

		// @required -(void)loadImageWithURL:(NSURL * _Nullable)url options:(ABKImageOptions)options completed:(void (^ _Nullable)(UIImage * _Nonnull, NSData * _Nonnull, NSError * _Nonnull, NSInteger, BOOL, NSURL * _Nonnull))completion;
		[Abstract]
		[Export ("loadImageWithURL:options:completed:")]
		void LoadImageWithURL ([NullAllowed] NSUrl url, ABKImageOptions options, [NullAllowed] Action<UIImage, NSData, NSError, nint, bool, NSUrl> completion);

		// @required -(void)diskImageExistsForURL:(NSURL * _Nullable)url completed:(void (^ _Nullable)(BOOL))completion;
		[Abstract]
		[Export ("diskImageExistsForURL:completed:")]
		void DiskImageExistsForURL ([NullAllowed] NSUrl url, [NullAllowed] Action<bool> completion);

		// @required -(UIImage * _Nullable)imageFromCacheForURL:(NSURL * _Nullable)url;
		[Abstract]
		[Export ("imageFromCacheForURL:")]
		[return: NullAllowed]
		UIImage ImageFromCacheForURL ([NullAllowed] NSUrl url);

		// @required -(Class _Nonnull)imageViewClass;
		[Abstract]
		[Export ("imageViewClass")]
		Class ImageViewClass { get; }

	}

	// @interface ABKLocationManager : NSObject <CLLocationManagerDelegate>
	[BaseType (typeof(NSObject))]
	interface ABKLocationManager : ICLLocationManagerDelegate
	{
		// @property (readonly) BOOL enableLocationTracking;
		[Export ("enableLocationTracking")]
		bool EnableLocationTracking { get; }

		// @property (readonly) BOOL enableGeofences;
		[Export ("enableGeofences")]
		bool EnableGeofences { get; }

		// @property (readonly) BOOL disableAutomaticGeofenceRequests;
		[Export ("disableAutomaticGeofenceRequests")]
		bool DisableAutomaticGeofenceRequests { get; }

		// -(void)logSingleLocation;
		[Export ("logSingleLocation")]
		void LogSingleLocation ();

	}

	// @interface ABKLocationManagerProvider : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKLocationManagerProvider
	{
		// +(BOOL)locationServicesEnabled;
		[Static]
		[Export ("locationServicesEnabled")]
		bool LocationServicesEnabled { get; }

	}

	// @protocol ABKURLDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ABKURLDelegate
	{
		// @required -(BOOL)handleAppboyURL:(NSURL * _Nullable)url fromChannel:(ABKChannel)channel withExtras:(NSDictionary * _Nullable)extras;
		[Abstract]
		[Export ("handleAppboyURL:fromChannel:withExtras:")]
		bool FromChannel ([NullAllowed] NSUrl url, ABKChannel channel, [NullAllowed] NSDictionary extras);

	}

	// @interface ABKPushUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKPushUtils
	{
		// +(BOOL)isAppboyUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(maccatalyst, introduced=14.0)));
		[Static]
		[Export ("isAppboyUserNotification:")]
		bool IsAppboyUserNotification (UNNotificationResponse response);

		// +(BOOL)isAppboyRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("isAppboyRemoteNotification:")]
		bool IsAppboyRemoteNotification (NSDictionary userInfo);

		// +(BOOL)isAppboyInternalRemoteNotification:(NSDictionary * _Nonnull)userInfo __attribute__((deprecated("renamed to 'Braze.Notifications.isInternalNotification(_:)'")));
		[Obsolete("renamed to 'Braze.Notifications.isInternalNotification(_:)'")]
		[Static]
		[Export ("isAppboyInternalRemoteNotification:")]
		bool IsAppboyInternalRemoteNotification (NSDictionary userInfo);

		// +(BOOL)isUninstallTrackingUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(maccatalyst, introduced=14.0)));
		[Static]
		[Export ("isUninstallTrackingUserNotification:")]
		bool IsUninstallTrackingUserNotification (UNNotificationResponse response);

		// +(BOOL)isUninstallTrackingRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("isUninstallTrackingRemoteNotification:")]
		bool IsUninstallTrackingRemoteNotification (NSDictionary userInfo);

		// +(BOOL)isGeofencesSyncUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(maccatalyst, introduced=14.0)));
		[Static]
		[Export ("isGeofencesSyncUserNotification:")]
		bool IsGeofencesSyncUserNotification (UNNotificationResponse response);

		// +(BOOL)isGeofencesSyncRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("isGeofencesSyncRemoteNotification:")]
		bool IsGeofencesSyncRemoteNotification (NSDictionary userInfo);

		// +(BOOL)isAppboySilentRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("isAppboySilentRemoteNotification:")]
		bool IsAppboySilentRemoteNotification (NSDictionary userInfo);

		// +(BOOL)isPushStoryRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("isPushStoryRemoteNotification:")]
		bool IsPushStoryRemoteNotification (NSDictionary userInfo);

		// +(BOOL)notificationContainsContentCard:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("notificationContainsContentCard:")]
		bool NotificationContainsContentCard (NSDictionary userInfo);

		// +(BOOL)shouldFetchTestTriggersFlagContainedInPayload:(NSDictionary * _Nonnull)userInfo __attribute__((deprecated("")));
		[Static]
		[Export ("shouldFetchTestTriggersFlagContainedInPayload:")]
		bool ShouldFetchTestTriggersFlagContainedInPayload (NSDictionary userInfo);

		// +(NSSet<UNNotificationCategory *> * _Nonnull)getAppboyUNNotificationCategorySet __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(maccatalyst, introduced=14.0))) __attribute__((deprecated("renamed to 'Braze.Notifications.categories'.")));
		[Obsolete("renamed to 'Braze.Notifications.categories'.")]
		[Static]
		[Export ("getAppboyUNNotificationCategorySet")]
		NSSet<UNNotificationCategory> AppboyUNNotificationCategorySet { get; }

		// +(NSSet<UIUserNotificationCategory *> * _Nonnull)getAppboyUIUserNotificationCategorySet __attribute__((deprecated("Please use `getAppboyUNNotificationCategorySet` instead.")));
		[Obsolete("Please use `getAppboyUNNotificationCategorySet` instead.")]
		[Static]
		[Export ("getAppboyUIUserNotificationCategorySet")]
		NSSet<UIUserNotificationCategory> AppboyUIUserNotificationCategorySet { get; }

	}

	// @interface ABKModalWebViewController : UINavigationController <WKNavigationDelegate>
	[BaseType (typeof(UINavigationController))]
	interface ABKModalWebViewController : IWKNavigationDelegate
	{
		// @property NSURL * url;
		[Export ("url", ArgumentSemantic.Assign)]
		NSUrl Url { get; set; }

		// @property (nonatomic) WKWebView * webView __attribute__((iboutlet));
		[Export ("webView", ArgumentSemantic.Assign)]
		WKWebView WebView { get; set; }

		// @property (nonatomic) UIProgressView * progressBar __attribute__((iboutlet));
		[Export ("progressBar", ArgumentSemantic.Assign)]
		UIProgressView ProgressBar { get; set; }

	}

	// @interface ABKNoConnectionLocalization : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKNoConnectionLocalization
	{
		// +(NSString *)getNoConnectionLocalizedString;
		[Static]
		[Export ("getNoConnectionLocalizedString")]
		string NoConnectionLocalizedString { get; }

	}

}
