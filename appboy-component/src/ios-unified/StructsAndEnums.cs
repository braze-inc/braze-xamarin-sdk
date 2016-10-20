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

  public enum ABKUserGenderType /* nint */
  {
    Male,
    Female
  }

  public enum ABKNotificationSubscriptionType /* nint */
  {
    ABKOptedIn,
    ABKSubscribed,
    ABKUnsubscribed
  }

  public enum ABKInAppMessageClickActionType
  {
    DisplayNewsFeed,
    RedirectToURI,
    NoneClickAction
  }

  public enum ABKInAppMessageDismissType
  {
    Automatically,
    Manually
  }

  public enum ABKInAppMessageOrientation /* nint */
  {
    Any,
    Portrait,
    Landscape
  }

  public enum ABKInAppMessageDisplayChoice
  {
    playInAppMessageNow,
    playInAppMessageLater,
    cardInAppMessage
  }

  public enum ABKInAppMessageImmersiveImageStyle /* nint */
  {
    Graphic,
    TopImage
  }

  public enum ABKInAppMessageSlideupAnchor
  {
    Top,
    Bottom
  }

  public enum ABKRequestProcessingPolicy /* nint */
  {
    AutomaticRequestProcessing,
    AutomaticRequestProcessingExceptForDataFlush,
    ManualRequestProcessing
  }
}
