using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Appboy;
using Com.Appboy.UI.Slideups;

namespace TestAppXamarinForms.Droid
{
  [Activity (Label = "TestAppXamarinForms.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
  public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
  {
    private bool mRefreshData;

    protected override void OnCreate (Bundle bundle)
    {
      base.OnCreate (bundle);

      global::Xamarin.Forms.Forms.Init (this, bundle);

      LoadApplication (new App ());
    }

    protected override void OnStart() {
      base.OnStop ();
      Appboy.GetInstance (this).OpenSession (this);
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

      AppboySlideupManager.Instance.RegisterInAppMessageManager (this);
      if (mRefreshData) {
        Appboy.GetInstance(this).RequestInAppMessageRefresh();
        mRefreshData = false;
      }

      Intent = new Intent ();
    }

    protected override void OnPause() {
      base.OnPause ();
      AppboySlideupManager.Instance.UnregisterInAppMessageManager (this);
    }
  }
}

