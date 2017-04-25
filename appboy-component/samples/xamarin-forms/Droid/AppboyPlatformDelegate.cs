using System;
using Com.Appboy;
using Com.Appboy.Models;
using Com.Appboy.UI;
using Com.Appboy.UI.Inappmessage;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.Dependency (typeof (TestAppXamarinForms.Droid.AppboyPlatformDelegate))]
namespace TestAppXamarinForms.Droid
{
  public class AppboyPlatformDelegate :  Java.Lang.Object, IAppboyPlatformDelegate
  {
    public AppboyPlatformDelegate ()
    {
    }
    public void LogCustomEvent(String eventName) {
      Com.Appboy.Appboy.GetInstance (Xamarin.Forms.Forms.Context).LogCustomEvent (eventName);
    }

    public void ShowSlideupIam ()
    {
      InAppMessageSlideup slideup = new InAppMessageSlideup () {
        Message = "This is a slideup",
      };
      AppboyInAppMessageManager.Instance.AddInAppMessage (slideup);
    }

    public void ShowModalIam ()
    {
      InAppMessageModal modal = new InAppMessageModal () {
        Message = "This is a modal",
      };
      AppboyInAppMessageManager.Instance.AddInAppMessage (modal);
    }

    public void ShowFullIam ()
    {
      InAppMessageFull full = new InAppMessageFull () {
        Message = "This is a full"
      };
      AppboyInAppMessageManager.Instance.AddInAppMessage (full);
    }
  }
}

