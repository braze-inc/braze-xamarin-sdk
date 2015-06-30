using System;
using ObjCRuntime;

[assembly: LinkWith ("libAppboyKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, Frameworks="SystemConfiguration QuartzCore CoreImage CoreTelephony Social Accounts AdSupport StoreKit CoreText", SmartLink = true, ForceLoad = true)]
