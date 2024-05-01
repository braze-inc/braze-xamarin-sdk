![Braze Logo](https://github.com/braze-inc/braze-xamarin-sdk/blob/master/braze-logo.png)

# Xamarin SDK

Successful marketing automation is essential to the future of your mobile app. Braze helps you engage your users beyond the download. Visit the following links for details and we'll have you up and running in no time!

- [Braze User Guide](https://www.braze.com/docs/user_guide/introduction/ "Braze User Guide")
- [Braze Developer Guide](https://www.braze.com/docs/developer_guide/home/ "Braze Developer Guide")
- [Android Class Documentation](https://appboy.github.io/appboy-android-sdk/kdoc "Braze Android SDK Class Documentation")
- [iOS Full Class Documentation](http://appboy.github.io/appboy-ios-sdk/docs/annotated.html "Braze iOS SDK Class Documentation")
- [iOS Xamarin Bindings Nuget Package](https://www.nuget.org/packages/AppboyPlatformXamariniOSBinding/ "iOS Xamarin Bindings Nuget Package")
- [Android Xamarin Bindings Nuget Package](https://www.nuget.org/packages/AppboyPlatform.AndroidBinding/ "Android Xamarin Bindings Nuget Package")

## Components

The format of this repository is that of a Xamarin component: under appboy-component you will find the directories src,
libs, component, and samples. Libs, src, and samples each contain two directories, one for Android and one for iOS. The directories
contain:

- libs: the compiled DLL bindings for the Braze SDKs.
- src: the Xamarin bindings projects that generated the DLLs found in the libs folder.
- samples: Xamarin applications that show how to use the bindings to access the Braze feature set.
- nuget: Nuspec files for our Xamarin Nuget packages.

## Versioning

| Binding file name                          | Supported Xamarin Frameworks                              | Native Braze framework                              | Braze Xamarin SDK version |
|--------------------------------------------|-----------------------------------------------------------|-----------------------------------------------------|---------------------------|
| `BrazeAndroidBinding.sln`                  | .NET 6+                                                   | Android SDK 24.2.0+                                 | 1.27.0+                   |
| `AppboyPlatform.XamarinAndroidBinding.sln` | Xamarin.Android,<br/>Xamarin.Forms,<br/>.NET 5 and before | Android SDK 23.3.0 and before                       | 1.26.0 and before         |
| `BrazeiOSBinding.sln`                      | .NET 7+                                                   | Swift SDK 7.5.0+                                    | 4.0.0+                    |
| `AppboyPlatformXamariniOSBinding.sln`      | Xamarin.iOS,<br/>Xamarin.Forms,<br/>.NET 5 and before     | `Appboy_iOS_SDK.framework` version 4.4.1 and before | 1.27.0 and before         |

### Xamarin & Xamarin.Forms

As of May 1, 2024, [Microsoft announced the end of support for Xamarin & Xamarin.Forms](https://dotnet.microsoft.com/en-us/platform/support/policy/xamarin).

The Braze SDK version dropped support for Xamarin & Xamarin.Forms starting with version `4.0.0` and added support for [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui).

## Questions?

If you have questions, please contact [support@braze.com](mailto:support@braze.com).
