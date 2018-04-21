using System;
using System.Drawing;

using Foundation;
using UIKit;
using AppboyPlatformXamariniOSBinding;

namespace TestApp.XamariniOS
{
  public partial class AppboySampleViewController : UIViewController
  {
    public AppboySampleViewController(IntPtr handle) : base(handle)
    {
    }

    public override void DidReceiveMemoryWarning()
    {
      // Releases the view if it doesn't have a superview.
      base.DidReceiveMemoryWarning();
    }

    public override void ViewDidLoad()
    {
      base.ViewDidLoad();
      ChangeUserButton.TouchUpInside += ChangeUserButtonHandler;
      UserPropertyButton.TouchUpInside += UserPropertyButtonHandler;
      EventsAndPurchasesButton.TouchUpInside += EventsAndPurchasesButtonHandler;
      AddSlideupButton.TouchUpInside += AddSlideupButtonHandler;
      ChangeUserLabel.Text = "Current User: " + Appboy.SharedInstance?.User?.UserID;
    }
      
    private void ChangeUserButtonHandler(object sender, EventArgs e)
    {
      if (Appboy.SharedInstance != null)
      {
        String userId = "myUserId" + new Random().Next(1, 10000);
        Appboy.SharedInstance.ChangeUser(userId);
        ChangeUserLabel.Text = "Current User: " + userId;
      }
    }

    private void UserPropertyButtonHandler(object sender, EventArgs e)
    {
      if (Appboy.SharedInstance != null)
      {
        Appboy.SharedInstance.User.Country = "USA";
        Appboy.SharedInstance.User.DateOfBirth = NSDate.Now;
        Appboy.SharedInstance.User.Email = "test@appboy.com";
        Appboy.SharedInstance.User.FirstName = "Brian";
        Appboy.SharedInstance.User.HomeCity = "Belmar";
        Appboy.SharedInstance.User.LastName = "Tester";
        Appboy.SharedInstance.User.Phone = "5555555555";
        Appboy.SharedInstance.User.SetCustomAttributeWithKey("customAttributeKey", true);
        Appboy.SharedInstance.User.SetEmailNotificationSubscriptionType(ABKNotificationSubscriptionType.ABKOptedIn);
        Appboy.SharedInstance.User.SetGender(ABKUserGenderType.Male);
        Appboy.SharedInstance.User.AttributionData = new ABKAttributionData("n1", "c1", "a1", "cr1");
      }
    }

    private void EventsAndPurchasesButtonHandler(object sender, EventArgs e)
    {
      Appboy.SharedInstance?.LogCustomEvent("myCustomEvent");
      Appboy.SharedInstance?.LogPurchase("myProduct", "USD", new NSDecimalNumber("10"));
    }

    private void AddSlideupButtonHandler(object sender, EventArgs e)
    {
      if (Appboy.SharedInstance != null)
      {
        Appboy.SharedInstance.InAppMessageController.Delegate = new ABKInAppMessageControllerDelegate();
        ABKInAppMessageSlideup slideup = new ABKInAppMessageSlideup()
        {
          Message = "This is a slideup",
          Duration = 10
        };
        Appboy.SharedInstance.InAppMessageController.AddInAppMessage(slideup);
      }
    }
      
    partial void AddModalButton_TouchUpInside(UIButton sender)
    {
      if (Appboy.SharedInstance != null)
      {
        Appboy.SharedInstance.InAppMessageController.Delegate = new ABKInAppMessageControllerDelegate();
        ABKInAppMessageModal modal = new ABKInAppMessageModal()
        {
          Message = "This is a modal",
          Duration = 10
        };
        Appboy.SharedInstance.InAppMessageController.AddInAppMessage(modal);
      }
    }

    partial void AddFullButton_TouchUpInside(UIButton sender)
    {
      if (Appboy.SharedInstance != null)
      {
        Appboy.SharedInstance.InAppMessageController.Delegate = new ABKInAppMessageControllerDelegate();
        ABKInAppMessageFull full = new ABKInAppMessageFull()
        {
          Message = "This is a full",
          Duration = 10,
          ImageURI = new NSUrl("https://raw.githubusercontent.com/Appboy/appboy-xamarin-bindings/master/braze-logo.png")
        };
        Appboy.SharedInstance.InAppMessageController.AddInAppMessage(full);
      }
    }

    partial void WipeData_TouchUpInside(UIButton sender)
    {
      Appboy.WipeDataAndDisableForAppRun();
    }

    partial void EnableSDK_TouchUpInside(UIButton sender)
    {
      Appboy.RequestEnableSDKOnNextAppRun();
    }

    partial void DisableSDK_TouchUpInside(UIButton sender)
    {
      Appboy.DisableSDK();
    }
  }

  // To add your own delegate, extend and override ABKSlideupControllerDelegate
  class SampleInAppMessageDelegate :  ABKInAppMessageControllerDelegate {
    public override ABKInAppMessageDisplayChoice BeforeInAppMessageDisplayed(ABKInAppMessage inAppMessage) {
      Console.WriteLine("Before IAM Displayed");
      return ABKInAppMessageDisplayChoice.displayInAppMessageNow;
    }
  }
}
