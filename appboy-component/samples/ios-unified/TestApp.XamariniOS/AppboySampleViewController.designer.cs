// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TestApp.XamariniOS
{
	[Register ("AppboySampleViewController")]
	partial class AppboySampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton AddSlideupButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ChangeUserButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton EventsAndPurchasesButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton NewsFeedButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SubmitFeedbackButton1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton UserPropertyButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AddSlideupButton != null) {
				AddSlideupButton.Dispose ();
				AddSlideupButton = null;
			}
			if (ChangeUserButton != null) {
				ChangeUserButton.Dispose ();
				ChangeUserButton = null;
			}
			if (EventsAndPurchasesButton != null) {
				EventsAndPurchasesButton.Dispose ();
				EventsAndPurchasesButton = null;
			}
			if (NewsFeedButton != null) {
				NewsFeedButton.Dispose ();
				NewsFeedButton = null;
			}
			if (SubmitFeedbackButton1 != null) {
				SubmitFeedbackButton1.Dispose ();
				SubmitFeedbackButton1 = null;
			}
			if (UserPropertyButton != null) {
				UserPropertyButton.Dispose ();
				UserPropertyButton = null;
			}
		}
	}
}
