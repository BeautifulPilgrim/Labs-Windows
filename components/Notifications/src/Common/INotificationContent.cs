// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Windows.Data.Xml.Dom;

namespace CommunityToolkit.Notifications;

/// <summary>
/// Base notification content interface to retrieve notification Xml as a string.
/// </summary>
public interface INotificationContent
{
    /// <summary>
    /// Retrieves the notification Xml content as a string.
    /// </summary>
    /// <returns>The notification Xml content as a string.</returns>
    string GetContent();

    /// <summary>
    /// Retrieves the notification Xml content as a WinRT Xml document.
    /// </summary>
    /// <returns>The notification Xml content as a WinRT Xml document.</returns>
    XmlDocument GetXml();
}
