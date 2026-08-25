#! /bin/bash
# Unofficial bash strict mode
set -euo pipefail
IFS=$'\n\t'

###################################################################################################
# This script downloads and copies the prebuilt xcframeworks to the corresponding module 
# directories.
# When called without argument, it uses the content of ../.swift-sdk-version as the version of the
# Swift SDK to download. Otherwise, the first argument is used as the version.
###################################################################################################

# Constants
SCRIPT_DIR=$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" &> /dev/null && pwd)
MODULES=(BrazeKit BrazeLocation BrazeUI BrazeKitCompat BrazeUICompat SDWebImage)

# Parameters
SWIFT_SDK_VERSION=${1:-$(cat "$SCRIPT_DIR/../.swift-sdk-version")}

# Main
cd "$SCRIPT_DIR"

# - Clean up previous artifacts
if [ -d "artifacts" ] || [ -f "artifacts.zip" ]; then
  echo "→ Cleaning up previous artifacts"
  rm -rf artifacts artifacts.zip
fi

# - Download prebuilt artifacts
echo "→ Downloading Swift SDK prebuilt artifacts (version $SWIFT_SDK_VERSION)"
curl -L -o artifacts.zip https://github.com/braze-inc/braze-swift-sdk/releases/download/$SWIFT_SDK_VERSION/braze-swift-sdk-prebuilt.zip

# - Unzip prebuilt artifacts
echo "→ Unzipping prebuilt artifacts"
unzip -o -q artifacts.zip -d artifacts
rm artifacts.zip

# - Copy dynamic xcframeworks to corresponding module directories
echo "→ Copying dynamic xcframeworks"
copy_dynamic_xcframework() {
  local module="$1"
  local lowercaseModule=$(echo "$module" | tr '[:upper:]' '[:lower:]')
  local moduleDir="$SCRIPT_DIR/../ios-$lowercaseModule"
  echo "  · $module"
  rm -rf "$moduleDir/$module.xcframework"
  cp -rf "artifacts/dynamic/$module.xcframework" "$moduleDir"
  echo "$SWIFT_SDK_VERSION" > "$moduleDir/.swift-sdk-version"
}
for module in "${MODULES[@]}"; do
  copy_dynamic_xcframework "$module"
done

remove_swift_compiler_generated_files() {
  local module="$1"
  local lowercaseModule
  lowercaseModule=$(echo "$module" | tr '[:upper:]' '[:lower:]')
  local moduleDir="$SCRIPT_DIR/../ios-$lowercaseModule"
  # Find all <Module>.swiftmodule directories in the xcframework
  local swiftModuleDirs
  swiftModuleDirs=$(find "$moduleDir/$module.xcframework" -type d -name "$module.swiftmodule")
  # Delete all <Module>.swiftmodule directories
  for swiftModuleDir in $swiftModuleDirs; do
    echo "  · $swiftModuleDir"
    rm -rf "$swiftModuleDir"
  done
}

# Stripping .swiftmodule files invalidates the vendor ad-hoc signature (sealed
# resources). Re-sign so the simulator does not SIGKILL with Code Signature Invalid.
# Skip Mac Catalyst / tvOS slices: this binding targets iOS only, and Catalyst
# versioned frameworks fail codesign with "bundle format is ambiguous".
resign_xcframework_slices() {
  local module="$1"
  local lowercaseModule
  lowercaseModule=$(echo "$module" | tr '[:upper:]' '[:lower:]')
  local moduleDir="$SCRIPT_DIR/../ios-$lowercaseModule"
  local framework
  while IFS= read -r -d '' framework; do
    echo "  · $framework"
    codesign --force --sign - --timestamp=none "$framework"
  done < <(find "$moduleDir/$module.xcframework" -type d -name '*.framework' \
    ! -path '*-maccatalyst/*' ! -path '*/tvos-*/*' -print0)
}

for module in "${MODULES[@]}"; do
  echo "→ Removing Swift compiler generated files for $module"
  remove_swift_compiler_generated_files "$module"
  echo "→ Re-signing $module xcframework slices"
  resign_xcframework_slices "$module"
done

# - Cleanup run
echo "→ Cleaning up"
rm -rf artifacts