<p align="center">
  <img width="480" alt="Braze Logo" src=".github/assets/logo-light.png#gh-light-mode-only" />
  <img width="480" alt="Braze Logo" src=".github/assets/logo-dark.png#gh-dark-mode-only" />
</p>

# Braze Xamarin SDK

Successful marketing automation is essential to the future of your mobile app. Braze helps you engage your users beyond the download. Visit the following links for details and we'll have you up and running in no time!

- [Braze User Guide](https://www.braze.com/docs/user_guide/introduction/ "Braze User Guide")
- [Braze Developer Guide](https://www.braze.com/docs/developer_guide/home/ "Braze Developer Guide")
- iOS Xamarin Bindings Nuget Packages:
  - [Braze.iOS.BrazeKit](https://www.nuget.org/packages/Braze.iOS.BrazeKit "Braze.iOS.BrazeKit")
  - [Braze.iOS.BrazeUI](https://www.nuget.org/packages/Braze.iOS.BrazeUI "Braze.iOS.BrazeUI")
  - [Braze.iOS.BrazeLocation](https://www.nuget.org/packages/Braze.iOS.BrazeLocation "Braze.iOS.BrazeLocation")
  - [Braze.iOS.BrazeKitCompat](https://www.nuget.org/packages/Braze.iOS.BrazeKitCompat "Braze.iOS.BrazeKitCompat")
  - [Braze.iOS.BrazeUICompat](https://www.nuget.org/packages/Braze.iOS.BrazeUICompat "Braze.iOS.BrazeUICompat")
- [Android Xamarin Bindings Nuget Package](https://www.nuget.org/packages/BrazePlatform.BrazeAndroidBinding "Android Xamarin Bindings Nuget Package")

## Components

The format of this repository is that of a Xamarin component: under appboy-component you will find the directories src,
libs, component, and samples. Libs, src, and samples each contain two directories, one for Android and one for iOS. The directories
contain:

- libs: the compiled DLL bindings for the Braze SDKs.
- src: the Xamarin bindings projects that generated the DLLs found in the libs folder.
- samples: Xamarin applications that show how to use the bindings to access the Braze feature set.
- nuget: Nuspec files for our Xamarin Nuget packages.

## Versioning

### Native Bindings
| Binding file name                          | Supported Xamarin Frameworks                              | Native Braze framework                              | Braze Xamarin SDK version |
|--------------------------------------------|-----------------------------------------------------------|-----------------------------------------------------|---------------------------|
| `BrazeAndroidBinding.sln`                  | .NET 8+                                                   | Android SDK 32.0.0+                                 | 6.0.0+                    |
| `AppboyPlatform.XamarinAndroidBinding.sln` | Xamarin.Android,<br/>Xamarin.Forms,<br/>.NET 5 and before | Android SDK 23.3.0 and before                       | 1.26.0 and before         |
| `BrazeiOSBinding.sln`                      | .NET 8+                                                   | Swift SDK 10.0.0+                                   | 6.0.0+                    |
| `AppboyPlatformXamariniOSBinding.sln`      | Xamarin.iOS,<br/>Xamarin.Forms,<br/>.NET 5 and before     | `Appboy_iOS_SDK.framework` version 4.4.1 and before | 1.27.0 and before         |

### Xamarin & Xamarin.Forms

As of May 1, 2024, [Microsoft announced the end of support for Xamarin & Xamarin.Forms](https://dotnet.microsoft.com/en-us/platform/support/policy/xamarin).

The Braze SDK version dropped support for Xamarin & Xamarin.Forms starting with version `4.0.0` and added support for [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui).

## Questions?

If you have questions, please contact [support@braze.com](mailto:support@braze.com).
