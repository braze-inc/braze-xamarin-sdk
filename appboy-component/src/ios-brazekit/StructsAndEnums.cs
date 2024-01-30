using ObjCRuntime;

namespace BrazeKit
{
	[Native]
	public enum BRZContentCardRawType : long
	{
		Classic = 0,
		ImageOnly = 1,
		CaptionedImage = 2,
		Control = 3
	}

	[Native]
	public enum BRZInAppMessageRawType : long
	{
		Slideup = 0,
		Modal = 1,
		Full = 2,
		HtmlFull = 3,
		Html = 4
	}

	[Native]
	public enum BRZInAppMessageRawClickAction : long
	{
		None = 0,
		NewsFeed = 1,
		Url = 2
	}

	[Native]
	public enum BRZInAppMessageRawClose : long
	{
		AutoDismiss = 0,
		Swipe = 1
	}

	[Native]
	public enum BRZInAppMessageRawOrientation : long
	{
		Any = 0,
		Portrait = 1,
		Landscape = 2
	}

	[Native]
	public enum BRZInAppMessageRawTextAlignment : long
	{
		Start = 0,
		Center = 1,
		End = 2
	}

	[Native]
	public enum BRZInAppMessageRawImageStyle : long
	{
		Graphic = 0,
		Top = 1
	}

	[Native]
	public enum BRZInAppMessageRawSlideFrom : long
	{
		Top = 0,
		Bottom = 1
	}

	public enum BRZLoggerLevel : byte
	{
		Debug = 0,
		Info = 1,
		Error = 2,
		Disabled = 255
	}

	[Native]
	public enum BRZNewsFeedCardType : long
	{
		Classic = 0,
		Banner = 1,
		CaptionedImage = 2,
		TextAnnouncement = 3
	}

	[Native]
	public enum _COMPAT_ABKRequestProcessingPolicy : long
	{
		ManualRequestProcessing = 0,
		AutomaticRequestProcessing = 1
	}

	[Native]
	public enum _COMPAT_ABKSDKFlavor : long
	{
		Vanilla = 0,
		Unity = 1,
		React = 2,
		Cordova = 3,
		Xamarin = 4,
		Flutter = 5,
		Segment = 6,
		Mparticle = 7,
		Tealium = 8
	}

	[Native]
	public enum BRZChannel : long
	{
		Notification = 0,
		InAppMessage = 1,
		NewsFeed = 2,
		ContentCard = 3
	}

	[Native]
	public enum BRZRequestPolicy : long
	{
		Automatic = 0,
		Manual = 1
	}

	[Native]
	public enum BRZSDKFlavor : long
	{
		Vanilla = 0,
		Unity = 1,
		React = 2,
		Cordova = 3,
		Xamarin = 4,
		Flutter = 5,
		Segment = 6,
		Mparticle = 7,
		Tealium = 8
	}

	[Native]
	public enum BRZUserSubscriptionState : long
	{
		OptedIn = 0,
		Subscribed = 1,
		Unsubscribed = 2
	}

	[Native]
	public enum BRZTriggerEvent : long
	{
		SessionStart = 0,
		CustomEvent = 1,
		Purchase = 2,
		Other = 3
	}
}
