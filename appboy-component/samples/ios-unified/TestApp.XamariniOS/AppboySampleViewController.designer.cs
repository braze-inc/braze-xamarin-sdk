// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TestApp.XamariniOS
{
	[Register ("AppboySampleViewController")]
	partial class AppboySampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton AddFullButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton AddModalButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton AddSlideupButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton ChangeUserButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel ChangeUserLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton ContentCardsButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton EventsAndPurchasesButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton NewsFeedButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton UserPropertyButton { get; set; }

		[Action ("AddFullButton_TouchUpInside:")]
		partial void AddFullButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("AddModalButton_TouchUpInside:")]
		partial void AddModalButton_TouchUpInside (UIKit.UIButton sender);

		[Action ("ChangeSDKAuthSignature_TouchUpInside:")]
		partial void ChangeSDKAuthSignature_TouchUpInside (UIKit.UIButton sender);

		[Action ("DisableSDK_TouchUpInside:")]
		partial void DisableSDK_TouchUpInside (UIKit.UIButton sender);

		[Action ("EnableSDK_TouchUpInside:")]
		partial void EnableSDK_TouchUpInside (UIKit.UIButton sender);

		[Action ("FlushData_TouchUpInside:")]
		partial void FlushData_TouchUpInside (UIKit.UIButton sender);

		[Action ("WipeData_TouchUpInside:")]
		partial void WipeData_TouchUpInside (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AddFullButton != null) {
				AddFullButton.Dispose ();
				AddFullButton = null;
			}

			if (AddModalButton != null) {
				AddModalButton.Dispose ();
				AddModalButton = null;
			}

			if (AddSlideupButton != null) {
				AddSlideupButton.Dispose ();
				AddSlideupButton = null;
			}

			if (ChangeUserButton != null) {
				ChangeUserButton.Dispose ();
				ChangeUserButton = null;
			}

			if (ChangeUserLabel != null) {
				ChangeUserLabel.Dispose ();
				ChangeUserLabel = null;
			}

			if (ContentCardsButton != null) {
				ContentCardsButton.Dispose ();
				ContentCardsButton = null;
			}

			if (EventsAndPurchasesButton != null) {
				EventsAndPurchasesButton.Dispose ();
				EventsAndPurchasesButton = null;
			}

			if (NewsFeedButton != null) {
				NewsFeedButton.Dispose ();
				NewsFeedButton = null;
			}

			if (UserPropertyButton != null) {
				UserPropertyButton.Dispose ();
				UserPropertyButton = null;
			}
		}
	}
}
