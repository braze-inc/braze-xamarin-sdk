using System;

namespace AppboyPlatformXamariniOSBinding
{
  public enum ABKRequestProcessingPolicy /* nint */ {
    ABKAutomaticRequestProcessing,
    ABKAutomaticRequestProcessingExceptForDataFlush,
    ABKManualRequestProcessing
  }

  public enum ABKSocialAccountAcquisitionPolicy /* nint */ {
    ABKAutomaticSocialAccountAcquisition,
    ABKAutomaticSocialAccountAcquisitionWithIdentifierOnly,
    ABKManualSocialAccountAcquisition
  }

  public enum ABKSocialNetwork /* nuint */ {
    Facebook = 1 << 0,
    Twitter = 1 << 1
  }

  public enum ABKUserGenderType /* nint */ {
    Male,
    Female
  }

  public enum ABKNotificationSubscriptionType /* nint */ {
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

  public enum ABKInAppMessageDisplayChoice
  {
    playInAppMessageNow,
    playInAppMessageLater,
    cardInAppMessage
  }
  public enum ABKCardCategory /* nuint */ {
    NoCategory = 1 << 0,
    News = 1 << 1,
    Advertising = 1 << 2,
    Announcements = 1 << 3,
    Social = 1 << 4,
    All = 1 << 0 | 1 << 1 | 1 << 2 | 1 << 3 | 1 << 4
  }
      
  public enum ABKInAppMessageSlideupAnchor
  {
    Top,
    Bottom
  }
}

