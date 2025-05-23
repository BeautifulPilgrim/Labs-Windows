// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace CommunityToolkit.Notifications;

/// <summary>
/// Actions to display on a Toast notification. One of <see cref="ToastActionsCustom"/> or <see cref="ToastActionsSnoozeAndDismiss"/>.
/// </summary>
public interface IToastActions
{
    /// <summary>
    /// Gets custom context menu items, providing additional actions when the user right clicks the Toast notification. New in Anniversary Update
    /// </summary>
    IList<ToastContextMenuItem> ContextMenuItems { get; }
}
