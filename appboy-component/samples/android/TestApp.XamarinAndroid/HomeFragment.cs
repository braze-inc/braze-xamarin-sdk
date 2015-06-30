using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Appboy;
using Com.Appboy.UI.Inappmessage;
using Com.Appboy.UI;
using Com.Appboy.Models;
using Com.Appboy.Enums;
using Com.Appboy.Enums.Inappmessage;
using Com.Appboy.Models.Outgoing;

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

      View view = inflater.Inflate (Resource.Layout.HomeFragment, container, false);

      // Change User
      view.FindViewById<Button> (Resource.Id.changeUserButton).Click += delegate {
        Appboy.GetInstance(Activity).ChangeUser("myUser" + (new Random().Next()));
      };

      // Set User Properties
      view.FindViewById<Button> (Resource.Id.userPropertyButton).Click += delegate {
        Appboy.GetInstance(Activity).CurrentUser.SetBio("My bio");
        Appboy.GetInstance(Activity).CurrentUser.SetCountry("USA");
        Appboy.GetInstance(Activity).CurrentUser.SetDateOfBirth(1987, Month.September, 21);
        Appboy.GetInstance(Activity).CurrentUser.SetEmail("brian@appboy.com");
        Appboy.GetInstance(Activity).CurrentUser.SetFirstName("Brian");
        Appboy.GetInstance(Activity).CurrentUser.SetLastName("Wheeler");
        Appboy.GetInstance(Activity).CurrentUser.SetHomeCity("Mountain View");
        Appboy.GetInstance(Activity).CurrentUser.SetPhoneNumber("5555555555");
        Appboy.GetInstance(Activity).CurrentUser.SetCustomUserAttribute("customAttributeKey", true);
        Appboy.GetInstance(Activity).CurrentUser.SetEmailNotificationSubscriptionType(NotificationSubscriptionType.OptedIn);
        Appboy.GetInstance(Activity).CurrentUser.SetGender(Gender.Male);
      };

      // Events and purchases
      view.FindViewById<Button> (Resource.Id.eventsAndPurchasesButton).Click += delegate {
        Appboy.GetInstance(Activity).LogCustomEvent("myCustomEvent");
        Appboy.GetInstance(Activity).LogPurchase("myProduct", 100);
        Appboy.GetInstance(Activity).LogShare(SocialNetwork.Facebook);
      };

      // Feedback
      view.FindViewById<Button> (Resource.Id.submitFeedbackButton).Click += delegate {
        Appboy.GetInstance(Activity).SubmitFeedback("testuser@test.com", "Great App!", false);
      };

      // Social
      view.FindViewById<Button> (Resource.Id.trackSocialDataButton).Click += delegate {
        Appboy.GetInstance(Activity).LogShare(SocialNetwork.Facebook);

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
        Appboy.GetInstance(Activity).CurrentUser.SetFacebookData(facebookUser);

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
        TwitterUser twitterUser = new TwitterUser(new Java.Lang.Integer(6253282), "Test", "User", "Tester",  new Java.Lang.Integer(100), new Java.Lang.Integer(100), 
          new Java.Lang.Integer(100), "https://si0.twimg.com/profile_images/2685532587/fa47382ad67a0135acc62d4c6b49dbdc_bigger.jpeg");
        Appboy.GetInstance(Activity).CurrentUser.SetTwitterData(twitterUser);
      };

      // Feed
      view.FindViewById<Button> (Resource.Id.launchNewsFeedButton).Click += delegate {
        FragmentTransaction fragmentTransaction = Activity.SupportFragmentManager.BeginTransaction();
        AppboyFeedFragment feedFragment = new AppboyFeedFragment();
        fragmentTransaction.Replace(Resource.Id.root, feedFragment, feedFragment.Class.ToString());
        fragmentTransaction.AddToBackStack(feedFragment.Class.ToString());
        fragmentTransaction.Commit();   
      };

      // Feedback
      view.FindViewById<Button> (Resource.Id.launchFeedbackButton).Click += delegate {
        FragmentTransaction fragmentTransaction = Activity.SupportFragmentManager.BeginTransaction();
        AppboyFeedbackFragment feedbackFragment = new AppboyFeedbackFragment();
        feedbackFragment.SetFeedbackFinishedListener(new FeedbackFinishedListener(Activity.SupportFragmentManager));
        fragmentTransaction.Replace(Resource.Id.root, feedbackFragment, feedbackFragment.Class.ToString());
        fragmentTransaction.AddToBackStack(feedbackFragment.Class.ToString());
        fragmentTransaction.Commit();     
      };

      // Slideup
      view.FindViewById<Button> (Resource.Id.addSlideupButton).Click += delegate {
        InAppMessageSlideup slideup = new InAppMessageSlideup();
        slideup.Message = "This is the message";
        slideup.SetClickAction(ClickAction.Uri, Android.Net.Uri.Parse("http://appboy.com"));
        AppboyInAppMessageManager.Instance.AddInAppMessage(slideup);
      };

      // Request Data Flush
      view.FindViewById<Button> (Resource.Id.dataFlushButton).Click += delegate {
        Appboy.GetInstance(Activity).RequestImmediateDataFlush();
      };
				
      return view;
    }

    class FeedbackFinishedListener : Java.Lang.Object, AppboyFeedbackFragment.IFeedbackFinishedListener {
      FragmentManager mFragmentManager;

      public FeedbackFinishedListener(FragmentManager supportFragmentManager) {
        mFragmentManager = supportFragmentManager;
      }

      public void OnFeedbackFinished () {
        Console.WriteLine ("Feedback finished");
        mFragmentManager.PopBackStack ();
      }
    }
  }
}

