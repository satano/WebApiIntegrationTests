# WebApiIntegrationTests

This is a demo project to show a bug in ASP.NET Core Integration tests when the tests are not working if the SUT (target API/application) does not have specified version in reference to `Microsoft.AspNetCore.App`.

`DemoApi` and `DemoApi_WithVersion` are two identical web API apllications. The only difference is that the package reference to `Microsoft.AspNetCore.App` is added with and without version specification.

- DemoApi: [\<PackageReference Include="Microsoft.AspNetCore.App" /\>](https://github.com/satano/WebApiIntegrationTests/blob/master/DemoApi/DemoApi.csproj#L9)
- DemoApi_WithVersion: [\<PackageReference Include="Microsoft.AspNetCore.App" Version="2.2.0" /\>](https://github.com/satano/WebApiIntegrationTests/blob/master/DemoApi_WithVersion/DemoApi_WithVersion.csproj#L9)

The correct approach is **not to** specify version number. If it is specified, the compiler generates warning:

> Warning	NETSDK1071 A PackageReference to 'Microsoft.AspNetCore.App' specified a Version of `2.2.0`. Specifying the version of this package is not recommended. For more information, see https://aka.ms/sdkimplicitrefs

**But if the version is not specified, the integration tests are not working, if inherited `Startup` class is used.** If the original `Startup` from the SUT is used, the tests are working correctly.

We use inherited `Startup` class for our integration tests, because we have different initialization logic, different services etc.
