## 1.5

##### Breaking
- Removed the need to include `Appboy.bundle` manually in iOS integrations. Integrators should remove existing `Appboy.bundle` files from their iOS integrations.

##### Added
- Added the ability to report to Braze that the app is running Xamarin to iOS integrations. We strongly recommend reporting this value to allow Braze to calculate accurate usage around different SDK platforms. To enable reporting, add `Appboy.SharedInstance.SdkFlavor = ABKSDKFlavor.Xamarin;` to your `AppDelegate.cs` after calling `Appboy.StartWithApiKey()`.
- Braze Xamarin Bindings are now available on [Nuget](nuget.org). Check out our [iOS Binding](https://www.nuget.org/packages/AppboyPlatformXamariniOSBinding/) and [Android Binding](https://www.nuget.org/packages/AppboyPlatform.AndroidBinding/). Note that Braze Xamarin SDK version `1.5.0` is the last version to receive a Xamarin component store release. Future releases will be released to Nuget and the open source repo only.

##### Changed
- Updated the iOS binding to use Braze SDK version 3.3.0.
- Updated the Android binding to use Braze SDK version 2.2.1.

## 1.4

##### Changed
- Updated the iOS binding to use Braze SDK version 2.29.0.
- Updated the Android binding to use Braze SDK version 2.0.0.

## 1.3

##### Breaking
- **Update Required** — Updated iOS push handling in the AppboyProject sample project to be compatible with iOS 10. For more information, refer to the CHANGELOG for [Braze iOS SDK v2.24.0](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#2240).

##### Changed
- Updated the iOS binding to use Braze SDK version 2.24.2.
- Updated the Android binding to use Braze SDK version 1.15.3.
- Updated the AppboyProject sample project to integrate session handling and in-app message manager registration using an [AppboyLifecycleCallbackListener](https://github.com/Appboy/appboy-android-sdk/blob/master/android-sdk-ui/src/com/appboy/AppboyLifecycleCallbackListener.java), as introduced in Braze Android SDK v1.15.0.

##### Removed
- Removed `AppboyBroadcastReceiver.cs` from the AppboyProject sample project, as Braze Android SDK v1.15.0 removes the need for a custom `AppboyBroadcastReceiver` for Braze push notifications.

## 1.2

##### Changed
- Updated the iOS binding to use Braze SDK version 2.17.1.
- Updated the Android binding to use Braze SDK version 1.11.0.

## 1.1

##### Added
- Added a Xamarin Forms sample application with News Feed integrations.
- Added AppboyXamarinFormsFeedFragment that inherits from Android.App.Fragment to be compatible with Xamarin Forms.

##### Changed
- Updated the iOS binding to use Braze SDK version 2.12.0.
- Updated the Android binding to use Braze SDK version 1.8.0.

## 1.0

##### Added
- Added support for all standard API and UI functionality in the Android SDK and iOS SDKs.
- iOS functionality not included in this release: IDFA collection, custom Slideup viewControllers, social data collection.
- Please contact support@braze.com for more information about these features and the timeline for their inclusion.
