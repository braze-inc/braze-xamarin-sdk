using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;
using AppboyPlatformXamariniOSBinding;
using UserNotifications;

namespace TestApp.XamariniOS
{
  [Register("AppDelegate")]
  public partial class AppDelegate : UIApplicationDelegate
  {

    public static UIStoryboard Storyboard = UIStoryboard.FromName("MainStoryboard", null);
    public static UIViewController initialViewController;
    private UserNotificationsDelegate notificationsDelegate;

    public override UIWindow Window {
      get;
      set;
    }

    public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler) 
    {
      Appboy.SharedInstance?.RegisterApplicationWithFetchCompletionHandler(application, userInfo, completionHandler);
    }

    //
    // You have 17 seconds to return from this method, or iOS will terminate your application.
    //
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
      // create a new window instance based on the screen size
      Window = new UIWindow(UIScreen.MainScreen.Bounds);

      initialViewController = Storyboard.InstantiateInitialViewController() as UIViewController;
      Window.RootViewController = initialViewController;

      // make the window visible
      Window.MakeKeyAndVisible();

      // Start Appboy
      Appboy.StartWithApiKey("09aa7156-9aef-4043-acfa-424d0dbc3d80", UIApplication.SharedApplication, options);
      if (Appboy.SharedInstance != null) {
      Appboy.SharedInstance.SdkFlavor = ABKSDKFlavor.Xamarin;
      }

      if (UIDevice.CurrentDevice.CheckSystemVersion(10, 0))
      {
        UNUserNotificationCenter.Current.RequestAuthorization(UNAuthorizationOptions.Alert | UNAuthorizationOptions.Badge | UNAuthorizationOptions.Sound | UNAuthorizationOptions.Provisional, (approved, err) =>
        {
          if (approved) {
            Console.WriteLine("Permission granted");
            Appboy.SharedInstance.PushAuthorizationFromUserNotificationCenter(approved);
          }
        });

        notificationsDelegate = new UserNotificationsDelegate();
        UNUserNotificationCenter.Current.Delegate = notificationsDelegate;
        UIApplication.SharedApplication.RegisterForRemoteNotifications();
      }
      else
      {
        // Settings for Appboy push
        UIUserNotificationSettings settings = UIUserNotificationSettings.GetSettingsForTypes(UIUserNotificationType.Badge | UIUserNotificationType.Alert | UIUserNotificationType.Sound, null);
        UIApplication.SharedApplication.RegisterForRemoteNotifications();
        UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);
      }
 
      return true;
    }
    
    public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
    {
      Console.WriteLine("Registered For Remote Notifications");
      Appboy.SharedInstance?.RegisterPushToken(deviceToken.ToString());
    }

    private class UserNotificationsDelegate : UNUserNotificationCenterDelegate
    {
      public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler)
      {
        Appboy.SharedInstance?.UserNotificationCenter(center, response, completionHandler);
      }
    }
  }
}

