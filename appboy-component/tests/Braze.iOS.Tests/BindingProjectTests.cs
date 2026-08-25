using System.Reflection;
using Xunit;

namespace Braze.iOS.Tests;

/// <summary>
/// Verifies each iOS binding project file exists in the repository.
///
/// This is a cross-platform (net9.0) sanity check, not a substitute for building the
/// bindings themselves: appboy-component/src contains only auto-generated Objective-C
/// interop declarations (no executable C# logic), so there is nothing to unit test until
/// bespoke code is added under an Additions/ folder on top of the generated bindings
/// (see e.g. https://github.com/braze-inc/xamarin-sdk/pull/287).
/// </summary>
public class BindingProjectTests
{
    private static string GetRepoPath(string relativePath)
    {
        var attribute = typeof(BindingProjectTests).Assembly
            .GetCustomAttributes(typeof(AssemblyMetadataAttribute))
            .OfType<AssemblyMetadataAttribute>()
            .FirstOrDefault(a => a.Key == "RepoRoot")
            ?? throw new InvalidOperationException("RepoRoot metadata not found");
        var repoRoot = attribute.Value ?? throw new InvalidOperationException("RepoRoot metadata value is null");
        return System.IO.Path.GetFullPath(System.IO.Path.Combine(repoRoot, relativePath));
    }

    [Theory]
    [InlineData("appboy-component/src/ios-brazekit/Braze.BrazeKit.csproj")]
    [InlineData("appboy-component/src/ios-brazekitcompat/Braze.BrazeKitCompat.csproj")]
    [InlineData("appboy-component/src/ios-brazeui/Braze.BrazeUI.csproj")]
    [InlineData("appboy-component/src/ios-brazeuicompat/Braze.BrazeUICompat.csproj")]
    [InlineData("appboy-component/src/ios-brazelocation/Braze.BrazeLocation.csproj")]
    [InlineData("appboy-component/src/ios-sdwebimage/Braze.SDWebImage.csproj")]
    [InlineData("appboy-component/src/ios-unified/AppboyPlatformXamariniOSBinding.csproj")]
    public void BindingProjectExists(string relativeProjectPath)
    {
        var projectPath = GetRepoPath(relativeProjectPath);
        Assert.True(System.IO.File.Exists(projectPath), $"Expected binding project at {projectPath}");
    }
}
