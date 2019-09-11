using System;

using Android.Gms.Common;
using Android.Support.V4.App;
using Android.OS;

using Firebase.Messaging;
using Firebase.Iid;
using Android.Util;

namespace com.appboy.xamarinsample
{
  [Android.App.Activity (Label = "TestApp.XamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
  public class MainActivity : FragmentActivity
  {
    protected override void OnCreate (Bundle bundle)
    {
      base.OnCreate (bundle);
      SetContentView (Resource.Layout.Main);

      FragmentTransaction fragmentTransaction = SupportFragmentManager.BeginTransaction();
      HomeFragment homeFragment = new HomeFragment();
      fragmentTransaction.Add(com.appboy.xamarinsample.Resource.Id.root, homeFragment, homeFragment.Class.ToString());
      fragmentTransaction.Commit();
    }
  }
}
