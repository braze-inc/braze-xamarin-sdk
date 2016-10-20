using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using StoreKit;
using UserNotifications;
using UIKit;

namespace AppboyPlatformXamariniOSBinding
{
  [Protocol]
  // @interface Appboy : NSObject
  [BaseType (typeof (NSObject))]
  interface Appboy 
  {

    // @property (readonly) ABKFeedController * _Nonnull feedController;
    [Export ("feedController", ArgumentSemantic.Retain)]
    ABKFeedController FeedController { get; }

    // @property (readonly) ABKInAppMessageController * _Nonnull inAppMessageController;
    [Export ("inAppMessageController", ArgumentSemantic.Retain)]
    ABKInAppMessageController InAppMessageController { get; }

    // @property (readonly) ABKUser * _Nonnull user;
    [Export ("user", ArgumentSemantic.Retain)]
    ABKUser User { get; }

    // @property (readonly, nonatomic) ABKLocationManager * _Nonnull locationManager;
    [Export ("locationManager")]
    ABKLocationManager LocationManager { get; }

    // @property (nonatomic) BOOL useNUITheming;
    [Export ("useNUITheming", ArgumentSemantic.UnsafeUnretained)]
    bool UseNUITheming { get; set; }

    // @property ABKRequestProcessingPolicy requestProcessingPolicy;
    [Export ("requestProcessingPolicy", ArgumentSemantic.UnsafeUnretained)]
    ABKRequestProcessingPolicy RequestProcessingPolicy { get; set; }

    // +(Appboy * _Nullable)sharedInstance;
    [Static, Export ("sharedInstance")]
    [return: NullAllowed]
    Appboy SharedInstance { get; }

    // +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions;
    [Static, Export ("startWithApiKey:inApplication:withLaunchOptions:")]
    void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions);

    // +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions withAppboyOptions:(NSDictionary * _Nullable)appboyOptions;
    [Static, Export ("startWithApiKey:inApplication:withLaunchOptions:withAppboyOptions:")]
    void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions, [NullAllowed] NSDictionary appboyOptions);
    
    [Wrap ("WeakAppboyEndpointDelegate")]
    ABKAppboyEndpointDelegate AppboyEndpointDelegate { get; set; }

    // @property (nonatomic, weak) id<ABKAppboyEndpointDelegate> _Nullable appboyEndpointDelegate;
    [NullAllowed, Export ("appboyEndpointDelegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakAppboyEndpointDelegate { get; set; }

    // -(void)flushDataAndProcessRequestQueue;
    [Export ("flushDataAndProcessRequestQueue")]
    void FlushDataAndProcessRequestQueue();

    // -(void)shutdownServerCommunication;
    [Export ("shutdownServerCommunication")]
    void ShutdownServerCommunication();

    // -(BOOL)pushNotificationWasSentFromAppboy:(NSDictionary * _Nonnull)options;
    [Export ("pushNotificationWasSentFromAppboy:")]
    bool PushNotificationWasSentFromAppboy (NSDictionary options);

    // -(void)registerPushToken:(NSString * _Nonnull)token;
    [Export ("registerPushToken:")]
    void RegisterPushToken (string token);

    // -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification __attribute__((deprecated("`registerApplication:didReceiveRemoteNotification:` is deprecated in iOS 10, please use `registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:` instead.")));
    [Export ("registerApplication:didReceiveRemoteNotification:")]
    void RegisterApplication (UIApplication application, NSDictionary notification);

    // -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
    [Export ("registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:")]
    void RegisterApplicationWithFetchCompletionHandler (UIApplication application, NSDictionary notification, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

    // -(void)getActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nullable)())completionHandler __attribute__((deprecated("`getActionWithIdentifier:forRemoteNotification:completionHandler:` is deprecated in iOS 10, please use `userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:` instead.")));
    [Export ("getActionWithIdentifier:forRemoteNotification:completionHandler:")]
    void GetActionWithIdentifier (string identifier, NSDictionary userInfo, [NullAllowed] Action completionHandler);

    // -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nullable)())completionHandler;
    [Export ("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
    void UserNotificationCenter (UNUserNotificationCenter center, UNNotificationResponse response, [NullAllowed] Action completionHandler);

    [Wrap ("WeakAppboyPushURIDelegate")]
    ABKPushURIDelegate AppboyPushURIDelegate { get; set; }

    // @property (nonatomic, weak) id<ABKPushURIDelegate> _Nullable appboyPushURIDelegate;
    [NullAllowed, Export ("appboyPushURIDelegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakAppboyPushURIDelegate { get; set; }

    // -(void)changeUser:(NSString * _Nonnull)userID;
    [Export ("changeUser:")]
    void ChangeUser (string userID);

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

    // -(BOOL)submitFeedback:(NSString * _Nonnull)replyToEmail message:(NSString * _Nonnull)message isReportingABug:(BOOL)isReportingABug;
    [Export ("submitFeedback:message:isReportingABug:")]
    bool SubmitFeedback (string replyToEmail, string message, bool isReportingABug);

    // -(void)logFeedDisplayed;
    [Export ("logFeedDisplayed")]
    void LogFeedDisplayed ();

    // -(void)logFeedbackDisplayed;
    [Export ("logFeedbackDisplayed")]
    void LogFeedbackDisplayed ();

    // -(void)requestFeedRefresh;
    [Export ("requestFeedRefresh")]
    void RequestFeedRefresh ();

    // -(void)requestInAppMessageRefresh;
    [Export ("requestInAppMessageRefresh")]
    void RequestInAppMessageRefresh ();
  }

  // @protocol ABKAppboyEndpointDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof(NSObject))]
  interface ABKAppboyEndpointDelegate
  {
    // @required -(NSString * _Nonnull)getApiEndpoint:(NSString * _Nonnull)appboyApiEndpoint;
    [Abstract]
    [Export ("getApiEndpoint:")]
    string GetApiEndpoint (string appboyApiEndpoint);
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

  // @interface ABKFacebookUser : NSObject
  [BaseType (typeof(NSObject))]
  interface ABKFacebookUser
  {
    // -(instancetype _Nonnull)initWithFacebookUserDictionary:(NSDictionary * _Nullable)facebookUserDictionary numberOfFriends:(NSInteger)numberOfFriends likes:(NSArray * _Nullable)likes;
    [Export("initWithFacebookUserDictionary:numberOfFriends:likes:")]
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

    // @property (copy, nonatomic) NSString * _Nullable phone;
    [NullAllowed, Export ("phone")]
    string Phone { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable foursquareAccessToken;
    [NullAllowed, Export ("foursquareAccessToken")]
    string FoursquareAccessToken { get; set; }

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

    // -(BOOL)setGender:(ABKUserGenderType)gender;
    [Export ("setGender:")]
    bool SetGender (ABKUserGenderType gender);

    // -(BOOL)setIsSubscribedToEmails:(BOOL)subscribed __attribute__((deprecated("")));
    [Export ("setIsSubscribedToEmails:")]
    bool SetIsSubscribedToEmails (bool subscribed);

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
  }

  // @interface ABKLocationManager : NSObject
  [BaseType (typeof(NSObject))]
  interface ABKLocationManager
  {
    // @property (readonly) BOOL disableLocationTracking;
    [Export ("disableLocationTracking")]
    bool DisableLocationTracking { get; }

    // -(instancetype _Nonnull)initWithServerConfig:(ABKServerConfig * _Nonnull)serverConfig andAppboyOptions:(NSDictionary * _Nonnull)appboyOptions;
    [Export ("initWithServerConfig:andAppboyOptions:")]
    IntPtr Constructor (ABKServerConfig serverConfig, NSDictionary appboyOptions);

    // -(void)allowRequestWhenInUseLocationPermission;
    [Export ("allowRequestWhenInUseLocationPermission")]
    void AllowRequestWhenInUseLocationPermission ();

    // -(void)allowRequestAlwaysPermission;
    [Export ("allowRequestAlwaysPermission")]
    void AllowRequestAlwaysPermission ();

    // -(void)logSingleLocation;
    [Export ("logSingleLocation")]
    void LogSingleLocation ();
  }

  // @protocol ABKPushURIDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof(NSObject))]
  interface ABKPushURIDelegate
  {
    // @required -(BOOL)handleAppboyPushURI:(NSString * _Nonnull)URIString withNotificationInfo:(NSDictionary * _Nonnull)notificationInfo;
    [Abstract]
    [Export ("handleAppboyPushURI:withNotificationInfo:")]
    bool HandleAppboyPushURI (string URIString, NSDictionary notificationInfo);
  }

  // @interface ABKPushUtils : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKPushUtils
  {
    // +(BOOL)isUninstallTrackingNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export ("isUninstallTrackingNotification:")]
    bool IsUninstallTrackingNotification (NSDictionary userInfo);

    // +(BOOL)shouldFetchTestTriggersFlagContainedInPayload:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export ("shouldFetchTestTriggersFlagContainedInPayload:")]
    bool ShouldFetchTestTriggersFlagContainedInPayload (NSDictionary userInfo);
  }

  /******************************************************************************************************************************************************
   * 
   * IAM API
   * 
   ******************************************************************************************************************************************************/

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

    // @property (readonly) NSURL * _Nullable uri;
    [NullAllowed, Export ("uri")]
    NSUrl Uri { get; }

    // @property BOOL shouldOpenURIExternally;
    [Export ("shouldOpenURIExternally")]
    bool ShouldOpenURIExternally { get; set; }

    // @property ABKInAppMessageDismissType inAppMessageDismissType;
    [Export ("inAppMessageDismissType", ArgumentSemantic.UnsafeUnretained)]
    ABKInAppMessageDismissType InAppMessageDismissType { get; set; }

    // @property (strong) UIColor * _Nullable backgroundColor;
    [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
    UIColor BackgroundColor { get; set; }

    // @property (strong) UIColor * _Nullable textColor;
    [NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
    UIColor TextColor { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable icon;
    [NullAllowed, Export ("icon")]
    string Icon { get; set; }

    // @property (strong) UIColor * _Nullable iconColor;
    [NullAllowed, Export ("iconColor", ArgumentSemantic.Strong)]
    UIColor IconColor { get; set; }

    // @property (strong) UIColor * _Nullable iconBackgroundColor;
    [NullAllowed, Export ("iconBackgroundColor", ArgumentSemantic.Strong)]
    UIColor IconBackgroundColor { get; set; }

    // @property (copy) NSURL * _Nullable imageURI;
    [NullAllowed, Export ("imageURI", ArgumentSemantic.Copy)]
    NSUrl ImageURI { get; set; }

    // @property UIViewContentMode imageContentMode;
    [Export ("imageContentMode", ArgumentSemantic.UnsafeUnretained)]
    UIViewContentMode ImageContentMode { get; set; }

    // @property ABKInAppMessageOrientation orientation;
    [Export ("orientation", ArgumentSemantic.UnsafeUnretained)]
    ABKInAppMessageOrientation Orientation { get; set; }

    // @property NSTextAlignment messageTextAlignment;
    [Export ("messageTextAlignment", ArgumentSemantic.UnsafeUnretained)]
    UITextAlignment MessageTextAlignment { get; set; }

    // @property BOOL animateIn;
    [Export ("animateIn")]
    bool AnimateIn { get; set; }

    // @property BOOL animateOut;
    [Export ("animateOut")]
    bool AnimateOut { get; set; }

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

  // @interface ABKInAppMessageViewController : UIViewController
  [BaseType (typeof(UIViewController))]
  interface ABKInAppMessageViewController
  {
    // @property (strong) ABKInAppMessage * _Nonnull inAppMessage;
    [Export ("inAppMessage", ArgumentSemantic.Strong)]
    ABKInAppMessage InAppMessage { get; set; }

    // @property (weak) UIImageView * _Nullable iconImageView __attribute__((iboutlet));
    [NullAllowed, Export ("iconImageView", ArgumentSemantic.Retain)]
    UIImageView IconImageView { get; set; }

    // @property (weak) UILabel * _Nullable iconLabelView __attribute__((iboutlet));
    [NullAllowed, Export ("iconLabelView", ArgumentSemantic.Retain)]
    UILabel IconLabelView { get; set; }

    // @property (weak) ABKLabel * _Nullable inAppMessageMessageLabel __attribute__((iboutlet));
    [NullAllowed, Export ("inAppMessageMessageLabel", ArgumentSemantic.Retain)]
    ABKLabel InAppMessageMessageLabel { get; set; }

    // -(instancetype _Nonnull)initWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
    [Export ("initWithInAppMessage:")]
    IntPtr Constructor (ABKInAppMessage inAppMessage);

    // -(void)hideInAppMessage:(BOOL)animated;
    [Export ("hideInAppMessage:")]
    void HideInAppMessage (bool animated);

    // -(void)moveInAppMessageViewOffScreen:(CGRect)inAppMessageWindowFrame;
    [Export ("moveInAppMessageViewOffScreen:")]
    void MoveInAppMessageViewOffScreen (CGRect inAppMessageWindowFrame);

    // -(void)moveInAppMessageViewOnScreen:(CGRect)inAppMessageWindowFrame;
    [Export ("moveInAppMessageViewOnScreen:")]
    void MoveInAppMessageViewOnScreen (CGRect inAppMessageWindowFrame);
  }

  // @interface ABKInAppMessageButton : UIButton
  [BaseType (typeof(UIButton))]
  interface ABKInAppMessageButton
  {
    // @property (copy, nonatomic) NSString * _Nullable buttonText;
    [NullAllowed, Export ("buttonText")]
    string ButtonText { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable buttonBackgroundColor;
    [NullAllowed, Export ("buttonBackgroundColor", ArgumentSemantic.Strong)]
    UIColor ButtonBackgroundColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable buttonTextColor;
    [NullAllowed, Export ("buttonTextColor", ArgumentSemantic.Strong)]
    UIColor ButtonTextColor { get; set; }

    // @property (readonly) ABKInAppMessageClickActionType buttonClickActionType;
    [Export ("buttonClickActionType")]
    ABKInAppMessageClickActionType ButtonClickActionType { get; }

    // @property (readonly, copy) NSURL * _Nullable buttonClickedURI;
    [NullAllowed, Export ("buttonClickedURI", ArgumentSemantic.Copy)]
    NSUrl ButtonClickedURI { get; }

    // @property (readonly) NSInteger buttonID;
    [Export ("buttonID")]
    nint ButtonID { get; }

    // -(void)setButtonClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSURL * _Nullable)uri;
    [Export ("setButtonClickAction:withURI:")]
    void SetButtonClickAction (ABKInAppMessageClickActionType clickActionType, [NullAllowed] NSUrl uri);
  }

  // @interface ABKInAppMessageImmersive : ABKInAppMessage
  [BaseType (typeof(ABKInAppMessage))]
  interface ABKInAppMessageImmersive
  {
    // @property (copy) NSString * _Nullable header;
    [NullAllowed, Export ("header")]
    string Header { get; set; }

    // @property (strong) UIColor * _Nullable headerTextColor;
    [NullAllowed, Export ("headerTextColor", ArgumentSemantic.Strong)]
    UIColor HeaderTextColor { get; set; }

    // @property (strong) UIColor * _Nullable closeButtonColor;
    [NullAllowed, Export ("closeButtonColor", ArgumentSemantic.Strong)]
    UIColor CloseButtonColor { get; set; }

    // @property (readonly) NSArray * _Nullable buttons;
    [NullAllowed, Export ("buttons")]
    NSObject[] Buttons { get; }

    // @property (strong) UIColor * _Nullable frameColor;
    [NullAllowed, Export ("frameColor", ArgumentSemantic.Strong)]
    UIColor FrameColor { get; set; }

    // @property NSTextAlignment headerTextAlignment;
    [Export ("headerTextAlignment", ArgumentSemantic.UnsafeUnretained)]
    UITextAlignment HeaderTextAlignment { get; set; }

    // @property ABKInAppMessageImmersiveImageStyle imageStyle;
    [Export ("imageStyle", ArgumentSemantic.UnsafeUnretained)]
    ABKInAppMessageImmersiveImageStyle ImageStyle { get; set; }

    // -(void)logInAppMessageClickedWithButtonID:(NSInteger)buttonID;
    [Export ("logInAppMessageClickedWithButtonID:")]
    void LogInAppMessageClickedWithButtonID (nint buttonID);

    // -(void)setInAppMessageButtons:(NSArray * _Nonnull)buttonArray;
    [Export ("setInAppMessageButtons:")]
    void SetInAppMessageButtons (NSObject[] buttonArray);
  }

  // @protocol ABKInAppMessageControllerDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof(NSObject))]
  interface ABKInAppMessageControllerDelegate
  {
    // @optional -(BOOL)onInAppMessageReceived:(ABKInAppMessage * _Nonnull)inAppMessage __attribute__((deprecated("")));
    [Export ("onInAppMessageReceived:")]
    bool OnInAppMessageReceived (ABKInAppMessage inAppMessage);

    // @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage * _Nonnull)inAppMessage withKeyboardIsUp:(BOOL)keyboardIsUp;
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

    // @optional -(BOOL)onInAppMessageHTMLButtonClicked:(ABKInAppMessageHTML * _Nonnull)inAppMessage clickedURL:(NSURL * _Nullable)clickedURL buttonID:(NSString * _Nonnull)buttonID;
    [Export ("onInAppMessageHTMLButtonClicked:clickedURL:buttonID:")]
    bool OnInAppMessageHTMLButtonClicked (ABKInAppMessageHTML inAppMessage, [NullAllowed] NSUrl clickedURL, string buttonID);
  }

  // @interface ABKInAppMessageController : NSObject
  [BaseType (typeof(NSObject))]
  interface ABKInAppMessageController
  {
    [Wrap("WeakDelegate")]
    ABKInAppMessageControllerDelegate Delegate { get; set; }

    // @property (weak) id<ABKInAppMessageControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Retain)]
    NSObject WeakDelegate { get; set; }

    // @property UIInterfaceOrientationMask supportedOrientationMasks;
    [Export ("supportedOrientationMasks", ArgumentSemantic.UnsafeUnretained)]
    UIInterfaceOrientationMask SupportedOrientationMasks { get; set; }

    // @property UIInterfaceOrientation supportedOrientations;
    [Export ("supportedOrientations", ArgumentSemantic.UnsafeUnretained)]
    UIInterfaceOrientation SupportedOrientations { get; set; }

    // -(void)displayNextInAppMessageWithDelegate:(id<ABKInAppMessageControllerDelegate> _Nullable)delegate;
    [Export ("displayNextInAppMessageWithDelegate:")]
    void DisplayNextInAppMessageWithDelegate ([NullAllowed] ABKInAppMessageControllerDelegate @delegate);

    // -(NSInteger)inAppMessagesRemainingOnStack;
    [Export ("inAppMessagesRemainingOnStack")]
    nint InAppMessagesRemainingOnStack { get; }

    // -(void)addInAppMessage:(ABKInAppMessage * _Nonnull)newInAppMessage;
    [Export ("addInAppMessage:")]
    void AddInAppMessage (ABKInAppMessage newInAppMessage);

    // -(void)hideCurrentInAppMessage:(BOOL)animated;
    [Export ("hideCurrentInAppMessage:")]
    void HideCurrentInAppMessage (bool animated);
  }

  // @interface ABKInAppMessageSlideup : ABKInAppMessage
  [BaseType (typeof(ABKInAppMessage))]
  interface ABKInAppMessageSlideup
  {
    // @property BOOL hideChevron;
    [Export ("hideChevron")]
    bool HideChevron { get; set; }

    // @property ABKInAppMessageSlideupAnchor inAppMessageSlideupAnchor;
    [Export ("inAppMessageSlideupAnchor", ArgumentSemantic.UnsafeUnretained)]
    ABKInAppMessageSlideupAnchor InAppMessageSlideupAnchor { get; set; }

    // @property (strong) UIColor * _Nullable chevronColor;
    [NullAllowed, Export ("chevronColor", ArgumentSemantic.Strong)]
    UIColor ChevronColor { get; set; }
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

  // @interface ABKInAppMessageHTML : ABKInAppMessage
  [BaseType (typeof(ABKInAppMessage))]
  interface ABKInAppMessageHTML
  {
    // @property (strong) NSURL * _Nullable assetsZipRemoteUrl;
    [NullAllowed, Export ("assetsZipRemoteUrl", ArgumentSemantic.Strong)]
    NSUrl AssetsZipRemoteUrl { get; set; }

    // -(void)logInAppMessageHTMLClickWithButtonID:(NSString * _Nonnull)buttonID;
    [Export ("logInAppMessageHTMLClickWithButtonID:")]
    void LogInAppMessageHTMLClickWithButtonID (string buttonID);
  }

  // @interface ABKInAppMessageHTMLFull : ABKInAppMessageHTML
  [BaseType (typeof(ABKInAppMessageHTML))]
  interface ABKInAppMessageHTMLFull
  {
  }

  // @interface ABKInAppMessageHTMLViewController : ABKInAppMessageViewController <UIWebViewDelegate>
  [BaseType (typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageHTMLViewController : IUIWebViewDelegate
  {
    // @property (weak) UIWebView * _Nullable webView __attribute__((iboutlet));
    [NullAllowed, Export ("webView", ArgumentSemantic.Assign)]
    UIWebView WebView { get; set; }
  }

  // @interface ABKInAppMessageHTMLFullViewController : ABKInAppMessageHTMLViewController
  [BaseType (typeof(ABKInAppMessageHTMLViewController))]
  interface ABKInAppMessageHTMLFullViewController
  {
  }

  // @interface ABKInAppMessageImmersiveViewController : ABKInAppMessageViewController
  [BaseType (typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageImmersiveViewController
  {
    // @property (weak) ABKLabel inAppMessageHeaderLabel __attribute__((iboutlet));
    [Export ("inAppMessageHeaderLabel", ArgumentSemantic.Retain)]
    ABKLabel InAppMessageHeaderLabel { get; set; }

    // @property (nonatomic, weak) UIImageView * _Nullable graphicImageView __attribute__((iboutlet));
    [NullAllowed, Export ("graphicImageView", ArgumentSemantic.Retain)]
    UIImageView GraphicImageView { get; set; }

    // -(void)dismissInAppMessage:(id _Nonnull)sender __attribute__((ibaction));
    [Export ("dismissInAppMessage:")]
    void DismissInAppMessage (NSObject sender);
  }

  // @interface ABKInAppMessageFullViewController : ABKInAppMessageImmersiveViewController
  [BaseType (typeof(ABKInAppMessageImmersiveViewController))]
  interface ABKInAppMessageFullViewController
  {
  }

  // @interface ABKInAppMessageModalViewController : ABKInAppMessageImmersiveViewController
  [BaseType (typeof(ABKInAppMessageImmersiveViewController))]
  interface ABKInAppMessageModalViewController
  {
  }

  // @interface ABKInAppMessageSlideupViewController : ABKInAppMessageViewController
  [BaseType (typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageSlideupViewController
  {
    // @property (weak) UIImageView * _Nullable arrowImage __attribute__((iboutlet));
    [NullAllowed, Export ("arrowImage", ArgumentSemantic.Retain)]
    UIImageView ArrowImage { get; set; }
  }

  // @interface ABKInAppMessageView : UIView
  [BaseType (typeof(UIView))]
  interface ABKInAppMessageView
  {
  }

  /******************************************************************************************************************************************************
   * 
   * News Feed API
   * 
   ******************************************************************************************************************************************************/

  // @protocol ABKFeedViewControllerDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedViewControllerDelegate
  {
    // @optional -(BOOL)onCardClicked:(ABKCard * _Nonnull)clickedCard feedViewController:(UIViewController * _Nonnull)newsFeed;
    [Export ("onCardClicked:feedViewController:")]
    [Abstract]
    bool FeedViewController (ABKCard clickedCard, UIViewController newsFeed);
  }

  // @interface ABKFeedController : NSObject
  [BaseType (typeof (NSObject))]
  interface ABKFeedController
  {
    // @property (readonly, getter = getNewsFeedCards) NSArray * _Nullable newsFeedCards;
    [NullAllowed, Export ("newsFeedCards")]
    NSObject[] NewsFeedCards { [Bind("getNewsFeedCards")] get; }

    // @property (readonly) NSDate * _Nullable lastUpdate;
    [NullAllowed, Export ("lastUpdate")]
    NSDate LastUpdate { get; }

    // -(NSInteger)unreadCardCountForCategories:(ABKCardCategory)categories;
    [Export ("unreadCardCountForCategories:")]
    nint UnreadCardCountForCategories (ABKCardCategory categories);

    // -(NSInteger)cardCountForCategories:(ABKCardCategory)categories;
    [Export ("cardCountForCategories:")]
    nint CardCountForCategories (ABKCardCategory categories);

    // -(NSArray * _Nullable)getCardsInCategories:(ABKCardCategory)categories;
    [Export ("getCardsInCategories:")]
    [return: NullAllowed]
    NSObject[] GetCardsInCategories (ABKCardCategory categories);

    // NSString *const ABKFeedUpdatedNotification
    [Notification]
    [Field ("ABKFeedUpdatedNotification", "__Internal")]
    NSString ABKFeedUpdatedNotification { get; }
  }

  // @interface ABKFeedViewControllerGenericContext : UINavigationController <UINavigationControllerDelegate>
  [BaseType (typeof (UINavigationController))] //UINavigationControllerDelegate
  interface ABKFeedViewControllerGenericContext
  {
    // @property CGFloat cardWidthForiPhone;
    [Export ("cardWidthForiPhone")]
    nfloat CardWidthForiPhone { get; set; }

    // @property CGFloat cardWidthForiPad;
    [Export ("cardWidthForiPad")]
    nfloat CardWidthForiPad { get; set; }

    // @property CGFloat minimumCardMarginForiPhone;
    [Export ("minimumCardMarginForiPhone")]
    nfloat MinimumCardMarginForiPhone { get; set; }

    // @property CGFloat minimumCardMarginForiPad;
    [Export ("minimumCardMarginForiPad")]
    nfloat MinimumCardMarginForiPad { get; set; }

    // @property (weak) id<ABKFeedViewControllerDelegate> _Nullable appboyDelegate;
    [NullAllowed, Export ("appboyDelegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakAppboyDelegate { get; set; }

    [Wrap ("WeakAppboyDelegate")]
    ABKFeedViewControllerDelegate AppboyDelegate { get; set; }

    // @property ABKCardCategory categories;
    [Export ("categories", ArgumentSemantic.UnsafeUnretained)]
    ABKCardCategory Categories { get; set; }

    // @property BOOL disableUnreadIndicator;
    [Export ("disableUnreadIndicator")]
    bool DisableUnreadIndicator { get; set; }

    // -(void)closeButtonPressed:(id _Nonnull)sender;
    [Export ("closeButtonPressed:")]
    void CloseButtonPressed (NSObject sender);
  }

  // @protocol ABKFeedViewControllerModalContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedViewControllerModalContextDelegate
  {
    // @required -(void)feedViewControllerModalContextCloseTapped:(ABKFeedViewControllerModalContext * _Nonnull)sender;
    [Abstract]
    [Export ("feedViewControllerModalContextCloseTapped:")]
    void FeedViewControllerModalContextCloseTapped (ABKFeedViewControllerModalContext sender);
  }

  // @interface ABKFeedViewControllerModalContext : ABKFeedViewControllerGenericContext
  [BaseType (typeof (ABKFeedViewControllerGenericContext))]
  interface ABKFeedViewControllerModalContext
  {
    // @property (strong) NSString * _Nullable navigationBarTitle;
    [NullAllowed, Export ("navigationBarTitle", ArgumentSemantic.Strong)]
    string NavigationBarTitle { get; set; }

    // @property (weak) id<ABKFeedViewControllerModalContextDelegate> _Nullable closeButtonDelegate;
    [NullAllowed, Export("closeButtonDelegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakCloseButtonDelegate { get; set; }

    [Wrap ("WeakCloseButtonDelegate")]
    ABKFeedViewControllerModalContextDelegate CloseButtonDelegate { get; set; }
  }

    // @interface ABKFeedViewController : UIViewController <UITableViewDataSource, UITableViewDelegate, SKStoreProductViewControllerDelegate>
  [BaseType (typeof (UIViewController))]
  interface ABKFeedViewController 
  {
    // @property CGFloat cardWidthForiPhone;
    [Export ("cardWidthForiPhone")]
    nfloat CardWidthForiPhone { get; set; }

    // @property CGFloat cardWidthForiPad;
    [Export ("cardWidthForiPad")]
    nfloat CardWidthForiPad { get; set; }

    // @property CGFloat minimumCardMarginForiPhone;
    [Export ("minimumCardMarginForiPhone")]
    nfloat MinimumCardMarginForiPhone { get; set; }

    // @property CGFloat minimumCardMarginForiPad;
    [Export ("minimumCardMarginForiPad")]
    nfloat MinimumCardMarginForiPad { get; set; }

    // @property (nonatomic) ABKCardCategory categories;
    [Export ("categories", ArgumentSemantic.UnsafeUnretained)]
    ABKCardCategory Categories { get; set; }

    // @property (nonatomic) BOOL disableUnreadIndicator;
    [Export ("disableUnreadIndicator")]
    bool DisableUnreadIndicator { get; set; }

    // @property (weak) id<ABKFeedViewControllerDelegate> _Nullable appboyDelegate;
    [NullAllowed, Export ("appboyDelegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakAppboyDelegate { get; set; }

    [Wrap ("WeakAppboyDelegate")]
    ABKFeedViewControllerDelegate AppboyDelegate { get; set; }
  }

  // @interface ABKFeedViewControllerNavigationContext : ABKFeedViewController <UINavigationControllerDelegate>
  [BaseType (typeof (ABKFeedViewController))]
  interface ABKFeedViewControllerNavigationContext
  {
  }

  // @protocol ABKFeedViewControllerPopoverContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedViewControllerPopoverContextDelegate
  {
    // -(void)feedViewControllerPopoverContextCloseTapped:(ABKFeedViewControllerPopoverContext * _Nonnull)sender;
    [Export ("feedViewControllerPopoverContextCloseTapped:")]
    void FeedViewControllerPopoverContextCloseTapped (ABKFeedViewControllerPopoverContext sender);
  }

  // @interface ABKFeedViewControllerPopoverContext : ABKFeedViewControllerGenericContext
  [BaseType (typeof (ABKFeedViewControllerGenericContext))]
  interface ABKFeedViewControllerPopoverContext
  {
    // @property (strong) NSString * _Nullable navigationBarTitle;
    [NullAllowed, Export ("navigationBarTitle", ArgumentSemantic.Strong)]
    string NavigationBarTitle { get; set; }

    // @property (weak) id<ABKFeedViewControllerPopoverContextDelegate> _Nullable closeButtonDelegate;
    [NullAllowed, Export("closeButtonDelegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakCloseButtonDelegate { get; set; }

    [Wrap ("WeakCloseButtonDelegate")]
    ABKFeedViewControllerPopoverContextDelegate CloseButtonDelegate { get; set; }
  }

  // @interface ABKFeedbackViewController : UIViewController
  [BaseType (typeof (UIViewController))]
  interface ABKFeedbackViewController
  {
    // @property (nonatomic, weak) id _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakDelegate { get; set; }

    [Wrap ("WeakDelegate")]
    NSObject Delegate { get; set; }
  }
  
  partial interface Constants
  {
    // extern NSString *const _Nonnull ABKFeedUpdatedNotification;
    [Field("ABKFeedUpdatedNotification", "__Internal")]
    NSString ABKFeedUpdatedNotification { get; }

    // extern NSString *const _Nonnull ABKFeedUpdatedIsSuccessfulKey;
    [Field("ABKFeedUpdatedIsSuccessfulKey", "__Internal")]
    NSString ABKFeedUpdatedIsSuccessfulKey { get; }
  }

  /******************************************************************************************************************************************************
   * 
   * Feed Cards API
   * 
   ******************************************************************************************************************************************************/

  // @interface ABKCard : NSObject <NSCopying, NSCoding>
  [BaseType (typeof (NSObject))]
  interface ABKCard
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
    [Export ("categories", ArgumentSemantic.UnsafeUnretained)]
    ABKCardCategory Categories { get; set; }

    // @property (readonly) double expiresAt;
    [Export ("expiresAt")]
    double ExpiresAt { get; }

    // @property (strong) NSDictionary * _Nullable extras;
    [NullAllowed, Export ("extras", ArgumentSemantic.Strong)]
    NSDictionary Extras { get; set; }

    // +(ABKCard * _Nullable)deserializeCardFromDictionary:(NSDictionary * _Nullable)cardDictionary;
    [Static, Export ("deserializeCardFromDictionary:")]
    [return: NullAllowed]
    ABKCard DeserializeCardFromDictionary ([NullAllowed] NSDictionary cardDictionary);

    // -(NSData * _Nullable)serializeToData;
    [Export ("serializeToData")]
    [return: NullAllowed]
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
  [BaseType (typeof (ABKCard))]
  interface ABKBannerCard
  {
    // @property (copy) NSString * _Nonnull image;
    [Export ("image")]
    string Image { get; set; }

    // @property (copy) NSString * _Nullable url;
    [NullAllowed, Export ("url")]
    string Url { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export ("domain")]
    string Domain { get; set; }

    // @property float imageAspectRatio;
    [Export ("imageAspectRatio")]
    float ImageAspectRatio { get; set; }
  }

  // @interface ABKCaptionedImageCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKCaptionedImageCard
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

    // @property (copy) NSString * _Nullable url;
    [NullAllowed, Export ("url")]
    string Url { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export ("domain")]
    string Domain { get; set; }
  }

  // @interface ABKClassicCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKClassicCard
  {
    // @property (copy) NSString * _Nullable image;
    [NullAllowed, Export ("image")]
    string Image { get; set; }

    // @property (copy) NSString * _Nonnull cardDescription;
    [Export ("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy) NSString * _Nullable url;
    [NullAllowed, Export ("url")]
    string Url { get; set; }

    // @property (copy) NSString * _Nullable title;
    [NullAllowed, Export ("title")]
    string Title { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export ("domain")]
    string Domain { get; set; }
  }

  // @interface ABKCrossPromotionCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKCrossPromotionCard
  {
    // @property (copy) NSString * _Nonnull mediaType;
    [Export ("mediaType")]
    string MediaType { get; set; }

    // @property (copy) NSString * _Nonnull title;
    [Export ("title")]
    string Title { get; set; }

    // @property (copy) NSString * _Nonnull subtitle;
    [Export ("subtitle")]
    string Subtitle { get; set; }

    // @property (copy) NSString * _Nonnull image;
    [Export ("image")]
    string Image { get; set; }

    // @property (copy) NSString * _Nullable displayPrice;
    [NullAllowed, Export ("displayPrice")]
    string DisplayPrice { get; set; }

    // @property (nonatomic) long long iTunesId;
    [Export ("iTunesId")]
    long ITunesId { get; set; }

    // @property (nonatomic) float rating;
    [Export ("rating")]
    float Rating { get; set; }

    // @property (nonatomic) float price;
    [Export ("price")]
    float Price { get; set; }

    // @property (nonatomic) int reviews;
    [Export ("reviews")]
    int Reviews { get; set; }

    // @property (copy) NSString * _Nonnull caption;
    [Export ("caption")]
    string Caption { get; set; }

    // @property (copy) NSString * _Nonnull url;
    [Export ("url")]
    string Url { get; set; }

    // @property BOOL universal;
    [Export ("universal")]
    bool Universal { get; set; }
  }

  // @interface ABKTextAnnouncementCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKTextAnnouncementCard
  {
    // @property (copy) NSString * _Nonnull title;
    [Export ("title")]
    string Title { get; set; }

    // @property (copy) NSString * _Nonnull cardDescription;
    [Export ("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy) NSString * _Nullable url;
    [NullAllowed, Export ("url")]
    string Url { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export ("domain")]
    string Domain { get; set; }
  }

  /******************************************************************************************************************************************************
   * 
   * Feedback View Controller API
   * 
   ******************************************************************************************************************************************************/

  // @protocol ABKFeedbackViewControllerModalContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedbackViewControllerModalContextDelegate
  {
    // @optional -(void)feedbackViewControllerModalContextCancelTapped:(ABKFeedbackViewControllerModalContext * _Nonnull)sender;
    [Export ("feedbackViewControllerModalContextCancelTapped:")]
    void FeedbackViewControllerModalContextCancelTapped (ABKFeedbackViewControllerModalContext sender);

    // @optional -(void)feedbackViewControllerModalContextFeedbackSent:(ABKFeedbackViewControllerModalContext * _Nonnull)sender;
    [Export ("feedbackViewControllerModalContextFeedbackSent:")]
    void FeedbackViewControllerModalContextFeedbackSent (ABKFeedbackViewControllerModalContext sender);

    // @optional -(NSString * _Nonnull)feedbackViewControllerBeforeFeedbackSent:(NSString * _Nonnull)message;
    [Export ("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent (string message);
  }

  // @interface ABKFeedbackViewControllerModalContext : UINavigationController
  [BaseType (typeof (UINavigationController))]
  interface ABKFeedbackViewControllerModalContext
  {
    // @property (weak) id<ABKFeedbackViewControllerModalContextDelegate> _Nullable feedbackDelegate;
    [NullAllowed, Export ("feedbackDelegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakFeedbackDelegate { get; set; }

    [Wrap ("WeakFeedbackDelegate")]
    ABKFeedbackViewControllerModalContextDelegate FeedbackDelegate { get; set; }
  }

  // @protocol ABKFeedbackViewControllerNavigationContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedbackViewControllerNavigationContextDelegate
  {
    // - (void) feedbackViewControllerNavigationContextFeedbackSent:(ABKFeedbackViewControllerNavigationContext * _Nonnull)sender;
    [Export ("feedbackViewControllerNavigationContextFeedbackSent:")]
    void FeedbackViewControllerNavigationContextFeedbackSent (ABKFeedbackViewControllerNavigationContext sender);

    // @optional -(NSString *)feedbackViewControllerBeforeFeedbackSent:(NSString *)message;
    [Export ("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent (string message);
  }

  // @interface ABKFeedbackViewControllerNavigationContext : ABKFeedbackViewController
  [BaseType(typeof(ABKFeedbackViewController))]
  interface ABKFeedbackViewControllerNavigationContext
  {
    // @property (nonatomic, weak) id<ABKFeedbackViewControllerNavigationContextDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakDelegate { get; set; }
    
    [Wrap ("WeakDelegate")]
    ABKFeedbackViewControllerNavigationContextDelegate Delegate { get; set; }
  }

  // @protocol ABKFeedbackViewControllerPopoverContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedbackViewControllerPopoverContextDelegate
  {
    // - (void) feedbackViewControllerPopoverContextCancelTapped:(ABKFeedbackViewControllerPopoverContext *)sender;
    [Export ("feedbackViewControllerPopoverContextCancelTapped:")]
    void FeedbackViewControllerPopoverContextCancelTapped (ABKFeedbackViewControllerPopoverContext sender);

    // - (void) feedbackViewControllerPopoverContextFeedbackSent:(ABKFeedbackViewControllerPopoverContext *)sender;
    [Export ("feedbackViewControllerPopoverContextFeedbackSent:")]
    void FeedbackViewControllerPopoverContextFeedbackSent (ABKFeedbackViewControllerPopoverContext sender);

    // @optional -(NSString *)feedbackViewControllerBeforeFeedbackSent:(NSString * _Nonnull)message;
    [Export ("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent (string message);
  }

  // @interface ABKFeedbackViewControllerPopoverContext : ABKFeedbackViewController
  [BaseType (typeof (ABKFeedbackViewController))]
  interface ABKFeedbackViewControllerPopoverContext
  {
    // @property (nonatomic, weak) id<ABKFeedbackViewControllerPopoverContextDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.UnsafeUnretained)]
    NSObject WeakDelegate { get; set; }

    [Wrap ("WeakDelegate")]
    ABKFeedbackViewControllerPopoverContextDelegate Delegate { get; set; }
  }

  partial interface Constants
  {
    // extern const NSInteger DefaultNumberOfFriends;
    [Field("DefaultNumberOfFriends", "__Internal")]
    nint DefaultNumberOfFriends { get; }
  }

  // @interface ABKLabel : UILabel
  [BaseType(typeof(UILabel))]
  interface ABKLabel
  {
  }

  // @interface ABKServerConfig : NSObject <NSCoding>
  [BaseType(typeof(NSObject))]
  interface ABKServerConfig : INSCoding
  {
  }

  partial interface Constants
  {
    // extern NSString *const _Nonnull ABKRequestProcessingPolicyOptionKey;
    [Field("ABKRequestProcessingPolicyOptionKey", "__Internal")]
    NSString ABKRequestProcessingPolicyOptionKey { get; }

    // extern NSString *const _Nonnull ABKFlushIntervalOptionKey;
    [Field("ABKFlushIntervalOptionKey", "__Internal")]
    NSString ABKFlushIntervalOptionKey { get; }

    // extern NSString *const _Nonnull ABKDisableAutomaticLocationCollectionKey;
    [Field("ABKDisableAutomaticLocationCollectionKey", "__Internal")]
    NSString ABKDisableAutomaticLocationCollectionKey { get; }

    // extern NSString *const _Nonnull ABKSignificantChangeCollectionEnabledOptionKey;
    [Field("ABKSignificantChangeCollectionEnabledOptionKey", "__Internal")]
    NSString ABKSignificantChangeCollectionEnabledOptionKey { get; }

    // extern NSString *const _Nonnull ABKSignificantChangeCollectionDistanceFilterOptionKey;
    [Field("ABKSignificantChangeCollectionDistanceFilterOptionKey", "__Internal")]
    NSString ABKSignificantChangeCollectionDistanceFilterOptionKey { get; }

    // extern NSString *const _Nonnull ABKSignificantChangeCollectionTimeFilterOptionKey;
    [Field("ABKSignificantChangeCollectionTimeFilterOptionKey", "__Internal")]
    NSString ABKSignificantChangeCollectionTimeFilterOptionKey { get; }

    // extern NSString *const _Nonnull ABKAppboyEndpointDelegateKey;
    [Field("ABKAppboyEndpointDelegateKey", "__Internal")]
    NSString ABKAppboyEndpointDelegateKey { get; }

    // extern NSString *const _Nonnull ABKPushURIDelegateKey;
    [Field("ABKPushURIDelegateKey", "__Internal")]
    NSString ABKPushURIDelegateKey { get; }

    // extern NSString *const _Nonnull ABKSessionTimeoutKey;
    [Field("ABKSessionTimeoutKey", "__Internal")]
    NSString ABKSessionTimeoutKey { get; }

    // extern NSString *const _Nonnull ABKMinimumTriggerTimeIntervalKey;
    [Field("ABKMinimumTriggerTimeIntervalKey", "__Internal")]
    NSString ABKMinimumTriggerTimeIntervalKey { get; }
  }
}
