using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using StoreKit;
using UIKit;
using UserNotifications;
using WebKit;

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

    // @property (copy, nonatomic) NSString * _Nullable language;
    [NullAllowed, Export("language")]
    string Language { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable phone;
    [NullAllowed, Export("phone")]
    string Phone { get; set; }

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

    // -(BOOL)addAlias:(NSString * _Nonnull)alias withLabel:(NSString * _Nonnull)label;
    [Export("addAlias:withLabel:")]
    bool AddAlias(string alias, string label);

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

  [Static]
  interface Constants
  {
    // extern const NSInteger DefaultNumberOfFriends;
    [Field("DefaultNumberOfFriends", "__Internal")]
    nint DefaultNumberOfFriends { get; }

    // extern NSString *const _Nonnull ABKFeedUpdatedNotification;
    [Field("ABKFeedUpdatedNotification", "__Internal")]
    NSString ABKFeedUpdatedNotification { get; }

    // extern NSString *const _Nonnull ABKFeedUpdatedIsSuccessfulKey;
    [Field("ABKFeedUpdatedIsSuccessfulKey", "__Internal")]
    NSString ABKFeedUpdatedIsSuccessfulKey { get; }

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

    // extern NSString *const _Nonnull ABKPushStoryAppGroupKey;
    [Field("ABKPushStoryAppGroupKey", "__Internal")]
    NSString ABKPushStoryAppGroupKey { get; }
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

    // -(NSString * _Nonnull)getDeviceId;
    [Export("getDeviceId")]
    string DeviceId { get; }

    // -(BOOL)userNotificationWasSentFromAppboy:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0))) __attribute__((deprecated("Use [ABKPushUtils isAppboyUserNotification:] instead.")));
    [Introduced(PlatformName.iOS, 10, 0, message: "")]
    [Export("userNotificationWasSentFromAppboy:")]
    bool UserNotificationWasSentFromAppboy(UNNotificationResponse response);

    // -(BOOL)pushNotificationWasSentFromAppboy:(NSDictionary * _Nonnull)options __attribute__((deprecated("Use [ABKPushUtils isAppboyRemoteNotification:] instead.")));
    [Export("pushNotificationWasSentFromAppboy:")]
    bool PushNotificationWasSentFromAppboy(NSDictionary options);

    // -(void)registerPushToken:(NSString * _Nonnull)token;
    [Export("registerPushToken:")]
    void RegisterPushToken(string token);

    // -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification __attribute__((availability(ios, introduced=3_0, deprecated=10_0)));
    [Introduced(PlatformName.iOS, 3, 0, message: "`registerApplication:didReceiveRemoteNotification:` is deprecated in iOS 10, please use `registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:` instead.")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "`registerApplication:didReceiveRemoteNotification:` is deprecated in iOS 10, please use `registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:` instead.")]
    [Export("registerApplication:didReceiveRemoteNotification:")]
    void RegisterApplication(UIApplication application, NSDictionary notification);

    // -(void)registerApplication:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
    [Export("registerApplication:didReceiveRemoteNotification:fetchCompletionHandler:")]
    void RegisterApplicationWithFetchCompletionHandler(UIApplication application, NSDictionary notification, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

    // -(void)getActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nullable)(void))completionHandler __attribute__((availability(ios, introduced=8_0, deprecated=10_0)));
    [Introduced(PlatformName.iOS, 8, 0, message: "`getActionWithIdentifier:forRemoteNotification:completionHandler:` is deprecated in iOS 10, please use `userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:` instead.")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "`getActionWithIdentifier:forRemoteNotification:completionHandler:` is deprecated in iOS 10, please use `userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:` instead.")]
    [Export("getActionWithIdentifier:forRemoteNotification:completionHandler:")]
    void GetActionWithIdentifier(string identifier, NSDictionary userInfo, [NullAllowed] Action completionHandler);

    // -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nullable)(void))completionHandler __attribute__((availability(ios, introduced=10_0)));
    [Introduced(PlatformName.iOS, 10, 0, message: "")]
    [Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
    void UserNotificationCenter(UNUserNotificationCenter center, UNNotificationResponse response, [NullAllowed] Action completionHandler);

    // -(void)pushAuthorizationFromUserNotificationCenter:(BOOL)pushAuthGranted;
    [Export("pushAuthorizationFromUserNotificationCenter:")]
    void PushAuthorizationFromUserNotificationCenter(bool pushAuthGranted);

    // +(void)wipeDataAndDisableForAppRun;
    [Static]
    [Export("wipeDataAndDisableForAppRun")]
    void WipeDataAndDisableForAppRun();

    // +(void)disableSDK;
    [Static]
    [Export("disableSDK")]
    void DisableSDK();

    // +(void)requestEnableSDKOnNextAppRun;
    [Static]
    [Export("requestEnableSDKOnNextAppRun")]
    void RequestEnableSDKOnNextAppRun();
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

    // -(BOOL)isBeveled;
    [Export("isBeveled")]
    bool IsBeveled { get; }
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
    NSObject[] Buttons { get; }

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
    void SetInAppMessageButtons(NSObject[] buttonArray);
  }

  // @interface ABKInAppMessageModal : ABKInAppMessageImmersive
  [BaseType(typeof(ABKInAppMessageImmersive))]
  interface ABKInAppMessageModal
  {
  }

  // @interface ABKInAppMessageFull : ABKInAppMessageImmersive
  [BaseType(typeof(ABKInAppMessageImmersive))]
  interface ABKInAppMessageFull
  {
  }

  // @interface ABKInAppMessageHTML : ABKInAppMessage
  [BaseType(typeof(ABKInAppMessage))]
  interface ABKInAppMessageHTML
  {
    // @property (strong) NSURL * _Nullable assetsZipRemoteUrl;
    [NullAllowed, Export("assetsZipRemoteUrl", ArgumentSemantic.Strong)]
    NSUrl AssetsZipRemoteUrl { get; set; }

    // @property NSURL * _Nonnull assetsLocalDirectoryPath;
    [Export("assetsLocalDirectoryPath", ArgumentSemantic.Assign)]
    NSUrl AssetsLocalDirectoryPath { get; set; }

    // -(void)logInAppMessageHTMLClickWithButtonID:(NSString * _Nonnull)buttonId;
    [Export("logInAppMessageHTMLClickWithButtonID:")]
    void LogInAppMessageHTMLClickWithButtonID(string buttonId);
  }

  // @interface ABKInAppMessageHTMLFull : ABKInAppMessageHTML
  [BaseType(typeof(ABKInAppMessageHTML))]
  interface ABKInAppMessageHTMLFull
  {
  }

  // @protocol ABKInAppMessageControllerDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageControllerDelegate
  {
    // @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage * _Nonnull)inAppMessage;
    [Export("beforeInAppMessageDisplayed:")]
    ABKInAppMessageDisplayChoice BeforeInAppMessageDisplayed(ABKInAppMessage inAppMessage);
  }

  // @protocol ABKInAppMessageUIControlling <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageUIControlling
  {
    // @optional -(void)setInAppMessageUIDelegate:(id)uiDelegate;
    [Export("setInAppMessageUIDelegate:")]
    void SetInAppMessageUIDelegate(NSObject uiDelegate);

    // @optional -(void)hideCurrentInAppMessage:(BOOL)animated;
    [Export("hideCurrentInAppMessage:")]
    void HideCurrentInAppMessage(bool animated);

    // @optional -(ABKInAppMessageDisplayChoice)getCurrentDisplayChoiceForInAppMessage:(ABKInAppMessage *)inAppMessage;
    [Export("getCurrentDisplayChoiceForInAppMessage:")]
    ABKInAppMessageDisplayChoice GetCurrentDisplayChoiceForInAppMessage(ABKInAppMessage inAppMessage);

    // @optional -(void)showInAppMessage:(ABKInAppMessage *)inAppMessage;
    [Export("showInAppMessage:")]
    void ShowInAppMessage(ABKInAppMessage inAppMessage);

    // @optional -(BOOL)inAppMessageCurrentlyVisible;
    [Export("inAppMessageCurrentlyVisible")]
    bool InAppMessageCurrentlyVisible { get; }
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

    // @property id<ABKInAppMessageUIControlling> _Nullable inAppMessageUIController;
    [NullAllowed, Export("inAppMessageUIController", ArgumentSemantic.Assign)]
    ABKInAppMessageUIControlling InAppMessageUIController { get; set; }

    // -(void)displayNextInAppMessageWithDelegate:(id<ABKInAppMessageControllerDelegate> _Nullable)delegate;
    [Export("displayNextInAppMessageWithDelegate:")]
    void DisplayNextInAppMessageWithDelegate([NullAllowed] ABKInAppMessageControllerDelegate @delegate);

    // -(NSInteger)inAppMessagesRemainingOnStack;
    [Export("inAppMessagesRemainingOnStack")]
    nint InAppMessagesRemainingOnStack { get; }

    // -(void)addInAppMessage:(ABKInAppMessage * _Nonnull)newInAppMessage;
    [Export("addInAppMessage:")]
    void AddInAppMessage(ABKInAppMessage newInAppMessage);
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

    // @property (copy) UIFont * _Nullable buttonTextFont;
    [NullAllowed, Export("buttonTextFont", ArgumentSemantic.Copy)]
    UIFont ButtonTextFont { get; set; }

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

  // @interface ABKInAppMessageHTMLJSBridge : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageHTMLJSBridge
  {
    // +(BOOL)isBridgeURL:(NSURL *)url;
    [Static]
    [Export("isBridgeURL:")]
    bool IsBridgeURL(NSUrl url);

    // -(void)handleBridgeCallWithURL:(NSURL *)url appboyInstance:(Appboy *)appboy;
    [Export("handleBridgeCallWithURL:appboyInstance:")]
    void HandleBridgeCallWithURL(NSUrl url, Appboy appboy);
  }

  // @interface ABKInAppMessageHTMLJSInterface : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageHTMLJSInterface
  {
    // +(NSString *)getJSInterface;
    [Static]
    [Export("getJSInterface")]
    string JSInterface { get; }
  }

  // @interface ABKIdentifierForAdvertisingProvider : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKIdentifierForAdvertisingProvider
  {
    // +(NSString * _Nullable)getIdentifierForAdvertiser;
    [Static]
    [NullAllowed, Export("getIdentifierForAdvertiser")]
    string IdentifierForAdvertiser { get; }

    // +(NSNumber * _Nullable)getIsAdvertisingTrackingEnabledAsNSNumber;
    [Static]
    [NullAllowed, Export("getIsAdvertisingTrackingEnabledAsNSNumber")]
    NSNumber IsAdvertisingTrackingEnabledAsNSNumber { get; }
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

  // @interface ABKSDWebImageProxy : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKSDWebImageProxy
  {
    // +(void)setImageForView:(UIImageView * _Nonnull)imageView showActivityIndicator:(BOOL)showActivityIndicator withURL:(NSURL * _Nullable)imageURL imagePlaceHolder:(UIImage * _Nullable)placeHolder completed:(void (^ _Nullable)(UIImage * _Nullable, NSError * _Nullable, NSInteger, NSUrl * _Nullable))completion;
    [Static]
    [Export("setImageForView:showActivityIndicator:withURL:imagePlaceHolder:completed:")]
    void SetImageForView(UIImageView imageView, bool showActivityIndicator, [NullAllowed] NSUrl imageURL, [NullAllowed] UIImage placeHolder, [NullAllowed] Action<UIImage, NSError, nint, NSUrl> completion);

    // +(void)prefetchURLs:(NSArray * _Nullable)imageURLs;
    [Static]
    [Export("prefetchURLs:")]
    void PrefetchURLs([NullAllowed] NSObject[] imageURLs);

    // +(void)loadImageWithURL:(NSURL * _Nullable)url options:(NSInteger)options completed:(void (^ _Nullable)(UIImage * _Nonnull, NSData * _Nonnull, NSError * _Nonnull, NSInteger, BOOL, NSUrl * _Nonnull))completion;
    [Static]
    [Export("loadImageWithURL:options:completed:")]
    void LoadImageWithURL([NullAllowed] NSUrl url, nint options, [NullAllowed] Action<UIImage, NSData, NSError, nint, bool, NSUrl> completion);

    // +(void)diskImageExistsForURL:(NSURL * _Nullable)url completed:(void (^ _Nullable)(BOOL))completion;
    [Static]
    [Export("diskImageExistsForURL:completed:")]
    void DiskImageExistsForURL([NullAllowed] NSUrl url, [NullAllowed] Action<bool> completion);

    // +(NSString * _Nullable)cacheKeyForURL:(NSURL * _Nullable)url;
    [Static]
    [Export("cacheKeyForURL:")]
    [return: NullAllowed]
    string CacheKeyForURL([NullAllowed] NSUrl url);

    // +(void)removeImageForKey:(NSString * _Nullable)key;
    [Static]
    [Export("removeImageForKey:")]
    void RemoveImageForKey([NullAllowed] string key);

    // +(UIImage * _Nullable)imageFromCacheForKey:(NSString * _Nullable)key;
    [Static]
    [Export("imageFromCacheForKey:")]
    [return: NullAllowed]
    UIImage ImageFromCacheForKey([NullAllowed] string key);

    // +(BOOL)isSupportedSDWebImageVersion;
    [Static]
    [Export("isSupportedSDWebImageVersion")]
    bool IsSupportedSDWebImageVersion { get; }
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
    // +(BOOL)isAppboyUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0)));
    [Introduced(PlatformName.iOS, 10, 0, message: "")]
    [Static]
    [Export("isAppboyUserNotification:")]
    bool IsAppboyUserNotification(UNNotificationResponse response);

    // +(BOOL)isAppboyRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isAppboyRemoteNotification:")]
    bool IsAppboyRemoteNotification(NSDictionary userInfo);

    // +(BOOL)isAppboyInternalRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isAppboyInternalRemoteNotification:")]
    bool IsAppboyInternalRemoteNotification(NSDictionary userInfo);

    // +(BOOL)isUninstallTrackingUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0)));
    [Introduced(PlatformName.iOS, 10, 0, message: "")]
    [Static]
    [Export("isUninstallTrackingUserNotification:")]
    bool IsUninstallTrackingUserNotification(UNNotificationResponse response);

    // +(BOOL)isUninstallTrackingRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isUninstallTrackingRemoteNotification:")]
    bool IsUninstallTrackingRemoteNotification(NSDictionary userInfo);

    // +(BOOL)isGeofencesSyncUserNotification:(UNNotificationResponse * _Nonnull)response __attribute__((availability(ios, introduced=10.0)));
    [Introduced(PlatformName.iOS, 10, 0, message: "")]
    [Static]
    [Export("isGeofencesSyncUserNotification:")]
    bool IsGeofencesSyncUserNotification(UNNotificationResponse response);

    // +(BOOL)isGeofencesSyncRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isGeofencesSyncRemoteNotification:")]
    bool IsGeofencesSyncRemoteNotification(NSDictionary userInfo);

    // +(BOOL)isPushStoryRemoteNotification:(NSDictionary * _Nonnull)userInfo;
    [Static]
    [Export("isPushStoryRemoteNotification:")]
    bool IsPushStoryRemoteNotification(NSDictionary userInfo);

    // +(BOOL)shouldFetchTestTriggersFlagContainedInPayload:(NSDictionary * _Nonnull)userInfo __attribute__((deprecated("")));
    [Static]
    [Export("shouldFetchTestTriggersFlagContainedInPayload:")]
    bool ShouldFetchTestTriggersFlagContainedInPayload(NSDictionary userInfo);

    // +(NSSet<UNNotificationCategory *> * _Nonnull)getAppboyUNNotificationCategorySet __attribute__((availability(ios, introduced=10.0)));
    [Introduced(PlatformName.iOS, 10, 0, message: "")]
    [Static]
    [Export("getAppboyUNNotificationCategorySet")]
    NSSet<UNNotificationCategory> AppboyUNNotificationCategorySet { get; }

    // +(NSSet<UIUserNotificationCategory *> * _Nonnull)getAppboyUIUserNotificationCategorySet __attribute__((deprecated("")));
    [Static]
    [Export("getAppboyUIUserNotificationCategorySet")]
    NSSet<UIUserNotificationCategory> AppboyUIUserNotificationCategorySet { get; }
  }

  // @interface ABKFeedbackViewController : UIViewController <UITextFieldDelegate>
  [BaseType(typeof(UIViewController))]
  interface ABKFeedbackViewController : IUITextFieldDelegate
  {
    // @property (nonatomic, weak) UITextView * feedbackTextView __attribute__((iboutlet));
    [Export("feedbackTextView", ArgumentSemantic.Weak)]
    UITextView FeedbackTextView { get; set; }

    // @property (nonatomic, weak) UIButton * issueButton __attribute__((iboutlet));
    [Export("issueButton", ArgumentSemantic.Weak)]
    UIButton IssueButton { get; set; }

    // @property (nonatomic, weak) UILabel * messageLabel __attribute__((iboutlet));
    [Export("messageLabel", ArgumentSemantic.Weak)]
    UILabel MessageLabel { get; set; }

    // @property (nonatomic, weak) UILabel * reportIssueLabel __attribute__((iboutlet));
    [Export("reportIssueLabel", ArgumentSemantic.Weak)]
    UILabel ReportIssueLabel { get; set; }

    // @property (nonatomic, weak) UITextField * emailTextField __attribute__((iboutlet));
    [Export("emailTextField", ArgumentSemantic.Weak)]
    UITextField EmailTextField { get; set; }

    // @property (nonatomic, weak) UIView * spinnerView __attribute__((iboutlet));
    [Export("spinnerView", ArgumentSemantic.Weak)]
    UIView SpinnerView { get; set; }

    // -(void)issueButtonTapped:(UIButton *)sender __attribute__((ibaction));
    [Export("issueButtonTapped:")]
    void IssueButtonTapped(UIButton sender);

    // -(void)sendButtonTapped:(UIBarButtonItem *)sender __attribute__((ibaction));
    [Export("sendButtonTapped:")]
    void SendButtonTapped(UIBarButtonItem sender);

    // -(ABKFeedback *)appboyFeedbackFromMessage:(NSString *)message email:(NSString *)email isBug:(BOOL)isBug;
    [Export("appboyFeedbackFromMessage:email:isBug:")]
    ABKFeedback AppboyFeedbackFromMessage(string message, string email, bool isBug);

    // -(void)feedbackSent:(ABKFeedbackSentResult)feedbackSentResult;
    [Export("feedbackSent:")]
    void FeedbackSent(ABKFeedbackSentResult feedbackSentResult);

    // -(NSString *)localizedAppboyFeedbackString:(NSString *)key;
    [Export("localizedAppboyFeedbackString:")]
    string LocalizedAppboyFeedbackString(string key);

    // -(void)displayAlertViewWithTitle:(NSString *)title message:(NSString *)message;
    [Export("displayAlertViewWithTitle:message:")]
    void DisplayAlertViewWithTitle(string title, string message);
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

    // @property (nonatomic, weak) UILabel * _Nullable inAppMessageMessageLabel __attribute__((iboutlet));
    [NullAllowed, Export("inAppMessageMessageLabel", ArgumentSemantic.Weak)]
    UILabel InAppMessageMessageLabel { get; set; }

    // @property BOOL isiPad;
    [Export("isiPad")]
    bool IsiPad { get; set; }

    // -(instancetype _Nonnull)initWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage;
    [Export("initWithInAppMessage:")]
    IntPtr Constructor(ABKInAppMessage inAppMessage);

    // -(void)hideInAppMessage:(BOOL)animated;
    [Export("hideInAppMessage:")]
    void HideInAppMessage(bool animated);

    // -(void)beforeMoveInAppMessageViewOffScreen;
    [Export("beforeMoveInAppMessageViewOffScreen")]
    void BeforeMoveInAppMessageViewOffScreen();

    // -(void)moveInAppMessageViewOffScreen;
    [Export("moveInAppMessageViewOffScreen")]
    void MoveInAppMessageViewOffScreen();

    // -(void)beforeMoveInAppMessageViewOnScreen;
    [Export("beforeMoveInAppMessageViewOnScreen")]
    void BeforeMoveInAppMessageViewOnScreen();

    // -(void)moveInAppMessageViewOnScreen;
    [Export("moveInAppMessageViewOnScreen")]
    void MoveInAppMessageViewOnScreen();

    // -(BOOL)applyImageToImageView:(UIImageView * _Nonnull)iconImageView;
    [Export("applyImageToImageView:")]
    bool ApplyImageToImageView(UIImageView iconImageView);

    // -(BOOL)applyIconToLabelView:(UILabel * _Nonnull)iconLabelView;
    [Export("applyIconToLabelView:")]
    bool ApplyIconToLabelView(UILabel iconLabelView);
  }

  // @interface ABKInAppMessageUIButton : UIButton
  [BaseType(typeof(UIButton))]
  interface ABKInAppMessageUIButton
  {
    // @property ABKInAppMessageButton * _Nonnull inAppButtonModel;
    [Export("inAppButtonModel", ArgumentSemantic.Assign)]
    ABKInAppMessageButton InAppButtonModel { get; set; }
  }

  // @interface ABKInAppMessageImmersiveViewController : ABKInAppMessageViewController
  [BaseType(typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageImmersiveViewController
  {
    // @property (nonatomic, weak) UILabel * _Nullable inAppMessageHeaderLabel __attribute__((iboutlet));
    [NullAllowed, Export("inAppMessageHeaderLabel", ArgumentSemantic.Weak)]
    UILabel InAppMessageHeaderLabel { get; set; }

    // @property (nonatomic, weak) UIImageView * _Nullable graphicImageView __attribute__((iboutlet));
    [NullAllowed, Export("graphicImageView", ArgumentSemantic.Weak)]
    UIImageView GraphicImageView { get; set; }

    // @property (nonatomic) NSLayoutConstraint * _Nonnull headerBodySpaceConstraint __attribute__((iboutlet));
    [Export("headerBodySpaceConstraint", ArgumentSemantic.Assign)]
    NSLayoutConstraint HeaderBodySpaceConstraint { get; set; }

    // @property (retain, nonatomic) ABKInAppMessageUIButton * _Nullable leftInAppMessageButton __attribute__((iboutlet));
    [NullAllowed, Export("leftInAppMessageButton", ArgumentSemantic.Retain)]
    ABKInAppMessageUIButton LeftInAppMessageButton { get; set; }

    // @property (retain, nonatomic) ABKInAppMessageUIButton * _Nullable rightInAppMessageButton __attribute__((iboutlet));
    [NullAllowed, Export("rightInAppMessageButton", ArgumentSemantic.Retain)]
    ABKInAppMessageUIButton RightInAppMessageButton { get; set; }

    // @property (nonatomic) UIScrollView * _Nullable textsView __attribute__((iboutlet));
    [NullAllowed, Export("textsView", ArgumentSemantic.Assign)]
    UIScrollView TextsView { get; set; }

    // -(void)setupLayoutForGraphic;
    [Export("setupLayoutForGraphic")]
    void SetupLayoutForGraphic();

    // -(void)setupLayoutForTopImage;
    [Export("setupLayoutForTopImage")]
    void SetupLayoutForTopImage();

    // -(void)changeCloseButtonColor;
    [Export("changeCloseButtonColor")]
    void ChangeCloseButtonColor();

    // -(void)dismissInAppMessage:(id _Nonnull)sender __attribute__((ibaction));
    [Export("dismissInAppMessage:")]
    void DismissInAppMessage(NSObject sender);

    // -(void)buttonClicked:(ABKInAppMessageUIButton * _Nonnull)button __attribute__((ibaction));
    [Export("buttonClicked:")]
    void ButtonClicked(ABKInAppMessageUIButton button);
  }

  // @interface ABKInAppMessageFullViewController : ABKInAppMessageImmersiveViewController
  [BaseType(typeof(ABKInAppMessageImmersiveViewController))]
  interface ABKInAppMessageFullViewController
  {
    // @property (nonatomic, unsafe_unretained) NSLayoutConstraint * _Nonnull textsViewLeadingConstraint __attribute__((iboutlet));
    [Export("textsViewLeadingConstraint", ArgumentSemantic.Assign)]
    NSLayoutConstraint TextsViewLeadingConstraint { get; set; }

    // @property (nonatomic, unsafe_unretained) NSLayoutConstraint * _Nonnull textsViewTrailingConstraint __attribute__((iboutlet));
    [Export("textsViewTrailingConstraint", ArgumentSemantic.Assign)]
    NSLayoutConstraint TextsViewTrailingConstraint { get; set; }

    // @property (nonatomic, unsafe_unretained) NSLayoutConstraint * _Nonnull headerLeadingConstraint __attribute__((iboutlet));
    [Export("headerLeadingConstraint", ArgumentSemantic.Assign)]
    NSLayoutConstraint HeaderLeadingConstraint { get; set; }

    // @property (nonatomic, unsafe_unretained) NSLayoutConstraint * _Nonnull headerTrailingConstraint __attribute__((iboutlet));
    [Export("headerTrailingConstraint", ArgumentSemantic.Assign)]
    NSLayoutConstraint HeaderTrailingConstraint { get; set; }

    // @property (nonatomic, unsafe_unretained) NSLayoutConstraint * _Nonnull messageLeadingConstraint __attribute__((iboutlet));
    [Export("messageLeadingConstraint", ArgumentSemantic.Assign)]
    NSLayoutConstraint MessageLeadingConstraint { get; set; }

    // @property (nonatomic, unsafe_unretained) NSLayoutConstraint * _Nonnull messageTrailingConstraint __attribute__((iboutlet));
    [Export("messageTrailingConstraint", ArgumentSemantic.Assign)]
    NSLayoutConstraint MessageTrailingConstraint { get; set; }
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
    // @property (nonatomic, weak) NSLayoutConstraint * _Nullable topConstraint __attribute__((iboutlet));
    [NullAllowed, Export("topConstraint", ArgumentSemantic.Weak)]
    NSLayoutConstraint TopConstraint { get; set; }

    // @property (nonatomic, weak) NSLayoutConstraint * _Nullable bottomConstraint __attribute__((iboutlet));
    [NullAllowed, Export("bottomConstraint", ArgumentSemantic.Weak)]
    NSLayoutConstraint BottomConstraint { get; set; }
  }

  // @interface ABKInAppMessageModalViewController : ABKInAppMessageImmersiveViewController
  [BaseType(typeof(ABKInAppMessageImmersiveViewController))]
  interface ABKInAppMessageModalViewController
  {
    // @property (retain, nonatomic) NSLayoutConstraint * _Nonnull iconImageHeightConstraint __attribute__((iboutlet));
    [Export("iconImageHeightConstraint", ArgumentSemantic.Retain)]
    NSLayoutConstraint IconImageHeightConstraint { get; set; }

    // @property (retain, nonatomic) NSLayoutConstraint * _Nonnull textsViewWidthConstraint __attribute__((iboutlet));
    [Export("textsViewWidthConstraint", ArgumentSemantic.Retain)]
    NSLayoutConstraint TextsViewWidthConstraint { get; set; }
  }

  // @interface ABKInAppMessageSlideupViewController : ABKInAppMessageViewController
  [BaseType(typeof(ABKInAppMessageViewController))]
  interface ABKInAppMessageSlideupViewController
  {
    // @property (nonatomic, weak) UIImageView * _Nullable arrowImage __attribute__((iboutlet));
    [NullAllowed, Export("arrowImage", ArgumentSemantic.Weak)]
    UIImageView ArrowImage { get; set; }

    // @property (nonatomic, weak) NSLayoutConstraint * _Nullable slideConstraint __attribute__((iboutlet));
    [NullAllowed, Export("slideConstraint", ArgumentSemantic.Weak)]
    NSLayoutConstraint SlideConstraint { get; set; }
  }

  // @protocol ABKInAppMessageUIDelegate <NSObject>
  [Protocol, Model]
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageUIDelegate
  {
    // @optional -(ABKInAppMessageDisplayChoice)beforeInAppMessageDisplayed:(ABKInAppMessage * _Nonnull)inAppMessage withKeyboardIsUp:(BOOL)keyboardIsUp __attribute__((deprecated("")));
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

  // @interface ABKInAppMessageWindow : UIWindow
  [BaseType(typeof(UIWindow))]
  interface ABKInAppMessageWindow
  {
    // @property BOOL catchClicksOutsideInAppMessage;
    [Export("catchClicksOutsideInAppMessage")]
    bool CatchClicksOutsideInAppMessage { get; set; }
  }

  // @interface ABKInAppMessageWindowController : UIViewController <UIGestureRecognizerDelegate>
  [BaseType(typeof(UIViewController))]
  interface ABKInAppMessageWindowController : IUIGestureRecognizerDelegate
  {
    // @property (nonatomic) ABKInAppMessageWindow * _Nullable inAppMessageWindow __attribute__((iboutlet));
    [NullAllowed, Export("inAppMessageWindow", ArgumentSemantic.Assign)]
    ABKInAppMessageWindow InAppMessageWindow { get; set; }

    // @property NSTimer * _Nullable slideAwayTimer;
    [NullAllowed, Export("slideAwayTimer", ArgumentSemantic.Assign)]
    NSTimer SlideAwayTimer { get; set; }

    // @property ABKInAppMessage * _Nonnull inAppMessage;
    [Export("inAppMessage", ArgumentSemantic.Assign)]
    ABKInAppMessage InAppMessage { get; set; }

    [Wrap("WeakInAppMessageUIDelegate")]
    [NullAllowed]
    ABKInAppMessageUIDelegate InAppMessageUIDelegate { get; set; }

    // @property (weak) id<ABKInAppMessageUIDelegate> _Nullable inAppMessageUIDelegate;
    [NullAllowed, Export("inAppMessageUIDelegate", ArgumentSemantic.Weak)]
    NSObject WeakInAppMessageUIDelegate { get; set; }

    // @property ABKInAppMessageViewController * _Nonnull inAppMessageViewController;
    [Export("inAppMessageViewController", ArgumentSemantic.Assign)]
    ABKInAppMessageViewController InAppMessageViewController { get; set; }

    // @property CGFloat slideupConstraintMaxValue;
    [Export("slideupConstraintMaxValue")]
    nfloat SlideupConstraintMaxValue { get; set; }

    // @property CGPoint inAppMessagePreviousPanPosition;
    [Export("inAppMessagePreviousPanPosition", ArgumentSemantic.Assign)]
    CGPoint InAppMessagePreviousPanPosition { get; set; }

    // @property UIInterfaceOrientationMask supportedOrientationMasks;
    [Export("supportedOrientationMasks", ArgumentSemantic.Assign)]
    UIInterfaceOrientationMask SupportedOrientationMasks { get; set; }

    // @property UIInterfaceOrientation supportedOrientations;
    [Export("supportedOrientations", ArgumentSemantic.Assign)]
    UIInterfaceOrientation SupportedOrientations { get; set; }

    // @property (nonatomic, weak) UIWindow * _Nullable appWindow;
    [NullAllowed, Export("appWindow", ArgumentSemantic.Weak)]
    UIWindow AppWindow { get; set; }

    // @property BOOL isInRotation;
    [Export("isInRotation")]
    bool IsInRotation { get; set; }

    // @property BOOL inAppMessageIsTapped;
    [Export("inAppMessageIsTapped")]
    bool InAppMessageIsTapped { get; set; }

    // @property NSInteger clickedButtonId;
    [Export("clickedButtonId")]
    nint ClickedButtonId { get; set; }

    // @property NSString * _Nullable clickedHTMLButtonId;
    [NullAllowed, Export("clickedHTMLButtonId")]
    string ClickedHTMLButtonId { get; set; }

    // -(instancetype _Nonnull)initWithInAppMessage:(ABKInAppMessage * _Nonnull)inAppMessage inAppMessageViewController:(ABKInAppMessageViewController * _Nonnull)inAppMessageViewController inAppMessageDelegate:(id<ABKInAppMessageUIDelegate> _Nonnull)delegate;
    [Export("initWithInAppMessage:inAppMessageViewController:inAppMessageDelegate:")]
    IntPtr Constructor(ABKInAppMessage inAppMessage, ABKInAppMessageViewController inAppMessageViewController, ABKInAppMessageUIDelegate @delegate);

    // -(void)keyboardWasShown;
    [Export("keyboardWasShown")]
    void KeyboardWasShown();

    // -(void)displayInAppMessageViewWithAnimation:(BOOL)withAnimation;
    [Export("displayInAppMessageViewWithAnimation:")]
    void DisplayInAppMessageViewWithAnimation(bool withAnimation);

    // -(void)hideInAppMessageViewWithAnimation:(BOOL)withAnimation;
    [Export("hideInAppMessageViewWithAnimation:")]
    void HideInAppMessageViewWithAnimation(bool withAnimation);

    // -(void)hideInAppMessageViewWithAnimation:(BOOL)withAnimation completionHandler:(void (^ _Nullable)(void))completionHandler;
    [Export("hideInAppMessageViewWithAnimation:completionHandler:")]
    void HideInAppMessageViewWithAnimation(bool withAnimation, [NullAllowed] Action completionHandler);

    // -(void)inAppMessageClickedWithActionType:(ABKInAppMessageClickActionType)actionType URL:(NSURL * _Nullable)url openURLInWebView:(BOOL)openUrlInWebView;
    [Export("inAppMessageClickedWithActionType:URL:openURLInWebView:")]
    void InAppMessageClickedWithActionType(ABKInAppMessageClickActionType actionType, [NullAllowed] NSUrl url, bool openUrlInWebView);
  }

  // @interface ABKInAppMessageUIController : NSObject <ABKInAppMessageUIControlling>
  [BaseType(typeof(NSObject))]
  interface ABKInAppMessageUIController : ABKInAppMessageUIControlling
  {
    // @property UIInterfaceOrientationMask supportedOrientationMasks;
    [Export("supportedOrientationMasks", ArgumentSemantic.Assign)]
    UIInterfaceOrientationMask SupportedOrientationMasks { get; set; }

    // @property UIInterfaceOrientation supportedOrientations;
    [Export("supportedOrientations", ArgumentSemantic.Assign)]
    UIInterfaceOrientation SupportedOrientations { get; set; }

    // @property BOOL keyboardVisible;
    [Export("keyboardVisible")]
    bool KeyboardVisible { get; set; }

    // @property ABKInAppMessageWindowController * _Nullable inAppMessageWindowController;
    [NullAllowed, Export("inAppMessageWindowController", ArgumentSemantic.Assign)]
    ABKInAppMessageWindowController InAppMessageWindowController { get; set; }

    [Wrap("WeakUiDelegate")]
    [NullAllowed]
    ABKInAppMessageUIDelegate UiDelegate { get; set; }

    // @property (weak) id<ABKInAppMessageUIDelegate> _Nullable uiDelegate;
    [NullAllowed, Export("uiDelegate", ArgumentSemantic.Weak)]
    NSObject WeakUiDelegate { get; set; }
  }

  // @interface ABKInAppMessageView : UIView
  [BaseType(typeof(UIView))]
  interface ABKInAppMessageView
  {
  }

  // @interface ABKModalFeedbackViewController : ABKFeedbackViewController
  [BaseType(typeof(ABKFeedbackViewController))]
  interface ABKModalFeedbackViewController
  {
    // @property (nonatomic, weak) UINavigationBar * navigationBar __attribute__((iboutlet));
    [Export("navigationBar", ArgumentSemantic.Weak)]
    UINavigationBar NavigationBar { get; set; }

    // @property (nonatomic, weak) UIBarButtonItem * cancelBarButton __attribute__((iboutlet));
    [Export("cancelBarButton", ArgumentSemantic.Weak)]
    UIBarButtonItem CancelBarButton { get; set; }

    // @property (nonatomic, weak) UIBarButtonItem * sendBarButton __attribute__((iboutlet));
    [Export("sendBarButton", ArgumentSemantic.Weak)]
    UIBarButtonItem SendBarButton { get; set; }

    // -(void)cancelButtonTapped:(UIBarButtonItem *)sender __attribute__((ibaction));
    [Export("cancelButtonTapped:")]
    void CancelButtonTapped(UIBarButtonItem sender);
  }

  // @interface ABKModalWebViewController : UINavigationController <WKNavigationDelegate>
  [BaseType(typeof(UINavigationController))]
  interface ABKModalWebViewController : IWKNavigationDelegate
  {
    // @property NSURL * url;
    [Export("url", ArgumentSemantic.Assign)]
    NSUrl Url { get; set; }

    // @property (nonatomic) WKWebView * webView __attribute__((iboutlet));
    [Export("webView", ArgumentSemantic.Assign)]
    WKWebView WebView { get; set; }

    // @property (nonatomic) UIProgressView * progressBar __attribute__((iboutlet));
    [Export("progressBar", ArgumentSemantic.Assign)]
    UIProgressView ProgressBar { get; set; }
  }

  // @interface ABKNavigationBar : UINavigationBar
  [BaseType(typeof(UINavigationBar))]
  interface ABKNavigationBar
  {
  }

  // @interface ABKNavigationFeedbackViewController : ABKFeedbackViewController
  [BaseType(typeof(ABKFeedbackViewController))]
  interface ABKNavigationFeedbackViewController
  {
  }

  // @interface ABKNoConnectionLocalization : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKNoConnectionLocalization
  {
    // +(NSString *)getNoConnectionLocalizedString;
    [Static]
    [Export("getNoConnectionLocalizedString")]
    string NoConnectionLocalizedString { get; }
  }

  // @interface ABKThemableFeedNavigationBar : ABKNavigationBar
  [BaseType(typeof(ABKNavigationBar))]
  interface ABKThemableFeedNavigationBar
  {
  }

  // @interface ABKUIURLUtils : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKUIURLUtils
  {
    // +(BOOL)URLDelegate:(id<ABKURLDelegate>)urlDelegate handlesURL:(NSURL *)url fromChannel:(ABKChannel)channel withExtras:(NSDictionary *)extras;
    [Static]
    [Export("URLDelegate:handlesURL:fromChannel:withExtras:")]
    bool URLDelegate(ABKURLDelegate urlDelegate, NSUrl url, ABKChannel channel, NSDictionary extras);

    // +(BOOL)URL:(NSURL *)url shouldOpenInWebView:(BOOL)openUrlInWebView;
    [Static]
    [Export("URL:shouldOpenInWebView:")]
    bool URL(NSUrl url, bool openUrlInWebView);

    // +(void)openURLWithSystem:(NSURL *)url;
    [Static]
    [Export("openURLWithSystem:")]
    void OpenURLWithSystem(NSUrl url);

    // +(UIViewController *)topmostViewControllerWithRootViewController:(UIViewController *)viewController;
    [Static]
    [Export("topmostViewControllerWithRootViewController:")]
    UIViewController TopmostViewControllerWithRootViewController(UIViewController viewController);

    // +(void)displayModalWebViewWithURL:(NSURL *)url topmostViewController:(UIViewController *)topmostViewController;
    [Static]
    [Export("displayModalWebViewWithURL:topmostViewController:")]
    void DisplayModalWebViewWithURL(NSUrl url, UIViewController topmostViewController);
  }

  // @interface ABKUIUtils : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKUIUtils
  {
    // +(NSString *)getLocalizedString:(NSString *)key inAppboyBundle:(NSBundle *)appboyBundle table:(NSString *)table;
    [Static]
    [Export("getLocalizedString:inAppboyBundle:table:")]
    string GetLocalizedString(string key, NSBundle appboyBundle, string table);

    // +(BOOL)objectIsValidAndNotEmpty:(id)object;
    [Static]
    [Export("objectIsValidAndNotEmpty:")]
    bool ObjectIsValidAndNotEmpty(NSObject @object);

    // +(UIImage *)maskImage:(UIImage *)image toColor:(UIColor *)color;
    [Static]
    [Export("maskImage:toColor:")]
    UIImage MaskImage(UIImage image, UIColor color);

    // +(Class)getSDWebImageProxyClass;
    [Static]
    [Export("getSDWebImageProxyClass")]
    Class SDWebImageProxyClass { get; }

    // +(Class)getModalFeedViewControllerClass;
    [Static]
    [Export("getModalFeedViewControllerClass")]
    Class ModalFeedViewControllerClass { get; }

    // +(BOOL)isiPhoneX;
    [Static]
    [Export("isiPhoneX")]
    bool IsiPhoneX { get; }
  }

  // @interface ABKViewUtilities : NSObject
  [BaseType(typeof(NSObject))]
  interface ABKViewUtilities
  {
    // +(void)setViewOriginY:(UIView *)view originY:(CGFloat)originY;
    [Static]
    [Export("setViewOriginY:originY:")]
    void SetViewOriginY(UIView view, nfloat originY);

    // +(void)setViewOriginX:(UIView *)view originX:(CGFloat)originX;
    [Static]
    [Export("setViewOriginX:originX:")]
    void SetViewOriginX(UIView view, nfloat originX);

    // +(void)setViewHeight:(UIView *)view height:(CGFloat)aHeight;
    [Static]
    [Export("setViewHeight:height:")]
    void SetViewHeight(UIView view, nfloat aHeight);

    // +(void)setViewWidth:(UIView *)view width:(CGFloat)aWidth;
    [Static]
    [Export("setViewWidth:width:")]
    void SetViewWidth(UIView view, nfloat aWidth);

    // +(void)setViewCenterY:(UIView *)view centerY:(CGFloat)centerY;
    [Static]
    [Export("setViewCenterY:centerY:")]
    void SetViewCenterY(UIView view, nfloat centerY);

    // +(void)setViewCenterX:(UIView *)view centerX:(CGFloat)centerX;
    [Static]
    [Export("setViewCenterX:centerX:")]
    void SetViewCenterX(UIView view, nfloat centerX);

    // +(void)stackViews:(NSArray *)views startYPosition:(CGFloat)startYPosition padding:(CGFloat)padding spacing:(CGFloat)spacing maxTotalHeight:(CGFloat)maxTotalHeight;
    [Static]
    [Export("stackViews:startYPosition:padding:spacing:maxTotalHeight:")]
    void StackViews(NSObject[] views, nfloat startYPosition, nfloat padding, nfloat spacing, nfloat maxTotalHeight);

    // +(UIImage *)fetchImageIfCached:(NSString *)imageUrlString;
    [Static]
    [Export("fetchImageIfCached:")]
    UIImage FetchImageIfCached(string imageUrlString);
  }
}
