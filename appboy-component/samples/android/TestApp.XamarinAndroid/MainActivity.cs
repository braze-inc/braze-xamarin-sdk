using System;

using Android.Support.V4.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Appboy;
using Com.Appboy.UI.Slideups;

namespace com.appboy.xamarinsample
{
  [Android.App.Activity (Label = "TestApp.XamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
  public class MainActivity : FragmentActivity
  {
    private bool mRefreshData;

    protected override void OnCreate (Bundle bundle)
    {
      base.OnCreate (bundle);
      SetContentView (Resource.Layout.Main);

      FragmentTransaction fragmentTransaction = SupportFragmentManager.BeginTransaction();
      HomeFragment homeFragment = new HomeFragment();
      fragmentTransaction.Add(com.appboy.xamarinsample.Resource.Id.root, homeFragment, homeFragment.Class.ToString());
      fragmentTransaction.Commit();    
    }

    protected override void OnStart() {
      base.OnStart ();
      if (Appboy.GetInstance (this).OpenSession (this)) {
        mRefreshData = true;
      }
    }

    protected override void OnStop() {
      base.OnStop ();
      Appboy.GetInstance (this).CloseSession (this);
    }

    protected override void OnNewIntent(Intent intent) {
      base.OnNewIntent(intent);
      Intent = intent;
    }

    protected override void OnResume() {
      base.OnResume ();

      AppboySlideupManager.Instance.RegisterSlideupManager (this);
      if (mRefreshData) {
        Appboy.GetInstance(this).RequestSlideupRefresh();
        mRefreshData = false;
      }

      String source = Intent.GetStringExtra (AppboyBroadcastReceiver.SOURCE_KEY);
      if (source != null && source == Com.Appboy.Constants.Appboy) {
        String campaignId = Intent.GetStringExtra (Com.Appboy.Constants.AppboyPushCampaignIdKey);
        if (campaignId != null) {
          Appboy.GetInstance (this).LogPushNotificationOpened (campaignId);
        }
      }
      Intent = new Intent ();
    }

    protected override void OnPause() {
      base.OnPause ();
      AppboySlideupManager.Instance.UnregisterSlideupManager (this);
    }
  }
}


