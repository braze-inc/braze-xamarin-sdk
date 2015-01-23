using System;
using ObjCRuntime;

[assembly: LinkWith ("libAppboyKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator, Frameworks="SystemConfiguration QuartzCore CoreImage CoreTelephony Social Twitter Accounts AdSupport StoreKit", ForceLoad = true, SmartLink = true)]
