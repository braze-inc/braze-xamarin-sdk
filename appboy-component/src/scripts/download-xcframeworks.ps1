###################################################################################################
# This script downloads and copies the prebuilt xcframeworks to the corresponding module 
# directories.
# When called without argument, it uses the content of ../.swift-sdk-version as the version of the
# Swift SDK to download. Otherwise, the first argument is used as the version.
###################################################################################################

# Constants
$SCRIPT_DIR = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
$MODULES = "BrazeKit", "BrazeLocation", "BrazeUI", "BrazeKitCompat", "BrazeUICompat", "SDWebImage"

# Parameters
if ($args.Length -eq 0) {
  $SWIFT_SDK_VERSION = Get-Content "$SCRIPT_DIR\..\.swift-sdk-version"
} else {
  $SWIFT_SDK_VERSION = $args[0]
}

# Main
Set-Location -Path $SCRIPT_DIR

# - Clean up previous artifacts
if ((Test-Path .\artifacts -PathType Container) -or (Test-Path .\artifacts.zip)) {
  Write-Host "→ Cleaning up previous artifacts"
  Remove-Item -Recurse -Force artifacts, artifacts.zip
}

# - Download prebuilt artifacts
Write-Host "→ Downloading Swift SDK prebuilt artifacts (version $SWIFT_SDK_VERSION)"
Invoke-WebRequest -Uri "https://github.com/braze-inc/braze-swift-sdk/releases/download/$SWIFT_SDK_VERSION/braze-swift-sdk-prebuilt.zip" -OutFile artifacts.zip

# - Unzip prebuilt artifacts
Write-Host "→ Unzipping prebuilt artifacts"
Expand-Archive -Path artifacts.zip -DestinationPath artifacts
Remove-Item artifacts.zip

# - Copy dynamic xcframeworks to corresponding module directories
Write-Host "→ Copying dynamic xcframeworks"
foreach ($module in $MODULES) {
  $lowercaseModule = $module.ToLower()
  $moduleDir = "$SCRIPT_DIR\..\ios-$lowercaseModule"
  Write-Host "  · $module"
  if (Test-Path "$moduleDir\$module.xcframework") {
    Remove-Item -Recurse -Force "$moduleDir\$module.xcframework"
  }
  Copy-Item -Recurse "artifacts\dynamic\$module.xcframework" $moduleDir
  $SWIFT_SDK_VERSION | Out-File -FilePath "$moduleDir\.swift-sdk-version"
}

# - Cleanup run
Write-Host "→ Cleaning up"
Remove-Item -Recurse -Force artifacts
