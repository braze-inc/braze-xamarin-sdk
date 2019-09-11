using System;
using ObjCRuntime;

namespace AppboyPlatformXamariniOSBinding
{

  [Native]
  public enum ABKDeviceOptions /* nuint */
  {
    None = 0,
    Resolution = (1 << 0),
    Carrier = (1 << 1),
    Locale = (1 << 2),
    Model = (1 << 3),
    OSVersion = (1 << 4),
    Idfv = (1 << 5),
    Idfa = (1 << 6),
    PushEnabled = (1 << 7),
    Timezone = (1 << 8),
    PushAuthStatus = (1 << 9),
    AdTrackingEnabled = (1 << 10),
    All = ~None
  }

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
