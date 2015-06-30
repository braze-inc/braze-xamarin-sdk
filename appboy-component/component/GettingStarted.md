### Quickstart

To get started, create an [Appboy](https://appboy.com) account.  See [our documentation](https://documentation.appboy.com/) for detailed instructions on how to integrate Appboy depending on your platform.

## iOS

First, set up an application in the Appboy dashboard.  Then, within your `AppDelegate.cs` file, add the following snippet within your `FinishedLaunching` method:
__Note__: Be sure to update `YOUR-API-KEY` with the correct value from your App Settings page in the Appboy dashboard.

```csharp
 Appboy.StartWithApiKey ("YOUR-API-KEY", UIApplication.SharedApplication, options);
```

See [our documentation](https://documentation.appboy.com/) for instructions on how to integrate further features.

## Android 

First, set up an application in the Appboy dashboard.  Then, to enable tracking of user sessions and the gathering of basic user data, add the following calls to the `onStart()` and `onStop()` lifecycle methods of __every__ Activity class in your app:

```csharp
protected override void OnStart() {
    base.OnStart();
    Appboy.GetInstance(this).OpenSession(this);
}
```

```csharp
protected override void OnStop() {
    base.OnStop();
    Appboy.GetInstance(this).CloseSession(this);
}
```

__Note__:  Ensure that you have ``using Com.Appboy;`` at the top of your Activity so that the Appboy class resolves.

See [our documentation](https://documentation.appboy.com/) for instructions on how to integrate further features.
