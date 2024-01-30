#! /bin/bash
# Unofficial bash strict mode
set -euo pipefail
IFS=$'\n\t'

###################################################################################################
# This script verifies that the desired Swift SDK version is installed and downloads it if not.
# It is executed automatically by the iOS `.csproj` files.
# It uses:
# - The content of ../.swift-sdk-version as the desired version of the Swift SDK.
# - The content of .swift-sdk-version as the current installed version of the Swift SDK (this file
#   exist side by side with the modules `.csproj`).
###################################################################################################

# Constants
SCRIPT_DIR=$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" &> /dev/null && pwd)
DESIRED_SWIFT_SDK_VERSION=$(cat "$SCRIPT_DIR/../.swift-sdk-version")

if [[ -f .swift-sdk-version ]]; then
  CURRENT_SWIFT_SDK_VERSION=$(cat ".swift-sdk-version")
else
  CURRENT_SWIFT_SDK_VERSION="unknown"
fi

echo "→ Checking Swift SDK version"
echo "  · Desired version: $DESIRED_SWIFT_SDK_VERSION"
echo "  · Current version: $CURRENT_SWIFT_SDK_VERSION"

# Main
# - Early exit if the desired Swift SDK version is already installed
if [ "$CURRENT_SWIFT_SDK_VERSION" = "$DESIRED_SWIFT_SDK_VERSION" ]; then
  echo "The desired Swift SDK version ($DESIRED_SWIFT_SDK_VERSION) is already installed"
  exit 0
fi

# - Download the desired Swift SDK version
"$SCRIPT_DIR/download-xcframeworks.sh" "$DESIRED_SWIFT_SDK_VERSION"
