﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace TeleBotMessenger.Helper
{
    public static class Emoji
    {
        public static Dictionary<string, Bitmap> EmojiBitmap { get; } = new Dictionary<string, Bitmap>();

        static Emoji()
        {
            var properties = typeof(Properties.EmojiResources).GetProperties();

            foreach (var prop in properties)
            {
                if (prop.PropertyType == typeof(Bitmap))
                {
                    var image = (Bitmap) prop.GetValue(null);
                    var names = prop.Name.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                    EmojiBitmap[names[0]] = image;
                }
            }
        }
    }
}
