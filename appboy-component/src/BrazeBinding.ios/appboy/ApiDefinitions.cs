using System;
using Appboy_iOS_SDK;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const ABKSdkMetadata ABKSdkMetadataAdjust;
	[Field ("ABKSdkMetadataAdjust", "__Internal")]
	NSString ABKSdkMetadataAdjust { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataAirBridge;
	[Field ("ABKSdkMetadataAirBridge", "__Internal")]
	NSString ABKSdkMetadataAirBridge { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataAppsFlyer;
	[Field ("ABKSdkMetadataAppsFlyer", "__Internal")]
	NSString ABKSdkMetadataAppsFlyer { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataBluedot;
	[Field ("ABKSdkMetadataBluedot", "__Internal")]
	NSString ABKSdkMetadataBluedot { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataBranch;
	[Field ("ABKSdkMetadataBranch", "__Internal")]
	NSString ABKSdkMetadataBranch { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataCordova;
	[Field ("ABKSdkMetadataCordova", "__Internal")]
	NSString ABKSdkMetadataCordova { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataCarthage;
	[Field ("ABKSdkMetadataCarthage", "__Internal")]
	NSString ABKSdkMetadataCarthage { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataCocoaPods;
	[Field ("ABKSdkMetadataCocoaPods", "__Internal")]
	NSString ABKSdkMetadataCocoaPods { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataCordovaPM;
	[Field ("ABKSdkMetadataCordovaPM", "__Internal")]
	NSString ABKSdkMetadataCordovaPM { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataExpo;
	[Field ("ABKSdkMetadataExpo", "__Internal")]
	NSString ABKSdkMetadataExpo { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataFoursquare;
	[Field ("ABKSdkMetadataFoursquare", "__Internal")]
	NSString ABKSdkMetadataFoursquare { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataFlutter;
	[Field ("ABKSdkMetadataFlutter", "__Internal")]
	NSString ABKSdkMetadataFlutter { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataGoogleTagManager;
	[Field ("ABKSdkMetadataGoogleTagManager", "__Internal")]
	NSString ABKSdkMetadataGoogleTagManager { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataGimbal;
	[Field ("ABKSdkMetadataGimbal", "__Internal")]
	NSString ABKSdkMetadataGimbal { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataGraddle;
	[Field ("ABKSdkMetadataGraddle", "__Internal")]
	NSString ABKSdkMetadataGraddle { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataIonic;
	[Field ("ABKSdkMetadataIonic", "__Internal")]
	NSString ABKSdkMetadataIonic { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataKochava;
	[Field ("ABKSdkMetadataKochava", "__Internal")]
	NSString ABKSdkMetadataKochava { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataManual;
	[Field ("ABKSdkMetadataManual", "__Internal")]
	NSString ABKSdkMetadataManual { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataMParticle;
	[Field ("ABKSdkMetadataMParticle", "__Internal")]
	NSString ABKSdkMetadataMParticle { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataNativeScript;
	[Field ("ABKSdkMetadataNativeScript", "__Internal")]
	NSString ABKSdkMetadataNativeScript { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataNPM;
	[Field ("ABKSdkMetadataNPM", "__Internal")]
	NSString ABKSdkMetadataNPM { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataNuGet;
	[Field ("ABKSdkMetadataNuGet", "__Internal")]
	NSString ABKSdkMetadataNuGet { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataPub;
	[Field ("ABKSdkMetadataPub", "__Internal")]
	NSString ABKSdkMetadataPub { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataRadar;
	[Field ("ABKSdkMetadataRadar", "__Internal")]
	NSString ABKSdkMetadataRadar { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataReactNative;
	[Field ("ABKSdkMetadataReactNative", "__Internal")]
	NSString ABKSdkMetadataReactNative { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataSegment;
	[Field ("ABKSdkMetadataSegment", "__Internal")]
	NSString ABKSdkMetadataSegment { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataSingular;
	[Field ("ABKSdkMetadataSingular", "__Internal")]
	NSString ABKSdkMetadataSingular { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataSwiftPM;
	[Field ("ABKSdkMetadataSwiftPM", "__Internal")]
	NSString ABKSdkMetadataSwiftPM { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataTealium;
	[Field ("ABKSdkMetadataTealium", "__Internal")]
	NSString ABKSdkMetadataTealium { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataUnreal;
	[Field ("ABKSdkMetadataUnreal", "__Internal")]
	NSString ABKSdkMetadataUnreal { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataUnityPM;
	[Field ("ABKSdkMetadataUnityPM", "__Internal")]
	NSString ABKSdkMetadataUnityPM { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataUnity;
	[Field ("ABKSdkMetadataUnity", "__Internal")]
	NSString ABKSdkMetadataUnity { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataVizbee;
	[Field ("ABKSdkMetadataVizbee", "__Internal")]
	NSString ABKSdkMetadataVizbee { get; }

	// extern const ABKSdkMetadata ABKSdkMetadataXamarin;
	[Field ("ABKSdkMetadataXamarin", "__Internal")]
	NSString ABKSdkMetadataXamarin { get; }

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
	[Field ("ABKDeviceWhitelistKey", "__Internal")]
	NSString ABKDeviceWhitelistKey { get; }

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
	[Verify (MethodToProperty)]
	Appboy SharedInstance { get; }

	// +(Appboy * _Nonnull)unsafeInstance;
	[Static]
	[Export ("unsafeInstance")]
	[Verify (MethodToProperty)]
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
	[Export ("flushDataAndProcessRequestQueue")]
	void FlushDataAndProcessRequestQueue ();

	// -(void)shutdownServerCommunication;
	[Export ("shutdownServerCommunication")]
	void ShutdownServerCommunication ();

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
	[Verify (MethodToProperty)]
	string DeviceId { get; }

	// -(void)registerDeviceToken:(NSData * _Nonnull)deviceToken;
	[Export ("registerDeviceToken:")]
	void RegisterDeviceToken (NSData deviceToken);

	// -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification __attribute__((availability(ios, introduced=3.0, deprecated=10.0)));
	[Introduced (PlatformName.iOS, 3, 0, message: "`registerApplication:didReceiveRemoteNotification:` is deprecated in iOS 10, please use `registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:` instead.")]
	[Deprecated (PlatformName.iOS, 10, 0, message: "`registerApplication:didReceiveRemoteNotification:` is deprecated in iOS 10, please use `registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:` instead.")]
	[Export ("registerApplication:didReceiveRemoteNotification:")]
	void RegisterApplication (UIApplication application, NSDictionary notification);

	// -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
	[Export ("registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:")]
	void RegisterApplication (UIApplication application, NSDictionary notification, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

	// -(void)getActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nullable)(void))completionHandler __attribute__((availability(ios, introduced=8.0, deprecated=10.0)));
	[Introduced (PlatformName.iOS, 8, 0, message: "`getActionWithIdentifier:forRemoteNotification:completionHandler:` is deprecated in iOS 10, please use `userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:` instead.")]
	[Deprecated (PlatformName.iOS, 10, 0, message: "`getActionWithIdentifier:forRemoteNotification:completionHandler:` is deprecated in iOS 10, please use `userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:` instead.")]
	[Export ("getActionWithIdentifier:forRemoteNotification:completionHandler:")]
	void GetActionWithIdentifier (string identifier, NSDictionary userInfo, [NullAllowed] Action completionHandler);

	// -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nullable)(void))completionHandler __attribute__((availability(ios, introduced=10.0)));
	[iOS (10,0)]
	[Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
	void UserNotificationCenter (UNUserNotificationCenter center, UNNotificationResponse response, [NullAllowed] Action completionHandler);

	// -(void)pushAuthorizationFromUserNotificationCenter:(BOOL)pushAuthGranted;
	[Export ("pushAuthorizationFromUserNotificationCenter:")]
	void PushAuthorizationFromUserNotificationCenter (bool pushAuthGranted);

	// -(void)addSdkMetadata:(NSArray<ABKSdkMetadata> * _Nonnull)metadata;
	[Export ("addSdkMetadata:")]
	void AddSdkMetadata (string[] metadata);

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
	[Verify (StronglyTypedNSArray)]
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

[Static]
[Verify (ConstantsInterfaceAssociation)]
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
	[Verify (StronglyTypedNSArray)]
	NativeHandle Constructor ([NullAllowed] NSDictionary facebookUserDictionary, nint numberOfFriends, [NullAllowed] NSObject[] likes);

	// @property (readonly) NSDictionary * _Nullable facebookUserDictionary;
	[NullAllowed, Export ("facebookUserDictionary")]
	NSDictionary FacebookUserDictionary { get; }

	// @property (readonly) NSInteger numberOfFriends;
	[Export ("numberOfFriends")]
	nint NumberOfFriends { get; }

	// @property (readonly) NSArray * _Nullable likes;
	[NullAllowed, Export ("likes")]
	[Verify (StronglyTypedNSArray)]
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

[Static]
[Verify (ConstantsInterfaceAssociation)]
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
	[Verify (StronglyTypedNSArray)]
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
	[Verify (StronglyTypedNSArray)]
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
	[Verify (MethodToProperty)]
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
	[Verify (MethodToProperty)]
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
	[Verify (MethodToProperty)]
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

	// -(instancetype _Nonnull)initWithCode:(NSInteger)code reason:(NSString * _Nonnull)reason userId:(NSString * _Nonnull)userId signature:(NSString * _Nonnull)signature;
	[Export ("initWithCode:reason:userId:signature:")]
	NativeHandle Constructor (nint code, string reason, string userId, string signature);
}

// @protocol ABKSdkAuthenticationDelegate <NSObject>
[Protocol, Model (AutoGeneratedName = true)]
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

	// @property NSTextAlignment messageTextAlignment;
	[Export ("messageTextAlignment", ArgumentSemantic.Assign)]
	NSTextAlignment MessageTextAlignment { get; set; }

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
	[Verify (MethodToProperty)]
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

	// @property NSTextAlignment headerTextAlignment;
	[Export ("headerTextAlignment", ArgumentSemantic.Assign)]
	NSTextAlignment HeaderTextAlignment { get; set; }

	// @property ABKInAppMessageImmersiveImageStyle imageStyle;
	[Export ("imageStyle", ArgumentSemantic.Assign)]
	ABKInAppMessageImmersiveImageStyle ImageStyle { get; set; }

	// -(void)logInAppMessageClickedWithButtonID:(NSInteger)buttonId;
	[Export ("logInAppMessageClickedWithButtonID:")]
	void LogInAppMessageClickedWithButtonID (nint buttonId);

	// -(void)setInAppMessageButtons:(NSArray * _Nonnull)buttonArray;
	[Export ("setInAppMessageButtons:")]
	[Verify (StronglyTypedNSArray)]
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
	[Verify (StronglyTypedNSArray)]
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
[Protocol, Model (AutoGeneratedName = true)]
[BaseType (typeof(NSObject))]
interface ABKInAppMessageControllerDelegate
{
	// @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage * _Nonnull)inAppMessage;
	[Export ("beforeInAppMessageDisplayed:")]
	ABKInAppMessageDisplayChoice BeforeInAppMessageDisplayed (ABKInAppMessage inAppMessage);

	// @optional -(ABKInAppMessageDisplayChoice)beforeControlMessageImpressionLogged:(ABKInAppMessage * _Nonnull)inAppMessage;
	[Export ("beforeControlMessageImpressionLogged:")]
	ABKInAppMessageDisplayChoice BeforeControlMessageImpressionLogged (ABKInAppMessage inAppMessage);
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
	[Verify (MethodToProperty)]
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
	[Export ("displayNextInAppMessageWithDelegate:")]
	void DisplayNextInAppMessageWithDelegate ([NullAllowed] ABKInAppMessageControllerDelegate @delegate);

	// -(void)displayNextInAppMessage;
	[Export ("displayNextInAppMessage")]
	void DisplayNextInAppMessage ();

	// -(NSInteger)inAppMessagesRemainingOnStack;
	[Export ("inAppMessagesRemainingOnStack")]
	[Verify (MethodToProperty)]
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
[Protocol, Model (AutoGeneratedName = true)]
[BaseType (typeof(NSObject))]
interface ABKInAppMessageWebViewBridgeDelegate
{
	// @required -(void)webViewBridge:(ABKInAppMessageWebViewBridge * _Nonnull)webViewBridge receivedClickAction:(ABKInAppMessageClickActionType)clickAction;
	[Abstract]
	[Export ("webViewBridge:receivedClickAction:")]
	void ReceivedClickAction (ABKInAppMessageWebViewBridge webViewBridge, ABKInAppMessageClickActionType clickAction);
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

[Static]
[Verify (ConstantsInterfaceAssociation)]
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
	[Verify (StronglyTypedNSArray)]
	NSObject[] ContentCards { [Bind ("getContentCards")] get; }

	// @property (readonly) NSDate * _Nullable lastUpdate;
	[NullAllowed, Export ("lastUpdate")]
	NSDate LastUpdate { get; }

	// -(NSInteger)unviewedContentCardCount;
	[Export ("unviewedContentCardCount")]
	[Verify (MethodToProperty)]
	nint UnviewedContentCardCount { get; }

	// -(NSInteger)contentCardCount;
	[Export ("contentCardCount")]
	[Verify (MethodToProperty)]
	nint ContentCardCount { get; }
}

// @protocol ABKIDFADelegate <NSObject>
[Protocol, Model (AutoGeneratedName = true)]
[BaseType (typeof(NSObject))]
interface ABKIDFADelegate
{
	// @required -(NSString * _Nonnull)advertisingIdentifierString;
	[Abstract]
	[Export ("advertisingIdentifierString")]
	[Verify (MethodToProperty)]
	string AdvertisingIdentifierString { get; }

	// @required -(BOOL)isAdvertisingTrackingEnabledOrATTAuthorized;
	[Abstract]
	[Export ("isAdvertisingTrackingEnabledOrATTAuthorized")]
	[Verify (MethodToProperty)]
	bool IsAdvertisingTrackingEnabledOrATTAuthorized { get; }
}

// @interface ABKSDWebImageProxy : NSObject
[BaseType (typeof(NSObject))]
interface ABKSDWebImageProxy
{
	// +(void)setImageForView:(UIImageView * _Nonnull)imageView showActivityIndicator:(BOOL)showActivityIndicator withURL:(NSURL * _Nullable)imageURL imagePlaceHolder:(UIImage * _Nullable)placeHolder completed:(void (^ _Nullable)(UIImage * _Nullable, NSError * _Nullable, NSInteger, NSURL * _Nullable))completion;
	[Static]
	[Export ("setImageForView:showActivityIndicator:withURL:imagePlaceHolder:completed:")]
	void SetImageForView (UIImageView imageView, bool showActivityIndicator, [NullAllowed] NSUrl imageURL, [NullAllowed] UIImage placeHolder, [NullAllowed] Action<UIImage, NSError, nint, NSURL> completion);

	// +(void)loadImageWithURL:(NSURL * _Nullable)url options:(NSInteger)options completed:(void (^ _Nullable)(UIImage * _Nonnull, NSData * _Nonnull, NSError * _Nonnull, NSInteger, BOOL, NSURL * _Nonnull))completion;
	[Static]
	[Export ("loadImageWithURL:options:completed:")]
	void LoadImageWithURL ([NullAllowed] NSUrl url, nint options, [NullAllowed] Action<UIImage, NSData, NSError, nint, bool, NSURL> completion);

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
	[Verify (MethodToProperty)]
	bool IsSupportedSDWebImageVersion { get; }
}

// @protocol ABKImageDelegate
[Protocol, Model (AutoGeneratedName = true)]
interface ABKImageDelegate
{
	// @required -(void)setImageForView:(UIImageView * _Nonnull)imageView showActivityIndicator:(BOOL)showActivityIndicator withURL:(NSURL * _Nullable)imageURL imagePlaceHolder:(UIImage * _Nullable)placeHolder completed:(void (^ _Nullable)(UIImage * _Nullable, NSError * _Nullable, NSInteger, NSURL * _Nullable))completion;
	[Abstract]
	[Export ("setImageForView:showActivityIndicator:withURL:imagePlaceHolder:completed:")]
	void SetImageForView (UIImageView imageView, bool showActivityIndicator, [NullAllowed] NSUrl imageURL, [NullAllowed] UIImage placeHolder, [NullAllowed] Action<UIImage, NSError, nint, NSURL> completion);

	// @required -(void)loadImageWithURL:(NSURL * _Nullable)url options:(ABKImageOptions)options completed:(void (^ _Nullable)(UIImage * _Nonnull, NSData * _Nonnull, NSError * _Nonnull, NSInteger, BOOL, NSURL * _Nonnull))completion;
	[Abstract]
	[Export ("loadImageWithURL:options:completed:")]
	void LoadImageWithURL ([NullAllowed] NSUrl url, ABKImageOptions options, [NullAllowed] Action<UIImage, NSData, NSError, nint, bool, NSURL> completion);

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
	[Verify (MethodToProperty)]
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
	[Verify (MethodToProperty)]
	bool LocationServicesEnabled { get; }
}

// @protocol ABKURLDelegate <NSObject>
[Protocol, Model (AutoGeneratedName = true)]
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
	[MacCatalyst (14,0), iOS (10,0)]
	[Static]
	[Export ("isAppboyUserNotification:")]
	bool IsAppboyUserNotification (UNNotificationResponse response);

	// +(BOOL)isAppboyRemoteNotification:(NSDictionary * _Nonnull)userInfo;
	[Static]
	[Export ("isAppboyRemoteNotification:")]
	bool IsAppboyRemoteNotification (NSDictionary userInfo);

	// +(BOOL)isAppboyInternalRemoteNotification:(NSDictionary * _Nonnull)userInfo;
	[Static]
	[Export ("isAppboyInternalRemoteNotification:")]
	bool IsAppboyInternalRemoteNotification (NSDictionary userInfo);

	// +(BOOL)isUninstallTrackingUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(maccatalyst, introduced=14.0)));
	[MacCatalyst (14,0), iOS (10,0)]
	[Static]
	[Export ("isUninstallTrackingUserNotification:")]
	bool IsUninstallTrackingUserNotification (UNNotificationResponse response);

	// +(BOOL)isUninstallTrackingRemoteNotification:(NSDictionary * _Nonnull)userInfo;
	[Static]
	[Export ("isUninstallTrackingRemoteNotification:")]
	bool IsUninstallTrackingRemoteNotification (NSDictionary userInfo);

	// +(BOOL)isGeofencesSyncUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(maccatalyst, introduced=14.0)));
	[MacCatalyst (14,0), iOS (10,0)]
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

	// +(NSSet<UNNotificationCategory *> * _Nonnull)getAppboyUNNotificationCategorySet __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(maccatalyst, introduced=14.0)));
	[MacCatalyst (14, 0), iOS (10, 0)]
	[Static]
	[Export ("getAppboyUNNotificationCategorySet")]
	[Verify (MethodToProperty)]
	NSSet<UNNotificationCategory> AppboyUNNotificationCategorySet { get; }

	// +(NSSet<UIUserNotificationCategory *> * _Nonnull)getAppboyUIUserNotificationCategorySet __attribute__((deprecated("Please use `getAppboyUNNotificationCategorySet` instead.")));
	[Static]
	[Export ("getAppboyUIUserNotificationCategorySet")]
	[Verify (MethodToProperty)]
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
	[Verify (MethodToProperty)]
	string NoConnectionLocalizedString { get; }
}

// @protocol ABKBaseContentCardCellDelegate <NSObject>
[Protocol, Model (AutoGeneratedName = true)]
[BaseType (typeof(NSObject))]
interface ABKBaseContentCardCellDelegate
{
	// @required -(void)cellRequestSizeUpdate:(UITableViewCell *)cell;
	[Abstract]
	[Export ("cellRequestSizeUpdate:")]
	void CellRequestSizeUpdate (UITableViewCell cell);
}

// @interface ABKBaseContentCardCell : UITableViewCell
[BaseType (typeof(UITableViewCell))]
interface ABKBaseContentCardCell
{
	// @property (nonatomic) UIView * rootView __attribute__((iboutlet));
	[Export ("rootView", ArgumentSemantic.Assign)]
	UIView RootView { get; set; }

	// @property (nonatomic) UIImageView * pinImageView __attribute__((iboutlet));
	[Export ("pinImageView", ArgumentSemantic.Assign)]
	UIImageView PinImageView { get; set; }

	// @property (nonatomic) UIView * unviewedLineView __attribute__((iboutlet));
	[Export ("unviewedLineView", ArgumentSemantic.Assign)]
	UIView UnviewedLineView { get; set; }

	// @property (nonatomic) UIColor * unviewedLineViewColor;
	[Export ("unviewedLineViewColor", ArgumentSemantic.Assign)]
	UIColor UnviewedLineViewColor { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewLeadingConstraint __attribute__((iboutlet));
	[Export ("rootViewLeadingConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewLeadingConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewTrailingConstraint __attribute__((iboutlet));
	[Export ("rootViewTrailingConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewTrailingConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewTopConstraint __attribute__((iboutlet));
	[Export ("rootViewTopConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewTopConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewBottomConstraint __attribute__((iboutlet));
	[Export ("rootViewBottomConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewBottomConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * cardWidthConstraint __attribute__((iboutlet));
	[Export ("cardWidthConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint CardWidthConstraint { get; set; }

	// @property (assign, nonatomic) CGFloat cardSidePadding;
	[Export ("cardSidePadding")]
	nfloat CardSidePadding { get; set; }

	// @property (assign, nonatomic) CGFloat cardSpacing;
	[Export ("cardSpacing")]
	nfloat CardSpacing { get; set; }

	// @property (assign, nonatomic) BOOL hideUnreadIndicator;
	[Export ("hideUnreadIndicator")]
	bool HideUnreadIndicator { get; set; }

	[Wrap ("WeakDelegate")]
	ABKBaseContentCardCellDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<ABKBaseContentCardCellDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(void)applyCard:(ABKContentCard *)card;
	[Export ("applyCard:")]
	void ApplyCard (ABKContentCard card);

	// -(UIImage *)getPlaceHolderImage;
	[Export ("getPlaceHolderImage")]
	[Verify (MethodToProperty)]
	UIImage PlaceHolderImage { get; }

	// -(Class)imageViewClass;
	[Export ("imageViewClass")]
	[Verify (MethodToProperty)]
	Class ImageViewClass { get; }

	// -(void)setUp;
	[Export ("setUp")]
	void SetUp ();

	// -(void)setUpUI;
	[Export ("setUpUI")]
	void SetUpUI ();

	// -(void)applyAppboyAttributedTextStyleFrom:(NSString *)text forLabel:(UILabel *)label;
	[Export ("applyAppboyAttributedTextStyleFrom:forLabel:")]
	void ApplyAppboyAttributedTextStyleFrom (string text, UILabel label);
}

// @interface ABKContentCardsTableViewController : UITableViewController
[BaseType (typeof(UITableViewController))]
interface ABKContentCardsTableViewController
{
	// @property (nonatomic, strong) UIView * emptyFeedView __attribute__((iboutlet));
	[Export ("emptyFeedView", ArgumentSemantic.Strong)]
	UIView EmptyFeedView { get; set; }

	// @property (nonatomic, strong) UILabel * emptyFeedLabel __attribute__((iboutlet));
	[Export ("emptyFeedLabel", ArgumentSemantic.Strong)]
	UILabel EmptyFeedLabel { get; set; }

	[Wrap ("WeakDelegate")]
	ABKContentCardsTableViewControllerDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<ABKContentCardsTableViewControllerDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic) NSMutableArray<ABKContentCard *> * cards;
	[Export ("cards", ArgumentSemantic.Assign)]
	NSMutableArray<ABKContentCard> Cards { get; set; }

	// @property (assign, nonatomic) BOOL disableUnreadIndicator;
	[Export ("disableUnreadIndicator")]
	bool DisableUnreadIndicator { get; set; }

	// @property NSTimeInterval cacheTimeout;
	[Export ("cacheTimeout")]
	double CacheTimeout { get; set; }

	// @property (assign, nonatomic) CGFloat maxContentCardWidth;
	[Export ("maxContentCardWidth")]
	nfloat MaxContentCardWidth { get; set; }

	// @property (assign, nonatomic) BOOL enableDarkTheme;
	[Export ("enableDarkTheme")]
	bool EnableDarkTheme { get; set; }

	// +(instancetype)getNavigationContentCardsViewController;
	[Static]
	[Export ("getNavigationContentCardsViewController")]
	ABKContentCardsTableViewController GetNavigationContentCardsViewController ();

	// -(NSString *)localizedAppboyContentCardsString:(NSString *)key;
	[Export ("localizedAppboyContentCardsString:")]
	string LocalizedAppboyContentCardsString (string key);

	// -(void)setUp;
	[Export ("setUp")]
	void SetUp ();

	// -(void)setUpUI;
	[Export ("setUpUI")]
	void SetUpUI ();

	// -(void)setUpEmptyFeedLabel;
	[Export ("setUpEmptyFeedLabel")]
	void SetUpEmptyFeedLabel ();

	// -(void)setUpEmptyFeedView;
	[Export ("setUpEmptyFeedView")]
	void SetUpEmptyFeedView ();

	// -(void)registerTableViewCellClasses;
	[Export ("registerTableViewCellClasses")]
	void RegisterTableViewCellClasses ();

	// -(NSString *)findCellIdentifierWithCard:(ABKContentCard *)card;
	[Export ("findCellIdentifierWithCard:")]
	string FindCellIdentifierWithCard (ABKContentCard card);

	// -(ABKBaseContentCardCell *)dequeueCellFromTableView:(UITableView *)tableView forIndexPath:(NSIndexPath *)indexPath forCard:(ABKContentCard *)card;
	[Export ("dequeueCellFromTableView:forIndexPath:forCard:")]
	ABKBaseContentCardCell DequeueCellFromTableView (UITableView tableView, NSIndexPath indexPath, ABKContentCard card);

	// -(void)handleCardClick:(ABKContentCard *)card;
	[Export ("handleCardClick:")]
	void HandleCardClick (ABKContentCard card);

	// -(void)requestNewCardsIfTimeout;
	[Export ("requestNewCardsIfTimeout")]
	void RequestNewCardsIfTimeout ();

	// -(void)populateContentCards;
	[Export ("populateContentCards")]
	void PopulateContentCards ();
}

// @protocol ABKContentCardsTableViewControllerDelegate <NSObject>
[Protocol, Model (AutoGeneratedName = true)]
[BaseType (typeof(NSObject))]
interface ABKContentCardsTableViewControllerDelegate
{
	// @optional -(BOOL)contentCardTableViewController:(ABKContentCardsTableViewController *)viewController shouldHandleCardClick:(NSURL *)url;
	[Export ("contentCardTableViewController:shouldHandleCardClick:")]
	bool ContentCardTableViewController (ABKContentCardsTableViewController viewController, NSUrl url);

	// @optional -(void)contentCardTableViewController:(ABKContentCardsTableViewController *)viewController didHandleCardClick:(NSURL *)url;
	[Export ("contentCardTableViewController:didHandleCardClick:")]
	void ContentCardTableViewController (ABKContentCardsTableViewController viewController, NSUrl url);
}

// @interface ABKContentCardsViewController : UINavigationController
[BaseType (typeof(UINavigationController))]
interface ABKContentCardsViewController
{
	// @property (nonatomic, strong) ABKContentCardsTableViewController * contentCardsViewController;
	[Export ("contentCardsViewController", ArgumentSemantic.Strong)]
	ABKContentCardsTableViewController ContentCardsViewController { get; set; }
}

// @interface ABKBannerContentCardCell : ABKBaseContentCardCell
[BaseType (typeof(ABKBaseContentCardCell))]
interface ABKBannerContentCardCell
{
	// @property (nonatomic, strong) UIImageView * bannerImageView __attribute__((iboutlet));
	[Export ("bannerImageView", ArgumentSemantic.Strong)]
	UIImageView BannerImageView { get; set; }

	// @property (nonatomic, strong) NSLayoutConstraint * imageRatioConstraint __attribute__((iboutlet));
	[Export ("imageRatioConstraint", ArgumentSemantic.Strong)]
	NSLayoutConstraint ImageRatioConstraint { get; set; }

	// -(void)applyCard:(ABKBannerContentCard *)bannerCard;
	[Export ("applyCard:")]
	void ApplyCard (ABKBannerContentCard bannerCard);
}

// @interface ABKCaptionedImageContentCardCell : ABKBaseContentCardCell
[BaseType (typeof(ABKBaseContentCardCell))]
interface ABKCaptionedImageContentCardCell
{
	// @property (nonatomic, class) UIColor * titleLabelColor;
	[Static]
	[Export ("titleLabelColor", ArgumentSemantic.Assign)]
	UIColor TitleLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * descriptionLabelColor;
	[Static]
	[Export ("descriptionLabelColor", ArgumentSemantic.Assign)]
	UIColor DescriptionLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * linkLabelColor;
	[Static]
	[Export ("linkLabelColor", ArgumentSemantic.Assign)]
	UIColor LinkLabelColor { get; set; }

	// @property (nonatomic, strong) UIImageView * captionedImageView __attribute__((iboutlet));
	[Export ("captionedImageView", ArgumentSemantic.Strong)]
	UIImageView CaptionedImageView { get; set; }

	// @property (nonatomic, strong) NSLayoutConstraint * imageRatioConstraint __attribute__((iboutlet));
	[Export ("imageRatioConstraint", ArgumentSemantic.Strong)]
	NSLayoutConstraint ImageRatioConstraint { get; set; }

	// @property (nonatomic, strong) UILabel * titleLabel __attribute__((iboutlet));
	[Export ("titleLabel", ArgumentSemantic.Strong)]
	UILabel TitleLabel { get; set; }

	// @property (nonatomic, strong) UILabel * descriptionLabel __attribute__((iboutlet));
	[Export ("descriptionLabel", ArgumentSemantic.Strong)]
	UILabel DescriptionLabel { get; set; }

	// @property (nonatomic, strong) UILabel * linkLabel __attribute__((iboutlet));
	[Export ("linkLabel", ArgumentSemantic.Strong)]
	UILabel LinkLabel { get; set; }

	// -(void)applyCard:(ABKCaptionedImageContentCard *)captionedImageCard;
	[Export ("applyCard:")]
	void ApplyCard (ABKCaptionedImageContentCard captionedImageCard);
}

// @interface ABKClassicContentCardCell : ABKBaseContentCardCell
[BaseType (typeof(ABKBaseContentCardCell))]
interface ABKClassicContentCardCell
{
	// @property (nonatomic, class) UIColor * titleLabelColor;
	[Static]
	[Export ("titleLabelColor", ArgumentSemantic.Assign)]
	UIColor TitleLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * descriptionLabelColor;
	[Static]
	[Export ("descriptionLabelColor", ArgumentSemantic.Assign)]
	UIColor DescriptionLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * linkLabelColor;
	[Static]
	[Export ("linkLabelColor", ArgumentSemantic.Assign)]
	UIColor LinkLabelColor { get; set; }

	// @property (nonatomic, strong) UILabel * titleLabel __attribute__((iboutlet));
	[Export ("titleLabel", ArgumentSemantic.Strong)]
	UILabel TitleLabel { get; set; }

	// @property (nonatomic, strong) UILabel * descriptionLabel __attribute__((iboutlet));
	[Export ("descriptionLabel", ArgumentSemantic.Strong)]
	UILabel DescriptionLabel { get; set; }

	// @property (nonatomic, strong) UILabel * linkLabel __attribute__((iboutlet));
	[Export ("linkLabel", ArgumentSemantic.Strong)]
	UILabel LinkLabel { get; set; }

	// @property (nonatomic, strong) NSArray * descriptionConstraints;
	[Export ("descriptionConstraints", ArgumentSemantic.Strong)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] DescriptionConstraints { get; set; }

	// @property (nonatomic, strong) NSArray * linkConstraints;
	[Export ("linkConstraints", ArgumentSemantic.Strong)]
	[Verify (StronglyTypedNSArray)]
	NSObject[] LinkConstraints { get; set; }

	// @property (assign, nonatomic) CGFloat padding;
	[Export ("padding")]
	nfloat Padding { get; set; }

	// -(void)applyCard:(ABKClassicContentCard *)classicCard;
	[Export ("applyCard:")]
	void ApplyCard (ABKClassicContentCard classicCard);
}

// @interface ABKContentCardsWebViewController : UIViewController <WKNavigationDelegate>
[BaseType (typeof(UIViewController))]
interface ABKContentCardsWebViewController : IWKNavigationDelegate
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

	// @property (nonatomic) BOOL showDoneButton;
	[Export ("showDoneButton")]
	bool ShowDoneButton { get; set; }
}

// @interface ABKClassicImageContentCardCell : ABKClassicContentCardCell
[BaseType (typeof(ABKClassicContentCardCell))]
interface ABKClassicImageContentCardCell
{
	// @property (nonatomic, strong) UIImageView * classicImageView __attribute__((iboutlet));
	[Export ("classicImageView", ArgumentSemantic.Strong)]
	UIImageView ClassicImageView { get; set; }

	// -(void)applyCard:(ABKClassicContentCard *)classicCard;
	[Export ("applyCard:")]
	void ApplyCard (ABKClassicContentCard classicCard);
}

// @interface ABKControlTableViewCell : ABKBaseContentCardCell
[BaseType (typeof(ABKBaseContentCardCell))]
interface ABKControlTableViewCell
{
}

// @interface ABKSDWebImageImageDelegate : NSObject <ABKImageDelegate>
[BaseType (typeof(NSObject))]
interface ABKSDWebImageImageDelegate : IABKImageDelegate
{
}

// @interface ABKUIURLUtils : NSObject
[BaseType (typeof(NSObject))]
interface ABKUIURLUtils
{
	// +(BOOL)URLDelegate:(id<ABKURLDelegate>)urlDelegate handlesURL:(NSURL *)url fromChannel:(ABKChannel)channel withExtras:(NSDictionary *)extras;
	[Static]
	[Export ("URLDelegate:handlesURL:fromChannel:withExtras:")]
	bool URLDelegate (ABKURLDelegate urlDelegate, NSUrl url, ABKChannel channel, NSDictionary extras);

	// +(BOOL)URL:(NSURL *)url shouldOpenInWebView:(BOOL)openUrlInWebView;
	[Static]
	[Export ("URL:shouldOpenInWebView:")]
	bool URL (NSUrl url, bool openUrlInWebView);

	// +(BOOL)URLHasSystemScheme:(NSURL *)url;
	[Static]
	[Export ("URLHasSystemScheme:")]
	bool URLHasSystemScheme (NSUrl url);

	// +(void)openURLWithSystem:(NSURL *)url;
	[Static]
	[Export ("openURLWithSystem:")]
	void OpenURLWithSystem (NSUrl url);

	// +(UIViewController *)topmostViewControllerWithRootViewController:(UIViewController *)viewController;
	[Static]
	[Export ("topmostViewControllerWithRootViewController:")]
	UIViewController TopmostViewControllerWithRootViewController (UIViewController viewController);

	// +(void)displayModalWebViewWithURL:(NSURL *)url topmostViewController:(UIViewController *)topmostViewController;
	[Static]
	[Export ("displayModalWebViewWithURL:topmostViewController:")]
	void DisplayModalWebViewWithURL (NSUrl url, UIViewController topmostViewController);

	// +(NSURL *)getEncodedURIFromString:(NSString *)uriString;
	[Static]
	[Export ("getEncodedURIFromString:")]
	NSUrl GetEncodedURIFromString (string uriString);
}

// @interface ABKUIUtils : NSObject
[BaseType (typeof(NSObject))]
interface ABKUIUtils
{
	// @property (readonly, nonatomic, class) UIWindowScene * activeWindowScene __attribute__((availability(ios, introduced=13.0)));
	[iOS (13, 0)]
	[Static]
	[Export ("activeWindowScene")]
	UIWindowScene ActiveWindowScene { get; }

	// @property (readonly, nonatomic, class) UIWindow * activeApplicationWindow;
	[Static]
	[Export ("activeApplicationWindow")]
	UIWindow ActiveApplicationWindow { get; }

	// @property (readonly, nonatomic, class) UIViewController * activeApplicationViewController;
	[Static]
	[Export ("activeApplicationViewController")]
	UIViewController ActiveApplicationViewController { get; }

	// @property (readonly, class) BOOL applicationStatusBarHidden;
	[Static]
	[Export ("applicationStatusBarHidden")]
	bool ApplicationStatusBarHidden { get; }

	// @property (readonly, class) UIStatusBarStyle applicationStatusBarStyle;
	[Static]
	[Export ("applicationStatusBarStyle")]
	UIStatusBarStyle ApplicationStatusBarStyle { get; }

	// +(NSBundle *)bundle:(Class)bundleClass channel:(ABKChannel)channel;
	[Static]
	[Export ("bundle:channel:")]
	NSBundle Bundle (Class bundleClass, ABKChannel channel);

	// +(UIImage *)imageNamed:(NSString *)name bundle:(Class)bundleClass channel:(ABKChannel)channel;
	[Static]
	[Export ("imageNamed:bundle:channel:")]
	UIImage ImageNamed (string name, Class bundleClass, ABKChannel channel);

	// +(NSString *)getLocalizedString:(NSString *)key inAppboyBundle:(NSBundle *)appboyBundle table:(NSString *)table;
	[Static]
	[Export ("getLocalizedString:inAppboyBundle:table:")]
	string GetLocalizedString (string key, NSBundle appboyBundle, string table);

	// +(BOOL)objectIsValidAndNotEmpty:(id)object;
	[Static]
	[Export ("objectIsValidAndNotEmpty:")]
	bool ObjectIsValidAndNotEmpty (NSObject @object);

	// +(Class)getModalFeedViewControllerClass;
	[Static]
	[Export ("getModalFeedViewControllerClass")]
	[Verify (MethodToProperty)]
	Class ModalFeedViewControllerClass { get; }

	// +(BOOL)isNotchedPhone;
	[Static]
	[Export ("isNotchedPhone")]
	[Verify (MethodToProperty)]
	bool IsNotchedPhone { get; }

	// +(UIInterfaceOrientation)getInterfaceOrientation;
	[Static]
	[Export ("getInterfaceOrientation")]
	[Verify (MethodToProperty)]
	UIInterfaceOrientation InterfaceOrientation { get; }

	// +(CGSize)getStatusBarSize;
	[Static]
	[Export ("getStatusBarSize")]
	[Verify (MethodToProperty)]
	CGSize StatusBarSize { get; }

	// +(UIColor *)dynamicColorForLightColor:(UIColor *)lightColor darkColor:(UIColor *)darkColor;
	[Static]
	[Export ("dynamicColorForLightColor:darkColor:")]
	UIColor DynamicColorForLightColor (UIColor lightColor, UIColor darkColor);

	// +(BOOL)string:(NSString *)string1 isEqualToString:(NSString *)string2;
	[Static]
	[Export ("string:isEqualToString:")]
	bool String (string string1, string string2);

	// +(BOOL)responderChainOf:(UIResponder *)responder hasKindOfClass:(Class)aClass;
	[Static]
	[Export ("responderChainOf:hasKindOfClass:")]
	bool ResponderChainOf (UIResponder responder, Class aClass);

	// +(BOOL)responderChainOf:(UIResponder *)responder hasClassPrefixedWith:(NSString *)prefix;
	[Static]
	[Export ("responderChainOf:hasClassPrefixedWith:")]
	bool ResponderChainOf (UIResponder responder, string prefix);

	// +(UIFont *)preferredFontForTextStyle:(UIFontTextStyle)textStyle weight:(UIFontWeight)weight;
	[Static]
	[Export ("preferredFontForTextStyle:weight:")]
	UIFont PreferredFontForTextStyle (string textStyle, double weight);

	// +(void)enableAdjustsFontForContentSizeCategory:(id)label;
	[Static]
	[Export ("enableAdjustsFontForContentSizeCategory:")]
	void EnableAdjustsFontForContentSizeCategory (NSObject label);
}

// @interface ABKInAppMessageUIButton : UIButton
[BaseType (typeof(UIButton))]
interface ABKInAppMessageUIButton
{
	// @property ABKInAppMessageButton * _Nonnull inAppButtonModel;
	[Export ("inAppButtonModel", ArgumentSemantic.Assign)]
	ABKInAppMessageButton InAppButtonModel { get; set; }
}

// @interface ABKInAppMessageViewController : UIViewController
[BaseType (typeof(UIViewController))]
interface ABKInAppMessageViewController
{
	// @property (strong) ABKInAppMessage * _Nonnull inAppMessage;
	[Export ("inAppMessage", ArgumentSemantic.Strong)]
	ABKInAppMessage InAppMessage { get; set; }

	// @property (nonatomic, weak) UIImageView * _Nullable iconImageView __attribute__((iboutlet));
	[NullAllowed, Export ("iconImageView", ArgumentSemantic.Weak)]
	UIImageView IconImageView { get; set; }

	// @property (nonatomic, weak) UILabel * _Nullable iconLabelView __attribute__((iboutlet));
	[NullAllowed, Export ("iconLabelView", ArgumentSemantic.Weak)]
	UILabel IconLabelView { get; set; }

	// @property (nonatomic, weak) UILabel * _Nullable inAppMessageMessageLabel __attribute__((iboutlet));
	[NullAllowed, Export ("inAppMessageMessageLabel", ArgumentSemantic.Weak)]
	UILabel InAppMessageMessageLabel { get; set; }

	// @property BOOL isiPad;
	[Export ("isiPad")]
	bool IsiPad { get; set; }

	// -(instancetype _Nonnull)initWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
	[Export ("initWithInAppMessage:")]
	NativeHandle Constructor (ABKInAppMessage inAppMessage);

	// -(void)hideInAppMessage:(BOOL)animated;
	[Export ("hideInAppMessage:")]
	void HideInAppMessage (bool animated);

	// -(void)beforeMoveInAppMessageViewOffScreen;
	[Export ("beforeMoveInAppMessageViewOffScreen")]
	void BeforeMoveInAppMessageViewOffScreen ();

	// -(void)moveInAppMessageViewOffScreen;
	[Export ("moveInAppMessageViewOffScreen")]
	void MoveInAppMessageViewOffScreen ();

	// -(void)beforeMoveInAppMessageViewOnScreen;
	[Export ("beforeMoveInAppMessageViewOnScreen")]
	void BeforeMoveInAppMessageViewOnScreen ();

	// -(void)moveInAppMessageViewOnScreen;
	[Export ("moveInAppMessageViewOnScreen")]
	void MoveInAppMessageViewOnScreen ();

	// -(BOOL)applyImageToImageView:(UIImageView * _Nonnull)iconImageView;
	[Export ("applyImageToImageView:")]
	bool ApplyImageToImageView (UIImageView iconImageView);

	// -(BOOL)applyIconToLabelView:(UILabel * _Nonnull)iconLabelView;
	[Export ("applyIconToLabelView:")]
	bool ApplyIconToLabelView (UILabel iconLabelView);
}

// @protocol ABKInAppMessageUIDelegate <NSObject>
[Protocol, Model (AutoGeneratedName = true)]
[BaseType (typeof(NSObject))]
interface ABKInAppMessageUIDelegate
{
	// @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage * _Nonnull)inAppMessage withKeyboardIsUp:(BOOL)keyboardIsUp __attribute__((deprecated("")));
	[Export ("beforeInAppMessageDisplayed:withKeyboardIsUp:")]
	ABKInAppMessageDisplayChoice BeforeInAppMessageDisplayed (ABKInAppMessage inAppMessage, bool keyboardIsUp);

	// @optional -(ABKInAppMessageViewController * _Nullable)inAppMessageViewControllerWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
	[Export ("inAppMessageViewControllerWithInAppMessage:")]
	[return: NullAllowed]
	ABKInAppMessageViewController InAppMessageViewControllerWithInAppMessage (ABKInAppMessage inAppMessage);

	// @optional -(void)onInAppMessageDismissed:(ABKInAppMessage * _Nonnull)inAppMessage;
	[Export ("onInAppMessageDismissed:")]
	void OnInAppMessageDismissed (ABKInAppMessage inAppMessage);

	// @optional -(BOOL)onInAppMessageClicked:(ABKInAppMessage * _Nonnull)inAppMessage;
	[Export ("onInAppMessageClicked:")]
	bool OnInAppMessageClicked (ABKInAppMessage inAppMessage);

	// @optional -(BOOL)onInAppMessageButtonClicked:(ABKInAppMessageImmersive * _Nonnull)inAppMessage button:(ABKInAppMessageButton * _Nonnull)button;
	[Export ("onInAppMessageButtonClicked:button:")]
	bool OnInAppMessageButtonClicked (ABKInAppMessageImmersive inAppMessage, ABKInAppMessageButton button);

	// @optional -(BOOL)onInAppMessageHTMLButtonClicked:(ABKInAppMessageHTMLBase * _Nonnull)inAppMessage clickedURL:(NSURL * _Nullable)clickedURL buttonID:(NSString * _Nonnull)buttonId;
	[Export ("onInAppMessageHTMLButtonClicked:clickedURL:buttonID:")]
	bool OnInAppMessageHTMLButtonClicked (ABKInAppMessageHTMLBase inAppMessage, [NullAllowed] NSUrl clickedURL, string buttonId);

	// @optional -(WKWebViewConfiguration * _Nonnull)setCustomWKWebViewConfiguration;
	[Export ("setCustomWKWebViewConfiguration")]
	[Verify (MethodToProperty)]
	WKWebViewConfiguration SetCustomWKWebViewConfiguration { get; }
}

// @interface ABKInAppMessageWindow : UIWindow
[BaseType (typeof(UIWindow))]
interface ABKInAppMessageWindow
{
	// @property (nonatomic) BOOL handleAllTouchEvents;
	[Export ("handleAllTouchEvents")]
	bool HandleAllTouchEvents { get; set; }
}

// @interface ABKInAppMessageWindowController : UIViewController <UIGestureRecognizerDelegate>
[BaseType (typeof(UIViewController))]
interface ABKInAppMessageWindowController : IUIGestureRecognizerDelegate
{
	// @property (nonatomic) ABKInAppMessageWindow * _Nullable inAppMessageWindow __attribute__((iboutlet));
	[NullAllowed, Export ("inAppMessageWindow", ArgumentSemantic.Assign)]
	ABKInAppMessageWindow InAppMessageWindow { get; set; }

	// @property NSTimer * _Nullable slideAwayTimer;
	[NullAllowed, Export ("slideAwayTimer", ArgumentSemantic.Assign)]
	NSTimer SlideAwayTimer { get; set; }

	// @property ABKInAppMessage * _Nonnull inAppMessage;
	[Export ("inAppMessage", ArgumentSemantic.Assign)]
	ABKInAppMessage InAppMessage { get; set; }

	[Wrap ("WeakInAppMessageUIDelegate")]
	[NullAllowed]
	ABKInAppMessageUIDelegate InAppMessageUIDelegate { get; set; }

	// @property (weak) id<ABKInAppMessageUIDelegate> _Nullable inAppMessageUIDelegate;
	[NullAllowed, Export ("inAppMessageUIDelegate", ArgumentSemantic.Weak)]
	NSObject WeakInAppMessageUIDelegate { get; set; }

	// @property ABKInAppMessageViewController * _Nonnull inAppMessageViewController;
	[Export ("inAppMessageViewController", ArgumentSemantic.Assign)]
	ABKInAppMessageViewController InAppMessageViewController { get; set; }

	// @property CGFloat slideupConstraintMaxValue;
	[Export ("slideupConstraintMaxValue")]
	nfloat SlideupConstraintMaxValue { get; set; }

	// @property CGPoint inAppMessagePreviousPanPosition;
	[Export ("inAppMessagePreviousPanPosition", ArgumentSemantic.Assign)]
	CGPoint InAppMessagePreviousPanPosition { get; set; }

	// @property UIInterfaceOrientationMask supportedOrientationMask;
	[Export ("supportedOrientationMask", ArgumentSemantic.Assign)]
	UIInterfaceOrientationMask SupportedOrientationMask { get; set; }

	// @property UIInterfaceOrientation preferredOrientation;
	[Export ("preferredOrientation", ArgumentSemantic.Assign)]
	UIInterfaceOrientation PreferredOrientation { get; set; }

	// @property BOOL isInRotation;
	[Export ("isInRotation")]
	bool IsInRotation { get; set; }

	// @property BOOL inAppMessageIsTapped;
	[Export ("inAppMessageIsTapped")]
	bool InAppMessageIsTapped { get; set; }

	// @property NSInteger clickedButtonId;
	[Export ("clickedButtonId")]
	nint ClickedButtonId { get; set; }

	// @property NSString * _Nullable clickedHTMLButtonId;
	[NullAllowed, Export ("clickedHTMLButtonId")]
	string ClickedHTMLButtonId { get; set; }

	// -(instancetype _Nonnull)initWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage inAppMessageViewController:(ABKInAppMessageViewController * _Nonnull)inAppMessageViewController inAppMessageDelegate:(id<ABKInAppMessageUIDelegate> _Nonnull)delegate;
	[Export ("initWithInAppMessage:inAppMessageViewController:inAppMessageDelegate:")]
	NativeHandle Constructor (ABKInAppMessage inAppMessage, ABKInAppMessageViewController inAppMessageViewController, ABKInAppMessageUIDelegate @delegate);

	// -(void)keyboardWasShown;
	[Export ("keyboardWasShown")]
	void KeyboardWasShown ();

	// -(void)displayInAppMessageViewWithAnimation:(BOOL)withAnimation;
	[Export ("displayInAppMessageViewWithAnimation:")]
	void DisplayInAppMessageViewWithAnimation (bool withAnimation);

	// -(void)hideInAppMessageViewWithAnimation:(BOOL)withAnimation;
	[Export ("hideInAppMessageViewWithAnimation:")]
	void HideInAppMessageViewWithAnimation (bool withAnimation);

	// -(void)hideInAppMessageViewWithAnimation:(BOOL)withAnimation completionHandler:(void (^ _Nullable)(void))completionHandler;
	[Export ("hideInAppMessageViewWithAnimation:completionHandler:")]
	void HideInAppMessageViewWithAnimation (bool withAnimation, [NullAllowed] Action completionHandler);

	// -(void)inAppMessageClickedWithActionType:(ABKInAppMessageClickActionType)actionType URL:(NSURL * _Nullable)url openURLInWebView:(BOOL)openUrlInWebView;
	[Export ("inAppMessageClickedWithActionType:URL:openURLInWebView:")]
	void InAppMessageClickedWithActionType (ABKInAppMessageClickActionType actionType, [NullAllowed] NSUrl url, bool openUrlInWebView);
}

// @interface ABKInAppMessageUIController : NSObject <ABKInAppMessageUIControlling>
[BaseType (typeof(NSObject))]
interface ABKInAppMessageUIController : IABKInAppMessageUIControlling
{
	// @property UIInterfaceOrientationMask supportedOrientationMask;
	[Export ("supportedOrientationMask", ArgumentSemantic.Assign)]
	UIInterfaceOrientationMask SupportedOrientationMask { get; set; }

	// @property UIInterfaceOrientation preferredOrientation;
	[Export ("preferredOrientation", ArgumentSemantic.Assign)]
	UIInterfaceOrientation PreferredOrientation { get; set; }

	// @property BOOL keyboardVisible;
	[Export ("keyboardVisible")]
	bool KeyboardVisible { get; set; }

	// @property ABKInAppMessageWindowController * _Nullable inAppMessageWindowController;
	[NullAllowed, Export ("inAppMessageWindowController", ArgumentSemantic.Assign)]
	ABKInAppMessageWindowController InAppMessageWindowController { get; set; }

	[Wrap ("WeakUiDelegate")]
	[NullAllowed]
	ABKInAppMessageUIDelegate UiDelegate { get; set; }

	// @property (weak) id<ABKInAppMessageUIDelegate> _Nullable uiDelegate;
	[NullAllowed, Export ("uiDelegate", ArgumentSemantic.Weak)]
	NSObject WeakUiDelegate { get; set; }
}

// @interface ABKInAppMessageView : UIView
[BaseType (typeof(UIView))]
interface ABKInAppMessageView
{
}

// @interface ABKInAppMessageImmersiveViewController : ABKInAppMessageViewController
[BaseType (typeof(ABKInAppMessageViewController))]
interface ABKInAppMessageImmersiveViewController
{
	// @property (nonatomic, weak) UILabel * _Nullable inAppMessageHeaderLabel __attribute__((iboutlet));
	[NullAllowed, Export ("inAppMessageHeaderLabel", ArgumentSemantic.Weak)]
	UILabel InAppMessageHeaderLabel { get; set; }

	// @property (nonatomic, weak) UIImageView * _Nullable graphicImageView __attribute__((iboutlet));
	[NullAllowed, Export ("graphicImageView", ArgumentSemantic.Weak)]
	UIImageView GraphicImageView { get; set; }

	// @property (nonatomic) NSLayoutConstraint * _Nonnull headerBodySpaceConstraint __attribute__((iboutlet));
	[Export ("headerBodySpaceConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint HeaderBodySpaceConstraint { get; set; }

	// @property (retain, nonatomic) ABKInAppMessageUIButton * _Nullable leftInAppMessageButton __attribute__((iboutlet));
	[NullAllowed, Export ("leftInAppMessageButton", ArgumentSemantic.Retain)]
	ABKInAppMessageUIButton LeftInAppMessageButton { get; set; }

	// @property (retain, nonatomic) ABKInAppMessageUIButton * _Nullable rightInAppMessageButton __attribute__((iboutlet));
	[NullAllowed, Export ("rightInAppMessageButton", ArgumentSemantic.Retain)]
	ABKInAppMessageUIButton RightInAppMessageButton { get; set; }

	// @property (nonatomic) UIScrollView * _Nullable textsView __attribute__((iboutlet));
	[NullAllowed, Export ("textsView", ArgumentSemantic.Assign)]
	UIScrollView TextsView { get; set; }

	// -(void)setupLayoutForGraphic;
	[Export ("setupLayoutForGraphic")]
	void SetupLayoutForGraphic ();

	// -(void)setupLayoutForTopImage;
	[Export ("setupLayoutForTopImage")]
	void SetupLayoutForTopImage ();

	// -(void)changeCloseButtonColor;
	[Export ("changeCloseButtonColor")]
	void ChangeCloseButtonColor ();

	// -(void)dismissInAppMessage:(id _Nonnull)sender __attribute__((ibaction));
	[Export ("dismissInAppMessage:")]
	void DismissInAppMessage (NSObject sender);

	// -(void)buttonClicked:(ABKInAppMessageUIButton * _Nonnull)button __attribute__((ibaction));
	[Export ("buttonClicked:")]
	void ButtonClicked (ABKInAppMessageUIButton button);
}

// @interface ABKInAppMessageFullViewController : ABKInAppMessageImmersiveViewController
[BaseType (typeof(ABKInAppMessageImmersiveViewController))]
interface ABKInAppMessageFullViewController
{
	// @property (nonatomic, weak) NSLayoutConstraint * _Nullable closeXButtonTopConstraint __attribute__((iboutlet));
	[NullAllowed, Export ("closeXButtonTopConstraint", ArgumentSemantic.Weak)]
	NSLayoutConstraint CloseXButtonTopConstraint { get; set; }
}

// @interface ABKInAppMessageHTMLBaseViewController : ABKInAppMessageViewController <WKNavigationDelegate, WKUIDelegate>
[BaseType (typeof(ABKInAppMessageViewController))]
interface ABKInAppMessageHTMLBaseViewController : IWKNavigationDelegate, IWKUIDelegate
{
	// @property (nonatomic) WKWebView * _Nonnull webView;
	[Export ("webView", ArgumentSemantic.Assign)]
	WKWebView WebView { get; set; }

	// @property (nonatomic, weak) NSLayoutConstraint * _Nullable topConstraint __attribute__((iboutlet));
	[NullAllowed, Export ("topConstraint", ArgumentSemantic.Weak)]
	NSLayoutConstraint TopConstraint { get; set; }

	// @property (nonatomic, weak) NSLayoutConstraint * _Nullable bottomConstraint __attribute__((iboutlet));
	[NullAllowed, Export ("bottomConstraint", ArgumentSemantic.Weak)]
	NSLayoutConstraint BottomConstraint { get; set; }

	// @property (readonly, assign, nonatomic) BOOL automaticBodyClicksEnabled;
	[Export ("automaticBodyClicksEnabled")]
	bool AutomaticBodyClicksEnabled { get; }
}

// @interface ABKInAppMessageHTMLFullViewController : ABKInAppMessageHTMLBaseViewController
[BaseType (typeof(ABKInAppMessageHTMLBaseViewController))]
interface ABKInAppMessageHTMLFullViewController
{
}

// @interface ABKInAppMessageHTMLViewController : ABKInAppMessageHTMLBaseViewController
[BaseType (typeof(ABKInAppMessageHTMLBaseViewController))]
interface ABKInAppMessageHTMLViewController
{
}

// @interface ABKInAppMessageModalViewController : ABKInAppMessageImmersiveViewController
[BaseType (typeof(ABKInAppMessageImmersiveViewController))]
interface ABKInAppMessageModalViewController
{
	// @property (assign, nonatomic) BOOL enableDismissOnOutsideTap;
	[Export ("enableDismissOnOutsideTap")]
	bool EnableDismissOnOutsideTap { get; set; }

	// @property (retain, nonatomic) NSLayoutConstraint * _Nonnull iconImageHeightConstraint __attribute__((iboutlet));
	[Export ("iconImageHeightConstraint", ArgumentSemantic.Retain)]
	NSLayoutConstraint IconImageHeightConstraint { get; set; }

	// @property (retain, nonatomic) NSLayoutConstraint * _Nonnull textsViewWidthConstraint __attribute__((iboutlet));
	[Export ("textsViewWidthConstraint", ArgumentSemantic.Retain)]
	NSLayoutConstraint TextsViewWidthConstraint { get; set; }

	// @property (nonatomic, strong) UIView * _Nonnull iconImageContainerView __attribute__((iboutlet));
	[Export ("iconImageContainerView", ArgumentSemantic.Strong)]
	UIView IconImageContainerView { get; set; }

	// @property (nonatomic, strong) UIView * _Nonnull graphicImageContainerView __attribute__((iboutlet));
	[Export ("graphicImageContainerView", ArgumentSemantic.Strong)]
	UIView GraphicImageContainerView { get; set; }
}

// @interface ABKInAppMessageSlideupViewController : ABKInAppMessageViewController
[BaseType (typeof(ABKInAppMessageViewController))]
interface ABKInAppMessageSlideupViewController
{
	// @property (nonatomic, weak) UIImageView * _Nullable arrowImage __attribute__((iboutlet));
	[NullAllowed, Export ("arrowImage", ArgumentSemantic.Weak)]
	UIImageView ArrowImage { get; set; }

	// @property (assign, nonatomic) CGFloat offset;
	[Export ("offset")]
	nfloat Offset { get; set; }
}

// @interface ABKFeedWebViewController : UIViewController <WKNavigationDelegate>
[BaseType (typeof(UIViewController))]
interface ABKFeedWebViewController : IWKNavigationDelegate
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

	// @property (nonatomic) BOOL showDoneButton;
	[Export ("showDoneButton")]
	bool ShowDoneButton { get; set; }
}

// @protocol ABKBaseNewsFeedCellDelegate <NSObject>
[Protocol, Model (AutoGeneratedName = true)]
[BaseType (typeof(NSObject))]
interface ABKBaseNewsFeedCellDelegate
{
	// @required -(void)refreshTableViewCellHeights;
	[Abstract]
	[Export ("refreshTableViewCellHeights")]
	void RefreshTableViewCellHeights ();
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern CGFloat ABKNFLabelHorizontalSpace;
	[Field ("ABKNFLabelHorizontalSpace", "__Internal")]
	nfloat ABKNFLabelHorizontalSpace { get; }

	// extern CGFloat ABKNFLabelVerticalSpace;
	[Field ("ABKNFLabelVerticalSpace", "__Internal")]
	nfloat ABKNFLabelVerticalSpace { get; }

	// extern CGFloat ABKNFTopSpace;
	[Field ("ABKNFTopSpace", "__Internal")]
	nfloat ABKNFTopSpace { get; }
}

// @interface ABKNFBaseCardCell : UITableViewCell
[BaseType (typeof(UITableViewCell))]
interface ABKNFBaseCardCell
{
	// +(UIColor *)ABKNFDescriptionLabelColor;
	[Static]
	[Export ("ABKNFDescriptionLabelColor")]
	[Verify (MethodToProperty)]
	UIColor ABKNFDescriptionLabelColor { get; }

	// +(UIColor *)ABKNFTitleLabelColor;
	[Static]
	[Export ("ABKNFTitleLabelColor")]
	[Verify (MethodToProperty)]
	UIColor ABKNFTitleLabelColor { get; }

	// +(UIColor *)ABKNFTitleLabelColorOnGray;
	[Static]
	[Export ("ABKNFTitleLabelColorOnGray")]
	[Verify (MethodToProperty)]
	UIColor ABKNFTitleLabelColorOnGray { get; }

	// @property (nonatomic) UIView * rootView __attribute__((iboutlet));
	[Export ("rootView", ArgumentSemantic.Assign)]
	UIView RootView { get; set; }

	// @property (nonatomic) UIImageView * unreadIndicatorView __attribute__((iboutlet));
	[Export ("unreadIndicatorView", ArgumentSemantic.Assign)]
	UIImageView UnreadIndicatorView { get; set; }

	[Wrap ("WeakDelegate")]
	ABKBaseNewsFeedCellDelegate Delegate { get; set; }

	// @property (nonatomic) id<ABKBaseNewsFeedCellDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewLeadingConstraint __attribute__((iboutlet));
	[Export ("rootViewLeadingConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewLeadingConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewTrailingConstraint __attribute__((iboutlet));
	[Export ("rootViewTrailingConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewTrailingConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewTopConstraint __attribute__((iboutlet));
	[Export ("rootViewTopConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewTopConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * rootViewBottomConstraint __attribute__((iboutlet));
	[Export ("rootViewBottomConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint RootViewBottomConstraint { get; set; }

	// @property CGFloat cardSidePadding;
	[Export ("cardSidePadding")]
	nfloat CardSidePadding { get; set; }

	// @property CGFloat cardSpacing;
	[Export ("cardSpacing")]
	nfloat CardSpacing { get; set; }

	// @property (nonatomic) BOOL hideUnreadIndicator;
	[Export ("hideUnreadIndicator")]
	bool HideUnreadIndicator { get; set; }

	// -(void)setUp;
	[Export ("setUp")]
	void SetUp ();

	// -(void)setUpUI;
	[Export ("setUpUI")]
	void SetUpUI ();

	// -(void)setUpRootView;
	[Export ("setUpRootView")]
	void SetUpRootView ();

	// -(void)setUpRootViewBorder;
	[Export ("setUpRootViewBorder")]
	void SetUpRootViewBorder ();

	// -(void)setUpUnreadIndicatorView;
	[Export ("setUpUnreadIndicatorView")]
	void SetUpUnreadIndicatorView ();

	// -(void)applyCard:(ABKCard *)card;
	[Export ("applyCard:")]
	void ApplyCard (ABKCard card);

	// -(UIImage *)getPlaceHolderImage;
	[Export ("getPlaceHolderImage")]
	[Verify (MethodToProperty)]
	UIImage PlaceHolderImage { get; }

	// -(Class)imageViewClass;
	[Export ("imageViewClass")]
	[Verify (MethodToProperty)]
	Class ImageViewClass { get; }
}

// @interface ABKNewsFeedTableViewController : UITableViewController <ABKBaseNewsFeedCellDelegate>
[BaseType (typeof(UITableViewController))]
interface ABKNewsFeedTableViewController : IABKBaseNewsFeedCellDelegate
{
	// -(void)setUp;
	[Export ("setUp")]
	void SetUp ();

	// -(void)setUpUI;
	[Export ("setUpUI")]
	void SetUpUI ();

	// -(void)registerTableViewCellClasses;
	[Export ("registerTableViewCellClasses")]
	void RegisterTableViewCellClasses ();

	// -(ABKNFBaseCardCell *)dequeueCellFromTableView:(UITableView *)tableView forIndexPath:(NSIndexPath *)indexPath forCard:(ABKCard *)card;
	[Export ("dequeueCellFromTableView:forIndexPath:forCard:")]
	ABKNFBaseCardCell DequeueCellFromTableView (UITableView tableView, NSIndexPath indexPath, ABKCard card);

	// @property (nonatomic) UIView * emptyFeedView __attribute__((iboutlet));
	[Export ("emptyFeedView", ArgumentSemantic.Assign)]
	UIView EmptyFeedView { get; set; }

	// @property (nonatomic) UILabel * emptyFeedLabel __attribute__((iboutlet));
	[Export ("emptyFeedLabel", ArgumentSemantic.Assign)]
	UILabel EmptyFeedLabel { get; set; }

	// @property (nonatomic) BOOL disableUnreadIndicator;
	[Export ("disableUnreadIndicator")]
	bool DisableUnreadIndicator { get; set; }

	// @property (nonatomic) ABKCardCategory categories;
	[Export ("categories", ArgumentSemantic.Assign)]
	ABKCardCategory Categories { get; set; }

	// @property (nonatomic) NSArray<ABKCard *> * cards;
	[Export ("cards", ArgumentSemantic.Assign)]
	ABKCard[] Cards { get; set; }

	// @property (nonatomic) NSMutableSet<NSString *> * cardImpressions;
	[Export ("cardImpressions", ArgumentSemantic.Assign)]
	NSMutableSet<NSString> CardImpressions { get; set; }

	// @property NSTimeInterval cacheTimeout;
	[Export ("cacheTimeout")]
	double CacheTimeout { get; set; }

	// @property id constraintWarningValue;
	[Export ("constraintWarningValue", ArgumentSemantic.Assign)]
	NSObject ConstraintWarningValue { get; set; }

	// +(instancetype)getNavigationFeedViewController;
	[Static]
	[Export ("getNavigationFeedViewController")]
	ABKNewsFeedTableViewController GetNavigationFeedViewController ();

	// -(NSString *)findCellIdentifierWithCard:(ABKCard *)card;
	[Export ("findCellIdentifierWithCard:")]
	string FindCellIdentifierWithCard (ABKCard card);

	// -(NSString *)localizedAppboyFeedString:(NSString *)key;
	[Export ("localizedAppboyFeedString:")]
	string LocalizedAppboyFeedString (string key);

	// -(void)handleCardClick:(ABKCard *)card;
	[Export ("handleCardClick:")]
	void HandleCardClick (ABKCard card);
}

// @interface ABKNewsFeedViewController : UINavigationController
[BaseType (typeof(UINavigationController))]
interface ABKNewsFeedViewController
{
	// @property (nonatomic) ABKNewsFeedTableViewController * newsFeed;
	[Export ("newsFeed", ArgumentSemantic.Assign)]
	ABKNewsFeedTableViewController NewsFeed { get; set; }
}

// @interface ABKNFBannerCardCell : ABKNFBaseCardCell
[BaseType (typeof(ABKNFBaseCardCell))]
interface ABKNFBannerCardCell
{
	// @property (nonatomic) UIImageView * bannerImageView __attribute__((iboutlet));
	[Export ("bannerImageView", ArgumentSemantic.Assign)]
	UIImageView BannerImageView { get; set; }

	// @property (nonatomic) NSLayoutConstraint * imageRatioConstraint __attribute__((iboutlet));
	[Export ("imageRatioConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint ImageRatioConstraint { get; set; }

	// -(void)setUpBannerImageView;
	[Export ("setUpBannerImageView")]
	void SetUpBannerImageView ();

	// -(void)applyCard:(ABKCard *)bannerCard;
	[Export ("applyCard:")]
	void ApplyCard (ABKCard bannerCard);
}

// @interface ABKNFCaptionedMessageCardCell : ABKNFBaseCardCell
[BaseType (typeof(ABKNFBaseCardCell))]
interface ABKNFCaptionedMessageCardCell
{
	// @property (nonatomic, class) UIColor * titleLabelColor;
	[Static]
	[Export ("titleLabelColor", ArgumentSemantic.Assign)]
	UIColor TitleLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * descriptionLabelColor;
	[Static]
	[Export ("descriptionLabelColor", ArgumentSemantic.Assign)]
	UIColor DescriptionLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * linkLabelColor;
	[Static]
	[Export ("linkLabelColor", ArgumentSemantic.Assign)]
	UIColor LinkLabelColor { get; set; }

	// @property (nonatomic) UIImageView * captionedImageView __attribute__((iboutlet));
	[Export ("captionedImageView", ArgumentSemantic.Assign)]
	UIImageView CaptionedImageView { get; set; }

	// @property (nonatomic) UILabel * titleLabel __attribute__((iboutlet));
	[Export ("titleLabel", ArgumentSemantic.Assign)]
	UILabel TitleLabel { get; set; }

	// @property (nonatomic) UILabel * descriptionLabel __attribute__((iboutlet));
	[Export ("descriptionLabel", ArgumentSemantic.Assign)]
	UILabel DescriptionLabel { get; set; }

	// @property (nonatomic) UIView * titleBackgroundView __attribute__((iboutlet));
	[Export ("titleBackgroundView", ArgumentSemantic.Assign)]
	UIView TitleBackgroundView { get; set; }

	// @property (nonatomic) UILabel * linkLabel __attribute__((iboutlet));
	[Export ("linkLabel", ArgumentSemantic.Assign)]
	UILabel LinkLabel { get; set; }

	// @property (nonatomic) NSLayoutConstraint * imageHeightConstraint __attribute__((iboutlet));
	[Export ("imageHeightConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint ImageHeightConstraint { get; set; }

	// @property (nonatomic) NSLayoutConstraint * bodyAndLinkConstraint __attribute__((iboutlet));
	[Export ("bodyAndLinkConstraint", ArgumentSemantic.Assign)]
	NSLayoutConstraint BodyAndLinkConstraint { get; set; }

	// -(void)setUpTitleBackgroundView;
	[Export ("setUpTitleBackgroundView")]
	void SetUpTitleBackgroundView ();

	// -(void)setUpTitleLabel;
	[Export ("setUpTitleLabel")]
	void SetUpTitleLabel ();

	// -(void)setUpDescriptionLabel;
	[Export ("setUpDescriptionLabel")]
	void SetUpDescriptionLabel ();

	// -(void)setUpLinkLabel;
	[Export ("setUpLinkLabel")]
	void SetUpLinkLabel ();

	// -(void)setUpCaptionedImageView;
	[Export ("setUpCaptionedImageView")]
	void SetUpCaptionedImageView ();

	// -(void)setUpFonts;
	[Export ("setUpFonts")]
	void SetUpFonts ();

	// -(void)hideLinkLabel:(BOOL)hide;
	[Export ("hideLinkLabel:")]
	void HideLinkLabel (bool hide);

	// -(void)applyCard:(ABKCaptionedImageCard *)captionedImageCard;
	[Export ("applyCard:")]
	void ApplyCard (ABKCaptionedImageCard captionedImageCard);
}

// @interface ABKNFClassicCardCell : ABKNFBaseCardCell
[BaseType (typeof(ABKNFBaseCardCell))]
interface ABKNFClassicCardCell
{
	// @property (nonatomic, class) UIColor * titleLabelColor;
	[Static]
	[Export ("titleLabelColor", ArgumentSemantic.Assign)]
	UIColor TitleLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * descriptionLabelColor;
	[Static]
	[Export ("descriptionLabelColor", ArgumentSemantic.Assign)]
	UIColor DescriptionLabelColor { get; set; }

	// @property (nonatomic, class) UIColor * linkLabelColor;
	[Static]
	[Export ("linkLabelColor", ArgumentSemantic.Assign)]
	UIColor LinkLabelColor { get; set; }

	// @property (nonatomic) UIImageView * classicImageView __attribute__((iboutlet));
	[Export ("classicImageView", ArgumentSemantic.Assign)]
	UIImageView ClassicImageView { get; set; }

	// @property (nonatomic) UILabel * titleLabel __attribute__((iboutlet));
	[Export ("titleLabel", ArgumentSemantic.Assign)]
	UILabel TitleLabel { get; set; }

	// @property (nonatomic) UILabel * descriptionLabel __attribute__((iboutlet));
	[Export ("descriptionLabel", ArgumentSemantic.Assign)]
	UILabel DescriptionLabel { get; set; }

	// @property (nonatomic) UILabel * linkLabel __attribute__((iboutlet));
	[Export ("linkLabel", ArgumentSemantic.Assign)]
	UILabel LinkLabel { get; set; }

	// -(void)setUpClassicImageView;
	[Export ("setUpClassicImageView")]
	void SetUpClassicImageView ();

	// -(void)setUpTitleLabel;
	[Export ("setUpTitleLabel")]
	void SetUpTitleLabel ();

	// -(void)setUpDescriptionLabel;
	[Export ("setUpDescriptionLabel")]
	void SetUpDescriptionLabel ();

	// -(void)setUpLinkLabel;
	[Export ("setUpLinkLabel")]
	void SetUpLinkLabel ();

	// -(void)setUpFonts;
	[Export ("setUpFonts")]
	void SetUpFonts ();

	// -(void)applyCard:(ABKClassicCard *)classicCard;
	[Export ("applyCard:")]
	void ApplyCard (ABKClassicCard classicCard);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double Appboy_iOS_SDKVersionNumber;
	[Field ("Appboy_iOS_SDKVersionNumber", "__Internal")]
	double Appboy_iOS_SDKVersionNumber { get; }

	// extern const unsigned char[] Appboy_iOS_SDKVersionString;
	[Field ("Appboy_iOS_SDKVersionString", "__Internal")]
	byte[] Appboy_iOS_SDKVersionString { get; }
}
