using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;
using AppboyPlatformXamariniOSBinding;

namespace TestApp.XamariniOS
{
  [Register ("AppDelegate")]
  public partial class AppDelegate : UIApplicationDelegate
  {

    public static UIStoryboard Storyboard = UIStoryboard.FromName ("MainStoryboard", null);
    public static UIViewController initialViewController;

    public override UIWindow Window {
      get;
      set;
    }

  public override void DidReceiveRemoteNotification (UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler) 
  {
    Appboy.SharedInstance.RegisterApplicationWithFetchCompletionHandler(application, userInfo, completionHandler);
  }
   
    //
    // You have 17 seconds to return from this method, or iOS will terminate your application.
    //
    public override bool FinishedLaunching (UIApplication app, NSDictionary options)
    {
      // create a new window instance based on the screen size
      Window = new UIWindow (UIScreen.MainScreen.Bounds);

      initialViewController = Storyboard.InstantiateInitialViewController () as UIViewController;
      Window.RootViewController = initialViewController;

      // make the window visible
      Window.MakeKeyAndVisible ();
				
      // Start Appboy
      Appboy.StartWithApiKey ("5546dc47-fcd3-4245-85d6-963a1dd6c373", UIApplication.SharedApplication, options);

      // Settings for Appboy push
      UIUserNotificationSettings settings = UIUserNotificationSettings.GetSettingsForTypes (UIUserNotificationType.Badge | UIUserNotificationType.Alert | UIUserNotificationType.Sound, null);
      UIApplication.SharedApplication.RegisterForRemoteNotifications ();
      UIApplication.SharedApplication.RegisterUserNotificationSettings (settings);

      return true;
    }
      
    public override void RegisteredForRemoteNotifications (UIApplication application, NSData deviceToken)
    {
      Console.WriteLine ("Registered For Remote Notifications");
      Appboy.SharedInstance.RegisterPushToken (deviceToken.ToString ());
    }
  }
}

