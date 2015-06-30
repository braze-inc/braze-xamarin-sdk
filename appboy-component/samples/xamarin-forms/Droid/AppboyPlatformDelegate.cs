using System;
using Com.Appboy;
using Com.Appboy.UI;
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
  }
}

