## 1.16.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 10.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1000).

## 1.15.0

##### Breaking
- The native iOS bridge uses [Braze iOS SDK 3.27.0](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#3270). This release adds support for iOS 14 and requires XCode 12. Please read the Braze iOS SDK changelog for details.
- `ABKIDFADelegate.IsAdvertisingTrackingEnabled` has been renamed to `ABKIDFADelegate.IsAdvertisingTrackingEnabledOrATTAuthorized`.
- The class `ABKIdentifierForAdvertisingProvider` has been removed.

## 1.14.0

##### Breaking
- Updated the native iOS bridge to [Braze iOS SDK 3.26.1](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.26.1).

## 1.13.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 8.1.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#810).

## 1.12.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 8.0.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#801).
- Updated the native iOS bridge to [Braze iOS SDK 3.24.2](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.24.2).
  - Flipped `ABKLocationManager.DisableLocationTracking` to `ABKLocationManager.EnableLocationTracking`.
  - Replaced `ABKInAppMessageWindowController.supportedOrientationMasks` with `ABKInAppMessageWindowController.supportedOrientationMask`.
 
## 1.11.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 6.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#600).
- Changed the Android binding to target Android 10.

## 1.10.2

**Important:** This patch updates the Braze iOS SDK Dependency from 3.20.1 to 3.20.2, which contains important bugfixes. Integrators should upgrade to this patch version. Please see the [Braze iOS SDK Changelog](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md) for more information.

##### Changed
- Updated the native iOS bridge to [Braze iOS SDK 3.20.2](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.20.2).

## 1.10.1

**Important:** This release has known issues displaying HTML in-app messages. Do not upgrade to this version and upgrade to 1.10.2 and above instead. If you are using this version, you are strongly encouraged to upgrade to 1.10.2 or above if you make use of HTML in-app messages.

##### Changed
- Updated the native iOS bridge to [Braze iOS SDK 3.20.1](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.20.1).

## 1.10.0

**Important:** This release has known issues displaying HTML in-app messages. Do not upgrade to this version and upgrade to 1.10.2 and above instead. If you are using this version, you are strongly encouraged to upgrade to 1.10.2 or above if you make use of HTML in-app messages.

##### Breaking
- Updated the native iOS bridge to [Braze iOS SDK 3.20.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.20.0).
- **Important:** Braze iOS SDK 3.20.0 contains updated push token registration methods. We recommend upgrading to these methods as soon as possible to ensure a smooth transition as devices upgrade to iOS 13. In `application.RegisteredForRemoteNotifications:`, replace
```
Appboy.SharedInstance?.RegisterPushToken(deviceToken.ToString());
```
with
```
Appboy.SharedInstance?.RegisterDeviceToken(deviceToken);
```

## 1.9.0

**Important:** This release has known issues displaying HTML in-app messages. Do not upgrade to this version and upgrade to 1.10.2 and above instead. If you are using this version, you are strongly encouraged to upgrade to 1.10.2 or above if you make use of HTML in-app messages.

##### Breaking
- Updated the Android binding to use [Braze Android SDK 3.7.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#370).
- Updated the native iOS bridge to [Braze iOS SDK 3.19.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.19.0).
- Note: This Braze Xamarin SDK release updates to Braze Android SDK and Braze iOS SDK dependencies which no longer enable automatic Braze location collection by default. Please consult their respective changelogs for information on how to continue to enable automatic Braze location collection, as well as further information on breaking changes.
- Removes the Feedback feature as well as all associated methods, classes, and interfaces.

## 1.8.0

##### Changed
- Updated the Android binding to use [Braze Android SDK 3.3.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#330).

##### Added
- Added C# bindings for Braze Android SDK classes with Firebase Cloud Messaging dependencies.

## 1.7.0

##### Breaking
- Updated the Android binding to use [Braze Android SDK 3.2.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#321).
  - Added `AppboyFirebaseMessagingService` to directly use the Firebase messaging event `com.google.firebase.MESSAGING_EVENT`. This is now the recommended way to integrate Firebase push with Braze. The `AppboyFcmReceiver` should be removed from your `AndroidManifest` and replaced with the following:
    ```
    <service android:name="com.appboy.AppboyFirebaseMessagingService">
    <intent-filter>
    <action android:name="com.google.firebase.MESSAGING_EVENT" />
    </intent-filter>
    </service>
    ```
  - Also note that any `c2dm` related permissions should be removed from your manifest as Braze does not require any extra permissions for `AppboyFirebaseMessagingService` to work correctly.
- Updated the native iOS bridge to [Braze iOS SDK 3.14.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.14.0).
  - Drops support for iOS 8.
  - Removes Cross-Promotion cards from the News Feed. 

## 1.6.0

##### Breaking
- Updated the native iOS bridge to [Braze iOS SDK 3.11.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.11.0).
- Updated the Android binding to use [Braze Android SDK 3.0.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#301).

## 1.5.2

##### Breaking
- Updated the Android binding to use [Braze SDK version 2.5.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#250).

##### Fixed
- Fixed an issue that caused C# bindings to not be generated for certain classes in the Braze UI library.

##### Changed
- Updated the Android sample app to use Firebase Cloud Messaging (FCM).

## 1.5.1

##### Changed
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 3.3.4](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.3.4).
  - Added `DisableSDK()` and `RequestEnableSDKOnNextAppRun()` to the `Appboy` interface to disable and re-enable the Braze SDK.
  - Added `WipeDataAndDisableForAppRun()` on the `Appboy` interface to support wiping all customer data created by the Braze SDK.
  - Note that methods that disable the SDK will cause `Appboy.SharedInstance` to return `null`. If you have code that uses `Appboy.SharedInstance`, do not use `DisableSDK()` or `WipeDataAndDisableForAppRun()` until your code can safely execute even if `Appboy.SharedInstance` is null.
- Updated the Android binding to use [Braze SDK version 2.2.5](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#225).
  - Added `DisableSdk()` and `EnableSdk()` to the `Appboy` interface to disable and re-enable the Braze SDK.
  - Added `WipeData()` on the `Appboy` interface to support wiping all customer data created by the Braze SDK.

## 1.5

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 3.3.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/3.3.0).
- Updated the Android binding to use [Braze SDK version 2.2.1](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#221).
- Removed the need to include `Appboy.bundle` manually in iOS integrations. Integrators should remove existing `Appboy.bundle` files from their iOS integrations.

##### Added
- Added the ability to report to Braze that the app is running Xamarin to iOS integrations. We strongly recommend reporting this value to allow Braze to calculate accurate usage around different SDK platforms. To enable reporting, add `Appboy.SharedInstance.SdkFlavor = ABKSDKFlavor.Xamarin;` to your `AppDelegate.cs` after calling `Appboy.StartWithApiKey()`.
- Braze Xamarin Bindings are now available on [Nuget](nuget.org). Check out our [iOS Binding](https://www.nuget.org/packages/AppboyPlatformXamariniOSBinding/) and [Android Binding](https://www.nuget.org/packages/AppboyPlatform.AndroidBinding/). Note that Braze Xamarin SDK version `1.5.0` is the last version to receive a Xamarin component store release. Future releases will be released to Nuget and the open source repo only.

## 1.4

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.29.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.29.0).
- Updated the Android binding to use [Braze SDK version 2.0.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#200).

## 1.3

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.24.2](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.24.2).
- Updated the Android binding to use [Braze SDK version 1.15.3](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1153).
- **Update Required** — Updated iOS push handling in the AppboyProject sample project to be compatible with iOS 10. For more information, refer to the CHANGELOG for [Braze iOS SDK v2.24.0](https://github.com/Appboy/appboy-ios-sdk/blob/master/CHANGELOG.md#2240).

##### Changed
- Updated the AppboyProject sample project to integrate session handling and in-app message manager registration using an [AppboyLifecycleCallbackListener](https://github.com/Appboy/appboy-android-sdk/blob/master/android-sdk-ui/src/com/appboy/AppboyLifecycleCallbackListener.java), as introduced in Braze Android SDK v1.15.0.

##### Removed
- Removed `AppboyBroadcastReceiver.cs` from the AppboyProject sample project, as Braze Android SDK v1.15.0 removes the need for a custom `AppboyBroadcastReceiver` for Braze push notifications.

## 1.2

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.17.1](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.17.1).
- Updated the Android binding to use [Braze SDK version 1.11.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#1110).

## 1.1

##### Breaking
- Updated the iOS binding to use Braze SDK version [Braze iOS SDK 2.12.0](https://github.com/Appboy/appboy-ios-sdk/releases/tag/2.12.0).
- Updated the Android binding to use [Braze SDK version 1.8.0](https://github.com/Appboy/appboy-android-sdk/blob/master/CHANGELOG.md#180).

##### Added
- Added a Xamarin Forms sample application with News Feed integrations.
- Added AppboyXamarinFormsFeedFragment that inherits from Android.App.Fragment to be compatible with Xamarin Forms.

## 1.0

##### Added
- Added support for all standard API and UI functionality in the Android SDK and iOS SDKs.
- iOS functionality not included in this release: IDFA collection, custom Slideup viewControllers, social data collection.
- Please contact support@braze.com for more information about these features and the timeline for their inclusion.
