[![](https://img.shields.io/nuget/v/Soenneker.Blazor.Navigation.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Blazor.Navigation/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.navigation/main.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.navigation/actions/workflows/main.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Blazor.Navigation.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Blazor.Navigation/)

# Soenneker.Blazor.Navigation
### A small Blazor WebAssembly library that features navigate back, login/logout, reload and more

Can work side-by-side existing Blazor [NavigationManager](https://learn.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-7.0) usage, and still work with navigate back

## Installation

```
Install-Package Soenneker.Blazor.Navigation
```

## Usage

1. Register `INavigationUtil` within `Program.cs` or wherever your registering your services:

```csharp
public static async Task Main(string[] args)
{
    ...
    builder.Services.AddNavigation();
}
```

2. Warm it up so it can begin recording navigation history. Call after the `WebAssemblyHost` has been built:

```csharp
public static async Task Main(string[] args)
{
    ...
    WebAssemblyHost host = builder.Build();

    host.Services.WarmupNavigation();
}
```

3. Inject `INavigationUtil` within pages/components where you need to access navigation methods:


```csharp
@using Soenneker.Blazor.Navigation.Abstract
@inject INavigationUtil NavigationUtil
```


### Navigating back 
```csharp
NavigationUtil.NavigateBack();
```

### Logging in/out

```csharp
// Pairs nicely with MSAL defaults
NavigationUtil.Logout();
NavigationUtil.Login();
```

### Navigating
```csharp
// within the SPA client
NavigationUtil.NavigateTo("/users");

// forcing a page load
NavigationUtil.NavigateTo("/users", true);
```