namespace BrazeiOSMauiSampleApp;

using Foundation;
using UIKit;
using BrazeKit;
using BrazeUI;
using CoreFoundation;

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
        var SDKEnabledStateLabel = new Label
        {
            HorizontalTextAlignment = TextAlignment.Center,
        };
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
                SDKEnabledStateLabel,
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
                    Text = "In-App Message",
                    Command = new Command(ShowInAppMessage),
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
        UpdateSDKEnabledStateLabel();
        UpdateUserIDLabel();

        void ChangeUser()
        {
            string userId = "xam-" + (new Random().Next() % 1001);
            App.braze?.ChangeUser(userId);
            Console.WriteLine("→ Change user to: " + userId);
            UpdateUserIDLabel();
        }

        void SetUserProperties()
        {
            App.braze?.User.SetCountry("USA");
            App.braze?.User.SetDateOfBirth(NSDate.Now);
            App.braze?.User.SetEmail("test@braze.com");
            App.braze?.User.SetFirstName("Brian");
            App.braze?.User.SetLastName("Tester");
            App.braze?.User.SetHomeCity("Belmar");
            App.braze?.User.SetPhoneNumber("5555555555");
            App.braze?.User.SetCustomAttributeWithKey("customAttributeKey", true);
            App.braze?.User.SetEmailSubscriptionState(BRZUserSubscriptionState.OptedIn);
            App.braze?.User.SetGender(BRZUserGender.Male);
            App.braze?.User.SetAttributionData(new BRZUserAttributionData("a", "b", "c", "d"));
            App.braze?.User.AddToSubscriptionGroupWithGroupId("group-id-here");
            App.braze?.User.RemoveFromSubscriptionGroupWithGroupId("another-group-id");
        }

        void LogEventsAndPurchases()
        {
            App.braze?.LogCustomEvent("custom-event");
            App.braze?.LogPurchase("product-id", "USD", 1);
        }

        void ShowContentCards()
        {
            Console.WriteLine("→ Present Content Cards");
            if (App.braze != null)
            {
                BRZContentCardUIModalViewController contentCards = new BRZContentCardUIModalViewController(App.braze);
                PresentViewController(contentCards);
            }
        }

        void ShowInAppMessage()
        {
            Console.WriteLine("→ Show In-App Message");
            BRZInAppMessageRaw slideup = new BRZInAppMessageRaw();
            slideup.Type = BRZInAppMessageRawType.Slideup;
            slideup.Message = "This is the message";
            slideup.ClickAction = BRZInAppMessageRawClickAction.Url;
            slideup.Url = new NSUrl("http://braze.com");
            App.inAppMessageUI?.PresentMessage(slideup);
        }

        void FlushData()
        {
            Console.WriteLine("→ Flush data");
            App.braze?.RequestImmediateDataFlush();
        }

        void WipeData()
        {
            Console.WriteLine("→ Wipe data");
            App.braze?.WipeData();
            UpdateSDKEnabledStateLabel();
            UpdateUserIDLabel(true);
        }

        void EnableSDK()
        {
            Console.WriteLine("→ Enable SDK");
            if (App.braze != null)
            {
                App.braze.Enabled = true;
                UpdateSDKEnabledStateLabel();
                UpdateUserIDLabel();
            }
        }

        void DisableSDK()
        {
            Console.WriteLine("→ Disable SDK");
            if (App.braze != null)
            {
                App.braze.Enabled = false;
                UpdateSDKEnabledStateLabel();
            }
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

        void UpdateSDKEnabledStateLabel()
        {
            SDKEnabledStateLabel.Text = App.braze?.Enabled == true ? "SDK Enabled" : "SDK Disabled";
            SDKEnabledStateLabel.TextColor = App.braze?.Enabled == true ? Colors.Green : Colors.Red;
        }

        void UpdateUserIDLabel(bool reset = false)
        {
            if (reset)
            {
                UserIDLabel.Text = "User ID: <none>";
                return;
            }
            App.braze?.User.IdOnQueue(DispatchQueue.MainQueue, (userID) => {
                if (userID != null)
                {
                    UserIDLabel.Text = "User ID: " + userID;
                } else
                {
                    UserIDLabel.Text = "User ID: <none>";
                }
                
            });
        }

    }
}
