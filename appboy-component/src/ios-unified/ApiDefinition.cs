using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace AppboyPlatformXamariniOSBinding
{
	[Static]
	interface Constants
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

		// extern NSString *const _Nonnull ABKInAppMessageControllerDelegateKey;
		[Field ("ABKInAppMessageControllerDelegateKey", "__Internal")]
		NSString ABKInAppMessageControllerDelegateKey { get; }

		// extern NSString *const _Nonnull ABKSessionTimeoutKey;
		[Field ("ABKSessionTimeoutKey", "__Internal")]
		NSString ABKSessionTimeoutKey { get; }

		// extern NSString *const _Nonnull ABKMinimumTriggerTimeIntervalKey;
		[Field ("ABKMinimumTriggerTimeIntervalKey", "__Internal")]
		NSString ABKMinimumTriggerTimeIntervalKey { get; }

		// extern NSString *const _Nonnull ABKSDKFlavorKey;
		[Field ("ABKSDKFlavorKey", "__Internal")]
		NSString ABKSDKFlavorKey { get; }

		// extern NSString *const _Nonnull ABKDeviceWhitelistKey;
		[Field ("ABKDeviceWhitelistKey", "__Internal")]
		NSString ABKDeviceWhitelistKey { get; }

		// extern NSString *const _Nonnull ABKPushStoryAppGroupKey;
		[Field ("ABKPushStoryAppGroupKey", "__Internal")]
		NSString ABKPushStoryAppGroupKey { get; }

		// extern NSString *const _Nonnull ABKContentCardsProcessedNotification;
		[Field("ABKContentCardsProcessedNotification", "__Internal")]
		NSString ABKContentCardsProcessedNotification { get; }

		// extern NSString *const _Nonnull ABKContentCardsProcessedIsSuccessfulKey;
		[Field("ABKContentCardsProcessedIsSuccessfulKey", "__Internal")]
		NSString ABKContentCardsProcessedIsSuccessfulKey { get; }

		// extern const NSInteger DefaultNumberOfFriends;
		[Field("DefaultNumberOfFriends", "__Internal")]
		nint DefaultNumberOfFriends { get; }
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

		// @property (nonatomic) ABKSDKFlavor sdkFlavor;
		[Export ("sdkFlavor", ArgumentSemantic.Assign)]
		ABKSDKFlavor SdkFlavor { get; set; }

		// -(void)flushDataAndProcessRequestQueue;
		[Export ("flushDataAndProcessRequestQueue")]
		void FlushDataAndProcessRequestQueue ();

		// -(void)shutdownServerCommunication;
		[Export ("shutdownServerCommunication")]
		void ShutdownServerCommunication ();

		// -(void)changeUser:(NSString * _Nonnull)userId;
		[Export ("changeUser:")]
		void ChangeUser (string userId);

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

		// -(BOOL)userNotificationWasSentFromAppboy:(UNNotificationResponse * _Nonnull)response __attribute__((deprecated("Use [ABKPushUtils isAppboyUserNotification:] instead."))) __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Export ("userNotificationWasSentFromAppboy:")]
		bool UserNotificationWasSentFromAppboy (UNNotificationResponse response);

		// -(BOOL)pushNotificationWasSentFromAppboy:(NSDictionary * _Nonnull)options __attribute__((deprecated("Use [ABKPushUtils isAppboyRemoteNotification:] instead.")));
		[Export ("pushNotificationWasSentFromAppboy:")]
		bool PushNotificationWasSentFromAppboy (NSDictionary options);

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
		void RegisterApplicationWithFetchCompletionHandler (UIApplication application, NSDictionary notification, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

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

		// @property (readonly, copy, nonatomic) NSString * _Nonnull userID;
		[Export ("userID")]
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

	// @interface ABKFacebookUser : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKFacebookUser
	{
		// -(instancetype _Nonnull)initWithFacebookUserDictionary:(NSDictionary * _Nullable)facebookUserDictionary numberOfFriends:(NSInteger)numberOfFriends likes:(NSArray * _Nullable)likes;
		[Export ("initWithFacebookUserDictionary:numberOfFriends:likes:")]
		IntPtr Constructor ([NullAllowed] NSDictionary facebookUserDictionary, nint numberOfFriends, [NullAllowed] NSObject[] likes);

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
		IntPtr Constructor ([NullAllowed] string network, [NullAllowed] string campaign, [NullAllowed] string adGroup, [NullAllowed] string creative);

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

	// @interface ABKFeedController : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKFeedController
	{
		// extern NSString *const _Nonnull ABKFeedUpdatedNotification;
		[Field ("ABKFeedUpdatedNotification", "__Internal")]
		NSString ABKFeedUpdatedNotification { get; }

		// extern NSString *const _Nonnull ABKFeedUpdatedIsSuccessfulKey;
		[Field ("ABKFeedUpdatedIsSuccessfulKey", "__Internal")]
		NSString ABKFeedUpdatedIsSuccessfulKey { get; }
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

		// @property (readonly, copy) NSUrl * _Nullable uri;
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

		// @property (copy) NSUrl * _Nullable imageURI;
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

		// -(void)setInAppMessageClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSUrl * _Nullable)uri;
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
		// @property (nonatomic, strong) NSUrl * _Nonnull assetsLocalDirectoryPath;
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
		// @property (nonatomic, strong) NSUrl * _Nullable assetsZipRemoteUrl;
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
		ABKInAppMessageUIController InAppMessageUIController { get; set; }

		// -(void)displayNextInAppMessageWithDelegate:(id<ABKInAppMessageControllerDelegate> _Nullable)delegate;
		[Export ("displayNextInAppMessageWithDelegate:")]
		void DisplayNextInAppMessageWithDelegate ([NullAllowed] ABKInAppMessageControllerDelegate @delegate);

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

		// @property (readonly, copy) NSUrl * _Nullable buttonClickedURI;
		[NullAllowed, Export ("buttonClickedURI", ArgumentSemantic.Copy)]
		NSUrl ButtonClickedURI { get; }

		// @property BOOL buttonOpenUrlInWebView;
		[Export ("buttonOpenUrlInWebView")]
		bool ButtonOpenUrlInWebView { get; set; }

		// @property (readonly) NSInteger buttonID;
		[Export ("buttonID")]
		nint ButtonID { get; }

		// -(void)setButtonClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSUrl * _Nullable)uri;
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
		IntPtr Constructor (WKWebView webView, ABKInAppMessageHTML inAppMessage, Appboy appboy);
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
		IntPtr Constructor (NSDictionary<NSString, NSString> darkThemeFields);

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
		IntPtr Constructor (NSDictionary darkButtonFields);
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
	[Protocol, Model (AutoGeneratedName = true)]
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
		// +(void)setImageForView:(UIImageView * _Nonnull)imageView showActivityIndicator:(BOOL)showActivityIndicator withURL:(NSUrl * _Nullable)imageURL imagePlaceHolder:(UIImage * _Nullable)placeHolder completed:(void (^ _Nullable)(UIImage * _Nullable, NSError * _Nullable, NSInteger, NSUrl * _Nullable))completion;
		[Static]
		[Export ("setImageForView:showActivityIndicator:withURL:imagePlaceHolder:completed:")]
		void SetImageForView (UIImageView imageView, bool showActivityIndicator, [NullAllowed] NSUrl imageURL, [NullAllowed] UIImage placeHolder, [NullAllowed] Action<UIImage, NSError, nint, NSUrl> completion);

		// +(void)prefetchURLs:(NSArray * _Nullable)imageURLs;
		[Static]
		[Export ("prefetchURLs:")]
		void PrefetchURLs ([NullAllowed] NSObject[] imageURLs);

		// +(void)loadImageWithURL:(NSUrl * _Nullable)url options:(NSInteger)options completed:(void (^ _Nullable)(UIImage * _Nonnull, NSData * _Nonnull, NSError * _Nonnull, NSInteger, BOOL, NSUrl * _Nonnull))completion;
		[Static]
		[Export ("loadImageWithURL:options:completed:")]
		void LoadImageWithURL ([NullAllowed] NSUrl url, nint options, [NullAllowed] Action<UIImage, NSData, NSError, nint, bool, NSUrl> completion);

		// +(void)diskImageExistsForURL:(NSUrl * _Nullable)url completed:(void (^ _Nullable)(BOOL))completion;
		[Static]
		[Export ("diskImageExistsForURL:completed:")]
		void DiskImageExistsForURL ([NullAllowed] NSUrl url, [NullAllowed] Action<bool> completion);

		// +(NSString * _Nullable)cacheKeyForURL:(NSUrl * _Nullable)url;
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
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface ABKURLDelegate
	{
		// @required -(BOOL)handleAppboyURL:(NSUrl * _Nonnull)url fromChannel:(ABKChannel)channel withExtras:(NSDictionary * _Nonnull)extras;
		[Abstract]
		[Export ("handleAppboyURL:fromChannel:withExtras:")]
		bool FromChannel (NSUrl url, ABKChannel channel, NSDictionary extras);
	}

	// @interface ABKPushUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKPushUtils
	{
		// +(BOOL)isAppboyUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
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

		// +(BOOL)isUninstallTrackingUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Static]
		[Export ("isUninstallTrackingUserNotification:")]
		bool IsUninstallTrackingUserNotification (UNNotificationResponse response);

		// +(BOOL)isUninstallTrackingRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("isUninstallTrackingRemoteNotification:")]
		bool IsUninstallTrackingRemoteNotification (NSDictionary userInfo);

		// +(BOOL)isGeofencesSyncUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0)));
		[iOS (10,0)]
		[Static]
		[Export ("isGeofencesSyncUserNotification:")]
		bool IsGeofencesSyncUserNotification (UNNotificationResponse response);

		// +(BOOL)isGeofencesSyncRemoteNotification:(NSDictionary * _Nonnull)userInfo;
		[Static]
		[Export ("isGeofencesSyncRemoteNotification:")]
		bool IsGeofencesSyncRemoteNotification (NSDictionary userInfo);

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

		// +(NSSet<UNNotificationCategory *> * _Nonnull)getAppboyUNNotificationCategorySet __attribute__((availability(ios, introduced=10.0)));
		[iOS (10, 0)]
		[Static]
		[Export ("getAppboyUNNotificationCategorySet")]
		NSSet<UNNotificationCategory> AppboyUNNotificationCategorySet { get; }

		// +(NSSet<UIUserNotificationCategory *> * _Nonnull)getAppboyUIUserNotificationCategorySet __attribute__((deprecated("")));
		[Static]
		[Export ("getAppboyUIUserNotificationCategorySet")]
		NSSet<UIUserNotificationCategory> AppboyUIUserNotificationCategorySet { get; }
	}

	// @protocol ABKBaseContentCardCellDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface ABKBaseContentCardCellDelegate
	{
		// @required -(void)refreshTableViewCellHeights;
		[Abstract]
		[Export ("refreshTableViewCellHeights")]
		void RefreshTableViewCellHeights ();
	}

	// @interface ABKBaseContentCardCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface ABKBaseContentCardCell
	{
		// @property (nonatomic, weak) UIView * rootView __attribute__((iboutlet));
		[Export ("rootView", ArgumentSemantic.Weak)]
		UIView RootView { get; set; }

		// @property (nonatomic, weak) UIImageView * pinImageView __attribute__((iboutlet));
		[Export ("pinImageView", ArgumentSemantic.Weak)]
		UIImageView PinImageView { get; set; }

		// @property (nonatomic, weak) UIView * unviewedLineView __attribute__((iboutlet));
		[Export ("unviewedLineView", ArgumentSemantic.Weak)]
		UIView UnviewedLineView { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewLeadingConstraint __attribute__((iboutlet));
		[Export ("rootViewLeadingConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint RootViewLeadingConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewTrailingConstraint __attribute__((iboutlet));
		[Export ("rootViewTrailingConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint RootViewTrailingConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewTopConstraint __attribute__((iboutlet));
		[Export ("rootViewTopConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint RootViewTopConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewBottomConstraint __attribute__((iboutlet));
		[Export ("rootViewBottomConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint RootViewBottomConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * cardWidthConstraint __attribute__((iboutlet));
		[Export ("cardWidthConstraint", ArgumentSemantic.Weak)]
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
		UIImage PlaceHolderImage { get; }

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

		// @property (nonatomic, weak) UILabel * emptyFeedLabel __attribute__((iboutlet));
		[Export ("emptyFeedLabel", ArgumentSemantic.Weak)]
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

		// +(ABKBaseContentCardCell *)dequeueCellFromTableView:(UITableView *)tableView forIndexPath:(NSIndexPath *)indexPath forCard:(ABKContentCard *)card;
		[Static]
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
		// @optional -(BOOL)contentCardTableViewController:(ABKContentCardsTableViewController *)viewController shouldHandleCardClick:(NSUrl *)url;
		[Export ("contentCardTableViewController:shouldHandleCardClick:")]
		bool ShouldHandleCardClick (ABKContentCardsTableViewController viewController, NSUrl url);

		// @optional -(void)contentCardTableViewController:(ABKContentCardsTableViewController *)viewController didHandleCardClick:(NSUrl *)url;
		[Export ("contentCardTableViewController:didHandleCardClick:")]
		void DidHandleCardClick (ABKContentCardsTableViewController viewController, NSUrl url);
	}

	// @interface ABKContentCardsViewController : UINavigationController
	[BaseType (typeof(UINavigationController))]
	interface ABKContentCardsViewController
	{
		// @property (nonatomic, weak) ABKContentCardsTableViewController * contentCardsViewController;
		[Export ("contentCardsViewController", ArgumentSemantic.Weak)]
		ABKContentCardsTableViewController ContentCardsViewController { get; set; }
	}

	// @interface ABKBannerContentCardCell : ABKBaseContentCardCell
	[BaseType (typeof(ABKBaseContentCardCell))]
	interface ABKBannerContentCardCell
	{
    //// @property (nonatomic, weak) SDAnimatedImageView * bannerImageView __attribute__((iboutlet));
    //[Export("bannerImageView", ArgumentSemantic.Weak)]
    //SDAnimatedImageView BannerImageView { get; set; }

    // @property (nonatomic, weak) NSLayoutConstraint * imageRatioConstraint __attribute__((iboutlet));
    [Export ("imageRatioConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint ImageRatioConstraint { get; set; }

		// -(void)applyCard:(ABKBannerContentCard *)bannerCard;
		[Export ("applyCard:")]
		void ApplyCard (ABKBannerContentCard bannerCard);

		// -(void)updateImageConstraintsWithRatio:(CGFloat)newRatio;
		[Export ("updateImageConstraintsWithRatio:")]
		void UpdateImageConstraintsWithRatio (nfloat newRatio);
	}

	// @interface ABKCaptionedImageContentCardCell : ABKBaseContentCardCell
	[BaseType (typeof(ABKBaseContentCardCell))]
	interface ABKCaptionedImageContentCardCell
	{
		//// @property (nonatomic, weak) SDAnimatedImageView * captionedImageView __attribute__((iboutlet));
		//[Export ("captionedImageView", ArgumentSemantic.Weak)]
		//SDAnimatedImageView CaptionedImageView { get; set; }

		// @property (nonatomic, weak) UILabel * titleLabel __attribute__((iboutlet));
		[Export ("titleLabel", ArgumentSemantic.Weak)]
		UILabel TitleLabel { get; set; }

		// @property (nonatomic, weak) UILabel * descriptionLabel __attribute__((iboutlet));
		[Export ("descriptionLabel", ArgumentSemantic.Weak)]
		UILabel DescriptionLabel { get; set; }

		// @property (nonatomic, weak) UIView * TitleBackgroundView __attribute__((iboutlet));
		[Export ("TitleBackgroundView", ArgumentSemantic.Weak)]
		UIView TitleBackgroundView { get; set; }

		// @property (nonatomic, weak) UILabel * linkLabel __attribute__((iboutlet));
		[Export ("linkLabel", ArgumentSemantic.Weak)]
		UILabel LinkLabel { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * imageHeightContraint __attribute__((iboutlet));
		[Export ("imageHeightContraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint ImageHeightContraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * descriptionBottomConstraint __attribute__((iboutlet));
		[Export ("descriptionBottomConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint DescriptionBottomConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * linkBottomConstraint __attribute__((iboutlet));
		[Export ("linkBottomConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint LinkBottomConstraint { get; set; }

		// -(void)hideLinkLabel:(BOOL)hide;
		[Export ("hideLinkLabel:")]
		void HideLinkLabel (bool hide);

		// -(void)updateImageConstraintsWithNewConstant:(CGFloat)newConstant;
		[Export ("updateImageConstraintsWithNewConstant:")]
		void UpdateImageConstraintsWithNewConstant (nfloat newConstant);

		// -(void)applyCard:(ABKCaptionedImageContentCard *)captionedImageCard;
		[Export ("applyCard:")]
		void ApplyCard (ABKCaptionedImageContentCard captionedImageCard);
	}

	// @interface ABKClassicContentCardCell : ABKBaseContentCardCell
	[BaseType (typeof(ABKBaseContentCardCell))]
	interface ABKClassicContentCardCell
	{
		// @property (nonatomic, weak) UILabel * titleLabel __attribute__((iboutlet));
		[Export ("titleLabel", ArgumentSemantic.Weak)]
		UILabel TitleLabel { get; set; }

		// @property (nonatomic, weak) UILabel * descriptionLabel __attribute__((iboutlet));
		[Export ("descriptionLabel", ArgumentSemantic.Weak)]
		UILabel DescriptionLabel { get; set; }

		// @property (nonatomic, weak) UILabel * linkLabel __attribute__((iboutlet));
		[Export ("linkLabel", ArgumentSemantic.Weak)]
		UILabel LinkLabel { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * descriptionBottomConstraint __attribute__((iboutlet));
		[Export ("descriptionBottomConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint DescriptionBottomConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * linkBottomConstraint __attribute__((iboutlet));
		[Export ("linkBottomConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint LinkBottomConstraint { get; set; }

		// -(void)hideLinkLabel:(BOOL)hide;
		[Export ("hideLinkLabel:")]
		void HideLinkLabel (bool hide);

		// -(void)applyCard:(ABKClassicContentCard *)classicCard;
		[Export ("applyCard:")]
		void ApplyCard (ABKClassicContentCard classicCard);
	}

	// @interface ABKContentCardsWebViewController : UIViewController <WKNavigationDelegate>
	[BaseType (typeof(UIViewController))]
	interface ABKContentCardsWebViewController : IWKNavigationDelegate
	{
		// @property NSUrl * url;
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
		//// @property (nonatomic, weak) SDAnimatedImageView * classicImageView __attribute__((iboutlet));
		//[Export ("classicImageView", ArgumentSemantic.Weak)]
		//SDAnimatedImageView ClassicImageView { get; set; }

		// -(void)applyCard:(ABKClassicContentCard *)classicCard;
		[Export ("applyCard:")]
		void ApplyCard (ABKClassicContentCard classicCard);
	}

	// @interface ABKUIURLUtils : NSObject
	[BaseType (typeof(NSObject))]
	interface ABKUIURLUtils
	{
		// +(BOOL)URLDelegate:(id<ABKURLDelegate>)urlDelegate handlesURL:(NSUrl *)url fromChannel:(ABKChannel)channel withExtras:(NSDictionary *)extras;
		[Static]
		[Export ("URLDelegate:handlesURL:fromChannel:withExtras:")]
		bool URLDelegate (ABKURLDelegate urlDelegate, NSUrl url, ABKChannel channel, NSDictionary extras);

		// +(BOOL)URL:(NSUrl *)url shouldOpenInWebView:(BOOL)openUrlInWebView;
		[Static]
		[Export ("URL:shouldOpenInWebView:")]
		bool URL (NSUrl url, bool openUrlInWebView);

		// +(void)openURLWithSystem:(NSUrl *)url;
		[Static]
		[Export ("openURLWithSystem:")]
		void OpenURLWithSystem (NSUrl url);

		// +(void)openURLWithSystem:(NSUrl *)url fromChannel:(ABKChannel)channel;
		[Static]
		[Export ("openURLWithSystem:fromChannel:")]
		void OpenURLWithSystem (NSUrl url, ABKChannel channel);

		// +(UIViewController *)topmostViewControllerWithRootViewController:(UIViewController *)viewController;
		[Static]
		[Export ("topmostViewControllerWithRootViewController:")]
		UIViewController TopmostViewControllerWithRootViewController (UIViewController viewController);

		// +(void)displayModalWebViewWithURL:(NSUrl *)url topmostViewController:(UIViewController *)topmostViewController;
		[Static]
		[Export ("displayModalWebViewWithURL:topmostViewController:")]
		void DisplayModalWebViewWithURL (NSUrl url, UIViewController topmostViewController);

		// +(NSUrl *)getEncodedURIFromString:(NSString *)uriString;
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

		// +(NSString *)getLocalizedString:(NSString *)key inAppboyBundle:(NSBundle *)appboyBundle table:(NSString *)table;
		[Static]
		[Export ("getLocalizedString:inAppboyBundle:table:")]
		string GetLocalizedString (string key, NSBundle appboyBundle, string table);

		// +(BOOL)objectIsValidAndNotEmpty:(id)object;
		[Static]
		[Export ("objectIsValidAndNotEmpty:")]
		bool ObjectIsValidAndNotEmpty (NSObject @object);

		// +(Class)getSDWebImageProxyClass;
		[Static]
		[Export ("getSDWebImageProxyClass")]
		Class SDWebImageProxyClass { get; }

		// +(Class)getModalFeedViewControllerClass;
		[Static]
		[Export ("getModalFeedViewControllerClass")]
		Class ModalFeedViewControllerClass { get; }

		// +(BOOL)isNotchedPhone;
		[Static]
		[Export ("isNotchedPhone")]
		bool IsNotchedPhone { get; }

		// +(UIImage *)getImageWithName:(NSString *)name type:(NSString *)type inAppboyBundle:(NSBundle *)appboyBundle;
		[Static]
		[Export ("getImageWithName:type:inAppboyBundle:")]
		UIImage GetImageWithName (string name, string type, NSBundle appboyBundle);

		// +(UIInterfaceOrientation)getInterfaceOrientation;
		[Static]
		[Export ("getInterfaceOrientation")]
		UIInterfaceOrientation InterfaceOrientation { get; }

		// +(CGSize)getStatusBarSize;
		[Static]
		[Export ("getStatusBarSize")]
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
	}

	// @interface ABKModalWebViewController : UINavigationController <WKNavigationDelegate>
	[BaseType (typeof(UINavigationController))]
	interface ABKModalWebViewController : IWKNavigationDelegate
	{
		// @property NSUrl * url;
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

		// @property (readonly, nonatomic) BOOL overrideApplicationStatusBarHiddenState;
		[Export ("overrideApplicationStatusBarHiddenState")]
		bool OverrideApplicationStatusBarHiddenState { get; }

		// -(instancetype _Nonnull)initWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
		[Export ("initWithInAppMessage:")]
		IntPtr Constructor (ABKInAppMessage inAppMessage);

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

		// @optional -(ABKInAppMessageViewController * _Nonnull)inAppMessageViewControllerWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
		[Export ("inAppMessageViewControllerWithInAppMessage:")]
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

		// @optional -(BOOL)onInAppMessageHTMLButtonClicked:(ABKInAppMessageHTMLBase * _Nonnull)inAppMessage clickedURL:(NSUrl * _Nullable)clickedURL buttonID:(NSString * _Nonnull)buttonId;
		[Export ("onInAppMessageHTMLButtonClicked:clickedURL:buttonID:")]
		bool OnInAppMessageHTMLButtonClicked (ABKInAppMessageHTMLBase inAppMessage, [NullAllowed] NSUrl clickedURL, string buttonId);

		// @optional -(WKWebViewConfiguration * _Nonnull)setCustomWKWebViewConfiguration;
		[Export ("setCustomWKWebViewConfiguration")]
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

		// @property (nonatomic, weak) DEPRECATED_MSG_ATTRIBUTE("appWindow is not used anymore.") UIWindow * appWindow __attribute__((deprecated("appWindow is not used anymore.")));
		[Export ("appWindow", ArgumentSemantic.Weak)]
		UIWindow AppWindow { get; set; }

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
		IntPtr Constructor (ABKInAppMessage inAppMessage, ABKInAppMessageViewController inAppMessageViewController, ABKInAppMessageUIDelegate @delegate);

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

		// -(void)inAppMessageClickedWithActionType:(ABKInAppMessageClickActionType)actionType URL:(NSUrl * _Nullable)url openURLInWebView:(BOOL)openUrlInWebView;
		[Export ("inAppMessageClickedWithActionType:URL:openURLInWebView:")]
		void InAppMessageClickedWithActionType (ABKInAppMessageClickActionType actionType, [NullAllowed] NSUrl url, bool openUrlInWebView);
	}

	// @interface ABKInAppMessageUIController : NSObject <ABKInAppMessageUIControlling>
	[BaseType (typeof(NSObject))]
	interface ABKInAppMessageUIController : ABKInAppMessageUIControlling
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

		// @property (nonatomic, weak) NSLayoutConstraint * _Nullable slideConstraint __attribute__((iboutlet));
		[NullAllowed, Export ("slideConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint SlideConstraint { get; set; }
	}

	// @interface ABKFeedWebViewController : UIViewController <WKNavigationDelegate>
	[BaseType (typeof(UIViewController))]
	interface ABKFeedWebViewController : IWKNavigationDelegate
	{
		// @property NSUrl * url;
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

	// @interface ABKNFBaseCardCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface ABKNFBaseCardCell
	{
		// @property (nonatomic, weak) UIView * rootView __attribute__((iboutlet));
		[Export ("rootView", ArgumentSemantic.Weak)]
		UIView RootView { get; set; }

		// @property (nonatomic, weak) UIImageView * unreadIndicatorView __attribute__((iboutlet));
		[Export ("unreadIndicatorView", ArgumentSemantic.Weak)]
		UIImageView UnreadIndicatorView { get; set; }

		[Wrap ("WeakDelegate")]
		ABKBaseNewsFeedCellDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ABKBaseNewsFeedCellDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewLeadingConstraint __attribute__((iboutlet));
		[Export ("rootViewLeadingConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint RootViewLeadingConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewTrailingConstraint __attribute__((iboutlet));
		[Export ("rootViewTrailingConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint RootViewTrailingConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewTopConstraint __attribute__((iboutlet));
		[Export ("rootViewTopConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint RootViewTopConstraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * rootViewBottomConstraint __attribute__((iboutlet));
		[Export ("rootViewBottomConstraint", ArgumentSemantic.Weak)]
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

		// +(ABKNFBaseCardCell *)dequeueCellFromTableView:(UITableView *)tableView forIndexPath:(NSIndexPath *)indexPath forCard:(ABKCard *)card;
		[Static]
		[Export ("dequeueCellFromTableView:forIndexPath:forCard:")]
		ABKNFBaseCardCell DequeueCellFromTableView (UITableView tableView, NSIndexPath indexPath, ABKCard card);

		// -(void)applyCard:(ABKCard *)card;
		[Export ("applyCard:")]
		void ApplyCard (ABKCard card);

		// -(UIImage *)getPlaceHolderImage;
		[Export ("getPlaceHolderImage")]
		UIImage PlaceHolderImage { get; }
	}

	// @interface ABKNewsFeedTableViewController : UITableViewController <ABKBaseNewsFeedCellDelegate>
	[BaseType (typeof(UITableViewController))]
	interface ABKNewsFeedTableViewController : ABKBaseNewsFeedCellDelegate
	{
		// @property (nonatomic, strong) UIView * emptyFeedView __attribute__((iboutlet));
		[Export ("emptyFeedView", ArgumentSemantic.Strong)]
		UIView EmptyFeedView { get; set; }

		// @property (nonatomic, unsafe_unretained) UILabel * emptyFeedLabel __attribute__((iboutlet));
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
		// @property (nonatomic, unsafe_unretained) ABKNewsFeedTableViewController * newsFeed;
		[Export ("newsFeed", ArgumentSemantic.Assign)]
		ABKNewsFeedTableViewController NewsFeed { get; set; }
	}

	// @interface ABKNFBannerCardCell : ABKNFBaseCardCell
	[BaseType (typeof(ABKNFBaseCardCell))]
	interface ABKNFBannerCardCell
	{
		//// @property (nonatomic, weak) SDAnimatedImageView * bannerImageView __attribute__((iboutlet));
		//[Export ("bannerImageView", ArgumentSemantic.Weak)]
		//SDAnimatedImageView BannerImageView { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * imageRatioConstraint __attribute__((iboutlet));
		[Export ("imageRatioConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint ImageRatioConstraint { get; set; }

		// -(void)applyCard:(ABKCard *)bannerCard;
		[Export ("applyCard:")]
		void ApplyCard (ABKCard bannerCard);
	}

	// @interface ABKNFCaptionedMessageCardCell : ABKNFBaseCardCell
	[BaseType (typeof(ABKNFBaseCardCell))]
	interface ABKNFCaptionedMessageCardCell
	{
		//// @property (nonatomic, weak) SDAnimatedImageView * captionedImageView __attribute__((iboutlet));
		//[Export ("captionedImageView", ArgumentSemantic.Weak)]
		//SDAnimatedImageView CaptionedImageView { get; set; }

		// @property (nonatomic, weak) UILabel * titleLabel __attribute__((iboutlet));
		[Export ("titleLabel", ArgumentSemantic.Weak)]
		UILabel TitleLabel { get; set; }

		// @property (nonatomic, weak) UILabel * descriptionLabel __attribute__((iboutlet));
		[Export ("descriptionLabel", ArgumentSemantic.Weak)]
		UILabel DescriptionLabel { get; set; }

		// @property (nonatomic, weak) UIView * TitleBackgroundView __attribute__((iboutlet));
		[Export ("TitleBackgroundView", ArgumentSemantic.Weak)]
		UIView TitleBackgroundView { get; set; }

		// @property (nonatomic, weak) UILabel * linkLabel __attribute__((iboutlet));
		[Export ("linkLabel", ArgumentSemantic.Weak)]
		UILabel LinkLabel { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * imageHeightContraint __attribute__((iboutlet));
		[Export ("imageHeightContraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint ImageHeightContraint { get; set; }

		// @property (nonatomic, weak) NSLayoutConstraint * bodyAndLinkConstraint __attribute__((iboutlet));
		[Export ("bodyAndLinkConstraint", ArgumentSemantic.Weak)]
		NSLayoutConstraint BodyAndLinkConstraint { get; set; }

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
		//// @property (nonatomic, weak) SDAnimatedImageView * classicImageView __attribute__((iboutlet));
		//[Export ("classicImageView", ArgumentSemantic.Weak)]
		//SDAnimatedImageView ClassicImageView { get; set; }

		// @property (nonatomic, weak) UILabel * titleLabel __attribute__((iboutlet));
		[Export ("titleLabel", ArgumentSemantic.Weak)]
		UILabel TitleLabel { get; set; }

		// @property (nonatomic, weak) UILabel * descriptionLabel __attribute__((iboutlet));
		[Export ("descriptionLabel", ArgumentSemantic.Weak)]
		UILabel DescriptionLabel { get; set; }

		// @property (nonatomic, weak) UILabel * linkLabel __attribute__((iboutlet));
		[Export ("linkLabel", ArgumentSemantic.Weak)]
		UILabel LinkLabel { get; set; }

		// -(void)applyCard:(ABKClassicCard *)classicCard;
		[Export ("applyCard:")]
		void ApplyCard (ABKClassicCard classicCard);
	}
}
