using System;

using AndroidX.Fragment.App;
using Android.OS;
using Android.Views;
using Android.Widget;

using Com.Appboy.UI;
using Com.Appboy.Enums;
using Com.Appboy.Models.Outgoing;
using Com.Braze;
using Com.Braze.Enums.Inappmessage;
using Com.Braze.Push;
using Com.Braze.Models.Inappmessage;
using Com.Braze.UI.Contentcards;
using Com.Braze.UI.Inappmessage;

namespace com.appboy.xamarinsample
{
  public class HomeFragment : Fragment
  {
    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
      if (container == null)
      {
        return null;
      }
      BrazeFirebaseMessagingService brazeFirebaseMessagingService = new BrazeFirebaseMessagingService();

      View view = inflater.Inflate (Resource.Layout.HomeFragment, container, false);

      // Change User
      view.FindViewById<Button> (Resource.Id.changeUserButton).Click += delegate {
        String userId = "myUser" + (new Random().Next());
        Braze.GetInstance(Activity).ChangeUser(userId);
        view.FindViewById<TextView> (Resource.Id.userId).Text = "UserId: " + userId;
      };

      // Set User Properties
      view.FindViewById<Button> (Resource.Id.userPropertyButton).Click += delegate {
        Braze.GetInstance(Activity).CurrentUser.SetCountry("USA");
        Braze.GetInstance(Activity).CurrentUser.SetDateOfBirth(1987, Month.September, 21);
        Braze.GetInstance(Activity).CurrentUser.SetEmail("brian@braze.com");
        Braze.GetInstance(Activity).CurrentUser.SetFirstName("Brian");
        Braze.GetInstance(Activity).CurrentUser.SetLastName("Wheeler");
        Braze.GetInstance(Activity).CurrentUser.SetHomeCity("Mountain View");
        Braze.GetInstance(Activity).CurrentUser.SetPhoneNumber("5555555555");
        Braze.GetInstance(Activity).CurrentUser.SetCustomUserAttribute("customAttributeKey", true);
        Braze.GetInstance(Activity).CurrentUser.SetEmailNotificationSubscriptionType(NotificationSubscriptionType.OptedIn);
        Braze.GetInstance(Activity).CurrentUser.SetGender(Gender.Male);
        Braze.GetInstance(Activity).CurrentUser.SetAttributionData(new AttributionData("a", "b", "c", "d"));
        Braze.GetInstance(Activity).CurrentUser.AddToSubscriptionGroup("group-id-here");
        Braze.GetInstance(Activity).CurrentUser.RemoveFromSubscriptionGroup("another-group-id");
      };

      // Events and purchases
      view.FindViewById<Button> (Resource.Id.eventsAndPurchasesButton).Click += delegate {
        Braze.GetInstance(Activity).LogCustomEvent("myCustomEvent");
        Braze.GetInstance(Activity).LogPurchase("myProduct", "USD", new Java.Math.BigDecimal(3.50));
      };

      // Social
      view.FindViewById<Button> (Resource.Id.trackSocialDataButton).Click += delegate {

        /*
           FacebookUser(
            String facebookId,
            String firstName,
            String lastName,
            String email,
            String bio,
            String cityName,
            // Gender is an Appboy enum.
            // Specify either Gender.MALE or Gender.FEMALE.
            Gender gender,
            Integer numberOfFriends,
            // Names of pages the user likes.
            Collection<String> likes,
            // mm/dd/yyyy format.
            String birthday
          )
        **/
        FacebookUser facebookUser = new FacebookUser("708379", "Test", "User", "test@appboy.com", "Test",
          "Testtown", Gender.Male, new Java.Lang.Integer(100), new String[]{"Cats", "Dogs"}, "06/17/1987");
        Braze.GetInstance(Activity).CurrentUser.SetFacebookData(facebookUser);

        /*
        TwitterUser(
          Integer twitterUserId,
          String twitterHandle,
          String name,
          String description,
          Integer followerCount,
          Integer followingCount,
          Integer tweetCount,
          String profileImageUrl
        )
        **/
        TwitterUser twitterUser = new TwitterUser(99, "Test", "User", "Tester",  new Java.Lang.Integer(100), new Java.Lang.Integer(100), 
          new Java.Lang.Integer(100), "https://si0.twimg.com/profile_images/2685532587/fa47382ad67a0135acc62d4c6b49dbdc_bigger.jpeg");
        Braze.GetInstance(Activity).CurrentUser.SetTwitterData(twitterUser);
      };

      // Content Cards
      view.FindViewById<Button> (Resource.Id.launchContentCardsButton).Click += delegate {
        FragmentTransaction fragmentTransaction = Activity.SupportFragmentManager.BeginTransaction ();
        ContentCardsFragment contentCards = new ContentCardsFragment();
        fragmentTransaction.Replace (Resource.Id.root, contentCards, contentCards.Class.ToString ());
        fragmentTransaction.AddToBackStack (contentCards.Class.ToString ());
        fragmentTransaction.Commit ();
      };

      // Feed
      view.FindViewById<Button> (Resource.Id.launchNewsFeedButton).Click += delegate {
        FragmentTransaction fragmentTransaction = Activity.SupportFragmentManager.BeginTransaction();
        AppboyFeedFragment feedFragment = new AppboyFeedFragment();
        fragmentTransaction.Replace(Resource.Id.root, feedFragment, feedFragment.Class.ToString());
        fragmentTransaction.AddToBackStack(feedFragment.Class.ToString());
        fragmentTransaction.Commit();   
      };

      // In-App Message
      view.FindViewById<Button> (Resource.Id.addInAppMessageButton).Click += delegate {
        InAppMessageSlideup slideup = new InAppMessageSlideup();
        slideup.Message = "This is the message";
        slideup.SetClickBehavior(ClickAction.Uri, Android.Net.Uri.Parse("http://braze.com"));
        BrazeInAppMessageManager.Instance.AddInAppMessage(slideup);
      };

      // Request Data Flush
      view.FindViewById<Button> (Resource.Id.dataFlushButton).Click += delegate {
        Braze.GetInstance(Activity).RequestImmediateDataFlush();
      };

      // Wipe Data
      view.FindViewById<Button> (Resource.Id.wipeDataButton).Click += delegate {
        Braze.WipeData(Activity);
      };

      // Disable SDK
      view.FindViewById<Button> (Resource.Id.disableSDKButton).Click += delegate {
        Braze.DisableSdk(Activity);
      };

      // Enable SDK
      view.FindViewById<Button> (Resource.Id.enableSDKButton).Click += delegate {
        Braze.EnableSdk(Activity);
      };
				
      return view;
    }
  }
}
