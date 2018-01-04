### Quickstart

To get started, create a [Braze](https://braze.com) account.  See [our documentation](https://documentation.braze.com/) for detailed instructions on how to integrate Braze depending on your platform.

## iOS

First, set up an application in the Braze dashboard.  Then, within your `AppDelegate.cs` file, add the following snippet within your `FinishedLaunching` method:
__Note__: Be sure to update `YOUR-API-KEY` with the correct value from your App Settings page in the Braze dashboard.

```csharp
 Appboy.StartWithApiKey ("YOUR-API-KEY", UIApplication.SharedApplication, options);
```

See [our documentation](https://documentation.braze.com/) for instructions on how to integrate further features.

## Android 

First, set up an application in the Braze dashboard.  Then, to enable tracking of user sessions and the gathering of basic user data, add the following call to the `OnCreate()` lifecycle method of the Application class in your app:

```csharp
 	public override void OnCreate()
    {
      RegisterActivityLifecycleCallbacks (new AppboyLifecycleCallbackListener());
    }
```

__Note__:  Ensure that you have ``using Com.Appboy;`` at the top of your Activity so that the Braze class resolves.

See [our documentation](https://documentation.braze.com/) for instructions on how to integrate further features.
