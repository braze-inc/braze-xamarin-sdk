using System;
using Android.App;
using Android.Runtime;

using Com.Appboy;

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
      RegisterActivityLifecycleCallbacks (new AppboyLifecycleCallbackListener ());
    }
  }
}
