using System;
using BrazeKitCompat;
using BrazeUICompat;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using WebKit;

namespace BrazeUICompat
{
	// @protocol ABKBaseContentCardCellDelegate <NSObject>
	[Protocol, Model]
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
		UIImage PlaceHolderImage { get; }

		// -(Class)imageViewClass;
		[Export ("imageViewClass")]
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
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ABKContentCardsTableViewControllerDelegate
	{
		// @optional -(BOOL)contentCardTableViewController:(ABKContentCardsTableViewController *)viewController shouldHandleCardClick:(NSURL *)url;
		[Export ("contentCardTableViewController:shouldHandleCardClick:")]
		bool ShouldHandleCardClick (ABKContentCardsTableViewController viewController, NSUrl url);

		// @optional -(void)contentCardTableViewController:(ABKContentCardsTableViewController *)viewController didHandleCardClick:(NSURL *)url;
		[Export ("contentCardTableViewController:didHandleCardClick:")]
		void DidHandleCardClick (ABKContentCardsTableViewController viewController, NSUrl url);

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

		// @property (assign, nonatomic) CGFloat padding;
		[Export ("padding")]
		nfloat Padding { get; set; }

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
		NSObject[] DescriptionConstraints { get; set; }

		// @property (nonatomic, strong) NSArray * linkConstraints;
		[Export ("linkConstraints", ArgumentSemantic.Strong)]
		NSObject[] LinkConstraints { get; set; }

		// @property (assign, nonatomic) CGFloat padding;
		[Export ("padding")]
		nfloat Padding { get; set; }

		// -(void)applyCard:(ABKClassicContentCard *)classicCard;
		[Export ("applyCard:")]
		void ApplyCard (ABKClassicContentCard classicCard);

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
	[Protocol, Model]
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

	// @interface ABKInAppMessageUIController : NSObject <ABKInAppMessageUIControlling, BrazeInAppMessagePresenter>
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
		Class ModalFeedViewControllerClass { get; }

		// +(BOOL)isNotchedPhone;
		[Static]
		[Export ("isNotchedPhone")]
		bool IsNotchedPhone { get; }

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
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ABKBaseNewsFeedCellDelegate
	{
		// @required -(void)refreshTableViewCellHeights;
		[Abstract]
		[Export ("refreshTableViewCellHeights")]
		void RefreshTableViewCellHeights ();

	}

	[Static]
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
		UIColor ABKNFDescriptionLabelColor { get; }

		// +(UIColor *)ABKNFTitleLabelColor;
		[Static]
		[Export ("ABKNFTitleLabelColor")]
		UIColor ABKNFTitleLabelColor { get; }

		// +(UIColor *)ABKNFTitleLabelColorOnGray;
		[Static]
		[Export ("ABKNFTitleLabelColorOnGray")]
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
		UIImage PlaceHolderImage { get; }

		// -(Class)imageViewClass;
		[Export ("imageViewClass")]
		Class ImageViewClass { get; }

	}

	// @interface ABKNewsFeedTableViewController : UITableViewController <ABKBaseNewsFeedCellDelegate>
	[BaseType (typeof(UITableViewController))]
	interface ABKNewsFeedTableViewController
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

}
