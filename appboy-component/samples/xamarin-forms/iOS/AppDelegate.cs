using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using AppboyPlatformXamariniOSBinding;

namespace TestAppXamarinForms.iOS
{
  [Register("AppDelegate")]
  public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
  {
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
      global::Xamarin.Forms.Forms.Init();

      // Code for starting up the Xamarin Test Cloud Agent
      #if ENABLE_TEST_CLOUD
      Xamarin.Calabash.Start();
      #endif

      LoadApplication(new App());

      // Start Appboy
      Appboy.StartWithApiKey("09aa7156-9aef-4043-acfa-424d0dbc3d80", UIApplication.SharedApplication, options);
      Appboy.SharedInstance.SdkFlavor = ABKSDKFlavor.Xamarin;

      // Subscribe to notification 
      NSNotificationCenter.DefaultCenter.AddObserver(ABKFeedController.ABKFeedUpdatedNotification, OnFeedUpdated);

      return base.FinishedLaunching(app, options);
    }

    void OnFeedUpdated(NSNotification notification)
    {
      Console.WriteLine("ABKFeedUpdatedNotification was posted");
    }
  }
}

