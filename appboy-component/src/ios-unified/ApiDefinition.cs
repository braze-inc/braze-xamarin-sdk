using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using StoreKit;
using UIKit;
using UserNotifications;

namespace AppboyPlatformXamariniOSBinding
{

  // @protocol ABKAppboyEndpointDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKAppboyEndpointDelegate
  {
    // @required -(NSString * _Nonnull)getApiEndpoint:(NSString * _Nonnull)appboyApiEndpoint;
    [Abstract]
    [Export("getApiEndpoint:")]
    string GetApiEndpoint(string appboyApiEndpoint);
  }

  // @interface ABKAttributionData : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKAttributionData
  {
    // -(instancetype _Nonnull)initWithNetwork:(NSString * _Nullable)network campaign:(NSString * _Nullable)campaign adGroup:(NSString * _Nullable)adGroup creative:(NSString * _Nullable)creative;
    [Export("initWithNetwork:campaign:adGroup:creative:")]
    IntPtr Constructor([NullAllowed] string network, [NullAllowed] string campaign, [NullAllowed] string adGroup, [NullAllowed] string creative);

    // @property (readonly, nonatomic) NSString * _Nullable network;
    [NullAllowed, Export("network")]
    string Network { get; }

    // @property (readonly, nonatomic) NSString * _Nullable campaign;
    [NullAllowed, Export("campaign")]
    string Campaign { get; }

    // @property (readonly, nonatomic) NSString * _Nullable adGroup;
    [NullAllowed, Export("adGroup")]
    string AdGroup { get; }

    // @property (readonly, nonatomic) NSString * _Nullable creative;
    [NullAllowed, Export("creative")]
    string Creative { get; }
  }

  // @interface ABKFeedController : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKFeedController
  {
    // extern NSString *const _Nonnull ABKFeedUpdatedNotification;
    [Field("ABKFeedUpdatedNotification", "__Internal")]
    NSString ABKFeedUpdatedNotification { get; }

    // extern NSString *const _Nonnull ABKFeedUpdatedIsSuccessfulKey;
    [Field("ABKFeedUpdatedIsSuccessfulKey", "__Internal")]
    NSString ABKFeedUpdatedIsSuccessfulKey { get; }

    // @property (readonly, getter = getNewsFeedCards) NSArray * _Nonnull newsFeedCards;
    [Export("newsFeedCards")]
    NSObject[] NewsFeedCards { [Bind("getNewsFeedCards")] get; }

    // @property (readonly) NSDate * _Nullable lastUpdate;
    [NullAllowed, Export("lastUpdate")]
    NSDate LastUpdate { get; }

    // -(NSInteger)unreadCardCountForCategories:(ABKCardCategory)categories;
    [Export("unreadCardCountForCategories:")]
    nint UnreadCardCountForCategories(ABKCardCategory categories);

    // -(NSInteger)cardCountForCategories:(ABKCardCategory)categories;
    [Export("cardCountForCategories:")]
    nint CardCountForCategories(ABKCardCategory categories);

    // -(NSArray * _Nonnull)getCardsInCategories:(ABKCardCategory)categories;
    [Export("getCardsInCategories:")]
    NSObject[] GetCardsInCategories(ABKCardCategory categories);
  }

  // @interface ABKCard : NSObject <NSCopying, NSCoding>
  [BaseType(typeof(NSObject))]
  interface ABKCard : INSCopying, INSCoding
  {
    // @property (readonly) NSString * _Nonnull idString;
    [Export("idString")]
    string IdString { get; }

    // @property (nonatomic) BOOL viewed;
    [Export("viewed")]
    bool Viewed { get; set; }

    // @property (readonly, nonatomic) double created;
    [Export("created")]
    double Created { get; }

    // @property (readonly, nonatomic) double updated;
    [Export("updated")]
    double Updated { get; }

    // @property ABKCardCategory categories;
    [Export("categories", ArgumentSemantic.Assign)]
    ABKCardCategory Categories { get; set; }

    // @property (readonly) double expiresAt;
    [Export("expiresAt")]
    double ExpiresAt { get; }

    // @property (strong) NSDictionary * _Nullable extras;
    [NullAllowed, Export("extras", ArgumentSemantic.Strong)]
    NSDictionary Extras { get; set; }

    // @property (copy) NSString * _Nullable urlString;
    [NullAllowed, Export("urlString")]
    string UrlString { get; set; }

    // @property BOOL openUrlInWebView;
    [Export("openUrlInWebView")]
    bool OpenUrlInWebView { get; set; }

    // +(ABKCard * _Nullable)deserializeCardFromDictionary:(NSDictionary * _Nullable)cardDictionary;
    [Static]
    [Export("deserializeCardFromDictionary:")]
    [return: NullAllowed]
    ABKCard DeserializeCardFromDictionary([NullAllowed] NSDictionary cardDictionary);

    // -(NSData * _Nullable)serializeToData;
    [NullAllowed, Export("serializeToData")]
    NSData SerializeToData { get; }

    // -(void)logCardImpression;
    [Export("logCardImpression")]
    void LogCardImpression();

    // -(void)logCardClicked;
    [Export("logCardClicked")]
    void LogCardClicked();

    // -(BOOL)hasSameId:(ABKCard * _Nonnull)card;
    [Export("hasSameId:")]
    bool HasSameId(ABKCard card);
  }

  // @interface ABKBannerCard : ABKCard <NSCoding>
  [BaseType(typeof(ABKCard))]
  interface ABKBannerCard : INSCoding
  {
    // @property (copy) NSString * _Nonnull image;
    [Export("image")]
    string Image { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export("domain")]
    string Domain { get; set; }

    // @property float imageAspectRatio;
    [Export("imageAspectRatio")]
    float ImageAspectRatio { get; set; }
  }

  // @interface ABKCaptionedImageCard : ABKCard <NSCoding>
  [BaseType(typeof(ABKCard))]
  interface ABKCaptionedImageCard : INSCoding
  {
    // @property (copy) NSString * _Nonnull image;
    [Export("image")]
    string Image { get; set; }

    // @property float imageAspectRatio;
    [Export("imageAspectRatio")]
    float ImageAspectRatio { get; set; }

    // @property (copy) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // @property (copy) NSString * _Nonnull cardDescription;
    [Export("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export("domain")]
    string Domain { get; set; }
  }

  // @interface ABKClassicCard : ABKCard <NSCoding>
  [BaseType(typeof(ABKCard))]
  interface ABKClassicCard : INSCoding
  {
    // @property (copy) NSString * _Nullable image;
    [NullAllowed, Export("image")]
    string Image { get; set; }

    // @property (copy) NSString * _Nonnull cardDescription;
    [Export("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy) NSString * _Nullable title;
    [NullAllowed, Export("title")]
    string Title { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export("domain")]
    string Domain { get; set; }
  }

  // @interface ABKCrossPromotionCard : ABKCard <NSCoding>
  [BaseType(typeof(ABKCard))]
  interface ABKCrossPromotionCard : INSCoding
  {
    // @property (copy) NSString * _Nonnull mediaType;
    [Export("mediaType")]
    string MediaType { get; set; }

    // @property (copy) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // @property (copy) NSString * _Nonnull subtitle;
    [Export("subtitle")]
    string Subtitle { get; set; }

    // @property (copy) NSString * _Nonnull image;
    [Export("image")]
    string Image { get; set; }

    // @property (copy) NSString * _Nullable displayPrice;
    [NullAllowed, Export("displayPrice")]
    string DisplayPrice { get; set; }

    // @property (nonatomic) long long iTunesId;
    [Export("iTunesId")]
    long ITunesId { get; set; }

    // @property (nonatomic) float rating;
    [Export("rating")]
    float Rating { get; set; }

    // @property (nonatomic) float price;
    [Export("price")]
    float Price { get; set; }

    // @property (nonatomic) int reviews;
    [Export("reviews")]
    int Reviews { get; set; }

    // @property (copy) NSString * _Nonnull caption;
    [Export("caption")]
    string Caption { get; set; }

    // @property BOOL universal;
    [Export("universal")]
    bool Universal { get; set; }
  }

  // @interface ABKUser : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKUser
  {
    // @property (copy, nonatomic) NSString * _Nullable firstName;
    [NullAllowed, Export("firstName")]
    string FirstName { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable lastName;
    [NullAllowed, Export("lastName")]
    string LastName { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable email;
    [NullAllowed, Export("email")]
    string Email { get; set; }

    // @property (copy, nonatomic) NSDate * _Nullable dateOfBirth;
    [NullAllowed, Export("dateOfBirth", ArgumentSemantic.Copy)]
    NSDate DateOfBirth { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable country;
    [NullAllowed, Export("country")]
    string Country { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable homeCity;
    [NullAllowed, Export("homeCity")]
    string HomeCity { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable phone;
    [NullAllowed, Export("phone")]
    string Phone { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable foursquareAccessToken;
    [NullAllowed, Export("foursquareAccessToken")]
    string FoursquareAccessToken { get; set; }

    // @property (readonly, copy, nonatomic) NSString * _Nonnull userID;
    [Export("userID")]
    string UserID { get; }

    // @property (copy, nonatomic) NSString * _Nullable avatarImageURL;
    [NullAllowed, Export("avatarImageURL")]
    string AvatarImageURL { get; set; }

    // @property (strong) ABKFacebookUser * _Nullable facebookUser;
    [NullAllowed, Export("facebookUser", ArgumentSemantic.Strong)]
    ABKFacebookUser FacebookUser { get; set; }

    // @property (strong) ABKTwitterUser * _Nullable twitterUser;
    [NullAllowed, Export("twitterUser", ArgumentSemantic.Strong)]
    ABKTwitterUser TwitterUser { get; set; }

    // @property (strong) ABKAttributionData * _Nullable attributionData;
    [NullAllowed, Export("attributionData", ArgumentSemantic.Strong)]
    ABKAttributionData AttributionData { get; set; }

    // -(BOOL)setGender:(ABKUserGenderType)gender;
    [Export("setGender:")]
    bool SetGender(ABKUserGenderType gender);

    // -(BOOL)setEmailNotificationSubscriptionType:(ABKNotificationSubscriptionType)emailNotificationSubscriptionType;
    [Export("setEmailNotificationSubscriptionType:")]
    bool SetEmailNotificationSubscriptionType(ABKNotificationSubscriptionType emailNotificationSubscriptionType);

    // -(BOOL)setPushNotificationSubscriptionType:(ABKNotificationSubscriptionType)pushNotificationSubscriptionType;
    [Export("setPushNotificationSubscriptionType:")]
    bool SetPushNotificationSubscriptionType(ABKNotificationSubscriptionType pushNotificationSubscriptionType);

    // -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andBOOLValue:(BOOL)value;
    [Export("setCustomAttributeWithKey:andBOOLValue:")]
    bool SetCustomAttributeWithKey(string key, bool value);

    // -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andIntegerValue:(NSInteger)value;
    [Export("setCustomAttributeWithKey:andIntegerValue:")]
    bool SetCustomAttributeWithKey(string key, nint value);

    // -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andDoubleValue:(double)value;
    [Export("setCustomAttributeWithKey:andDoubleValue:")]
    bool SetCustomAttributeWithKey(string key, double value);

    // -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andStringValue:(NSString * _Nonnull)value;
    [Export("setCustomAttributeWithKey:andStringValue:")]
    bool SetCustomAttributeWithKey(string key, string value);

    // -(BOOL)setCustomAttributeWithKey:(NSString * _Nonnull)key andDateValue:(NSDate * _Nonnull)value;
    [Export("setCustomAttributeWithKey:andDateValue:")]
    bool SetCustomAttributeWithKey(string key, NSDate value);

    // -(BOOL)unsetCustomAttributeWithKey:(NSString * _Nonnull)key;
    [Export("unsetCustomAttributeWithKey:")]
    bool UnsetCustomAttributeWithKey(string key);

    // -(BOOL)incrementCustomUserAttribute:(NSString * _Nonnull)key;
    [Export("incrementCustomUserAttribute:")]
    bool IncrementCustomUserAttribute(string key);

    // -(BOOL)incrementCustomUserAttribute:(NSString * _Nonnull)key by:(NSInteger)incrementValue;
    [Export("incrementCustomUserAttribute:by:")]
    bool IncrementCustomUserAttribute(string key, nint incrementValue);

    // -(BOOL)addToCustomAttributeArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
    [Export("addToCustomAttributeArrayWithKey:value:")]
    bool AddToCustomAttributeArrayWithKey(string key, string value);

    // -(BOOL)removeFromCustomAttributeArrayWithKey:(NSString * _Nonnull)key value:(NSString * _Nonnull)value;
    [Export("removeFromCustomAttributeArrayWithKey:value:")]
    bool RemoveFromCustomAttributeArrayWithKey(string key, string value);

    // -(BOOL)setCustomAttributeArrayWithKey:(NSString * _Nonnull)key array:(NSArray * _Nullable)valueArray;
    [Export("setCustomAttributeArrayWithKey:array:")]
    bool SetCustomAttributeArrayWithKey(string key, [NullAllowed] NSObject[] valueArray);

    // -(BOOL)setLastKnownLocationWithLatitude:(double)latitude longitude:(double)longitude horizontalAccuracy:(double)horizontalAccuracy;
    [Export("setLastKnownLocationWithLatitude:longitude:horizontalAccuracy:")]
    bool SetLastKnownLocationWithLatitude(double latitude, double longitude, double horizontalAccuracy);

    // -(BOOL)setLastKnownLocationWithLatitude:(double)latitude longitude:(double)longitude horizontalAccuracy:(double)horizontalAccuracy altitude:(double)altitude verticalAccuracy:(double)verticalAccuracy;
    [Export("setLastKnownLocationWithLatitude:longitude:horizontalAccuracy:altitude:verticalAccuracy:")]
    bool SetLastKnownLocationWithLatitude(double latitude, double longitude, double horizontalAccuracy, double altitude, double verticalAccuracy);
  }

  // @interface ABKFacebookUser : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKFacebookUser
  {
    // extern const NSInteger DefaultNumberOfFriends;
    [Field("DefaultNumberOfFriends", "__Internal")]
    nint DefaultNumberOfFriends { get; }

    // -(instancetype _Nonnull)initWithFacebookUserDictionary:(NSDictionary * _Nullable)facebookUserDictionary numberOfFriends:(NSInteger)numberOfFriends likes:(NSArray * _Nullable)likes;
    [Export("initWithFacebookUserDictionary:numberOfFriends:likes:")]
    IntPtr Constructor([NullAllowed] NSDictionary facebookUserDictionary, nint numberOfFriends, [NullAllowed] NSObject[] likes);

    // @property (readonly) NSDictionary * _Nullable facebookUserDictionary;
    [NullAllowed, Export("facebookUserDictionary")]
    NSDictionary FacebookUserDictionary { get; }

    // @property (readonly) NSInteger numberOfFriends;
    [Export("numberOfFriends")]
    nint NumberOfFriends { get; }

    // @property (readonly) NSArray * _Nullable likes;
    [NullAllowed, Export("likes")]
    NSObject[] Likes { get; }
  }

  // @interface ABKFeedback : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKFeedback
  {
    // @property (copy) NSString * _Nonnull message;
    [Export("message")]
    string Message { get; set; }

    // @property (copy) NSString * _Nonnull email;
    [Export("email")]
    string Email { get; set; }

    // @property BOOL isBug;
    [Export("isBug")]
    bool IsBug { get; set; }

    // -(instancetype _Nonnull)initWithFeedbackMessage:(NSString * _Nonnull)message email:(NSString * _Nonnull)email isBug:(BOOL)isBug;
    [Export("initWithFeedbackMessage:email:isBug:")]
    IntPtr Constructor(string message, string email, bool isBug);

    // -(ABKFeedbackValidation)feedbackValidation;
    [Export("feedbackValidation")]
    ABKFeedbackValidation FeedbackValidation { get; }
  }

  // @interface ABKFeedbackViewController : UIViewController
  [BaseType(typeof(UIViewController))]
  interface ABKFeedbackViewController
  {
    [Wrap("WeakDelegate")]
    [NullAllowed]
    NSObject Delegate { get; set; }

    // @property (nonatomic, weak) id _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }
  }

  // @protocol ABKFeedbackViewControllerModalContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKFeedbackViewControllerModalContextDelegate
  {
    // @optional -(void)feedbackViewControllerModalContextCancelTapped:(ABKFeedbackViewControllerModalContext * _Nonnull)sender;
    [Export("feedbackViewControllerModalContextCancelTapped:")]
    void FeedbackViewControllerModalContextCancelTapped(ABKFeedbackViewControllerModalContext sender);

    // @optional -(void)feedbackViewControllerModalContextFeedbackSent:(ABKFeedbackViewControllerModalContext * _Nonnull)sender;
    [Export("feedbackViewControllerModalContextFeedbackSent:")]
    void FeedbackViewControllerModalContextFeedbackSent(ABKFeedbackViewControllerModalContext sender);

    // @optional -(NSString * _Nonnull)feedbackViewControllerBeforeFeedbackSent:(NSString * _Nonnull)message;
    [Export("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent(string message);
  }

  // @interface ABKFeedbackViewControllerModalContext : UINavigationController
  [BaseType(typeof(UINavigationController))]
  interface ABKFeedbackViewControllerModalContext
  {
    [Wrap("WeakFeedbackDelegate")]
    [NullAllowed]
    ABKFeedbackViewControllerModalContextDelegate FeedbackDelegate { get; set; }

    // @property (weak) id<ABKFeedbackViewControllerModalContextDelegate> _Nullable feedbackDelegate;
    [NullAllowed, Export("feedbackDelegate", ArgumentSemantic.Weak)]
    NSObject WeakFeedbackDelegate { get; set; }
  }

  // @protocol ABKFeedbackViewControllerNavigationContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKFeedbackViewControllerNavigationContextDelegate
  {
    // @required -(void)feedbackViewControllerNavigationContextFeedbackSent:(ABKFeedbackViewControllerNavigationContext * _Nonnull)sender;
    [Abstract]
    [Export("feedbackViewControllerNavigationContextFeedbackSent:")]
    void FeedbackViewControllerNavigationContextFeedbackSent(ABKFeedbackViewControllerNavigationContext sender);

    // @optional -(NSString * _Nonnull)feedbackViewControllerBeforeFeedbackSent:(NSString * _Nonnull)message;
    [Export("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent(string message);
  }

  // @interface ABKFeedbackViewControllerNavigationContext : ABKFeedbackViewController
  [BaseType(typeof(ABKFeedbackViewController))]
  interface ABKFeedbackViewControllerNavigationContext
  {
    [Wrap("WeakDelegate")]
    [NullAllowed]
    ABKFeedbackViewControllerNavigationContextDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<ABKFeedbackViewControllerNavigationContextDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }
  }

  // @protocol ABKFeedbackViewControllerPopoverContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKFeedbackViewControllerPopoverContextDelegate
  {
    // @required -(void)feedbackViewControllerPopoverContextCancelTapped:(ABKFeedbackViewControllerPopoverContext * _Nonnull)sender;
    [Abstract]
    [Export("feedbackViewControllerPopoverContextCancelTapped:")]
    void FeedbackViewControllerPopoverContextCancelTapped(ABKFeedbackViewControllerPopoverContext sender);

    // @required -(void)feedbackViewControllerPopoverContextFeedbackSent:(ABKFeedbackViewControllerPopoverContext * _Nonnull)sender;
    [Abstract]
    [Export("feedbackViewControllerPopoverContextFeedbackSent:")]
    void FeedbackViewControllerPopoverContextFeedbackSent(ABKFeedbackViewControllerPopoverContext sender);

    // @optional -(NSString * _Nonnull)feedbackViewControllerBeforeFeedbackSent:(NSString * _Nonnull)message;
    [Export("feedbackViewControllerBeforeFeedbackSent:")]
    string FeedbackViewControllerBeforeFeedbackSent(string message);
  }

  // @interface ABKFeedbackViewControllerPopoverContext : ABKFeedbackViewController
  [BaseType(typeof(ABKFeedbackViewController))]
  interface ABKFeedbackViewControllerPopoverContext
  {
    [Wrap("WeakDelegate")]
    [NullAllowed]
    ABKFeedbackViewControllerPopoverContextDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<ABKFeedbackViewControllerPopoverContextDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }
  }

  // @protocol ABKFeedViewControllerDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKFeedViewControllerDelegate
  {
    // @optional -(BOOL)onCardClicked:(ABKCard * _Nonnull)clickedCard feedViewController:(UIViewController * _Nonnull)newsFeed;
    [Export("onCardClicked:feedViewController:")]
    bool FeedViewController(ABKCard clickedCard, UIViewController newsFeed);
  }

  // @interface ABKFeedViewController : UIViewController <UITableViewDataSource, UITableViewDelegate, SKStoreProductViewControllerDelegate>
  [BaseType(typeof(UIViewController))]
  interface ABKFeedViewController : IUITableViewDataSource, IUITableViewDelegate, ISKStoreProductViewControllerDelegate
  {
    // @property CGFloat cardWidthForiPhone;
    [Export("cardWidthForiPhone")]
    nfloat CardWidthForiPhone { get; set; }

    // @property CGFloat cardWidthForiPad;
    [Export("cardWidthForiPad")]
    nfloat CardWidthForiPad { get; set; }

    // @property CGFloat minimumCardMarginForiPhone;
    [Export("minimumCardMarginForiPhone")]
    nfloat MinimumCardMarginForiPhone { get; set; }

    // @property CGFloat minimumCardMarginForiPad;
    [Export("minimumCardMarginForiPad")]
    nfloat MinimumCardMarginForiPad { get; set; }

    [Wrap("WeakAppboyDelegate")]
    [NullAllowed]
    ABKFeedViewControllerDelegate AppboyDelegate { get; set; }

    // @property (weak) id<ABKFeedViewControllerDelegate> _Nullable appboyDelegate;
    [NullAllowed, Export("appboyDelegate", ArgumentSemantic.Weak)]
    NSObject WeakAppboyDelegate { get; set; }

    // @property (nonatomic) ABKCardCategory categories;
    [Export("categories", ArgumentSemantic.Assign)]
    ABKCardCategory Categories { get; set; }

    // @property (nonatomic) BOOL disableUnreadIndicator;
    [Export("disableUnreadIndicator")]
    bool DisableUnreadIndicator { get; set; }
  }

  // @interface ABKFeedViewControllerGenericContext : UINavigationController <UINavigationControllerDelegate>
  [BaseType(typeof(UINavigationController))]
  interface ABKFeedViewControllerGenericContext : IUINavigationControllerDelegate
  {
    // @property CGFloat cardWidthForiPhone;
    [Export("cardWidthForiPhone")]
    nfloat CardWidthForiPhone { get; set; }

    // @property CGFloat cardWidthForiPad;
    [Export("cardWidthForiPad")]
    nfloat CardWidthForiPad { get; set; }

    // @property CGFloat minimumCardMarginForiPhone;
    [Export("minimumCardMarginForiPhone")]
    nfloat MinimumCardMarginForiPhone { get; set; }

    // @property CGFloat minimumCardMarginForiPad;
    [Export("minimumCardMarginForiPad")]
    nfloat MinimumCardMarginForiPad { get; set; }

    [Wrap("WeakAppboyDelegate")]
    [NullAllowed]
    ABKFeedViewControllerDelegate AppboyDelegate { get; set; }

    // @property (weak) id<ABKFeedViewControllerDelegate> _Nullable appboyDelegate;
    [NullAllowed, Export("appboyDelegate", ArgumentSemantic.Weak)]
    NSObject WeakAppboyDelegate { get; set; }

    // -(void)closeButtonPressed:(id _Nonnull)sender;
    [Export("closeButtonPressed:")]
    void CloseButtonPressed(NSObject sender);

    // @property ABKCardCategory categories;
    [Export("categories", ArgumentSemantic.Assign)]
    ABKCardCategory Categories { get; set; }

    // @property (nonatomic) BOOL disableUnreadIndicator;
    [Export("disableUnreadIndicator")]
    bool DisableUnreadIndicator { get; set; }
  }

  // @interface ABKFeedViewControllerModalContext : ABKFeedViewControllerGenericContext
  [BaseType(typeof(ABKFeedViewControllerGenericContext))]
  interface ABKFeedViewControllerModalContext
  {
    // @property (strong) NSString * _Nullable navigationBarTitle;
    [NullAllowed, Export("navigationBarTitle", ArgumentSemantic.Strong)]
    string NavigationBarTitle { get; set; }

    [Wrap("WeakCloseButtonDelegate")]
    [NullAllowed]
    ABKFeedViewControllerModalContextDelegate CloseButtonDelegate { get; set; }

    // @property (weak) id<ABKFeedViewControllerModalContextDelegate> _Nullable closeButtonDelegate;
    [NullAllowed, Export("closeButtonDelegate", ArgumentSemantic.Weak)]
    NSObject WeakCloseButtonDelegate { get; set; }
  }

  // @protocol ABKFeedViewControllerModalContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKFeedViewControllerModalContextDelegate
  {
    // @required -(void)feedViewControllerModalContextCloseTapped:(ABKFeedViewControllerModalContext * _Nonnull)sender;
    [Abstract]
    [Export("feedViewControllerModalContextCloseTapped:")]
    void FeedViewControllerModalContextCloseTapped(ABKFeedViewControllerModalContext sender);
  }

  // @interface ABKFeedViewControllerNavigationContext : ABKFeedViewController <UINavigationControllerDelegate>
  [BaseType(typeof(ABKFeedViewController))]
  interface ABKFeedViewControllerNavigationContext : IUINavigationControllerDelegate
  {
  }

  // @interface ABKFeedViewControllerPopoverContext : ABKFeedViewControllerGenericContext
  [BaseType(typeof(ABKFeedViewControllerGenericContext))]
  interface ABKFeedViewControllerPopoverContext
  {
    // @property (strong) NSString * _Nullable navigationBarTitle;
    [NullAllowed, Export("navigationBarTitle", ArgumentSemantic.Strong)]
    string NavigationBarTitle { get; set; }

    [Wrap("WeakCloseButtonDelegate")]
    [NullAllowed]
    ABKFeedViewControllerPopoverContextDelegate CloseButtonDelegate { get; set; }

    // @property (weak) id<ABKFeedViewControllerPopoverContextDelegate> _Nullable closeButtonDelegate;
    [NullAllowed, Export("closeButtonDelegate", ArgumentSemantic.Weak)]
    NSObject WeakCloseButtonDelegate { get; set; }
  }

  // @protocol ABKFeedViewControllerPopoverContextDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKFeedViewControllerPopoverContextDelegate
  {
    // @required -(void)feedViewControllerPopoverContextCloseTapped:(ABKFeedViewControllerPopoverContext * _Nonnull)sender;
    [Abstract]
    [Export("feedViewControllerPopoverContextCloseTapped:")]
    void FeedViewControllerPopoverContextCloseTapped(ABKFeedViewControllerPopoverContext sender);
  }

  // @protocol ABKIDFADelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKIDFADelegate
  {
    // @required -(NSString * _Nonnull)advertisingIdentifierString;
    [Abstract]
    [Export("advertisingIdentifierString")]
    string AdvertisingIdentifierString { get; }

    // @required -(BOOL)isAdvertisingTrackingEnabled;
    [Abstract]
    [Export("isAdvertisingTrackingEnabled")]
    bool IsAdvertisingTrackingEnabled { get; }
  }

  // @interface ABKInAppMessage : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessage
  {
    // @property (copy) NSString * _Nonnull message;
    [Export("message")]
    string Message { get; set; }

    // @property (strong) NSDictionary * _Nullable extras;
    [NullAllowed, Export("extras", ArgumentSemantic.Strong)]
    NSDictionary Extras { get; set; }

    // @property (nonatomic) NSTimeInterval duration;
    [Export("duration")]
    double Duration { get; set; }

    // @property (readonly) ABKInAppMessageClickActionType inAppMessageClickActionType;
    [Export("inAppMessageClickActionType")]
    ABKInAppMessageClickActionType InAppMessageClickActionType { get; }

    // @property (readonly) NSURL * _Nullable uri;
    [NullAllowed, Export("uri")]
    NSUrl Uri { get; }

    // @property BOOL openUrlInWebView;
    [Export("openUrlInWebView")]
    bool OpenUrlInWebView { get; set; }

    // @property ABKInAppMessageDismissType inAppMessageDismissType;
    [Export("inAppMessageDismissType", ArgumentSemantic.Assign)]
    ABKInAppMessageDismissType InAppMessageDismissType { get; set; }

    // @property (strong) UIColor * _Nullable backgroundColor;
    [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
    UIColor BackgroundColor { get; set; }

    // @property (strong) UIColor * _Nullable textColor;
    [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
    UIColor TextColor { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable icon;
    [NullAllowed, Export("icon")]
    string Icon { get; set; }

    // @property (strong) UIColor * _Nullable iconColor;
    [NullAllowed, Export("iconColor", ArgumentSemantic.Strong)]
    UIColor IconColor { get; set; }

    // @property (strong) UIColor * _Nullable iconBackgroundColor;
    [NullAllowed, Export("iconBackgroundColor", ArgumentSemantic.Strong)]
    UIColor IconBackgroundColor { get; set; }

    // @property (copy) NSURL * _Nullable imageURI;
    [NullAllowed, Export("imageURI", ArgumentSemantic.Copy)]
    NSUrl ImageURI { get; set; }

    // @property UIViewContentMode imageContentMode;
    [Export("imageContentMode", ArgumentSemantic.Assign)]
    UIViewContentMode ImageContentMode { get; set; }

    // @property ABKInAppMessageOrientation orientation;
    [Export("orientation", ArgumentSemantic.Assign)]
    ABKInAppMessageOrientation Orientation { get; set; }

    // @property NSTextAlignment messageTextAlignment;
    [Export("messageTextAlignment", ArgumentSemantic.Assign)]
    UITextAlignment MessageTextAlignment { get; set; }

    // @property BOOL animateIn;
    [Export("animateIn")]
    bool AnimateIn { get; set; }

    // @property BOOL animateOut;
    [Export("animateOut")]
    bool AnimateOut { get; set; }

    // -(void)logInAppMessageImpression;
    [Export("logInAppMessageImpression")]
    void LogInAppMessageImpression();

    // -(void)logInAppMessageClicked;
    [Export("logInAppMessageClicked")]
    void LogInAppMessageClicked();

    // -(void)setInAppMessageClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSURL * _Nullable)uri;
    [Export("setInAppMessageClickAction:withURI:")]
    void SetInAppMessageClickAction(ABKInAppMessageClickActionType clickActionType, [NullAllowed] NSUrl uri);

    // -(NSData * _Nullable)serializeToData;
    [NullAllowed, Export("serializeToData")]
    NSData SerializeToData { get; }
  }

  // @interface ABKInAppMessageButton : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageButton
  {
    // @property (copy) NSString * _Nullable buttonText;
    [NullAllowed, Export("buttonText")]
    string ButtonText { get; set; }

    // @property (strong) UIColor * _Nullable buttonBackgroundColor;
    [NullAllowed, Export("buttonBackgroundColor", ArgumentSemantic.Strong)]
    UIColor ButtonBackgroundColor { get; set; }

    // @property (strong) UIColor * _Nullable buttonTextColor;
    [NullAllowed, Export("buttonTextColor", ArgumentSemantic.Strong)]
    UIColor ButtonTextColor { get; set; }

    // @property (readonly) ABKInAppMessageClickActionType buttonClickActionType;
    [Export("buttonClickActionType")]
    ABKInAppMessageClickActionType ButtonClickActionType { get; }

    // @property (readonly, copy) NSURL * _Nullable buttonClickedURI;
    [NullAllowed, Export("buttonClickedURI", ArgumentSemantic.Copy)]
    NSUrl ButtonClickedURI { get; }

    // @property BOOL buttonOpenUrlInWebView;
    [Export("buttonOpenUrlInWebView")]
    bool ButtonOpenUrlInWebView { get; set; }

    // @property (readonly) NSInteger buttonID;
    [Export("buttonID")]
    nint ButtonID { get; }

    // -(void)setButtonClickAction:(ABKInAppMessageClickActionType)clickActionType withURI:(NSURL * _Nullable)uri;
    [Export("setButtonClickAction:withURI:")]
    void SetButtonClickAction(ABKInAppMessageClickActionType clickActionType, [NullAllowed] NSUrl uri);
  }

  // @interface ABKInAppMessageViewController : UIViewController
  [BaseType(typeof(UIViewController))]
  interface ABKInAppMessageViewController
  {
    // @property (strong) ABKInAppMessage * _Nonnull inAppMessage;
    [Export("inAppMessage", ArgumentSemantic.Strong)]
    ABKInAppMessage InAppMessage { get; set; }

    // @property (nonatomic, weak) UIImageView * _Nullable iconImageView __attribute__((iboutlet));
    [NullAllowed, Export("iconImageView", ArgumentSemantic.Weak)]
    UIImageView IconImageView { get; set; }

    // @property (nonatomic, weak) UILabel * _Nullable iconLabelView __attribute__((iboutlet));
    [NullAllowed, Export("iconLabelView", ArgumentSemantic.Weak)]
    UILabel IconLabelView { get; set; }

    // @property (nonatomic, weak) ABKLabel * _Nullable inAppMessageMessageLabel __attribute__((iboutlet));
    [NullAllowed, Export("inAppMessageMessageLabel", ArgumentSemantic.Weak)]
    ABKLabel InAppMessageMessageLabel { get; set; }

    // -(instancetype _Nonnull)initWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
    [Export("initWithInAppMessage:")]
    IntPtr Constructor(ABKInAppMessage inAppMessage);

    // -(void)hideInAppMessage:(BOOL)animated;
    [Export("hideInAppMessage:")]
    void HideInAppMessage(bool animated);

    // -(void)moveInAppMessageViewOffScreen:(CGRect)inAppMessageWindowFrame;
    [Export("moveInAppMessageViewOffScreen:")]
    void MoveInAppMessageViewOffScreen(CGRect inAppMessageWindowFrame);

    // -(void)moveInAppMessageViewOnScreen:(CGRect)inAppMessageWindowFrame;
    [Export("moveInAppMessageViewOnScreen:")]
    void MoveInAppMessageViewOnScreen(CGRect inAppMessageWindowFrame);
  }

  // @protocol ABKInAppMessageControllerDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageControllerDelegate
  {
    // @optional -(BOOL)onInAppMessageReceived:(ABKInAppMessage * _Nonnull)inAppMessage __attribute__((deprecated("")));
    [Export("onInAppMessageReceived:")]
    bool OnInAppMessageReceived(ABKInAppMessage inAppMessage);

    // @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage * _Nonnull)inAppMessage withKeyboardIsUp:(BOOL)keyboardIsUp;
    [Export("beforeInAppMessageDisplayed:withKeyboardIsUp:")]
    ABKInAppMessageDisplayChoice BeforeInAppMessageDisplayed(ABKInAppMessage inAppMessage, bool keyboardIsUp);

    // @optional -(ABKInAppMessageViewController * _Nonnull)inAppMessageViewControllerWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
    [Export("inAppMessageViewControllerWithInAppMessage:")]
    ABKInAppMessageViewController InAppMessageViewControllerWithInAppMessage(ABKInAppMessage inAppMessage);

    // @optional -(void)onInAppMessageDismissed:(ABKInAppMessage * _Nonnull)inAppMessage;
    [Export("onInAppMessageDismissed:")]
    void OnInAppMessageDismissed(ABKInAppMessage inAppMessage);

    // @optional -(BOOL)onInAppMessageClicked:(ABKInAppMessage * _Nonnull)inAppMessage;
    [Export("onInAppMessageClicked:")]
    bool OnInAppMessageClicked(ABKInAppMessage inAppMessage);

    // @optional -(BOOL)onInAppMessageButtonClicked:(ABKInAppMessageImmersive * _Nonnull)inAppMessage button:(ABKInAppMessageButton * _Nonnull)button;
    [Export("onInAppMessageButtonClicked:button:")]
    bool OnInAppMessageButtonClicked(ABKInAppMessageImmersive inAppMessage, ABKInAppMessageButton button);

    // @optional -(BOOL)onInAppMessageHTMLButtonClicked:(ABKInAppMessageHTML * _Nonnull)inAppMessage clickedURL:(NSURL * _Nullable)clickedURL buttonID:(NSString * _Nonnull)buttonId;
    [Export("onInAppMessageHTMLButtonClicked:clickedURL:buttonID:")]
    bool OnInAppMessageHTMLButtonClicked(ABKInAppMessageHTML inAppMessage, [NullAllowed] NSUrl clickedURL, string buttonId);
  }

  // @interface ABKInAppMessageController : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageController
  {
    [Wrap("WeakDelegate")]
    [NullAllowed]
    ABKInAppMessageControllerDelegate Delegate { get; set; }

    // @property (weak) id<ABKInAppMessageControllerDelegate> _Nullable delegate;
    [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property UIInterfaceOrientationMask supportedOrientationMasks;
    [Export("supportedOrientationMasks", ArgumentSemantic.Assign)]
    UIInterfaceOrientationMask SupportedOrientationMasks { get; set; }

    // @property UIInterfaceOrientation supportedOrientations;
    [Export("supportedOrientations", ArgumentSemantic.Assign)]
    UIInterfaceOrientation SupportedOrientations { get; set; }

    // -(void)displayNextInAppMessageWithDelegate:(id<ABKInAppMessageControllerDelegate> _Nullable)delegate;
    [Export("displayNextInAppMessageWithDelegate:")]
    void DisplayNextInAppMessageWithDelegate([NullAllowed] ABKInAppMessageControllerDelegate @delegate);

    // -(NSInteger)inAppMessagesRemainingOnStack;
    [Export("inAppMessagesRemainingOnStack")]
    nint InAppMessagesRemainingOnStack { get; }

    // -(void)addInAppMessage:(ABKInAppMessage * _Nonnull)newInAppMessage;
    [Export("addInAppMessage:")]
    void AddInAppMessage(ABKInAppMessage newInAppMessage);

    // -(void)hideCurrentInAppMessage:(BOOL)animated;
    [Export("hideCurrentInAppMessage:")]
    void HideCurrentInAppMessage(bool animated);
  }

  // @interface ABKInAppMessageImmersive : ABKInAppMessage
  [BaseType(typeof(ABKInAppMessage))]
  interface ABKInAppMessageImmersive
  {
    // @property (copy) NSString * _Nullable header;
    [NullAllowed, Export("header")]
    string Header { get; set; }

    // @property (strong) UIColor * _Nullable headerTextColor;
    [NullAllowed, Export("headerTextColor", ArgumentSemantic.Strong)]
    UIColor HeaderTextColor { get; set; }

    // @property (strong) UIColor * _Nullable closeButtonColor;
    [NullAllowed, Export("closeButtonColor", ArgumentSemantic.Strong)]
    UIColor CloseButtonColor { get; set; }

    // @property (readonly) NSArray * _Nullable buttons;
    [NullAllowed, Export("buttons")]
    ABKInAppMessageButton[] Buttons { get; }

    // @property (strong) UIColor * _Nullable frameColor;
    [NullAllowed, Export("frameColor", ArgumentSemantic.Strong)]
    UIColor FrameColor { get; set; }

    // @property NSTextAlignment headerTextAlignment;
    [Export("headerTextAlignment", ArgumentSemantic.Assign)]
    UITextAlignment HeaderTextAlignment { get; set; }

    // @property ABKInAppMessageImmersiveImageStyle imageStyle;
    [Export("imageStyle", ArgumentSemantic.Assign)]
    ABKInAppMessageImmersiveImageStyle ImageStyle { get; set; }

    // -(void)logInAppMessageClickedWithButtonID:(NSInteger)buttonId;
    [Export("logInAppMessageClickedWithButtonID:")]
    void LogInAppMessageClickedWithButtonID(nint buttonId);

    // -(void)setInAppMessageButtons:(NSArray * _Nonnull)buttonArray;
    [Export("setInAppMessageButtons:")]
    void SetInAppMessageButtons(ABKInAppMessageButton[] buttonArray);
  }

  // @interface ABKInAppMessageFull : ABKInAppMessageImmersive
  [BaseType(typeof(ABKInAppMessageImmersive))]
  interface ABKInAppMessageFull
  {
  }

  // @interface ABKInAppMessageImmersiveViewController : ABKInAppMessageViewController
  [BaseType(typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageImmersiveViewController
  {
    // @property (nonatomic, weak) ABKLabel * _Nullable inAppMessageHeaderLabel __attribute__((iboutlet));
    [NullAllowed, Export("inAppMessageHeaderLabel", ArgumentSemantic.Weak)]
    ABKLabel InAppMessageHeaderLabel { get; set; }

    // @property (nonatomic, weak) UIImageView * _Nullable graphicImageView __attribute__((iboutlet));
    [NullAllowed, Export("graphicImageView", ArgumentSemantic.Weak)]
    UIImageView GraphicImageView { get; set; }

    // -(void)dismissInAppMessage:(id _Nonnull)sender __attribute__((ibaction));
    [Export("dismissInAppMessage:")]
    void DismissInAppMessage(NSObject sender);
  }

  // @interface ABKInAppMessageFullViewController : ABKInAppMessageImmersiveViewController
  [BaseType(typeof(ABKInAppMessageImmersiveViewController))]
  interface ABKInAppMessageFullViewController
  {
  }

  // @interface ABKInAppMessageHTML : ABKInAppMessage
  [BaseType(typeof(ABKInAppMessage))]
  interface ABKInAppMessageHTML
  {
    // @property (strong) NSURL * _Nullable assetsZipRemoteUrl;
    [NullAllowed, Export("assetsZipRemoteUrl", ArgumentSemantic.Strong)]
    NSUrl AssetsZipRemoteUrl { get; set; }

    // -(void)logInAppMessageHTMLClickWithButtonID:(NSString * _Nonnull)buttonId;
    [Export("logInAppMessageHTMLClickWithButtonID:")]
    void LogInAppMessageHTMLClickWithButtonID(string buttonId);
  }

  // @interface ABKInAppMessageHTMLFull : ABKInAppMessageHTML
  [BaseType(typeof(ABKInAppMessageHTML))]
  interface ABKInAppMessageHTMLFull
  {
  }

  // @interface ABKInAppMessageHTMLViewController : ABKInAppMessageViewController <UIWebViewDelegate>
  [BaseType(typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageHTMLViewController : IUIWebViewDelegate
  {
    // @property (nonatomic, weak) UIWebView * _Nullable webView __attribute__((iboutlet));
    [NullAllowed, Export("webView", ArgumentSemantic.Weak)]
    UIWebView WebView { get; set; }
  }

  // @interface ABKInAppMessageHTMLFullViewController : ABKInAppMessageHTMLViewController
  [BaseType(typeof(ABKInAppMessageHTMLViewController))]
  interface ABKInAppMessageHTMLFullViewController
  {
  }

  // @interface ABKInAppMessageModal : ABKInAppMessageImmersive
  [BaseType(typeof(ABKInAppMessageImmersive))]
  interface ABKInAppMessageModal
  {
  }

  // @interface ABKInAppMessageModalViewController : ABKInAppMessageImmersiveViewController
  [BaseType(typeof(ABKInAppMessageImmersiveViewController))]
  interface ABKInAppMessageModalViewController
  {
  }

  // @interface ABKInAppMessageSlideup : ABKInAppMessage
  [BaseType(typeof(ABKInAppMessage))]
  interface ABKInAppMessageSlideup
  {
    // @property BOOL hideChevron;
    [Export("hideChevron")]
    bool HideChevron { get; set; }

    // @property ABKInAppMessageSlideupAnchor inAppMessageSlideupAnchor;
    [Export("inAppMessageSlideupAnchor", ArgumentSemantic.Assign)]
    ABKInAppMessageSlideupAnchor InAppMessageSlideupAnchor { get; set; }

    // @property (strong) UIColor * _Nullable chevronColor;
    [NullAllowed, Export("chevronColor", ArgumentSemantic.Strong)]
    UIColor ChevronColor { get; set; }
  }

  // @interface ABKInAppMessageSlideupViewController : ABKInAppMessageViewController
  [BaseType(typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageSlideupViewController
  {
    // @property (nonatomic, weak) UIImageView * _Nullable arrowImage __attribute__((iboutlet));
    [NullAllowed, Export("arrowImage", ArgumentSemantic.Weak)]
    UIImageView ArrowImage { get; set; }
  }

  // @interface ABKInAppMessageView : UIView
  [BaseType(typeof(UIView))]
  interface ABKInAppMessageView
  {
  }

  // @interface ABKLocationManager : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKLocationManager
  {
    // @property (readonly) BOOL disableLocationTracking;
    [Export("disableLocationTracking")]
    bool DisableLocationTracking { get; }

    // -(void)allowRequestWhenInUseLocationPermission;
    [Export("allowRequestWhenInUseLocationPermission")]
    void AllowRequestWhenInUseLocationPermission();

    // -(void)allowRequestAlwaysPermission;
    [Export("allowRequestAlwaysPermission")]
    void AllowRequestAlwaysPermission();

    // -(void)logSingleLocation;
    [Export("logSingleLocation")]
    void LogSingleLocation();
  }

  // @interface ABKNavigationBar : UINavigationBar
  [BaseType(typeof(UINavigationBar))]
  interface ABKNavigationBar
  {
  }

  // @protocol ABKPushURIDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKPushURIDelegate
  {
    // @required -(BOOL)handleAppboyPushURI:(NSString * _Nonnull)URIString withNotificationInfo:(NSDictionary * _Nonnull)notificationInfo;
    [Abstract]
    [Export("handleAppboyPushURI:withNotificationInfo:")]
    bool WithNotificationInfo(string URIString, NSDictionary notificationInfo);
  }

  // @interface ABKPushUtils : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKPushUtils
  {
    // +(BOOL)isAppboyUserNotification:(UNNotificationResponse * _Nonnull)response;
    [Static]
    [Export("isAppboyUserNotification:")]
    bool IsAppboyUserNotification(UNNotificationResponse response);

    // +(BOOL)isAppboyRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isAppboyRemoteNotification:")]
    bool IsAppboyRemoteNotification(NSDictionary userInfo);

    // +(BOOL)isAppboyInternalUserNotification:(UNNotificationResponse * _Nonnull)response;
    [Static]
    [Export("isAppboyInternalUserNotification:")]
    bool IsAppboyInternalUserNotification(UNNotificationResponse response);

    // +(BOOL)isAppboyInternalRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isAppboyInternalRemoteNotification:")]
    bool IsAppboyInternalRemoteNotification(NSDictionary userInfo);

    // +(BOOL)isUninstallTrackingUserNotification:(UNNotificationResponse * _Nonnull)response;
    [Static]
    [Export("isUninstallTrackingUserNotification:")]
    bool IsUninstallTrackingUserNotification(UNNotificationResponse response);

    // +(BOOL)isUninstallTrackingRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isUninstallTrackingRemoteNotification:")]
    bool IsUninstallTrackingRemoteNotification(NSDictionary userInfo);

    // +(BOOL)isGeofencesSyncUserNotification:(UNNotificationResponse * _Nonnull)response;
    [Static]
    [Export("isGeofencesSyncUserNotification:")]
    bool IsGeofencesSyncUserNotification(UNNotificationResponse response);

    // +(BOOL)isGeofencesSyncRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isGeofencesSyncRemoteNotification:")]
    bool IsGeofencesSyncRemoteNotification(NSDictionary userInfo);

    // +(BOOL)shouldFetchTestTriggersFlagContainedInPayload:(NSDictionary * _Nonnull)userInfo __attribute__((deprecated("")));
    [Static]
    [Export("shouldFetchTestTriggersFlagContainedInPayload:")]
    bool ShouldFetchTestTriggersFlagContainedInPayload(NSDictionary userInfo);

    // +(NSSet<UNNotificationCategory *> * _Nonnull)getAppboyUNNotificationCategorySet;
    [Static]
    [Export("getAppboyUNNotificationCategorySet")]
    NSSet<UNNotificationCategory> AppboyUNNotificationCategorySet { get; }

    // +(NSSet<UIUserNotificationCategory *> * _Nonnull)getAppboyUIUserNotificationCategorySet;
    [Static]
    [Export("getAppboyUIUserNotificationCategorySet")]
    NSSet<UIUserNotificationCategory> AppboyUIUserNotificationCategorySet { get; }
  }

  // @interface ABKTextAnnouncementCard : ABKCard <NSCoding>
  [BaseType(typeof(ABKCard))]
  interface ABKTextAnnouncementCard : INSCoding
  {
    // @property (copy) NSString * _Nonnull title;
    [Export("title")]
    string Title { get; set; }

    // @property (copy) NSString * _Nonnull cardDescription;
    [Export("cardDescription")]
    string CardDescription { get; set; }

    // @property (copy) NSString * _Nullable domain;
    [NullAllowed, Export("domain")]
    string Domain { get; set; }
  }

  // @interface ABKThemableFeedNavigationBar : ABKNavigationBar
  [BaseType(typeof(ABKNavigationBar))]
  interface ABKThemableFeedNavigationBar
  {
  }

  // @interface ABKTwitterUser : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKTwitterUser
  {
    // @property (copy) NSString * _Nullable userDescription;
    [NullAllowed, Export("userDescription")]
    string UserDescription { get; set; }

    // @property (copy) NSString * _Nullable twitterName;
    [NullAllowed, Export("twitterName")]
    string TwitterName { get; set; }

    // @property (copy) NSString * _Nullable profileImageUrl;
    [NullAllowed, Export("profileImageUrl")]
    string ProfileImageUrl { get; set; }

    // @property (copy) NSString * _Nullable screenName;
    [NullAllowed, Export("screenName")]
    string ScreenName { get; set; }

    // @property NSInteger followersCount;
    [Export("followersCount")]
    nint FollowersCount { get; set; }

    // @property NSInteger friendsCount;
    [Export("friendsCount")]
    nint FriendsCount { get; set; }

    // @property NSInteger statusesCount;
    [Export("statusesCount")]
    nint StatusesCount { get; set; }

    // @property NSInteger twitterID;
    [Export("twitterID")]
    nint TwitterID { get; set; }
  }

  // @protocol ABKURLDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKURLDelegate
  {
    // @required -(BOOL)handleAppboyURL:(NSURL * _Nonnull)url fromChannel:(ABKChannel)channel withExtras:(NSDictionary * _Nonnull)extras;
    [Abstract]
    [Export("handleAppboyURL:fromChannel:withExtras:")]
    bool FromChannel(NSUrl url, ABKChannel channel, NSDictionary extras);
  }

  interface Constants
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

    // extern NSString *const _Nonnull ABKIDFADelegateKey;
    [Field("ABKIDFADelegateKey", "__Internal")]
    NSString ABKIDFADelegateKey { get; }

    // extern NSString *const _Nonnull ABKAppboyEndpointDelegateKey;
    [Field("ABKAppboyEndpointDelegateKey", "__Internal")]
    NSString ABKAppboyEndpointDelegateKey { get; }

    // extern NSString *const _Nonnull ABKPushURIDelegateKey __attribute__((deprecated("ABKPushURIDelegate is deprecated, please use the ABKURLDelegate protocol instead.")));
    [Field("ABKPushURIDelegateKey", "__Internal")]
    NSString ABKPushURIDelegateKey { get; }

    // extern NSString *const _Nonnull ABKURLDelegateKey;
    [Field("ABKURLDelegateKey", "__Internal")]
    NSString ABKURLDelegateKey { get; }

    // extern NSString *const _Nonnull ABKInAppMessageControllerDelegateKey;
    [Field("ABKInAppMessageControllerDelegateKey", "__Internal")]
    NSString ABKInAppMessageControllerDelegateKey { get; }

    // extern NSString *const _Nonnull ABKSessionTimeoutKey;
    [Field("ABKSessionTimeoutKey", "__Internal")]
    NSString ABKSessionTimeoutKey { get; }

    // extern NSString *const _Nonnull ABKMinimumTriggerTimeIntervalKey;
    [Field("ABKMinimumTriggerTimeIntervalKey", "__Internal")]
    NSString ABKMinimumTriggerTimeIntervalKey { get; }

    // extern NSString *const _Nonnull ABKSDKFlavorKey;
    [Field("ABKSDKFlavorKey", "__Internal")]
    NSString ABKSDKFlavorKey { get; }

    // extern double Appboy_iOS_SDKVersionNumber;
    [Field("Appboy_iOS_SDKVersionNumber", "__Internal")]
    double Appboy_iOS_SDKVersionNumber { get; }

    // extern const unsigned char [] Appboy_iOS_SDKVersionString;
    [Field("Appboy_iOS_SDKVersionString", "__Internal")]
    byte[] Appboy_iOS_SDKVersionString { get; }
  }

  // @interface Appboy : NSObject
  [BaseType(typeof(NSObject))]
  interface Appboy
  {
    // +(Appboy * _Nullable)sharedInstance;
    [Static]
    [NullAllowed, Export("sharedInstance")]
    Appboy SharedInstance { get; }

    // +(Appboy * _Nonnull)unsafeInstance;
    [Static]
    [Export("unsafeInstance")]
    Appboy UnsafeInstance { get; }

    // +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions;
    [Static]
    [Export("startWithApiKey:inApplication:withLaunchOptions:")]
    void StartWithApiKey(string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions);

    // +(void)startWithApiKey:(NSString * _Nonnull)apiKey inApplication:(UIApplication * _Nonnull)application withLaunchOptions:(NSDictionary * _Nullable)launchOptions withAppboyOptions:(NSDictionary * _Nullable)appboyOptions;
    [Static]
    [Export("startWithApiKey:inApplication:withLaunchOptions:withAppboyOptions:")]
    void StartWithApiKey(string apiKey, UIApplication application, [NullAllowed] NSDictionary launchOptions, [NullAllowed] NSDictionary appboyOptions);

    // @property (readonly) ABKUser * _Nonnull user;
    [Export("user")]
    ABKUser User { get; }

    // @property (readonly) ABKFeedController * _Nonnull feedController;
    [Export("feedController")]
    ABKFeedController FeedController { get; }

    // @property ABKRequestProcessingPolicy requestProcessingPolicy;
    [Export("requestProcessingPolicy", ArgumentSemantic.Assign)]
    ABKRequestProcessingPolicy RequestProcessingPolicy { get; set; }

    [Wrap("WeakAppboyEndpointDelegate")]
    [NullAllowed]
    ABKAppboyEndpointDelegate AppboyEndpointDelegate { get; set; }

    // @property (nonatomic, weak) id<ABKAppboyEndpointDelegate> _Nullable appboyEndpointDelegate;
    [NullAllowed, Export("appboyEndpointDelegate", ArgumentSemantic.Weak)]
    NSObject WeakAppboyEndpointDelegate { get; set; }

    [Wrap("WeakIdfaDelegate")]
    [NullAllowed]
    ABKIDFADelegate IdfaDelegate { get; set; }

    // @property (nonatomic, strong) id<ABKIDFADelegate> _Nullable idfaDelegate;
    [NullAllowed, Export("idfaDelegate", ArgumentSemantic.Strong)]
    NSObject WeakIdfaDelegate { get; set; }

    // @property (readonly) ABKInAppMessageController * _Nonnull inAppMessageController;
    [Export("inAppMessageController")]
    ABKInAppMessageController InAppMessageController { get; }

    // @property (readonly, nonatomic) ABKLocationManager * _Nonnull locationManager;
    [Export("locationManager")]
    ABKLocationManager LocationManager { get; }

    // @property (nonatomic) BOOL useNUITheming;
    [Export("useNUITheming")]
    bool UseNUITheming { get; set; }

    [Wrap("WeakAppboyPushURIDelegate")]
    [NullAllowed]
    ABKPushURIDelegate AppboyPushURIDelegate { get; set; }

    // @property (nonatomic, weak) id<ABKPushURIDelegate> _Nullable appboyPushURIDelegate __attribute__((deprecated("Use appboyURLDelegate instead.")));
    [NullAllowed, Export("appboyPushURIDelegate", ArgumentSemantic.Weak)]
    NSObject WeakAppboyPushURIDelegate { get; set; }

    [Wrap("WeakAppboyUrlDelegate")]
    [NullAllowed]
    ABKURLDelegate AppboyUrlDelegate { get; set; }

    // @property (nonatomic, weak) id<ABKURLDelegate> _Nullable appboyUrlDelegate;
    [NullAllowed, Export("appboyUrlDelegate", ArgumentSemantic.Weak)]
    NSObject WeakAppboyUrlDelegate { get; set; }

    // @property (nonatomic) ABKSDKFlavor sdkFlavor;
    [Export("sdkFlavor", ArgumentSemantic.Assign)]
    ABKSDKFlavor SdkFlavor { get; set; }

    // -(void)flushDataAndProcessRequestQueue;
    [Export("flushDataAndProcessRequestQueue")]
    void FlushDataAndProcessRequestQueue();

    // -(void)shutdownServerCommunication;
    [Export("shutdownServerCommunication")]
    void ShutdownServerCommunication();

    // -(void)changeUser:(NSString * _Nonnull)userId;
    [Export("changeUser:")]
    void ChangeUser(string userId);

    // -(void)logCustomEvent:(NSString * _Nonnull)eventName;
    [Export("logCustomEvent:")]
    void LogCustomEvent(string eventName);

    // -(void)logCustomEvent:(NSString * _Nonnull)eventName withProperties:(NSDictionary * _Nullable)properties;
    [Export("logCustomEvent:withProperties:")]
    void LogCustomEvent(string eventName, [NullAllowed] NSDictionary properties);

    // -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price;
    [Export("logPurchase:inCurrency:atPrice:")]
    void LogPurchase(string productIdentifier, string currencyCode, NSDecimalNumber price);

    // -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withProperties:(NSDictionary * _Nullable)properties;
    [Export("logPurchase:inCurrency:atPrice:withProperties:")]
    void LogPurchase(string productIdentifier, string currencyCode, NSDecimalNumber price, [NullAllowed] NSDictionary properties);

    // -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withQuantity:(NSUInteger)quantity;
    [Export("logPurchase:inCurrency:atPrice:withQuantity:")]
    void LogPurchase(string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity);

    // -(void)logPurchase:(NSString * _Nonnull)productIdentifier inCurrency:(NSString * _Nonnull)currencyCode atPrice:(NSDecimalNumber * _Nonnull)price withQuantity:(NSUInteger)quantity andProperties:(NSDictionary * _Nullable)properties;
    [Export("logPurchase:inCurrency:atPrice:withQuantity:andProperties:")]
    void LogPurchase(string productIdentifier, string currencyCode, NSDecimalNumber price, nuint quantity, [NullAllowed] NSDictionary properties);

    // -(BOOL)submitFeedback:(NSString * _Nonnull)replyToEmail message:(NSString * _Nonnull)message isReportingABug:(BOOL)isReportingABug;
    [Export("submitFeedback:message:isReportingABug:")]
    bool SubmitFeedback(string replyToEmail, string message, bool isReportingABug);

    // -(void)submitFeedback:(ABKFeedback * _Nonnull)feedback withCompletionHandler:(void (^ _Nullable)(ABKFeedbackSentResult))completionHandler;
    [Export("submitFeedback:withCompletionHandler:")]
    void SubmitFeedback(ABKFeedback feedback, [NullAllowed] Action<ABKFeedbackSentResult> completionHandler);

    // -(void)logFeedDisplayed;
    [Export("logFeedDisplayed")]
    void LogFeedDisplayed();

    // -(void)logFeedbackDisplayed;
    [Export("logFeedbackDisplayed")]
    void LogFeedbackDisplayed();

    // -(void)requestFeedRefresh;
    [Export("requestFeedRefresh")]
    void RequestFeedRefresh();

    // -(void)requestInAppMessageRefresh;
    [Export("requestInAppMessageRefresh")]
    void RequestInAppMessageRefresh();

    // -(BOOL)userNotificationWasSentFromAppboy:(UNNotificationResponse * _Nonnull)response __attribute__((deprecated("Use [ABKPushUtils isAppboyUserNotification:] instead.")));
    [Export("userNotificationWasSentFromAppboy:")]
    bool UserNotificationWasSentFromAppboy(UNNotificationResponse response);

    // -(BOOL)pushNotificationWasSentFromAppboy:(NSDictionary * _Nonnull)options __attribute__((deprecated("Use [ABKPushUtils isAppboyRemoteNotification:] instead.")));
    [Export("pushNotificationWasSentFromAppboy:")]
    bool PushNotificationWasSentFromAppboy(NSDictionary options);

    // -(void)registerPushToken:(NSString * _Nonnull)token;
    [Export("registerPushToken:")]
    void RegisterPushToken(string token);

    // -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification __attribute__((availability(ios, introduced=3.0, deprecated=10.0)));
    [Introduced(PlatformName.iOS, 3, 0, message: "`registerApplication:didReceiveRemoteNotification:` is deprecated in iOS 10, please use `registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:` instead.")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "`registerApplication:didReceiveRemoteNotification:` is deprecated in iOS 10, please use `registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:` instead.")]
    [Export("registerApplication:didReceiveRemoteNotification:")]
    void RegisterApplication(UIApplication application, NSDictionary notification);

    // -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
    [Export("registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:")]
    void RegisterApplicationWithFetchCompletionHandler(UIApplication application, NSDictionary notification, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

    // -(void)getActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nullable)())completionHandler __attribute__((availability(ios, introduced=8.0, deprecated=10.0)));
    [Introduced(PlatformName.iOS, 8, 0, message: "`getActionWithIdentifier:forRemoteNotification:completionHandler:` is deprecated in iOS 10, please use `userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:` instead.")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "`getActionWithIdentifier:forRemoteNotification:completionHandler:` is deprecated in iOS 10, please use `userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:` instead.")]
    [Export("getActionWithIdentifier:forRemoteNotification:completionHandler:")]
    void GetActionWithIdentifier(string identifier, NSDictionary userInfo, [NullAllowed] Action completionHandler);

    // -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nullable)())completionHandler;
    [Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
    void UserNotificationCenter(UNUserNotificationCenter center, UNNotificationResponse response, [NullAllowed] Action completionHandler);

    // -(void)pushAuthorizationFromUserNotificationCenter:(BOOL)pushAuthGranted;
    [Export("pushAuthorizationFromUserNotificationCenter:")]
    void PushAuthorizationFromUserNotificationCenter(bool pushAuthGranted);
  }

  // @interface ABKLabel : UILabel
  [BaseType(typeof(UILabel))]
  interface ABKLabel
  {
  }
}