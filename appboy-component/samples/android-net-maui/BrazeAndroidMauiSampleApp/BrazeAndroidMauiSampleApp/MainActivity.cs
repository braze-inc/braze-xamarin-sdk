using Android.Content.PM;
using Com.Braze.UI;
using Com.Braze.Enums;
using Com.Braze.Models.Outgoing;
using Com.Braze;
using Com.Braze.Enums.Inappmessage;
using Com.Braze.Push;
using Com.Braze.Models.Inappmessage;
using Com.Braze.UI.Contentcards;
using Com.Braze.UI.Inappmessage;
using Com.Braze.Models;
using Com.Braze.Support;
using Com.Braze.UI.Activities;
using Android.Gms.Common;
using Android.Content;
using Java.Lang;
// Location binding imports
using Com.Braze.Location;
using Android.Widget;
using AndroidX.Core.App;
using AndroidX.Core.Content;

namespace BrazeAndroidMauiSampleApp;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    private const int LOCATION_PERMISSION_REQUEST_CODE = 1001;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        ContentCardsFragment fragment = new ContentCardsFragment();
        BrazeFirebaseMessagingService brazeFirebaseMessagingService = new BrazeFirebaseMessagingService();
        IList<FeatureFlag> allFeatureFlags = Braze.GetInstance(this).AllFeatureFlags;
        BrazeLogger.D("HomeFragment num feature flags", allFeatureFlags.Count.ToString());

        // Change User
        FindViewById<Button>(Resource.Id.changeUserButton).Click += delegate
        {
            System.String userId = "xam-" + (new Random().Next() % 1001);
            Braze.GetInstance(this).ChangeUser(userId);
            FindViewById<TextView>(Resource.Id.userId).Text = "UserId: " + userId;
        };

        // Set User Properties
        FindViewById<Button>(Resource.Id.userPropertyButton).Click += delegate
        {
            Braze.GetInstance(this).CurrentUser.SetCountry("USA");
            Braze.GetInstance(this).CurrentUser.SetDateOfBirth(1987, Month.September, 21);
            Braze.GetInstance(this).CurrentUser.SetEmail("brian@braze.com");
            Braze.GetInstance(this).CurrentUser.SetFirstName("Brian");
            Braze.GetInstance(this).CurrentUser.SetLastName("Wheeler");
            Braze.GetInstance(this).CurrentUser.SetHomeCity("Mountain View");
            Braze.GetInstance(this).CurrentUser.SetPhoneNumber("5555555555");
            Braze.GetInstance(this).CurrentUser.SetCustomUserAttribute("customAttributeKey", true);
            Braze.GetInstance(this).CurrentUser.SetEmailNotificationSubscriptionType(NotificationSubscriptionType.OptedIn);
            Braze.GetInstance(this).CurrentUser.SetGender(Gender.Male);
            Braze.GetInstance(this).CurrentUser.SetAttributionData(new AttributionData("a", "b", "c", "d"));
            Braze.GetInstance(this).CurrentUser.AddToSubscriptionGroup("group-id-here");
            Braze.GetInstance(this).CurrentUser.RemoveFromSubscriptionGroup("another-group-id");
        };

        // Events and purchases
        FindViewById<Button>(Resource.Id.eventsAndPurchasesButton).Click += delegate
        {
            Braze.GetInstance(this).LogCustomEvent("myCustomEvent");
            Braze.GetInstance(this).LogPurchase("myProduct", "USD", new Java.Math.BigDecimal(3.50));
        };

        // Content Cards
        FindViewById<Button>(Resource.Id.launchContentCardsButton).Click += delegate
        {
            ContentCardsActivity contentCards = new ContentCardsActivity();
            Intent intent = new Intent(this, contentCards.Class);
            StartActivity(intent);
        };

        // In-App Message
        FindViewById<Button>(Resource.Id.addInAppMessageButton).Click += delegate
        {
            InAppMessageSlideup slideup = new InAppMessageSlideup();
            slideup.Message = "This is the message";
            slideup.SetClickBehavior(ClickAction.Uri, Android.Net.Uri.Parse("http://braze.com"));
            BrazeInAppMessageManager.Instance.AddInAppMessage(slideup);
        };

        // Request Data Flush
        FindViewById<Button>(Resource.Id.dataFlushButton).Click += delegate
        {
            Braze.GetInstance(this).RequestImmediateDataFlush();
        };

        // Wipe Data
        FindViewById<Button>(Resource.Id.wipeDataButton).Click += delegate
        {
            Braze.WipeData(this);
        };

        // Disable SDK
        FindViewById<Button>(Resource.Id.disableSDKButton).Click += delegate
        {
            Braze.DisableSdk(this);
        };

        // Enable SDK
        FindViewById<Button>(Resource.Id.enableSDKButton).Click += delegate
        {
            Braze.EnableSdk(this);
        };

        // Request Location Permission
        FindViewById<Button>(Resource.Id.requestLocationPermissionButton).Click += delegate
        {
            RequestLocationPermission();
        };

        // Set Last Known Location (NYC)
        FindViewById<Button>(Resource.Id.setLocationButton).Click += delegate
        {
            SetLastKnownLocation();
        };
    }

    private void RequestLocationPermission()
    {
        const string TAG = "LocationPermission";
        
        // Check if permissions are already granted
        bool fineLocationGranted = ContextCompat.CheckSelfPermission(this, Android.Manifest.Permission.AccessFineLocation) == Permission.Granted;
        bool coarseLocationGranted = ContextCompat.CheckSelfPermission(this, Android.Manifest.Permission.AccessCoarseLocation) == Permission.Granted;

        if (fineLocationGranted && coarseLocationGranted)
        {
            BrazeLogger.D(TAG, "Location permissions already granted");
            Toast.MakeText(this, "Location permissions already granted!", ToastLength.Short)?.Show();
            return;
        }

        BrazeLogger.D(TAG, "Requesting location permissions...");
        
        // Request permissions
        ActivityCompat.RequestPermissions(
            this,
            new string[]
            {
                Android.Manifest.Permission.AccessFineLocation,
                Android.Manifest.Permission.AccessCoarseLocation
            },
            LOCATION_PERMISSION_REQUEST_CODE
        );
    }

    private void SetLastKnownLocation()
    {
        const string TAG = "SetLocation";
        
        // New York, NY coordinates
        double latitude = 40.7128;
        double longitude = -74.0060;

        try
        {
            BrazeLogger.D(TAG, $"Setting last known location to NYC: ({latitude}, {longitude})");
            
            // Set the user's last known location
            Braze.GetInstance(this).CurrentUser.SetLastKnownLocation(latitude, longitude);
            
            BrazeLogger.D(TAG, "Flushing data to Braze...");
            
            // Flush data to Braze
            Braze.GetInstance(this).RequestImmediateDataFlush();

            Toast.MakeText(this, $"Location set to NYC ({latitude}, {longitude})\nData flush requested!", ToastLength.Long)?.Show();
            BrazeLogger.D(TAG, "Location set and data flush requested successfully");
        }
        catch (System.Exception ex)
        {
            Java.Lang.Throwable javaThrowable = Java.Lang.Throwable.FromException(ex);
            BrazeLogger.E(TAG, $"Error setting location: {ex.Message}",  javaThrowable);
            Toast.MakeText(this, $"Error setting location: {ex.Message}", ToastLength.Long)?.Show();
        }
    }

    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
    {
        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        const string TAG = "LocationPermission";

        if (requestCode == LOCATION_PERMISSION_REQUEST_CODE)
        {
            if (grantResults.Length > 0 && grantResults[0] == Permission.Granted)
            {
                BrazeLogger.D(TAG, "Location permission granted");
                Toast.MakeText(this, "Location permission granted!", ToastLength.Short)?.Show();
            }
            else
            {
                BrazeLogger.D(TAG, "Location permission denied");
                Toast.MakeText(this, "Location permission denied. Some features may not work.", ToastLength.Long)?.Show();
            }
        }
    }
}
