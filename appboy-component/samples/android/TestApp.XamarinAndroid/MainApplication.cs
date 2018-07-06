using System;
using System.Threading.Tasks;

using Android.App;
using Android.Runtime;

using Com.Appboy;
using Com.Appboy.Support;

using Firebase.Iid;

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
      AppboyLogger.LogLevel = 2;
      RegisterActivityLifecycleCallbacks(new AppboyLifecycleCallbackListener());

      new Task(RegisterFirebasePush).Start();
    }

    void RegisterFirebasePush() {
      try {
        var token = FirebaseInstanceId.Instance.GetToken("901477453852", "FCM");
        Appboy.GetInstance(this).RegisterAppboyPushMessages (token);
        Console.WriteLine("Registered Firebase push token with Braze: " + token);
      } catch (Exception e) {
        Console.WriteLine("Caught exception registering for Firebase push: " + e);
      }
    }
  }
}