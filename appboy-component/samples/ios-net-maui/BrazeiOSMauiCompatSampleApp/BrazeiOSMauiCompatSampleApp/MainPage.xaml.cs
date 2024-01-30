namespace BrazeiOSMauiCompatSampleApp;

using Foundation;
using UIKit;
using BrazeKitCompat;
using BrazeUICompat;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SetUpViews();
    }

    void SetUpViews()
    {
        var UserIDLabel = new Label
        {
            TextColor = Colors.Black,
            HorizontalTextAlignment = TextAlignment.Center,
        };

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
                UserIDLabel,
                new Button
                {
                    Text = "Change user",
                    Command = new Command(ChangeUser),
                },
                new Button
                {
                    Text = "Set user properties",
                    Command = new Command(SetUserProperties),
                },
                new Button
                {
                    Text = "Log events and purchases",
                    Command = new Command(LogEventsAndPurchases),
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

        // Update labels
        UpdateUserIDLabel();

        void ChangeUser()
        {
            string userId = "xam-" + (new Random().Next() % 1001);
            Appboy.SharedInstance.ChangeUser(userId);

            UpdateUserIDLabel();
        }

        void SetUserProperties()
        {
            Appboy.SharedInstance.User.Country = "USA";
            Appboy.SharedInstance.User.DateOfBirth = NSDate.Now;
            Appboy.SharedInstance.User.Email = "test@braze.com";
            Appboy.SharedInstance.User.FirstName = "Brian";
            Appboy.SharedInstance.User.LastName = "Tester";
            Appboy.SharedInstance.User.HomeCity = "Belmar";
            Appboy.SharedInstance.User.Phone = "5555555555";
            Appboy.SharedInstance.User.SetCustomAttributeWithKey("customAttributeKey", true);
            Appboy.SharedInstance.User.SetEmailNotificationSubscriptionType(ABKNotificationSubscriptionType.ABKOptedIn);
            Appboy.SharedInstance.User.SetGender(ABKUserGenderType.Male);
            Appboy.SharedInstance.User.AttributionData = new ABKAttributionData("n1", "c1", "a1", "cr1");
            Appboy.SharedInstance.User.AddToSubscriptionGroupWithGroupId("group-id-here");
            Appboy.SharedInstance.User.RemoveFromSubscriptionGroupWithGroupId("another-group-id");
        }

        void LogEventsAndPurchases()
        {
            Appboy.SharedInstance.LogCustomEvent("custom-event");
            Appboy.SharedInstance.LogPurchase("product-id", "USD", new NSDecimalNumber("1"));
        }

        void ShowContentCards()
        {
            Console.WriteLine("→ Present Content Cards");
            ABKContentCardsViewController contentCards = new ABKContentCardsViewController();
            PresentViewController(contentCards);
        }

        void FlushData()
        {
            Console.WriteLine("→ Flush data");
            Appboy.SharedInstance.RequestImmediateDataFlush();
        }

        void WipeData()
        {
            Console.WriteLine("→ Wipe data");
            Appboy.WipeDataAndDisableForAppRun();
            UpdateUserIDLabel(true);
        }

        void EnableSDK()
        {
            Console.WriteLine("→ Enable SDK (restart app to re-enable Braze)");
            Appboy.RequestEnableSDKOnNextAppRun();
            UpdateUserIDLabel();
        }

        void DisableSDK()
        {
            Console.WriteLine("→ Disable SDK");
            Appboy.DisableSDK();
        }

        void PresentViewController(UIViewController viewController)
        {
            var KeyWindow = UIApplication.SharedApplication.KeyWindow;
            if (KeyWindow != null)
            {
                var rootViewController = KeyWindow.RootViewController;
                if (rootViewController != null)
                {
                    rootViewController.PresentViewController(viewController, true, null);
                }
            }
            else
            {
                Console.WriteLine("→ Null KeyWindow");
            }
        }

        void UpdateUserIDLabel(bool reset = false)
        {
            if (reset || Appboy.SharedInstance.User.UserID == null)
            {
                UserIDLabel.Text = "User ID: <none>";
            }
            else
            {
                UserIDLabel.Text = "User ID: " + Appboy.SharedInstance.User.UserID;
            }
        }

    }
}
