using System;
using ObjCRuntime;

[assembly: LinkWith ("libSDWebImage.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator,  Frameworks="ImageIO", ForceLoad = true)]