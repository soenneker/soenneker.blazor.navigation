﻿using System;
using System.Collections.Generic;

namespace Soenneker.Blazor.Navigation.Abstract;

/// <summary>
/// Register as Scoped.
/// </summary>
public interface INavigationUtil : IDisposable
{
    /// <summary>
    /// Navigates to the specified url.
    /// </summary>
    /// <param name="uri">The destination url (relative or absolute).</param>
    /// <param name="forceLoad"></param>
    void NavigateTo(string uri, bool forceLoad = false);

    /// <summary>
    /// Navigates to the specified url with query strings attached (in dictionary form)
    /// </summary>
    /// <param name="uri">The destination url (relative or absolute).</param>
    /// <param name="queryString"></param>
    /// <param name="forceLoad"></param>
    void NavigateTo(string uri, IDictionary<string, string> queryString, bool forceLoad = false);

    /// <summary>
    /// Returns true if it is possible to navigate to the previous UR.
    /// </summary>
    bool CanNavigateBack { get; }

    /// <summary>
    /// Reloads at the current URI.
    /// </summary>
    void Reload(bool forceLoad);

    /// <summary>
    /// Navigates to the previous url if possible or does nothing if it is not.
    /// </summary>
    void NavigateBack();

    void Login(string logoutPath = "authentication/login");

    void Logout(string logoutPath = "authentication/logout");

    Uri GetCurrentUri();
}