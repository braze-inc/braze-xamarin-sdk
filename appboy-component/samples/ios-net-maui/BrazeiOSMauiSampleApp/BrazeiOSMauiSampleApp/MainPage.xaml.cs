using Foundation;
using Braze;
using UIKit;
using UserNotifications;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;

namespace BrazeiOSMauiSampleApp;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class MainPage : ContentPage
{
    private UserNotificationsDelegate notificationsDelegate = new UserNotificationsDelegate();

    public MainPage()
    {
        InitializeComponent();
        setUpViews();
        Console.WriteLine("Launched BrazeiOSMauiSampleApp.");

        // Currently passing in `null` as launchOptions bc we don't have direct access here
        Appboy.StartWithApiKey("30291861-a7a0-4ad9-9d45-212353cbdac1", UIApplication.SharedApplication, null, new NSDictionary(
            Constants.ABKEndpointKey, @"sondheim.braze.com",
            Constants.ABKEnableAutomaticLocationCollectionKey, false,
            Constants.ABKMinimumTriggerTimeIntervalKey, 4,
            Constants.ABKEnableSDKAuthenticationKey, true,
            Constants.ABKLogLevelKey, 0
        ));

        if (Appboy.SharedInstance != null)
        {
            Console.WriteLine("Initialized Braze SDK ✅");
            Appboy.SharedInstance.SdkFlavor = ABKSDKFlavor.Xamarin;
            Appboy.SharedInstance.AddSdkMetadata(new[] { Constants.ABKSdkMetadataXamarin.ToString() });
        }
        else
        {
            Console.WriteLine("🛑 Unable to inialize Braze SDK!");
        }

        // Push Notifications support
        UNUserNotificationCenter.Current.RequestAuthorization(UNAuthorizationOptions.Alert | UNAuthorizationOptions.Badge | UNAuthorizationOptions.Sound | UNAuthorizationOptions.Provisional, (approved, err) =>
        {
            Appboy.SharedInstance?.PushAuthorizationFromUserNotificationCenter(approved);
        });
        UNUserNotificationCenter.Current.Delegate = notificationsDelegate;
        UIApplication.SharedApplication.RegisterForRemoteNotifications();
    }

    void setUpViews()
    {
        StackLayout stackLayout = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            Spacing = 10,
            Children = {
                    new Label
                    {
                        Text = "Braze .NET MAUI sample app!",
                        TextColor = Colors.Black,
                        HorizontalTextAlignment = TextAlignment.Center,
                    },
                    new Button
                    {
                        Text = "Change user",
                        Command = new Command(ChangeUser),
                    },
                    new Button
                    {
                        Text = "Trigger IAM via custom event",
                        Command = new Command(TriggerIAM),
                    },
                    new Button
                    {
                        Text = "Perform preset actions",
                        Command = new Command(PerformPresetActions),
                    },
                    new Button
                    {
                        Text = "News Feed",
                        Command = new Command(ShowNewsFeed),
                    },
                    new Button
                    {
                        Text = "Content Cards",
                        Command = new Command(ShowContentCards),
                    },
                    new Button
                    {
                        Text = "Flush data",
                        Command = new Command(FlushData),
                    },
                    new Button
                    {
                        Text = "Wipe data",
                        Command = new Command(WipeData),
                    },
                    new Button
                    {
                        Text = "Enable SDK",
                        Command = new Command(EnableSDK),
                    },
                    new Button
                    {
                        Text = "Disable SDK",
                        Command = new Command(DisableSDK),
                    },
                }
        };
        Content = stackLayout;

        // Enable the navigation bar
        NavigationPage.SetHasNavigationBar(this, true);

        void ChangeUser()
        {
            // Create random suffix
            Random random = new Random();
            string randomSuffix = new string(Enumerable.Range(1, 5)
                .Select(_ => random.Next(10).ToString()[0])
                .ToArray());
            string userId = "ios-qa-" + randomSuffix;

            Appboy.SharedInstance?.ChangeUser(userId);
            Console.WriteLine("→ Change user to: " + userId);
        }

        void TriggerIAM()
        {
            // Log custom event `ios-qa-iam-*` with `*` being a number 1-33
            Random random = new Random();
            string eventName = "ios-qa-iam-" + random.Next(1, 33);

            Appboy.SharedInstance?.LogCustomEvent(eventName);
            Console.WriteLine("→ Logged custom event: " + eventName);
        }

        void PerformPresetActions()
        {
            Console.WriteLine("→ Performing preset actions");

            SampleSDKAuthenticationDelegate sdkAuthDelegate = new SampleSDKAuthenticationDelegate();
            Console.WriteLine("Setting SDKAuthDelegate: " + sdkAuthDelegate);
            Appboy.SharedInstance!.SdkAuthenticationDelegate = sdkAuthDelegate;

            // User Attributes
            Appboy.SharedInstance.User.Country = "USA";
            Appboy.SharedInstance.User.DateOfBirth = NSDate.Now;
            Appboy.SharedInstance.User.Email = "test@appboy.com";
            Appboy.SharedInstance.User.FirstName = "Brian";
            Appboy.SharedInstance.User.HomeCity = "Belmar";
            Appboy.SharedInstance.User.LastName = "Tester";
            Appboy.SharedInstance.User.Phone = "5555555555";
            Appboy.SharedInstance.User.SetCustomAttributeWithKey("customAttributeKey", true);
            Appboy.SharedInstance.User.SetEmailNotificationSubscriptionType(ABKNotificationSubscriptionType.OptedIn);
            Appboy.SharedInstance.User.AddToSubscriptionGroupWithGroupId("sampleGroup1");
            Appboy.SharedInstance.User.RemoveFromSubscriptionGroupWithGroupId("sampleGroup2");
            Appboy.SharedInstance.User.SetGender(ABKUserGenderType.Male);
            Appboy.SharedInstance.User.AttributionData = new ABKAttributionData("n1", "c1", "a1", "cr1");

            Appboy.SharedInstance?.LogCustomEvent("myCustomEvent");
            Appboy.SharedInstance?.LogPurchase("myProduct", "USD", new NSDecimalNumber("10"));
        }

        void PushViewController(UIViewController viewController)
        {
            var windowScene = UIApplication.SharedApplication.ConnectedScenes
                .OfType<UIWindowScene>()
                .FirstOrDefault();

            if (windowScene != null)
            {
                var window = windowScene.Windows.FirstOrDefault();
                var rootViewController = window?.RootViewController;
                if (rootViewController != null)
                {
                    UINavigationController navigationController = new UINavigationController(rootViewController: viewController);
                    navigationController.NavigationBar.BackgroundColor = UIColor.SystemBackground;
                    rootViewController.PresentViewController(navigationController, true, null);
                }
            }
            else
            {
                Console.WriteLine("→ Null windowScene");
            }
        }

        void ShowNewsFeed()
        {
            Console.WriteLine("→ Present News Feed");
            ABKNewsFeedTableViewController feed = ABKNewsFeedTableViewController.GetNavigationFeedViewController();
            PushViewController(feed);
        }

        void ShowContentCards()
        {
            Console.WriteLine("→ Present Content Cards");
            ABKContentCardsTableViewController contentCards = ABKContentCardsTableViewController.GetNavigationContentCardsViewController();
            contentCards.Title = "Content Cards";
            PushViewController(contentCards);
        }

        void FlushData()
        {
            Console.WriteLine("→ Flush data");
            Appboy.SharedInstance?.RequestImmediateDataFlush();
        }

        void WipeData()
        {
            Console.WriteLine("→ Wipe data");
            Appboy.WipeDataAndDisableForAppRun();
        }

        void EnableSDK()
        {
            Console.WriteLine("→ Enable SDK");
            Appboy.RequestEnableSDKOnNextAppRun();
        }

        void DisableSDK()
        {
            Console.WriteLine("→ Disable SDK");
            Appboy.DisableSDK();
        }
    }
}

class UserNotificationsDelegate : UNUserNotificationCenterDelegate
{
    public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler)
    {
        Appboy.SharedInstance?.UserNotificationCenter(center, response, completionHandler);
    }
}

class SampleSDKAuthenticationDelegate : ABKSdkAuthenticationDelegate
{
    public override void HandleSdkAuthenticationError(ABKSdkAuthenticationError authError)
    {
        Console.WriteLine("Invalid SDK Authentication signature. Executing `HandleSdkAuthenticationError` with error: " + authError);
        String newSignature = "NEW_SDK_AUTH_SIGNATURE_FOR_USER_" + Appboy.SharedInstance?.User.UserID;
        Appboy.SharedInstance?.SetSdkAuthenticationSignature(newSignature);
    }
}
