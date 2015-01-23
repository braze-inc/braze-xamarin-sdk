using System;

namespace AppboyPlatformXamariniOSBinding
{
  public enum ABKRequestProcessingPolicy : long /* nint */ {
    ABKAutomaticRequestProcessing,
    ABKAutomaticRequestProcessingExceptForDataFlush,
    ABKManualRequestProcessing
  }

  public enum ABKSocialAccountAcquisitionPolicy : long /* nint */ {
    ABKAutomaticSocialAccountAcquisition,
    ABKAutomaticSocialAccountAcquisitionWithIdentifierOnly,
    ABKManualSocialAccountAcquisition
  }

  public enum ABKSocialNetwork : ulong /* nuint */ {
    Facebook = 1 << 0,
    Twitter = 1 << 1
  }

  public enum ABKUserGenderType : long /* nint */ {
    Male,
    Female
  }

  public enum ABKNotificationSubscriptionType : long /* nint */ {
    ABKOptedIn,
    ABKSubscribed,
    ABKUnsubscribed
  }

  public enum ABKSlideupAnchor : long /* nint */ {
    ABKSlideupFromTop,
    ABKSlideupFromBottom
  }

  public enum ABKSlideupDismissType : long /* nint */ {
    Automatically,
    BySwipe
  }

  public enum ABKSlideupClickActionType : long /* nint */ {
    ABKSlideupDisplayNewsFeed,
    ABKSlideupRedirectToURI,
    ABKSlideupNoneClickAction
  }

  public enum ABKSlideupDisplayChoice : long /* nint */ {
    ABKDisplaySlideupNow,
    ABKDisplaySlideupLater,
    ABKDiscardSlideup
  }
  public enum ABKCardCategory : ulong /* nuint */ {
    NoCategory = 1 << 0,
    News = 1 << 1,
    Advertising = 1 << 2,
    Announcements = 1 << 3,
    Social = 1 << 4,
    All = 1 << 0 | 1 << 1 | 1 << 2 | 1 << 3 | 1 << 4
  }
}

