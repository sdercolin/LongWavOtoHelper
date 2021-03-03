using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;

namespace LongWavOtoHelper
{
    class WavUtil
    {
        public static double GetDurationMs(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var length100Ns = (ulong)prop.ValueAsObject;
                return length100Ns / 10000;
            }
        }
    }
}
