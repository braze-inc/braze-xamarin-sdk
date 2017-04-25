using System;
using AVFoundation;
using AppboyPlatformXamariniOSBinding;
using UIKit;

[assembly: Xamarin.Forms.Dependency (typeof (TestAppXamarinForms.iOS.AppboyPlatformDelegate))]
namespace TestAppXamarinForms.iOS
{
  public class AppboyPlatformDelegate : IAppboyPlatformDelegate
  {
    public AppboyPlatformDelegate()
    {
    }

    public void LogCustomEvent(String eventName) {
      Appboy.SharedInstance.LogCustomEvent(eventName);
    }

    public void ShowSlideupIam()
    {
      Appboy.SharedInstance.InAppMessageController.Delegate = new ABKInAppMessageControllerDelegate();
      ABKInAppMessageSlideup slideup = new ABKInAppMessageSlideup() {
        Message = "This is a slideup",
        Duration = 10
      };
      Appboy.SharedInstance.InAppMessageController.AddInAppMessage(slideup);
    }

    public void ShowModalIam ()
    {
      Appboy.SharedInstance.InAppMessageController.Delegate = new ABKInAppMessageControllerDelegate();
      ABKInAppMessageModal modal = new ABKInAppMessageModal() {
        Message = "This is a modal",
        Duration = 10
      };
      Appboy.SharedInstance.InAppMessageController.AddInAppMessage(modal);
    }

    public void ShowFullIam()
    {
      Appboy.SharedInstance.InAppMessageController.Delegate = new ABKInAppMessageControllerDelegate();
      ABKInAppMessageFull full = new ABKInAppMessageFull() {
        Message = "This is a full",
        Duration = 10,
        ImageURI = new Foundation.NSUrl("https://raw.githubusercontent.com/Appboy/appboy-xamarin-bindings/master/Appboy_Logo_400x100.png")
      };
      Appboy.SharedInstance.InAppMessageController.AddInAppMessage(full);
    }
  }
}
