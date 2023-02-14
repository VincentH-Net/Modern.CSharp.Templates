﻿using CSharpMarkup.WinUI;

namespace UnoWinUIQuickStart;

public static class Styles
{
    // Explicit styles go here - they can follow the same pattern as implicit styles below.
    // Since Styles is a global static using, you can then e.g. do: Button("<") .Style(HeaderButton)

    public static class Implicit
    {
        static UI.ResourceDictionary? dictionary;
        static Style<TextBlock>? textBlocks;

        public static UI.ResourceDictionary Dictionary => dictionary ??= CreateResourceDictionary(
            TextBlocks
        );

        public static Style<TextBlock> TextBlocks => textBlocks ??= new(
            (Controls.TextBlock.ForegroundProperty, White)
        );

        static ResourceDictionary CreateResourceDictionary(params UI.Style[] styles)
        {
            var resources = new UI.ResourceDictionary();
            foreach (var style in styles) resources.Add(style.TargetType, style);
            return resources;
        }
    }
}
