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
        var userIdEntry = new Entry
        {
            Placeholder = "User ID",
            HorizontalTextAlignment = TextAlignment.Center,
            TextColor = Colors.Black,
            Keyboard = Keyboard.Create(KeyboardFlags.None),
            IsTextPredictionEnabled = false,
            TextTransform = TextTransform.None
        };
        var customEventEntry = new Entry
        {
            Placeholder = "Custom event",
            HorizontalTextAlignment = TextAlignment.Center,
            TextColor = Colors.Black,
            Keyboard = Keyboard.Create(KeyboardFlags.None),
            IsTextPredictionEnabled = false,
            TextTransform = TextTransform.None
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
                userIdEntry,
                new Button
                {
                    Text = "Change user",
                    Command = new Command(ChangeUser),
                },
                customEventEntry,
                new Button
                {
                    Text = "Log custom event",
                    Command = new Command(LogCustomEvent),
                },
                new Button
                {
                    Text = "Set user properties",
                    Command = new Command(SetUserProperties),
                },
                new Button
                {
                    Text = "Log preset events and purchases",
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
        UpdateSDKEnabledStateLabel();
        UpdateUserIDLabel();

        // - Button actions

        void ChangeUser()
        {
            var userId = userIdEntry.Text?.Trim();
            if (!string.IsNullOrEmpty(userId))
            {
                App.braze?.ChangeUser(userId);
                Console.WriteLine("→ Change user to: " + userId);
                UpdateUserIDLabel();
            }
        }

        void LogCustomEvent()
        {
            var eventName = customEventEntry.Text?.Trim();
            if (!string.IsNullOrEmpty(eventName))
            {
                App.braze?.LogCustomEvent(eventName);
                Console.WriteLine($"→ Logged custom event: {eventName}");
            }
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
            var userId = App.braze?.User.Identifier;
            if (userId == null || reset)
            {
                userId = "<none>";
            }
            UserIDLabel.Text = "User ID: " + userId;
        }

    }
}
