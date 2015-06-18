﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebsitePanel.Providers
{
    public class LogExtensionHelper
    {
        public const string LOG_STRING_TEMPLATE = "{0}: {1}";

        public static string CombineString(string name, string value)
        {
            return String.Format(LOG_STRING_TEMPLATE, name, value);
        }

        public static string DecorateName(string name)
        {
            var newName = Regex.Replace(name, @"((?<=\p{Ll})\p{Lu})|((?!\A)\p{Lu}(?>\p{Ll}))", " $0"); // "DriveIsSCSICompatible" becomes "Drive Is SCSI Compatible"
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(newName); // Capitalize
        }

        public static string GetString(object value)
        {
            if (value == null)
                return "";

            return value.ToString();
        }
    }
}
