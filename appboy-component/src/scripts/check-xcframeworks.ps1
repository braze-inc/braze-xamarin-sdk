###################################################################################################
# This script verifies that the desired Swift SDK version is installed and downloads it if not.
# It is executed automatically by the iOS `.csproj` files.
# It uses:
# - The content of ../.swift-sdk-version as the desired version of the Swift SDK.
# - The content of .swift-sdk-version as the current installed version of the Swift SDK (this file
#   exist side by side with the modules `.csproj`).
###################################################################################################

# Constants
$SCRIPT_DIR = Split-Path -Parent -Path $MyInvocation.MyCommand.Definition
$DESIRED_SWIFT_SDK_VERSION = Get-Content "$SCRIPT_DIR\..\.swift-sdk-version"

if (Test-Path .\.swift-sdk-version) {
  $CURRENT_SWIFT_SDK_VERSION = Get-Content ".\.swift-sdk-version"
} else {
  $CURRENT_SWIFT_SDK_VERSION = "unknown"
}

Write-Host "→ Checking Swift SDK version"
Write-Host "  · Desired version: $DESIRED_SWIFT_SDK_VERSION"
Write-Host "  · Current version: $CURRENT_SWIFT_SDK_VERSION"

# Main
# - Early exit if the desired Swift SDK version is already installed
if ($CURRENT_SWIFT_SDK_VERSION -eq $DESIRED_SWIFT_SDK_VERSION) {
  Write-Host "The desired Swift SDK version ($DESIRED_SWIFT_SDK_VERSION) is already installed"
  exit
}

# - Download the desired Swift SDK version
& "$SCRIPT_DIR\download-xcframeworks.ps1" $DESIRED_SWIFT_SDK_VERSION
