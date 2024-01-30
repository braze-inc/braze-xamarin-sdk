namespace BrazeiOSMauiSampleApp;

using BrazeKit;
using BrazeLocation;
using BrazeUI;
using CoreFoundation;
using Foundation;
using SDWebImage;
using UIKit;

public partial class App : Application
{
    // Braze Properties
    public static Braze? braze = null;
    public static BrazeInAppMessageUI? inAppMessageUI = null;
    private BrazeSDKAuthDelegate? sdkAuthDelegate = null;

    public App()
	{
		InitializeComponent();
        SetupBraze();

        MainPage = new NavigationPage(new MainPage());
    }

    void SetupBraze()
    {
        // create the Braze configuration
        var configuration = new BRZConfiguration("35e33f03-e936-4891-9b83-fd0ef52fc861", "sondheim.braze.com");
        configuration.Logger.Level = BRZLoggerLevel.Debug;
        configuration.TriggerMinimumTimeInterval = 1.0;

        // - Location / Geofences support
        configuration.Location.BrazeLocationProvider = new BrazeLocationProvider();
        configuration.Location.AutomaticLocationCollection = true;
        configuration.Location.GeofencesEnabled = true;
        configuration.Location.AutomaticGeofenceRequests = true;

        // - Automatic push notifications support
        configuration.Push.Automation = new BRZConfigurationPushAutomation(true);
        configuration.Push.Automation.RequestAuthorizationAtLaunch = false;

        // - Universal link forwarding
        configuration.ForwardUniversalLinks = true;

        // - SDK Authentication support
        configuration.Api.SdkAuthentication = true;

        // - Miscellaneous
        configuration.Api.AddSDKMetadata(new[] { BRZSDKMetadata.Xamarin });

        // create the Braze instance and store it on the AppDelegate
        braze = new Braze(configuration);

        // register the BrazeInAppMessageUI as the In-App Message presenter
        inAppMessageUI = new BrazeInAppMessageUI();
        braze.InAppMessagePresenter = inAppMessageUI;

        // add GIF support to BrazeUI (see below for SdWebImage implementation)
        BRZGIFViewProvider.Shared = BRZGIFViewProviderExtensions.SdWebImage();

        // register the delegate for SDK authentication
        sdkAuthDelegate = new SDKAuthenticationDelegate();
        braze.SdkAuthDelegate = sdkAuthDelegate;
    }
}

// Braze SDK Authentication support

class SDKAuthenticationDelegate : BrazeSDKAuthDelegate
{
    public override void SdkAuthenticationFailedWithError(Braze braze, BRZSDKAuthenticationError error)
    {
        Console.WriteLine("Invalid SDK Authentication signature.");
        braze.User.IdOnQueue(DispatchQueue.MainQueue, (userId) => {
            string newSignature = "NEW_SDK_AUTH_SIGNATURE_FOR_USER_" + userId;
            braze.SetSDKAuthenticationSignature(newSignature);
        });
    }
}

// BrazeUI GIF support via SDWebImage

static class BRZGIFViewProviderExtensions
{
    public static BRZGIFViewProvider SdWebImage()
    {
        return BRZGIFViewProvider.ProviderWithView(
            url =>
            {
                UIImage? image = ImageForUrl(url);
                SDAnimatedImageView view;
                if (image != null)
                {
                    view = new SDAnimatedImageView(image);
                }
                else
                {
                    view = new SDAnimatedImageView();
                }
                return view;
            },
            (view, url) =>
            {
                if (view is SDAnimatedImageView animatedImageView)
                {
                    animatedImageView.Image = ImageForUrl(url);
                }
            });
    }

    private static UIImage? ImageForUrl(NSUrl url)
    {
        if (url == null || url.Path == null)
        {
            return null;
        }

        if (url.PathExtension != null && url.PathExtension.Equals("gif"))
        {
            return SDAnimatedImage.ImageWithContentsOfFile(url.Path);
        }
        else
        {
            return UIImage.FromFile(url.Path);
        }
    }
}
