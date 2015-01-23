using System;
using System.Drawing;

using Foundation;
using UIKit;
using AppboyPlatformXamariniOSBinding;

namespace TestApp.XamariniOS
{
  public partial class AppboySampleViewController : UIViewController
  {
    public AppboySampleViewController (IntPtr handle) : base (handle)
    {
    }

    public override void DidReceiveMemoryWarning ()
    {
      // Releases the view if it doesn't have a superview.
      base.DidReceiveMemoryWarning ();
    }

    public override void ViewDidLoad ()
    {
      base.ViewDidLoad ();
      ChangeUserButton.TouchUpInside += ChangeUserButtonHandler;
      UserPropertyButton.TouchUpInside += UserPropertyButtonHandler;
      EventsAndPurchasesButton.TouchUpInside += EventsAndPurchasesButtonHandler;
      AddSlideupButton.TouchUpInside += AddSlideupButtonHandler;
    }
      
    private void ChangeUserButtonHandler (object sender, EventArgs e)
    {
      Appboy.SharedInstance().ChangeUser("myUserId" + new Random().Next(1,10000));
    }

    private void UserPropertyButtonHandler (object sender, EventArgs e)
    {
      Appboy.SharedInstance ().User.Bio = "My bio";
      Appboy.SharedInstance ().User.Country = "USA";
      Appboy.SharedInstance ().User.DateOfBirth = NSDate.Now;
      Appboy.SharedInstance ().User.Email = "test@appboy.com";
      Appboy.SharedInstance ().User.FirstName = "Brian";
      Appboy.SharedInstance ().User.HomeCity = "Belmar";
      Appboy.SharedInstance ().User.LastName = "Tester";
      Appboy.SharedInstance ().User.Phone = "5555555555";
      Appboy.SharedInstance ().User.SetCustomAttributeWithKey ("customAttributeKey", true);
      Appboy.SharedInstance ().User.SetEmailNotificationSubscriptionType (ABKNotificationSubscriptionType.ABKOptedIn);
      Appboy.SharedInstance ().User.SetGender (ABKUserGenderType.Male);
    }

    private void EventsAndPurchasesButtonHandler (object sender, EventArgs e)
    {
      Appboy.SharedInstance ().LogCustomEvent ("myCustomEvent");
      Appboy.SharedInstance ().LogPurchase ("myProduct", "USD", new NSDecimalNumber("10"));
      Appboy.SharedInstance ().LogSocialShare (ABKSocialNetwork.Facebook);
    }

    private void AddSlideupButtonHandler (object sender, EventArgs e)
    {
      Appboy.SharedInstance ().SlideupController.Delegate = new SampleSlideupDelegate ();
      ABKSlideup slideup = new ABKSlideup () {
        Message = "This is a slideup",
        Duration = 10
      };
      Appboy.SharedInstance ().SlideupController.AddSlideup (slideup);  
    }
  }

  // To add your own delegate, extend and override ABKSlideupControllerDelegate
  class SampleSlideupDelegate :  ABKSlideupControllerDelegate {
    public override bool OnSlideupClicked (ABKSlideup slideup) {
      Console.WriteLine ("Slideup Clicked");
      return false;
    }
  }
}

