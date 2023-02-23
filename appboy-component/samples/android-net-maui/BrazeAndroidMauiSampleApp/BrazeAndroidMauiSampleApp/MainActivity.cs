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

namespace BrazeAndroidMauiSampleApp;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
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
    }
}
