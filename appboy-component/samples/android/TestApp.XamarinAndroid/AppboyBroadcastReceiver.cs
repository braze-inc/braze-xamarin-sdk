
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace com.appboy.xamarinsample
{
  [BroadcastReceiver]
  [IntentFilter(new string[] { "com.appboy.xamarinsample.intent.APPBOY_PUSH_RECEIVED" })]
  [IntentFilter(new string[] { "com.appboy.xamarinsample.intent.APPBOY_NOTIFICATION_OPENED" })]
  public class AppboyBroadcastReceiver : BroadcastReceiver
  {
    public const String SOURCE_KEY = "source";
  
    public override void OnReceive (Context context, Intent intent)
    {
      String packageName = context.PackageName;
      String pushReceivedAction = packageName + ".intent.APPBOY_PUSH_RECEIVED";
      String notificationOpenedAction = packageName + ".intent.APPBOY_NOTIFICATION_OPENED";
      String action = intent.Action;

      if (pushReceivedAction == action) {
        Console.WriteLine ("Received push notification");
      } else if (notificationOpenedAction == action) {
        Bundle extras = new Bundle ();
        extras.PutString (Com.Appboy.Constants.AppboyPushCampaignIdKey, intent.GetStringExtra (Com.Appboy.Constants.AppboyPushCampaignIdKey));

        if (intent.GetStringExtra ("uri") != null) {
          Intent uriIntent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(intent.GetStringExtra("uri")));
          TaskStackBuilder stackBuilder = TaskStackBuilder.Create(context);
          stackBuilder.AddNextIntent(getStartActivityIntent(context, extras));
          stackBuilder.AddNextIntent(uriIntent);
          stackBuilder.StartActivities(extras);
        } else {
          context.StartActivity (getStartActivityIntent (context, extras));
        }
      }
    }

    private Intent getStartActivityIntent(Context context, Bundle extras) {
      Intent startActivityIntent = new Intent(context, typeof(MainActivity));
      startActivityIntent.SetFlags(ActivityFlags.NewTask | ActivityFlags.ClearTop | ActivityFlags.SingleTop);
      startActivityIntent.PutExtra(SOURCE_KEY, Com.Appboy.Constants.Appboy);
      if (extras != null) {
        startActivityIntent.PutExtras(extras);
      }
      return startActivityIntent;
    }
  }
}

