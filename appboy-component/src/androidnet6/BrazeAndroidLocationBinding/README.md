# BrazeAndroidLocationBinding

This binding provides location and geofence support for the Braze Android SDK in .NET MAUI applications.

## Installation

### Via NuGet

```bash
dotnet add package BrazePlatform.BrazeAndroidLocationBinding
```

### Via Project Reference

Add a reference to the binding project in your `.csproj`:

```xml
<ItemGroup>
  <ProjectReference Include="path/to/BrazeAndroidLocationBinding.csproj" />
</ItemGroup>
```

## Configuration

### 1. Add Required Permissions

Add the following permissions to your `AndroidManifest.xml`:

```xml
<!-- Location permissions -->
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />

<!-- Required for geofences on Android 10+ -->
<uses-permission android:name="android.permission.ACCESS_BACKGROUND_LOCATION" />
```

### 2. Register the BrazeActionReceiver

Add the following to your `AndroidManifest.xml` inside the `<application>` tag:

```xml
<receiver
    android:name="com.braze.location.BrazeActionReceiver"
    android:exported="false">
    <intent-filter>
        <action android:name="com.braze.location.intent.action.GEOFENCE_UPDATE" />
        <action android:name="com.braze.location.intent.action.SINGLE_LOCATION_UPDATE" />
    </intent-filter>
</receiver>
```

### 3. Enable Location in Braze Configuration

In your `Resources/values/Braze.xml`, add:

```xml
<bool name="com_braze_enable_location_collection">true</bool>
<bool name="com_braze_geofences_enabled">true</bool>
```

### 4. Request Permissions at Runtime

In your `MainActivity.cs` or appropriate location:

```csharp
// Request location permissions
if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.AccessFineLocation) 
    != Permission.Granted)
{
    ActivityCompat.RequestPermissions(this, 
        new string[] { 
            Manifest.Permission.AccessFineLocation,
            Manifest.Permission.AccessCoarseLocation 
        }, 
        LOCATION_PERMISSION_REQUEST_CODE);
}

// For Android 10+, also request background location for geofences
if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
{
    if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.AccessBackgroundLocation) 
        != Permission.Granted)
    {
        ActivityCompat.RequestPermissions(this,
            new string[] { Manifest.Permission.AccessBackgroundLocation },
            BACKGROUND_LOCATION_PERMISSION_REQUEST_CODE);
    }
}
```

## Dependencies

This binding requires:
- `BrazePlatform.BrazeAndroidBinding` (base Braze SDK binding)
- `Xamarin.GooglePlayServices.Location` (Google Play Services Location)
- `Xamarin.Kotlin.StdLib`
- `Xamarin.KotlinX.Coroutines.Android`

## How It Works

The Braze Android SDK uses an optional module pattern for location:

1. The base SDK (`android-sdk-base`) contains interfaces and managers for location/geofences
2. This location module (`android-sdk-location`) provides the Google Play Services implementation
3. The SDK automatically detects the location module via reflection and enables location features

When this binding is included in your project:
- `BrazeLocationManager` will use Google Play Services for location updates
- `BrazeGeofenceManager` will register geofences with Google Play Services
- Location events and geofence transitions will be reported to Braze

## Key Classes

- `BrazeInternalLocationApi` - Location service implementation
- `BrazeInternalGeofenceApi` - Geofence service implementation
- `BrazeActionReceiver` - BroadcastReceiver for location/geofence events
- `GooglePlayLocationUtils` - Utility for Google Play Services integration
