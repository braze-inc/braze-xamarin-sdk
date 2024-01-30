using BrazeiOSMauiCompatSampleApp;
using Foundation;
using UIKit;
using UserNotifications;
using BrazeKitCompat;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    private ABKSdkAuthenticationDelegate sdkAuthenticationDelegate = null;
    private UNUserNotificationCenterDelegate notificationCenterDelegate = null;

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // - Braze (compat) / Appboy

        // create the Appboy configuration dictionary
        NSDictionary options = new NSDictionary(
            Constants.ABKLogLevelKey, 0,
            Constants.ABKMinimumTriggerTimeIntervalKey, 1,

            // - Location / Geofences support
            Constants.ABKEnableAutomaticLocationCollectionKey, true,
            Constants.ABKEnableGeofencesKey, true,
            Constants.ABKDisableAutomaticGeofenceRequestsKey, false,

            // - SDK Authentication support
            Constants.ABKEnableSDKAuthenticationKey, true,

            Constants.ABKEndpointKey, "sondheim.braze.com"
        );

        // start the Braze SDK (Appboy compatibility layer)
        Appboy.StartWithApiKey("35e33f03-e936-4891-9b83-fd0ef52fc861", application, launchOptions, options);

        // miscellaneous
        Appboy.SharedInstance.SdkFlavor = ABKSDKFlavor.Xamarin;
        Appboy.SharedInstance.AddSdkMetadata(new[] { ABKSdkMetadata.ABKSdkMetadataXamarin });

        // register the delegate for SDK authentication
        sdkAuthenticationDelegate = new SDKAuthenticationDelegate();
        Appboy.SharedInstance.SdkAuthenticationDelegate = sdkAuthenticationDelegate;

        // - Push support

        UNUserNotificationCenter center = UNUserNotificationCenter.Current;

        center.SetNotificationCategories(ABKPushUtils.AppboyUNNotificationCategorySet);

        notificationCenterDelegate = new UserNotificationCenterDelegate();
        center.Delegate = notificationCenterDelegate;

        application.RegisterForRemoteNotifications();

        center.RequestAuthorization(UNAuthorizationOptions.Alert | UNAuthorizationOptions.Sound | UNAuthorizationOptions.Badge, (granted, error) => {
            Console.WriteLine($"Notification authorization, granted: {granted}, error: {error?.ToString() ?? "None"}");
            Appboy.SharedInstance.PushAuthorizationFromUserNotificationCenter(granted);
        });


        return base.FinishedLaunching(application, launchOptions);
    }

    // - Push support

    [Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
    public void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
    {
        Console.WriteLine("Registered For Remote Notifications");
        Appboy.SharedInstance.RegisterDeviceToken(deviceToken);
    }

    [Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
    public void FailedToRegisterForRemoteNotifications(UIKit.UIApplication application, NSError error)
    {
        Console.WriteLine("FAILED Registered For Remote Notifications");
    }

    [Export("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
    public virtual void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
    {
        Appboy.SharedInstance.RegisterApplicationWithFetchCompletionHandler(application, userInfo, completionHandler);
    }

}

// - Push support (UserNotificationCenterDelegate)

class UserNotificationCenterDelegate : UNUserNotificationCenterDelegate
{
    public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler)
    {
        Appboy.SharedInstance.UserNotificationCenter(center, response, completionHandler);
    }

    public override void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler)
    {
        if (UIDevice.CurrentDevice.CheckSystemVersion(14, 0))
        {
            completionHandler(UNNotificationPresentationOptions.List | UNNotificationPresentationOptions.Banner);
        }
        else
        {
            completionHandler(UNNotificationPresentationOptions.Alert);
        }
    }
}

// - SDK Authentication Delegate

class SDKAuthenticationDelegate : ABKSdkAuthenticationDelegate
{
    public override void HandleSdkAuthenticationError(ABKSdkAuthenticationError authError)
    {
        Console.WriteLine("Invalid SDK Authentication signature.");
        String newSignature = "NEW_SDK_AUTH_SIGNATURE_FOR_USER_" + Appboy.SharedInstance.User.UserID;
        Appboy.SharedInstance.SetSdkAuthenticationSignature(newSignature);
    }
}
