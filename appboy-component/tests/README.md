# Braze Xamarin SDK Unit Tests

Unit test infrastructure for the Braze Xamarin SDK using [xUnit](https://xunit.net/), which is the recommended testing framework according to the [.NET MAUI documentation](https://learn.microsoft.com/en-us/dotnet/maui/deployment/unit-testing).

## Structure

- **Braze.iOS.Tests**: Verifies every iOS binding project file (`appboy-component/src/ios-*/*.csproj`) exists.
- **Braze.Android.Tests**: Verifies every Android binding project file (`appboy-component/src/android*/**/*.csproj`) exists.

That's currently the entire test surface, and that's intentional — see [Why so little?](#why-so-little) below.

## Running Tests Locally

Run all tests:
```bash
dotnet test appboy-component/tests/Braze.Tests.sln
```

Run tests for a specific project:
```bash
dotnet test appboy-component/tests/Braze.iOS.Tests/Braze.iOS.Tests.csproj
```

Run tests with verbose output:
```bash
dotnet test appboy-component/tests/Braze.Tests.sln -v d
```

Run a specific test:
```bash
dotnet test appboy-component/tests/Braze.Tests.sln --filter "FullyQualifiedName~BindingProjectExists"
```

## CI/CD Integration

Tests run automatically in the Buildkite pipeline as part of each build:
- Test results are captured in TRX format
- Code coverage is collected via `--collect:"XPlat Code Coverage"` (see [scripts/README.md](../../scripts/README.md) for why it currently reports `n/a`)

## Why so little?

`appboy-component/src` is a Xamarin **binding** SDK. Its `.cs` files
(`ApiDefinitions.cs`, `StructsAndEnums.cs`, `AssemblyInfo.cs`) are declarative
`[Export]`/`[BaseType]` interfaces consumed by the Xamarin binding generator, or plain
enum/struct declarations — not executable C# logic. There is nothing there for a unit
test to meaningfully exercise, and adding tests that assert against hardcoded literals
or unrelated .NET/BCL behavior (e.g. `Guid.NewGuid()`, `Enum.TryParse`, string validation
helpers invented for the test itself) doesn't test the SDK — it just pads the test count.
Don't add tests like that back in.

**What *is* worth testing:** bespoke C# occasionally gets added on top of the generated
bindings under an `Additions/` folder — partial classes and native-interop helpers with
real logic. See [PR #287](https://github.com/braze-inc/xamarin-sdk/pull/287)
(`Card.Extras.cs`, `BrazeJavaStringMap.cs`) for a concrete example. Once code like that
merges into `develop`, that's the surface to add real coverage for — see the "Coverage
Expectations" section in [scripts/README.md](../../scripts/README.md) for the platform
constraints involved (those files depend on `Mono.Android`/`ObjCRuntime` types and, for
anything touching JNI/native calls directly, a real emulator/simulator to execute at all).

## Adding New Tests

Only add a test if it asserts something concretely true (or false) about this repo's
actual code or structure — not an invented helper, not a hardcoded literal, not generic
language/framework behavior. If a test can't fail because of something *this SDK* did
wrong, it doesn't belong here.

## Resources

- [xUnit Documentation](https://xunit.net/)
- [Microsoft: Unit testing MAUI apps](https://learn.microsoft.com/en-us/dotnet/maui/deployment/unit-testing)
