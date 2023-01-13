using System;
using Microsoft.Extensions.DependencyInjection;
using Soenneker.Blazor.Navigation.Abstract;

namespace Soenneker.Blazor.Navigation.Extensions;

public static class NavigationRegistrar
{
    /// <summary>
    /// Shorthand for <code>services.AddScoped</code>
    /// </summary>
    public static void AddNavigation(this IServiceCollection services)
    {
        services.AddScoped<INavigationUtil, NavigationUtil>();
    }

    /// <summary>
    /// Call AFTER the WebAssembly/IServiceProvider has been built, aka builder.Build()
    /// </summary>
    /// <param name="provider"></param>
    public static void WarmupNavigation(this IServiceProvider provider)
    {
        provider.GetService<INavigationUtil>();
    }
}