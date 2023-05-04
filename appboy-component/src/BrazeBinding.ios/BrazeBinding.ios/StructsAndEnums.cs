namespace Braze
{

	using System;
	using ObjCRuntime;

	[Native]
	public enum ABKRequestProcessingPolicy : long
	{
		AutomaticRequestProcessing,
		ManualRequestProcessing,
		AutomaticRequestProcessingExceptForDataFlush = ManualRequestProcessing
	}

	[Native]
	public enum ABKSDKFlavor : long
	{
		Unity = 1,
		React,
		Cordova,
		Xamarin,
		Flutter,
		Segment,
		Mparticle,
		Tealium
	}

	[Flags]
	[Native]
	public enum ABKDeviceOptions : ulong
	{
		None = 0x0,
		Resolution = (1uL << 0),
		Carrier = (1uL << 1),
		Locale = (1uL << 2),
		Model = (1uL << 3),
		OSVersion = (1uL << 4),
		Idfv = (1uL << 5),
		Idfa = (1uL << 6),
		PushEnabled = (1uL << 7),
		Timezone = (1uL << 8),
		PushAuthStatus = (1uL << 9),
		AdTrackingEnabled = (1uL << 10),
		PushDisplayOptions = (1uL << 11),
		All = ~None
	}

	[Native]
	public enum ABKChannel : long
	{
		PushNotificationChannel,
		InAppMessageChannel,
		NewsFeedChannel,
		ContentCardChannel,
		UnknownChannel
	}

	[Native]
	public enum ABKUserGenderType : long
	{
		Male,
		Female,
		Other,
		Unknown,
		NotApplicable,
		PreferNotToSay
	}

	[Native]
	public enum ABKNotificationSubscriptionType : long
	{
		OptedIn,
		Subscribed,
		Unsubscribed
	}

	[Flags]
	[Native]
	public enum ABKCardCategory : ulong
	{
		NoCategory = 1uL << 0,
		News = 1uL << 1,
		Advertising = 1uL << 2,
		Announcements = 1uL << 3,
		Social = 1uL << 4,
		All = 1uL << 0 | 1uL << 1 | 1uL << 2 | 1uL << 3 | 1uL << 4
	}

	[Native]
	public enum ABKInAppMessageClickActionType : long
	{
		DisplayNewsFeed,
		RedirectToURI,
		NoneClickAction
	}

	[Native]
	public enum ABKInAppMessageDismissType : long
	{
		Automatically,
		Manually
	}

	[Native]
	public enum ABKInAppMessageOrientation : long
	{
		Any,
		Portrait,
		Landscape
	}

	[Native]
	public enum ABKInAppMessageSlideupAnchor : long
	{
		Top,
		Bottom
	}

	[Native]
	public enum ABKInAppMessageImmersiveImageStyle : long
	{
		Graphic,
		TopImage
	}

	[Native]
	public enum ABKInAppMessageDisplayChoice : long
	{
		playInAppMessageNow,
		playInAppMessageLater,
		cardInAppMessage
	}

	[Flags]
	[Native]
	public enum ABKImageOptions : ulong
	{
		RetryFailed = 1uL << 0,
		LowPriority = 1uL << 1,
		CacheMemoryOnly = 1uL << 2,
		ProgressiveDownload = 1uL << 3,
		RefreshCached = 1uL << 4,
		ContinueInBackground = 1uL << 5,
		HandleCookies = 1uL << 6
	}
}