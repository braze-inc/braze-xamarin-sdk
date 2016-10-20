## 1.3
- Updates the iOS binding to use Appboy SDK version 2.24.2.
- Updates the Android binding to use Appboy SDK version 1.15.3.
- **Update Required** — Updates iOS push handling in the AppboyProject sample project to be compatible with iOS 10. For more information, refer to the CHANGELOG for [Appboy iOS SDK v2.24.0](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#2240).
- Removes `AppboyBroadcastReceiver.cs` from the AppboyProject sample project, as Appboy Android SDK v1.15.0 removes the need for a custom `AppboyBroadcastReceiver` for Appboy push notifications.
- Updates the AppboyProject sample project to integrate session handling and in-app message manager registration using an [AppboyLifecycleCallbackListener](https://github.com/Appboy/appboy-android-sdk/blob/master/android-sdk-ui/src/com/appboy/AppboyLifecycleCallbackListener.java), as introduced in Appboy Android SDK v1.15.0.

## 1.2
- Updates the iOS binding to use Appboy SDK version 2.17.1.
- Updates the Android binding to use Appboy SDK version 1.11.0.

## 1.1
- Updates the iOS binding to use Appboy SDK version 2.12.0.
- Updates the Android binding to use Appboy SDK version 1.8.0.
- Adds a Xamarin Forms sample application with News Feed integrations.
- Adds AppboyXamarinFormsFeedFragment that inherits from Android.App.Fragment to be compatible with Xamarin Forms.

## 1.0
- Adds support for all standard API and UI functionality in the Android SDK and iOS SDKs.
- iOS functionality not included in this release:  IDFA collection, custom Slideup viewControllers, social data collection.
- Please contact support@appboy.com for more information about these features and the timeline for their inclusion.