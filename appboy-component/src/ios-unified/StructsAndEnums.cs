using System;
using ObjCRuntime;

namespace AppboyPlatformXamariniOSBinding
{
  public enum ABKCardCategory /* nuint */
  {
    NoCategory = 1 << 0,
    News = 1 << 1,
    Advertising = 1 << 2,
    Announcements = 1 << 3,
    Social = 1 << 4,
    All = 1 << 0 | 1 << 1 | 1 << 2 | 1 << 3 | 1 << 4
  }

  public enum ABKUserGenderType /* nuint */
  {
    Male,
    Female,
    Other,
    Unknown,
    NotApplicable,
    PreferNotToSay
  }

  public enum ABKNotificationSubscriptionType /* nuint */
  {
    ABKOptedIn,
    ABKSubscribed,
    ABKUnsubscribed
  }

  public enum ABKFeedbackValidation : uint
  {
    ValidFeedback,
    InvalidEmailAddressFeedback,
    EmptyFeedbackMessageFeedback
  }

  public enum ABKRequestProcessingPolicy /* nuint */
  {
    AutomaticRequestProcessing,
    AutomaticRequestProcessingExceptForDataFlush,
    ManualRequestProcessing
  }

  public enum ABKSDKFlavor /* nuint */
  {
    Unity = 1,
    React,
    Cordova,
    Xamarin,
    Segment,
    Mparticle
  }

  public enum ABKFeedbackSentResult /* nuint */
  {
    InvalidFeedback,
    NetworkIssue,
    FeedbackSentSuccessfully
  }

  public enum ABKInAppMessageClickActionType /* nuint */
  {
    DisplayNewsFeed,
    RedirectToURI,
    NoneClickAction
  }

  public enum ABKInAppMessageDismissType /* nuint */
  {
    Automatically,
    Manually
  }

  public enum ABKInAppMessageOrientation /* nuint */
  {
    Any,
    Portrait,
    Landscape
  }

  public enum ABKInAppMessageSlideupAnchor /* nuint */
  {
    Top,
    Bottom
  }

  public enum ABKInAppMessageImmersiveImageStyle /* nuint */
  {
    Graphic,
    TopImage
  }

  public enum ABKInAppMessageDisplayChoice /* nuint */
  {
    displayInAppMessageNow,
    displayInAppMessageLater,
    discardInAppMessage
  }

  public enum ABKChannel /* nuint */
  {
    PushNotificationChannel,
    InAppMessageChannel,
    NewsFeedChannel
  }
}
