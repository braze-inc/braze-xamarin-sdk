using System;
using AVFoundation;
using AppboyPlatformXamariniOSBinding;
using UIKit;

[assembly: Xamarin.Forms.Dependency (typeof (TestAppXamarinForms.iOS.AppboyPlatformDelegate))]
namespace TestAppXamarinForms.iOS
{
  public class AppboyPlatformDelegate : IAppboyPlatformDelegate
  {
    public AppboyPlatformDelegate ()
    {
    }
    public void LogCustomEvent(String eventName) {
      Appboy.SharedInstance.LogCustomEvent (eventName);
    }
  }
}

