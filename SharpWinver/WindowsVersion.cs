﻿using System;

namespace SharpWinver;

using Core;

public static partial class Winver
{
    /// <summary>
    /// 当前运行的 Windows 系统版本
    /// </summary>
    public static class WindowsVersion
    {
        /// <summary>
        /// Windows 系统版本代号
        /// </summary>
        /// <example>
        /// RTM; SP1; SP2; 1709; 1903; 21H2; 22H2
        /// </example>
        public static string VersionTag
        {
            get
            {
                string? osVersionTag = WinVersionEx.GetWindowsVersionTag();
                return osVersionTag ?? ConstantStrings.InfoIsUnknown;
            }
        }

        /// <summary>
        /// Windows NT 内核版本
        /// </summary>
        /// <example>
        /// 6.0.6000; 6.1.7600; 10.0.16299; 10.0.22000
        /// </example>
        public static Version NTVersion
        {
            get
            {
                uint[] ntVersionNum = WinNTVersion.GetWinNTVersionNumbers();
                return new((int)ntVersionNum[0], (int)ntVersionNum[1], (int)ntVersionNum[2]);
            }
        }

        /// <summary>
        /// Windows 操作系统版本
        /// </summary>
        /// <example>
        /// 6.1.7601.0; 6.2.9200.16384; 10.0.18362.1; 10.0.22621.1533
        /// </example>
        public static Version OSVersion
        {
            get
            {
                Version ntVersion = NTVersion;
                int revision = (int)WinVersionEx.GetWindowsRevisionNumber();
                return new(ntVersion.Major, ntVersion.Minor, ntVersion.Build, revision);
            }
        }
    }
}
