using System;
using Android.App;
using Android.Runtime;

using Com.Braze;
using Com.Braze.Support;

namespace TestAppXamarinForms.Droid
{
  [Application]
  public class MainApplication : Application
  {
    public MainApplication (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
    {
    }

    public override void OnCreate ()
    {
      BrazeLoggger.LogLevel = 2;
      RegisterActivityLifecycleCallbacks (new BrazeLifecycleCallbackListener ());
    }
  }
}
