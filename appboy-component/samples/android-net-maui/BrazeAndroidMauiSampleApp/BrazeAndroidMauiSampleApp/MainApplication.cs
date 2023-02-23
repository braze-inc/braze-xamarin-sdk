using Android.Runtime;
using Com.Braze;

namespace BrazeAndroidMauiSampleApp;

[Application]
public class MainApplication : Application
{
    protected MainApplication(System.IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
    {
    }

    public override void OnCreate()
    {
        base.OnCreate();
        RegisterActivityLifecycleCallbacks(new BrazeActivityLifecycleCallbackListener());
    }
}
