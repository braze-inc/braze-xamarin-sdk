using System;
using Android.App;
using Android.Runtime;

using Com.Appboy;
using Com.Appboy.Support;

namespace com.appboy.xamarinsample
{
  [Application]
  public class MainApplication : Application
  {
    public MainApplication (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
    {
    }

    public override void OnCreate ()
    {
      AppboyLogger.LogLevel = 2;
      RegisterActivityLifecycleCallbacks (new AppboyLifecycleCallbackListener ());
    }
  }
}