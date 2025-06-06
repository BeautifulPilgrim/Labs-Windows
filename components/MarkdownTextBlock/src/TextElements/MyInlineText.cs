// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CommunityToolkit.Labs.WinUI.MarkdownTextBlock.TextElements;
#if !WINAPPSDK
using Windows.UI.Xaml.Documents;

#else
using Microsoft.UI.Xaml.Documents;
#endif
internal class MyInlineText : IAddChild
{
    private Run _run;

    public TextElement TextElement
    {
        get => _run;
    }

    public MyInlineText(string text)
    {
        _run = new Run()
        {
            Text = text
        };
    }

    public void AddChild(IAddChild child) { }
}
