using System;
using System.Threading.Tasks;

using Android.App;
using Android.Runtime;

using Com.Braze;
using Com.Braze.Support;

namespace com.appboy.xamarinsample
{
  [Application]
  public class MainApplication : Application
  {
    public MainApplication (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
    {
    }

    public override void OnCreate()
    {
      BrazeLogger.LogLevel = 0;
      RegisterActivityLifecycleCallbacks(new BrazeActivityLifecycleCallbackListener());
    }
  }
}
