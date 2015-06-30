using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using AppboyPlatformXamariniOSBinding;

namespace TestAppXamarinForms.iOS
{
  [Register ("AppDelegate")]
  public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
  {
    public override bool FinishedLaunching (UIApplication app, NSDictionary options)
    {
      global::Xamarin.Forms.Forms.Init ();

      // Code for starting up the Xamarin Test Cloud Agent
      #if ENABLE_TEST_CLOUD
      Xamarin.Calabash.Start();
      #endif

      LoadApplication (new App ());

      // Start Appboy
      Appboy.StartWithApiKey ("5546dc47-fcd3-4245-85d6-963a1dd6c373", UIApplication.SharedApplication, options);

      return base.FinishedLaunching (app, options);
    }
  }
}

