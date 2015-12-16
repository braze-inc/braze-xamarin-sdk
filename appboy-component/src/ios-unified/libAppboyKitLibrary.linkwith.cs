using ObjCRuntime;

[assembly: LinkWith ("libAppboyKitLibrary.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, LinkerFlags = "-lz", Frameworks="SystemConfiguration QuartzCore CoreImage CoreTelephony Social Accounts AdSupport StoreKit CoreText", SmartLink = true, ForceLoad = true)]
