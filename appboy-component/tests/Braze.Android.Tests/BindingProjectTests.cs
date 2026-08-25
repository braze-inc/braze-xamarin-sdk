using System.Reflection;
using Xunit;

namespace Braze.Android.Tests;

/// <summary>
/// Verifies each Android binding project file exists in the repository.
///
/// This is a cross-platform (net9.0) sanity check, not a substitute for building the
/// bindings themselves: appboy-component/src contains only auto-generated Java/Kotlin
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
    [InlineData("appboy-component/src/android/AppboyPlatform.XamarinAndroidBinding.csproj")]
    [InlineData("appboy-component/src/android-core/AppboyPlatform.AndroidCore/AppboyPlatform.AndroidCore.csproj")]
    [InlineData("appboy-component/src/androidnet6/BrazeAndroidNet6Binding/BrazeAndroidBinding.csproj")]
    [InlineData("appboy-component/src/androidnet6/BrazeAndroidLocationBinding/BrazeAndroidLocationBinding.csproj")]
    public void BindingProjectExists(string relativeProjectPath)
    {
        var projectPath = GetRepoPath(relativeProjectPath);
        Assert.True(System.IO.File.Exists(projectPath), $"Expected binding project at {projectPath}");
    }
}
