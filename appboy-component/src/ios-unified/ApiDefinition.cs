using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace AppboyPlatformXamariniOSBinding
{
  [Protocol]
  // @interface Appboy : NSObject
  [BaseType (typeof (NSObject))]
  interface Appboy {

    // @property (readonly, retain, nonatomic) ABKFeedController * feedController;
     [Export ("feedController", ArgumentSemantic.Retain)]
     ABKFeedController FeedController { get; }

    // @property (readonly, retain, nonatomic) ABKSlideupController * slideupController;
    [Export ("slideupController", ArgumentSemantic.Retain)]
    ABKSlideupController SlideupController { get; }

    // @property (readonly, retain, nonatomic) ABKUser * user;
    [Export ("user", ArgumentSemantic.Retain)]
    ABKUser User { get; }

    // @property (assign, nonatomic) BOOL useNUITheming;
    [Export ("useNUITheming", ArgumentSemantic.UnsafeUnretained)]
    bool UseNUITheming { get; set; }


    // @property (assign, nonatomic) ABKRequestProcessingPolicy requestProcessingPolicy;
    [Export ("requestProcessingPolicy", ArgumentSemantic.UnsafeUnretained)]
    ABKRequestProcessingPolicy RequestProcessingPolicy { get; set; }

    // +(Appboy *)sharedInstance;
    [Static, Export ("sharedInstance")]
    Appboy SharedInstance ();

    // +(void)startWithApiKey:(NSString *)apiKey inApplication:(UIApplication *)application withLaunchOptions:(NSDictionary *)launchOptions;
    [Static, Export ("startWithApiKey:inApplication:withLaunchOptions:")]
    void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions);

    // +(void)startWithApiKey:(NSString *)apiKey inApplication:(UIApplication *)application withLaunchOptions:(NSDictionary *)launchOptions withAppboyOptions:(NSDictionary *)appboyOptions;
    [Static, Export ("startWithApiKey:inApplication:withLaunchOptions:withAppboyOptions:")]
    void StartWithApiKey (string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions, NSDictionary appboyOptions);

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

    // -(void)logPurchase:(NSString *)productIdentifier inCurrency:(NSString *)currencyCode atPrice:(NSDecimalNumber *)price;
    [Export ("logPurchase:inCurrency:atPrice:")]
    void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price);

    // -(void)logPurchase:(NSString *)productIdentifier inCurrency:(NSString *)currencyCode atPrice:(NSDecimalNumber *)price withQuantity:(NSUInteger)quantity;
    [Export ("logPurchase:inCurrency:atPrice:withQuantity:")]
    void LogPurchase (string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity);

    // -(void)logSocialShare:(ABKSocialNetwork)socialNetwork;
    [Export ("logSocialShare:")]
    void LogSocialShare (ABKSocialNetwork socialNetwork);

    // -(void)promptUserForAccessToSocialNetwork:(ABKSocialNetwork)socialNetwork;
    [Export ("promptUserForAccessToSocialNetwork:")]
    void PromptUserForAccessToSocialNetwork (ABKSocialNetwork socialNetwork);

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

    // -(void)requestSlideupRefresh;
    [Export ("requestSlideupRefresh")]
    void RequestSlideupRefresh ();
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

    // @property (copy, nonatomic) NSString * bio;
    [Export ("bio")]
    string Bio { get; set; }

    // @property (copy, nonatomic) NSString * phone;
    [Export ("phone")]
    string Phone { get; set; }

    // @property (copy, nonatomic) NSString * foursquareAccessToken;
    [Export ("foursquareAccessToken")]
    string FoursquareAccessToken { get; set; }

    // @property (readonly, copy, nonatomic) NSString * userID;
    [Export ("userID")]
    string UserID { get; }

    // @property (copy, nonatomic) NSString * avatarImageURL;
    [Export ("avatarImageURL")]
    string AvatarImageURL { get; set; }

    // @property (copy, nonatomic) NSString * twitterAccountIdentifier;
    [Export ("twitterAccountIdentifier")]
    string TwitterAccountIdentifier { get; set; }

    // @property (assign, nonatomic) BOOL clearTwitterDataWhenNoDataOfTwitterIdentifier;
    [Export ("clearTwitterDataWhenNoDataOfTwitterIdentifier", ArgumentSemantic.UnsafeUnretained)]
    bool ClearTwitterDataWhenNoDataOfTwitterIdentifier { get; set; }

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

  /******************************************************************************************************************************************************
   * 
   * Slideup API
   * 
   ******************************************************************************************************************************************************/

  // @interface ABKSlideup : NSObject
  [Protocol]
  [BaseType (typeof (NSObject))]
  interface ABKSlideup {

    // @property (copy, nonatomic) NSString * message;
    [Export ("message")]
    string Message { get; set; }

    // @property (assign, nonatomic) BOOL hideChevron;
    [Export ("hideChevron", ArgumentSemantic.UnsafeUnretained)]
    bool HideChevron { get; set; }

    // @property (retain, nonatomic) NSDictionary * extras;
    [Export ("extras", ArgumentSemantic.Retain), NullAllowed]
    NSDictionary Extras { get; set; }

    // @property (assign, nonatomic) ABKSlideupAnchor slideupAnchor;
    [Export ("slideupAnchor", ArgumentSemantic.UnsafeUnretained)]
    ABKSlideupAnchor SlideupAnchor { get; set; }

    // @property (assign, nonatomic) NSTimeInterval duration;
    [Export ("duration", ArgumentSemantic.UnsafeUnretained)]
    double Duration { get; set; }

    // @property (assign, nonatomic) ABKSlideupDismissType slideupDismissType;
    [Export ("slideupDismissType", ArgumentSemantic.UnsafeUnretained)]
    ABKSlideupDismissType SlideupDismissType { get; set; }

    // @property (readonly, assign, nonatomic) ABKSlideupClickActionType slideupClickActionType;
    [Export ("slideupClickActionType", ArgumentSemantic.UnsafeUnretained)]
    ABKSlideupClickActionType SlideupClickActionType { get; }

    // @property (readonly, copy, nonatomic) NSURL * uri;
    [Export ("uri", ArgumentSemantic.Copy)]
    NSUrl Uri { get; }

    // -(void)logSlideupImpression;
    [Export ("logSlideupImpression")]
    void LogSlideupImpression ();

    // -(void)logSlideupClicked;
    [Export ("logSlideupClicked")]
    void LogSlideupClicked ();

    // -(void)setSlideupClickActionToUri:(NSURL *)uri;
    [Export ("setSlideupClickActionToUri:")]
    void SetSlideupClickActionToUri (NSUrl uri);

    // -(void)setSlideupClickActionToNewsFeed;
    [Export ("setSlideupClickActionToNewsFeed")]
    void SetSlideupClickActionToNewsFeed ();

    // -(void)setSlideupClickActionToNone;
    [Export ("setSlideupClickActionToNone")]
    void SetSlideupClickActionToNone ();

    // -(NSData *)serializeToData;
    [Export ("serializeToData")]
    NSData SerializeToData ();
  }
    
  // @protocol ABKSlideupControllerDelegate <NSObject>
  [Protocol, Model]
  [BaseType (typeof (NSObject))]
  interface ABKSlideupControllerDelegate {

    // @optional -(BOOL)onSlideupReceived:(ABKSlideup *)slideup;
    [Export ("onSlideupReceived:")]
    bool OnSlideupReceived (ABKSlideup slideup);

    // @optional -(ABKSlideupDisplayChoice)beforeSlideupDisplayed:(ABKSlideup *)slideup withKeyboardIsUp:(BOOL)keyboardIsUp;
    [Export ("beforeSlideupDisplayed:withKeyboardIsUp:")]
    ABKSlideupDisplayChoice WithKeyboardIsUp (ABKSlideup slideup, bool keyboardIsUp);

    // @optional -(void)onSlideupDismissed:(ABKSlideup *)slideup;
    [Export ("onSlideupDismissed:")]
    void OnSlideupDismissed (ABKSlideup slideup);

    // @optional -(BOOL)onSlideupClicked:(ABKSlideup *)slideup;
    [Export ("onSlideupClicked:")]
    bool OnSlideupClicked (ABKSlideup slideup);
  }

  // @interface ABKSlideupController : NSObject
  [Protocol]
  [BaseType (typeof (NSObject))]
  interface ABKSlideupController {

    // @property (retain, nonatomic) id<ABKSlideupControllerDelegate> delegate;
    [Export ("delegate", ArgumentSemantic.Retain)]
    [NullAllowed]
    NSObject WeakDelegate { get; set; }

    // @property (retain, nonatomic) id<ABKSlideupControllerDelegate> delegate;
    [Wrap ("WeakDelegate")]
    ABKSlideupControllerDelegate Delegate { get; set; }

    // @property (assign, nonatomic) UIInterfaceOrientationMask supportedOrientationMasks;
    [Export ("supportedOrientationMasks", ArgumentSemantic.UnsafeUnretained)]
    UIInterfaceOrientationMask SupportedOrientationMasks { get; set; }

    // @property (assign, nonatomic) UIInterfaceOrientation supportedOrientations;
    [Export ("supportedOrientations", ArgumentSemantic.UnsafeUnretained)]
    UIInterfaceOrientation SupportedOrientations { get; set; }

    // -(void)displayNextSlideupWithDelegate:(id<ABKSlideupControllerDelegate>)delegate;
    [Export ("displayNextSlideupWithDelegate:")]
    void DisplayNextSlideupWithDelegate (ABKSlideupControllerDelegate slideupDelegate);

    // -(NSInteger)slideupsRemainingOnStack;
    [Export ("slideupsRemainingOnStack")]
    nint SlideupsRemainingOnStack ();

    // -(void)addSlideup:(ABKSlideup *)newSlideup;
    [Export ("addSlideup:")]
    void AddSlideup (ABKSlideup newSlideup);

    // -(void)hideCurrentSlideup:(BOOL)animated;
    [Export ("hideCurrentSlideup:")]
    void HideCurrentSlideup (bool animated);
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

