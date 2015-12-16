using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace AppboyPlatformXamariniOSBinding
{
  [Protocol]
  // @interface Appboy : NSObject
  [BaseType (typeof (NSObject))]
  interface Appboy {

    // @property (readonly, retain, nonatomic) ABKFeedController * feedController;
     [Export ("feedController", ArgumentSemantic.Retain)]
     ABKFeedController FeedController { get; }

    // @property (readonly, retain, nonatomic) ABKInAppMessageController * inAppMessageController;
    [Export ("inAppMessageController", ArgumentSemantic.Retain)]
    ABKInAppMessageController InAppMessageController { get; }

    // @property (readonly, retain, nonatomic) ABKUser * user;
    [Export ("user", ArgumentSemantic.Retain)]
    ABKUser User { get; }

    // @property (readonly, nonatomic) ABKLocationManager * locationManager;
    [Export ("locationManager")]
    ABKLocationManager LocationManager { get; }

    // @property (assign, nonatomic) BOOL useNUITheming;
    [Export ("useNUITheming", ArgumentSemantic.UnsafeUnretained)]
    bool UseNUITheming { get; set; }

    // @property (assign, nonatomic) ABKRequestProcessingPolicy requestProcessingPolicy;
    [Export ("requestProcessingPolicy", ArgumentSemantic.UnsafeUnretained)]
    ABKRequestProcessingPolicy RequestProcessingPolicy { get; set; }

    // +(Appboy *)sharedInstance;
    [Static]
    [Export ("sharedInstance")]
    Appboy SharedInstance { get; }

    // +(void)startWithApiKey:(NSString *)apiKey inApplication:(UIApplication *)application withLaunchOptions:(NSDictionary *)launchOptions;
    [Static, Export ("startWithApiKey:inApplication:withLaunchOptions:")]
    void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions);

    // +(void)startWithApiKey:(NSString *)apiKey inApplication:(UIApplication *)application withLaunchOptions:(NSDictionary *)launchOptions withAppboyOptions:(NSDictionary *)appboyOptions;
    [Static, Export ("startWithApiKey:inApplication:withLaunchOptions:withAppboyOptions:")]
    void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions, NSDictionary appboyOptions);

    [Wrap ("WeakAppboyEndpointDelegate")]
    ABKAppboyEndpointDelegate AppboyEndpointDelegate { get; set; }

    // @property (retain, nonatomic) id<ABKAppboyEndpointDelegate> appboyEndpointDelegate;
    [NullAllowed, Export ("appboyEndpointDelegate", ArgumentSemantic.Retain)]
    NSObject WeakAppboyEndpointDelegate { get; set; }

    // -(void)flushDataAndProcessRequestQueue;
    [Export ("flushDataAndProcessRequestQueue")]
    void FlushDataAndProcessRequestQueue ();

    // -(void)shutdownServerCommunication;
    [Export ("shutdownServerCommunication")]
    void ShutdownServerCommunication ();

    // -(BOOL)pushNotificationWasSentFromAppboy:(NSDictionary *)options;
    [Export ("pushNotificationWasSentFromAppboy:")]
    bool PushNotificationWasSentFromAppboy (NSDictionary options);

    // -(void)registerPushToken:(NSString *)token;
    [Export ("registerPushToken:")]
    void RegisterPushToken (string token);

    // -(void)registerApplication:(UIApplication *)application didReceiveRemoteNotification:(NSDictionary *)notification;
    [Export ("registerApplication:didReceiveRemoteNotification:")]
    void RegisterApplication (UIApplication application, NSDictionary notification);

    // - (void) registerApplication:(UIApplication *)application didReceiveRemoteNotification:(NSDictionary *)notification fetchCompletionHandler:(void (^)(UIBackgroundFetchResult))completionHandler;
    [Export ("registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:")]
    void RegisterApplicationWithFetchCompletionHandler (UIApplication application, NSDictionary notification, Action<UIBackgroundFetchResult> completionHandler);

    // -(void)getActionWithIdentifier:(NSString *)identifier forRemoteNotification:(NSDictionary *)userInfo;
    [Export ("getActionWithIdentifier:forRemoteNotification:")]
    void GetActionWithIdentifier (string identifier, NSDictionary userInfo);

    // -(void)changeUser:(NSString *)userID;
    [Export ("changeUser:")]
    void ChangeUser (string userID);

    // -(void)logCustomEvent:(NSString *)eventName;
    [Export ("logCustomEvent:")]
    void LogCustomEvent (string eventName);

    // -(void)logCustomEvent:(NSString *)eventName withProperties:(NSDictionary *)properties;
    [Export ("logCustomEvent:withProperties:")]
    void LogCustomEvent (string eventName, NSDictionary properties);

    // -(void)logPurchase:(NSString *)productIdentifier inCurrency:(NSString *)currencyCode atPrice:(NSDecimalNumber *)price;
    [Export ("logPurchase:inCurrency:atPrice:")]
    void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price);

    // -(void)logPurchase:(NSString *)productIdentifier inCurrency:(NSString *)currencyCode atPrice:(NSDecimalNumber *)price withProperties:(id)properties;
    [Export ("logPurchase:inCurrency:atPrice:withProperties:")]
    void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, NSObject properties);

    // -(void)logPurchase:(NSString *)productIdentifier inCurrency:(NSString *)currencyCode atPrice:(NSDecimalNumber *)price withQuantity:(NSUInteger)quantity;
    [Export ("logPurchase:inCurrency:atPrice:withQuantity:")]
    void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity);

    // -(void)logPurchase:(NSString *)productIdentifier inCurrency:(NSString *)currencyCode atPrice:(NSDecimalNumber *)price withQuantity:(NSUInteger)quantity andProperties:(id)properties;
    [Export ("logPurchase:inCurrency:atPrice:withQuantity:andProperties:")]
    void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity, NSObject properties);

    // -(BOOL)submitFeedback:(NSString *)replyToEmail message:(NSString *)message isReportingABug:(BOOL)isReportingABug;
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
    // @required -(NSString *)getApiEndpoint:(NSString *)appboyApiEndpoint;
    [Abstract]
    [Export ("getApiEndpoint:")]
    string GetApiEndpoint (string appboyApiEndpoint);

    // @required -(NSString *)getResourceEndpoint:(NSString *)appboyResourceEndpoint;
    [Abstract]
    [Export ("getResourceEndpoint:")]
    string GetResourceEndpoint (string appboyResourceEndpoint);
  }

  // @interface ABKAttributionData : NSObject
  [BaseType (typeof(NSObject))]
  interface ABKAttributionData
  {
    // -(id)initWithNetwork:(NSString *)network campaign:(NSString *)campaign adGroup:(NSString *)adGroup creative:(NSString *)creative;
    [Export ("initWithNetwork:campaign:adGroup:creative:")]
    IntPtr Constructor (string network, string campaign, string adGroup, string creative);

    // @property (readonly, nonatomic) NSString * network;
    [Export ("network")]
    string Network { get; }

    // @property (readonly, nonatomic) NSString * campaign;
    [Export ("campaign")]
    string Campaign { get; }

    // @property (readonly, nonatomic) NSString * adGroup;
    [Export ("adGroup")]
    string AdGroup { get; }

    // @property (readonly, nonatomic) NSString * creative;
    [Export ("creative")]
    string Creative { get; }
  }


  // @interface ABKTwitterUser : NSObject
  [BaseType (typeof(NSObject))]
  interface ABKTwitterUser
  {
    // @property (copy) NSString * userDescription;
    [Export ("userDescription")]
    string UserDescription { get; set; }

    // @property (copy) NSString * twitterName;
    [Export ("twitterName")]
    string TwitterName { get; set; }

    // @property (copy) NSString * profileImageUrl;
    [Export ("profileImageUrl")]
    string ProfileImageUrl { get; set; }

    // @property (copy) NSString * screenName;
    [Export ("screenName")]
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
    // -(id)initWithFacebookUserDictionary:(NSDictionary *)facebookUserDictionary numberOfFriends:(NSInteger)numberOfFriends likes:(NSArray *)likes;
    [Export ("initWithFacebookUserDictionary:numberOfFriends:likes:")]
    IntPtr Constructor (NSDictionary facebookUserDictionary, nint numberOfFriends, NSObject[] likes);

    // @property (readonly) NSDictionary * facebookUserDictionary;
    [Export ("facebookUserDictionary")]
    NSDictionary FacebookUserDictionary { get; }

    // @property (readonly) NSInteger numberOfFriends;
    [Export ("numberOfFriends")]
    nint NumberOfFriends { get; }

    // @property (readonly) NSArray * likes;
    [Export ("likes")]
    NSObject[] Likes { get; }
  }

  // @interface ABKUser : NSObject
  [Protocol]
  [BaseType (typeof (NSObject))]
  interface ABKUser {

    // @property (copy, nonatomic) NSString * firstName;
    [Export ("firstName")]
    string FirstName { get; set; }

    // @property (copy, nonatomic) NSString * lastName;
    [Export ("lastName")]
    string LastName { get; set; }

    // @property (copy, nonatomic) NSString * email;
    [Export ("email")]
    string Email { get; set; }

    // @property (copy, nonatomic) NSDate * dateOfBirth;
    [Export ("dateOfBirth", ArgumentSemantic.Copy)]
    NSDate DateOfBirth { get; set; }

    // @property (copy, nonatomic) NSString * country;
    [Export ("country")]
    string Country { get; set; }

    // @property (copy, nonatomic) NSString * homeCity;
    [Export ("homeCity")]
    string HomeCity { get; set; }

    // @property (copy, nonatomic) NSString * phone;
    [Export ("phone")]
    string Phone { get; set; }

    // @property (readonly, copy, nonatomic) NSString * userID;
    [Export ("userID")]
    string UserID { get; }

    // @property (copy, nonatomic) NSString * avatarImageURL;
    [Export ("avatarImageURL")]
    string AvatarImageURL { get; set; }

    // @property ABKFacebookUser * facebookUser;
    [Export ("facebookUser", ArgumentSemantic.Retain)]
    ABKFacebookUser FacebookUser { get; set; }

    // @property ABKTwitterUser * twitterUser;
    [Export ("twitterUser", ArgumentSemantic.Retain)]
    ABKTwitterUser TwitterUser { get; set; }

    // @property ABKAttributionData * attributionData;
    [Export ("attributionData", ArgumentSemantic.Retain)]
    ABKAttributionData AttributionData { get; set; }

    // -(BOOL)setGender:(ABKUserGenderType)gender;
    [Export ("setGender:")]
    bool SetGender (ABKUserGenderType gender);

    // -(BOOL)setIsSubscribedToEmails:(BOOL)subscribed;
    // [Availability (Deprecated = Platform.iOS | Platform.Mac)]
    [Export ("setIsSubscribedToEmails:")]
    bool SetIsSubscribedToEmails (bool subscribed);

    // -(BOOL)setEmailNotificationSubscriptionType:(ABKNotificationSubscriptionType)emailNotificationSubscriptionType;
    [Export ("setEmailNotificationSubscriptionType:")]
    bool SetEmailNotificationSubscriptionType (ABKNotificationSubscriptionType emailNotificationSubscriptionType);

    // -(BOOL)setPushNotificationSubscriptionType:(ABKNotificationSubscriptionType)pushNotificationSubscriptionType;
    [Export ("setPushNotificationSubscriptionType:")]
    bool SetPushNotificationSubscriptionType (ABKNotificationSubscriptionType pushNotificationSubscriptionType);

    // -(BOOL)setCustomAttributeWithKey:(NSString *)key andBOOLValue:(BOOL)value;
    [Export ("setCustomAttributeWithKey:andBOOLValue:")]
    bool SetCustomAttributeWithKey (string key, bool value);

    // -(BOOL)setCustomAttributeWithKey:(NSString *)key andIntegerValue:(NSInteger)value;
    [Export ("setCustomAttributeWithKey:andIntegerValue:")]
    bool SetCustomAttributeWithKey (string key, nint value);

    // -(BOOL)setCustomAttributeWithKey:(NSString *)key andDoubleValue:(double)value;
    [Export ("setCustomAttributeWithKey:andDoubleValue:")]
    bool SetCustomAttributeWithKey (string key, double value);

    // -(BOOL)setCustomAttributeWithKey:(NSString *)key andStringValue:(NSString *)value;
    [Export ("setCustomAttributeWithKey:andStringValue:")]
    bool SetCustomAttributeWithKey (string key, string value);

    // -(BOOL)setCustomAttributeWithKey:(NSString *)key andDateValue:(NSDate *)value;
    [Export ("setCustomAttributeWithKey:andDateValue:")]
    bool SetCustomAttributeWithKey (string key, NSDate value);

    // -(BOOL)unsetCustomAttributeWithKey:(NSString *)key;
    [Export ("unsetCustomAttributeWithKey:")]
    bool UnsetCustomAttributeWithKey (string key);

    // -(BOOL)incrementCustomUserAttribute:(NSString *)key;
    [Export ("incrementCustomUserAttribute:")]
    bool IncrementCustomUserAttribute (string key);

    // -(BOOL)incrementCustomUserAttribute:(NSString *)key by:(NSInteger)incrementValue;
    [Export ("incrementCustomUserAttribute:by:")]
    bool IncrementCustomUserAttribute (string key, nint incrementValue);

    // -(BOOL)addToCustomAttributeArrayWithKey:(NSString *)key value:(NSString *)value;
    [Export ("addToCustomAttributeArrayWithKey:value:")]
    bool AddToCustomAttributeArrayWithKey (string key, string value);

    // -(BOOL)removeFromCustomAttributeArrayWithKey:(NSString *)key value:(NSString *)value;
    [Export ("removeFromCustomAttributeArrayWithKey:value:")]
    bool RemoveFromCustomAttributeArrayWithKey (string key, string value);

    // -(BOOL)setCustomAttributeArrayWithKey:(NSString *)key array:(NSArray *)valueArray;
    [Export ("setCustomAttributeArrayWithKey:array:")]
    bool SetCustomAttributeArrayWithKey (string key, NSObject [] valueArray);

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

  // @interface ABKPushUtils : NSObject
  [BaseType (typeof(NSObject))]
  interface ABKPushUtils
  {
    // +(BOOL)isUninstallTrackingNotification:(NSDictionary *)userInfo;
    [Static]
    [Export ("isUninstallTrackingNotification:")]
    bool IsUninstallTrackingNotification (NSDictionary userInfo);
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
    // @property (copy, nonatomic) NSString * message;
    [Export ("message")]
    string Message { get; set; }

    // @property (retain, nonatomic) NSDictionary * extras;
    [Export ("extras", ArgumentSemantic.Retain), NullAllowed]
    NSDictionary Extras { get; set; }

    // @property (assign, nonatomic) NSTimeInterval duration;
    [Export ("duration")]
    double Duration { get; set; }

    // @property (readonly, assign, nonatomic) ABKInAppMessageClickActionType inAppMessageClickActionType;
    [Export ("inAppMessageClickActionType", ArgumentSemantic.Assign)]
    ABKInAppMessageClickActionType InAppMessageClickActionType { get; }

    // @property (readonly, copy, nonatomic) NSURL * uri;
    [Export ("uri", ArgumentSemantic.Copy)]
    NSUrl Uri { get; }

    // @property (assign, nonatomic) ABKInAppMessageDismissType inAppMessageDismissType;
    [Export ("inAppMessageDismissType", ArgumentSemantic.Assign)]
    ABKInAppMessageDismissType InAppMessageDismissType { get; set; }

    // @property (retain, nonatomic) UIColor * backgroundColor;
    [Export ("backgroundColor", ArgumentSemantic.Retain)]
    UIColor BackgroundColor { get; set; }

    // @property (retain, nonatomic) UIColor * textColor;
    [Export ("textColor", ArgumentSemantic.Retain)]
    UIColor TextColor { get; set; }

    // @property (retain, nonatomic) NSString * icon;
    [Export ("icon", ArgumentSemantic.Retain)]
    string Icon { get; set; }

    // @property (retain, nonatomic) UIColor * iconColor;
    [Export ("iconColor", ArgumentSemantic.Retain)]
    UIColor IconColor { get; set; }

    // @property (retain, nonatomic) UIColor * iconBackgroundColor;
    [Export ("iconBackgroundColor", ArgumentSemantic.Retain)]
    UIColor IconBackgroundColor { get; set; }

    // @property (copy, nonatomic) NSURL * imageURI;
    [Export ("imageURI", ArgumentSemantic.Copy)]
    NSUrl ImageURI { get; set; }

    // -(void)logInAppMessageImpression;
    [Export ("logInAppMessageImpression")]
    void LogInAppMessageImpression ();

    // -(void)logInAppMessageClicked;
    [Export ("logInAppMessageClicked")]
    void LogInAppMessageClicked ();

    // -(void)setInAppMessageClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSURL *)uri;
    [Export ("setInAppMessageClickAction:withURI:")]
    void SetInAppMessageClickAction (ABKInAppMessageClickActionType clickActionType, NSUrl uri);

    // -(NSData *)serializeToData;
    [Export ("serializeToData")]
    NSData SerializeToData { get; }
  }

  // @interface ABKInAppMessageViewController : UIViewController
  [BaseType (typeof(UIViewController))]
  interface ABKInAppMessageViewController
  {
    // @property (retain, nonatomic) ABKInAppMessage * inAppMessage;
    [Export ("inAppMessage", ArgumentSemantic.Retain)]
    ABKInAppMessage InAppMessage { get; set; }

    // @property (retain, nonatomic) UIImageView * iconImageView;
    [Export ("iconImageView", ArgumentSemantic.Retain)]
    UIImageView IconImageView { get; set; }

    // @property (retain, nonatomic) UILabel * iconLabelView;
    [Export ("iconLabelView", ArgumentSemantic.Retain)]
    UILabel IconLabelView { get; set; }

    // -(id)initWithInAppMessage:(ABKInAppMessage *)inAppMessage;
    [Export ("initWithInAppMessage:")]
    IntPtr Constructor (ABKInAppMessage inAppMessage);

    // -(void)hideInAppMessage:(BOOL)animated;
    [Export ("hideInAppMessage:")]
    void HideInAppMessage (bool animated);

    //(void)moveInAppMessageViewOffScreen:(CGRect)inAppMessageWindowFrame;
    [Export ("moveInAppMessageViewOffScreen:")]
    void MoveInAppMessageViewOffScreen (CGRect inAppMessageWindowFrame);

    //(void)moveInAppMessageViewOnScreen:(CGRect)inAppMessageWindowFrame;
    [Export ("moveInAppMessageViewOnScreen:")]
    void MoveInAppMessageViewOnScreen (CGRect inAppMessageWindowFrame);
  }


  // @interface ABKInAppMessageButton : UIButton
  [BaseType (typeof(UIButton))]
  interface ABKInAppMessageButton
  {
    // @property (copy, nonatomic) NSString * buttonText;
    [Export ("buttonText")]
    string ButtonText { get; set; }

    // @property (retain, nonatomic) UIColor * buttonBackgroundColor;
    [Export ("buttonBackgroundColor", ArgumentSemantic.Retain)]
    UIColor ButtonBackgroundColor { get; set; }

    // @property (retain, nonatomic) UIColor * buttonTextColor;
    [Export ("buttonTextColor", ArgumentSemantic.Retain)]
    UIColor ButtonTextColor { get; set; }

    // @property (readonly, assign, nonatomic) ABKInAppMessageClickActionType buttonClickActionType;
    [Export ("buttonClickActionType", ArgumentSemantic.Assign)]
    ABKInAppMessageClickActionType ButtonClickActionType { get; }

    // @property (readonly, copy, nonatomic) NSURL * buttonClickedURI;
    [Export ("buttonClickedURI", ArgumentSemantic.Copy)]
    NSUrl ButtonClickedURI { get; }

    // @property (readonly, assign, nonatomic) NSInteger buttonID;
    [Export ("buttonID", ArgumentSemantic.Assign)]
    nint ButtonID { get; }

    // -(void)setButtonClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSURL *)uri;
    [Export ("setButtonClickAction:withURI:")]
    void SetButtonClickAction (ABKInAppMessageClickActionType clickActionType, NSUrl uri);
  }

  // @interface ABKInAppMessageImmersive : ABKInAppMessage
  [BaseType (typeof(ABKInAppMessage))]
  interface ABKInAppMessageImmersive
  {
    // @property (copy, nonatomic) NSString * header;
    [Export ("header")]
    string Header { get; set; }

    // @property (retain, nonatomic) UIColor * headerTextColor;
    [Export ("headerTextColor", ArgumentSemantic.Retain)]
    UIColor HeaderTextColor { get; set; }

    // @property (retain, nonatomic) UIColor * closeButtonColor;
    [Export ("closeButtonColor", ArgumentSemantic.Retain)]
    UIColor CloseButtonColor { get; set; }

    // @property (readonly, retain, nonatomic) NSArray * buttons;
    [Export ("buttons", ArgumentSemantic.Retain)]
    NSObject[] Buttons { get; }

    // -(void)logInAppMessageClickedWithButtonID:(NSInteger)buttonID;
    [Export ("logInAppMessageClickedWithButtonID:")]
    void LogInAppMessageClickedWithButtonID (nint buttonID);

    // -(void)setInAppMessageButtons:(NSArray *)buttonArray;
    [Export ("setInAppMessageButtons:")]
    void SetInAppMessageButtons (NSObject[] buttonArray);
  }

  // @protocol ABKInAppMessageControllerDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof(NSObject))]
  interface ABKInAppMessageControllerDelegate
  {
    // @optional -(BOOL)onInAppMessageReceived:(ABKInAppMessage *)inAppMessage;
    [Export ("onInAppMessageReceived:")]
    bool OnInAppMessageReceived (ABKInAppMessage inAppMessage);

    // @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage *)inAppMessage withKeyboardIsUp:(BOOL)keyboardIsUp;
    [Export ("beforeInAppMessageDisplayed:withKeyboardIsUp:")]
    ABKInAppMessageDisplayChoice BeforeInAppMessageDisplayed (ABKInAppMessage inAppMessage, bool keyboardIsUp);

    // @optional -(ABKInAppMessageViewController *)inAppMessageViewControllerWithInAppMessage:(ABKInAppMessage *)inAppMessage;
    [Export ("inAppMessageViewControllerWithInAppMessage:")]
    ABKInAppMessageViewController InAppMessageViewControllerWithInAppMessage (ABKInAppMessage inAppMessage);

    // @optional -(void)onInAppMessageDismissed:(ABKInAppMessage *)inAppMessage;
    [Export ("onInAppMessageDismissed:")]
    void OnInAppMessageDismissed (ABKInAppMessage inAppMessage);

    // @optional -(BOOL)onInAppMessageClicked:(ABKInAppMessage *)inAppMessage;
    [Export ("onInAppMessageClicked:")]
    bool OnInAppMessageClicked (ABKInAppMessage inAppMessage);

    // @optional -(BOOL)onInAppMessageButtonClicked:(ABKInAppMessageImmersive *)inAppMessage button:(ABKInAppMessageButton *)button;
    [Export ("onInAppMessageButtonClicked:button:")]
    bool OnInAppMessageButtonClicked (ABKInAppMessageImmersive inAppMessage, ABKInAppMessageButton button);

    // @optional -(BOOL)onInAppMessageHTMLButtonClicked:(ABKInAppMessageHTML *)inAppMessage clickedURL:(NSURL *)clickedURL buttonID:(NSString *)buttonID;
    [Export ("onInAppMessageHTMLButtonClicked:clickedURL:buttonID:")]
    bool OnInAppMessageHTMLButtonClicked (ABKInAppMessageHTML inAppMessage, NSUrl clickedURL, string buttonID);
  }

  // @interface ABKInAppMessageController : NSObject
  [BaseType (typeof(NSObject))]
  interface ABKInAppMessageController
  {
    [Wrap ("WeakDelegate")]
    ABKInAppMessageControllerDelegate Delegate { get; set; }

    // @property (retain, nonatomic) id<ABKInAppMessageControllerDelegate> delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Retain)]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) UIInterfaceOrientationMask supportedOrientationMasks;
    [Export ("supportedOrientationMasks", ArgumentSemantic.Assign)]
    UIInterfaceOrientationMask SupportedOrientationMasks { get; set; }

    // @property (assign, nonatomic) UIInterfaceOrientation supportedOrientations;
    [Export ("supportedOrientations", ArgumentSemantic.Assign)]
    UIInterfaceOrientation SupportedOrientations { get; set; }

    // -(void)displayNextInAppMessageWithDelegate:(id<ABKInAppMessageControllerDelegate>)delegate;
    [Export ("displayNextInAppMessageWithDelegate:")]
    void DisplayNextInAppMessageWithDelegate (ABKInAppMessageControllerDelegate iamDelegate);

    // -(NSInteger)inAppMessagesRemainingOnStack;
    [Export ("inAppMessagesRemainingOnStack")]
    nint InAppMessagesRemainingOnStack { get; }

    // -(void)addInAppMessage:(ABKInAppMessage *)newInAppMessage;
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
    // @property (assign, nonatomic) BOOL hideChevron;
    [Export ("hideChevron")]
    bool HideChevron { get; set; }

    // @property (assign, nonatomic) ABKInAppMessageSlideupAnchor inAppMessageSlideupAnchor;
    [Export ("inAppMessageSlideupAnchor", ArgumentSemantic.Assign)]
    ABKInAppMessageSlideupAnchor InAppMessageSlideupAnchor { get; set; }

    // @property (retain, nonatomic) UIColor * chevronColor;
    [Export ("chevronColor", ArgumentSemantic.Retain)]
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
    // @property NSURL * assetsZipRemoteUrl;
    [Export ("assetsZipRemoteUrl", ArgumentSemantic.Assign)]
    NSUrl AssetsZipRemoteUrl { get; set; }

    // -(void)logInAppMessageHTMLClickWithButtonID:(NSString *)buttonID;
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
    // @property UIWebView * webView __attribute__((iboutlet));
    [Export ("webView", ArgumentSemantic.Assign)]
    UIWebView WebView { get; set; }
  }

  // @interface ABKInAppMessageHTMLFullViewController : ABKInAppMessageHTMLViewController
  [BaseType (typeof(ABKInAppMessageHTMLViewController))]
  interface ABKInAppMessageHTMLFullViewController
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
  interface ABKFeedViewControllerDelegate {

    // @required -(BOOL)onCardClicked:(ABKCard *)clickedCard feedViewController:(UIViewController *)newsFeed;
    [Export ("onCardClicked:feedViewController:")]
    [Abstract]
    bool FeedViewController (ABKCard clickedCard, UIViewController newsFeed);
  }

  // @interface ABKFeedController : NSObject
  [BaseType (typeof (NSObject))]
  interface ABKFeedController {

    // @property (readonly) NSArray * newsFeedCards;
    [Export ("newsFeedCards")]
    NSObject [] NewsFeedCards { get; }

    // @property (readonly) NSDate * lastUpdate;
    [Export ("lastUpdate")]
    NSDate LastUpdate { get; }

    // -(NSInteger)unreadCardCountForCategories:(ABKCardCategory)categories;
    [Export ("unreadCardCountForCategories:")]
    nint UnreadCardCountForCategories (ABKCardCategory categories);

    // -(NSInteger)cardCountForCategories:(ABKCardCategory)categories;
    [Export ("cardCountForCategories:")]
    nint CardCountForCategories (ABKCardCategory categories);

    // -(NSArray *)getCardsInCategories:(ABKCardCategory)categories;
    [Export ("getCardsInCategories:")]
    NSObject [] GetCardsInCategories (ABKCardCategory categories);
  }

  // @interface ABKFeedViewControllerGenericContext : UINavigationController <UINavigationControllerDelegate>
  [BaseType (typeof (UINavigationController))] //UINavigationControllerDelegate
  interface ABKFeedViewControllerGenericContext  {

    // @property (assign, nonatomic) CGFloat cardWidthForiPhone;
    [Export ("cardWidthForiPhone", ArgumentSemantic.UnsafeUnretained)]
    nfloat CardWidthForiPhone { get; set; }

    // @property (assign, nonatomic) CGFloat cardWidthForiPad;
    [Export ("cardWidthForiPad", ArgumentSemantic.UnsafeUnretained)]
    nfloat CardWidthForiPad { get; set; }

    // @property (assign, nonatomic) CGFloat minimumCardMarginForiPhone;
    [Export ("minimumCardMarginForiPhone", ArgumentSemantic.UnsafeUnretained)]
    nfloat MinimumCardMarginForiPhone { get; set; }

    // @property (assign, nonatomic) CGFloat minimumCardMarginForiPad;
    [Export ("minimumCardMarginForiPad", ArgumentSemantic.UnsafeUnretained)]
    nfloat MinimumCardMarginForiPad { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerDelegate> appboyDelegate;
    [Export ("appboyDelegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakAppboyDelegate { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerDelegate> appboyDelegate;
    [Wrap ("WeakAppboyDelegate")]
    ABKFeedViewControllerDelegate AppboyDelegate { get; set; }

    // @property (assign, nonatomic) ABKCardCategory categories;
    [Export ("categories", ArgumentSemantic.UnsafeUnretained)]
    ABKCardCategory Categories { get; set; }

    // @property (assign, nonatomic) BOOL disableUnreadIndicator;
    [Export ("disableUnreadIndicator", ArgumentSemantic.UnsafeUnretained)]
    bool DisableUnreadIndicator { get; set; }

    // -(void)closeButtonPressed:(id)sender;
    [Export ("closeButtonPressed:")]
    void CloseButtonPressed (NSObject sender);
  }

  // @protocol ABKFeedViewControllerModalContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedViewControllerModalContextDelegate {
    // - (void) feedViewControllerModalContextCloseTapped:(ABKFeedViewControllerModalContext *)sender;
    [Export ("feedViewControllerModalContextCloseTapped:")]
    bool FeedViewControllerModalContextCloseTapped (ABKFeedViewControllerModalContext sender);
  }

  // @interface ABKFeedViewControllerModalContext : ABKFeedViewControllerGenericContext
  [Protocol]
  [BaseType (typeof (ABKFeedViewControllerGenericContext))]
  interface ABKFeedViewControllerModalContext {

    // @property (retain, nonatomic) NSString * navigationBarTitle;
    [Export ("navigationBarTitle", ArgumentSemantic.Retain)]
    string NavigationBarTitle { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerModalContextDelegate> closeButtonDelegate;
    [Export ("closeButtonDelegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakCloseButtonDelegate { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerModalContextDelegate> closeButtonDelegate;
    [Wrap ("WeakCloseButtonDelegate")]
    ABKFeedViewControllerModalContextDelegate CloseButtonDelegate { get; set; }
  }

  // @interface ABKFeedViewController : UIViewController <UITableViewDataSource, UITableViewDelegate, SKStoreProductViewControllerDelegate>
  [BaseType (typeof (UIViewController))]
    interface ABKFeedViewController {

    // @property (nonatomic, assign) CGFloat cardWidthForiPhone;
    [Export ("cardWidthForiPhone", ArgumentSemantic.UnsafeUnretained)]
    nfloat CardWidthForiPhone { get; set; }

    // @property (nonatomic, assign) CGFloat cardWidthForiPad;
    [Export ("cardWidthForiPad", ArgumentSemantic.UnsafeUnretained)]
    nfloat CardWidthForiPad { get; set; }

    // @property (nonatomic, assign) CGFloat minimumCardMarginForiPhone;
    [Export ("minimumCardMarginForiPhone", ArgumentSemantic.UnsafeUnretained)]
    nfloat MinimumCardMarginForiPhone { get; set; }

    // @property (nonatomic, assign) CGFloat minimumCardMarginForiPad;
    [Export ("minimumCardMarginForiPad", ArgumentSemantic.UnsafeUnretained)]
    nfloat MinimumCardMarginForiPad { get; set; }

    // @property (nonatomic, assign) ABKCardCategory categories;
    [Export ("categories", ArgumentSemantic.UnsafeUnretained)]
    ABKCardCategory Categories { get; set; }

    // @property (nonatomic, assign) BOOL disableUnreadIndicator;
    [Export ("disableUnreadIndicator", ArgumentSemantic.UnsafeUnretained)]
    bool DisableUnreadIndicator { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerDelegate> appboyDelegate;
    [Export ("appboyDelegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakAppboyDelegate { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerDelegate> appboyDelegate;
    [Wrap ("WeakAppboyDelegate")]
    ABKFeedViewControllerDelegate AppboyDelegate { get; set; }
  }

  // @interface ABKFeedViewControllerNavigationContext : ABKFeedViewController <UINavigationControllerDelegate>;
  [BaseType (typeof (ABKFeedViewController))]
  interface ABKFeedViewControllerNavigationContext {}

  // @protocol ABKFeedViewControllerPopoverContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedViewControllerPopoverContextDelegate {
    // - (void) feedViewControllerPopoverContextCloseTapped:(ABKFeedViewControllerPopoverContext *)sender;
    [Export ("feedViewControllerPopoverContextCloseTapped:")]
    bool FeedViewControllerPopoverContextCloseTapped (ABKFeedViewControllerPopoverContext sender);
  }

  // @interface ABKFeedViewControllerPopoverContext : ABKFeedViewControllerGenericContext
  [Protocol]
  [BaseType (typeof (ABKFeedViewControllerGenericContext))]
  interface ABKFeedViewControllerPopoverContext {

    // @property (retain, nonatomic) NSString * navigationBarTitle;
    [Export ("navigationBarTitle", ArgumentSemantic.Retain)]
    string NavigationBarTitle { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerModalContextDelegate> closeButtonDelegate;
    [Export ("closeButtonDelegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakCloseButtonDelegate { get; set; }

    // @property (assign, nonatomic) id<ABKFeedViewControllerModalContextDelegate> closeButtonDelegate;
    [Wrap ("WeakCloseButtonDelegate")]
    ABKFeedViewControllerModalContextDelegate CloseButtonDelegate { get; set; }
  }

  // @interface ABKFeedbackViewController : UIViewController
  [BaseType (typeof (UIViewController))]
  interface ABKFeedbackViewController {

    // @property (assign, nonatomic) id delegate;
    [Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) id delegate;
    [Wrap ("WeakDelegate")]
    NSObject Delegate { get; set; }
  }

  /******************************************************************************************************************************************************
   * 
   * Feed Cards API
   * 
   ******************************************************************************************************************************************************/

  // @interface ABKCard : NSObject <NSCopying, NSCoding>
  [BaseType (typeof (NSObject))] // : NSCopying, NSCoding 
  interface ABKCard {

    // @property (readonly, nonatomic) NSString * idString;
    [Export ("idString")]
    string IdString { get; }

    // @property (assign, nonatomic) BOOL viewed;
    [Export ("viewed", ArgumentSemantic.UnsafeUnretained)]
    bool Viewed { get; set; }

    // @property (readonly, assign, nonatomic) double created;
    [Export ("created", ArgumentSemantic.UnsafeUnretained)]
    double Created { get; }

    // @property (readonly, assign, nonatomic) double updated;
    [Export ("updated", ArgumentSemantic.UnsafeUnretained)]
    double Updated { get; }

    // @property (assign, nonatomic) ABKCardCategory categories;
    [Export ("categories", ArgumentSemantic.UnsafeUnretained)]
    ABKCardCategory Categories { get; set; }

    // @property (readonly) double expiresAt;
    [Export ("expiresAt")]
    double ExpiresAt { get; }

    // +(ABKCard *)deserializeCardFromDictionary:(NSDictionary *)cardDictionary;
    [Static, Export ("deserializeCardFromDictionary:")]
    ABKCard DeserializeCardFromDictionary (NSDictionary cardDictionary);

    // -(NSData *)serializeToData;
    [Export ("serializeToData")]
    NSData SerializeToData ();

    // -(void)logCardImpression;
    [Export ("logCardImpression")]
    void LogCardImpression ();

    // -(void)logCardClicked;
    [Export ("logCardClicked")]
    void LogCardClicked ();

    // -(BOOL)hasSameId:(ABKCard *)card;
    [Export ("hasSameId:")]
    bool HasSameId (ABKCard card);

    // @property (retain, nonatomic) NSDictionary * extras;
    [Export ("extras", ArgumentSemantic.Retain)]
    NSDictionary Extras { get; set; }
  }

  // @interface ABKBannerCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKBannerCard {

    // @property (copy, nonatomic) NSString * image;
    [Export ("image")]
    string Image { get; set; }

    // @property (copy, nonatomic) NSString * url;
    [Export ("url")]
    string Url { get; set; }

    // @property (copy, nonatomic) NSString * domain;
    [Export ("domain")]
    string Domain { get; set; }

    // @property (assign, nonatomic) float imageAspectRatio;
    [Export ("imageAspectRatio", ArgumentSemantic.UnsafeUnretained)]
    float ImageAspectRatio { get; set; }
  }

  // @interface ABKCaptionedImageCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKCaptionedImageCard {

    // @property (copy, nonatomic) NSString * image;
    [Export ("image")]
    string Image { get; set; }

    // @property (assign, nonatomic) float imageAspectRatio;
    [Export ("imageAspectRatio", ArgumentSemantic.UnsafeUnretained)]
    float ImageAspectRatio { get; set; }

    // @property (copy, nonatomic) NSString * title;
    [Export ("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * cardDescription;
    [Export ("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy, nonatomic) NSString * url;
    [Export ("url")]
    string Url { get; set; }

    // @property (copy, nonatomic) NSString * domain;
    [Export ("domain")]
    string Domain { get; set; }
  }

  // @interface ABKClassicCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKClassicCard {

    // @property (copy, nonatomic) NSString * image;
    [Export ("image")]
    string Image { get; set; }

    // @property (copy, nonatomic) NSString * cardDescription;
    [Export ("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy, nonatomic) NSString * url;
    [Export ("url")]
    string Url { get; set; }

    // @property (copy, nonatomic) NSString * title;
    [Export ("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * domain;
    [Export ("domain")]
    string Domain { get; set; }
  }

  // @interface ABKCrossPromotionCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKCrossPromotionCard {

    // @property (copy, nonatomic) NSString * mediaType;
    [Export ("mediaType")]
    string MediaType { get; set; }

    // @property (copy, nonatomic) NSString * title;
    [Export ("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * subtitle;
    [Export ("subtitle")]
    string Subtitle { get; set; }

    // @property (copy, nonatomic) NSString * image;
    [Export ("image")]
    string Image { get; set; }

    // @property (copy, nonatomic) NSString * displayPrice;
    [Export ("displayPrice")]
    string DisplayPrice { get; set; }

    // @property (assign, nonatomic) long long iTunesId;
    [Export ("iTunesId", ArgumentSemantic.UnsafeUnretained)]
    long ITunesId { get; set; }

    // @property (assign, nonatomic) float rating;
    [Export ("rating", ArgumentSemantic.UnsafeUnretained)]
    float Rating { get; set; }

    // @property (assign, nonatomic) float price;
    [Export ("price", ArgumentSemantic.UnsafeUnretained)]
    float Price { get; set; }

    // @property (assign, nonatomic) int reviews;
    [Export ("reviews", ArgumentSemantic.UnsafeUnretained)]
    int Reviews { get; set; }

    // @property (copy, nonatomic) NSString * caption;
    [Export ("caption")]
    string Caption { get; set; }

    // @property (copy, nonatomic) NSString * url;
    [Export ("url")]
    string Url { get; set; }

    // @property (assign, nonatomic) BOOL universal;
    [Export ("universal", ArgumentSemantic.UnsafeUnretained)]
    bool Universal { get; set; }
  }

  // @interface ABKTextAnnouncementCard : ABKCard <NSCoding>
  [BaseType (typeof (ABKCard))]
  interface ABKTextAnnouncementCard {

    // @property (copy, nonatomic) NSString * title;
    [Export ("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * cardDescription;
    [Export ("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy, nonatomic) NSString * url;
    [Export ("url")]
    string Url { get; set; }

    // @property (copy, nonatomic) NSString * domain;
    [Export ("domain")]
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
  interface ABKFeedbackViewControllerModalContextDelegate {

    // - (void) feedbackViewControllerModalContextCancelTapped:(ABKFeedbackViewControllerModalContext *)sender;
    [Export ("feedbackViewControllerModalContextCancelTapped:")]
    void FeedbackViewControllerModalContextCancelTapped (ABKFeedbackViewControllerModalContext sender);

    // - (void) feedbackViewControllerModalContextFeedbackSent:(ABKFeedbackViewControllerModalContext *)sender;
    [Export ("feedbackViewControllerModalContextFeedbackSent:")]
    void FeedbackViewControllerModalContextFeedbackSent (ABKFeedbackViewControllerModalContext sender);

    // @optional -(NSString *)feedbackViewControllerBeforeFeedbackSent:(NSString *)message;
    [Export ("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent (string message);
  }

  // @interface ABKFeedbackViewControllerModalContext : UINavigationController
  [BaseType (typeof (UINavigationController))]
  interface ABKFeedbackViewControllerModalContext {

    // @property (assign, nonatomic) id <ABKFeedbackViewControllerModalContextDelegate> feedbackDelegate;
    [Export ("feedbackDelegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakFeedbackDelegate { get; set; }

    // @property (assign, nonatomic) id <ABKFeedbackViewControllerModalContextDelegate> feedbackDelegate;
    [Wrap ("WeakFeedbackDelegate")]
    NSObject FeedbackDelegate { get; set; }
  }

  // @protocol ABKFeedbackViewControllerNavigationContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedbackViewControllerNavigationContextDelegate {

    // - (void) feedbackViewControllerNavigationContextFeedbackSent:(ABKFeedbackViewControllerNavigationContext *)sender;
    [Export ("feedbackViewControllerNavigationContextFeedbackSent:")]
    void FeedbackViewControllerNavigationContextFeedbackSent (ABKFeedbackViewControllerNavigationContext sender);

    // @optional -(NSString *)feedbackViewControllerBeforeFeedbackSent:(NSString *)message;
    [Export ("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent (string message);
  }

  // @interface ABKFeedbackViewControllerNavigationContext : ABKFeedbackViewController
  [BaseType (typeof (ABKFeedbackViewController))]
  interface ABKFeedbackViewControllerNavigationContext {

    // @property (assign, nonatomic) id <ABKFeedbackViewControllerNavigationContextDelegate> delegate;
    [Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) id <ABKFeedbackViewControllerNavigationContextDelegate> delegate;
    [Wrap ("WeakDelegate")]
    NSObject Delegate { get; set; }
  }

  // @protocol ABKFeedbackViewControllerPopoverContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKFeedbackViewControllerPopoverContextDelegate {

    // - (void) feedbackViewControllerPopoverContextCancelTapped:(ABKFeedbackViewControllerPopoverContext *)sender;
    [Export ("feedbackViewControllerPopoverContextCancelTapped:")]
    void FeedbackViewControllerPopoverContextCancelTapped (ABKFeedbackViewControllerPopoverContext sender);

    // - (void) feedbackViewControllerPopoverContextFeedbackSent:(ABKFeedbackViewControllerPopoverContext *)sender;
    [Export ("feedbackViewControllerPopoverContextFeedbackSent:")]
    void FeedbackViewControllerPopoverContextFeedbackSent (ABKFeedbackViewControllerPopoverContext sender);

    // @optional -(NSString *)feedbackViewControllerBeforeFeedbackSent:(NSString *)message;
    [Export ("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent (string message);
  }

  // @interface ABKFeedbackViewControllerPopoverContext : ABKFeedbackViewController
  [BaseType (typeof (ABKFeedbackViewController))]
  interface ABKFeedbackViewControllerPopoverContext {

    // @property (assign, nonatomic) id <ABKFeedbackViewControllerPopoverContextDelegate> delegate;
    [Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
    [NullAllowed]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) id <ABKFeedbackViewControllerPopoverContextDelegate> delegate;
    [Wrap ("WeakDelegate")]
    NSObject Delegate { get; set; }
  }
}

