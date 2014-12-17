// Guids.cs
// MUST match guids.h
using System;

namespace 迹I柳燕.FormatArrangement
{
    static class GuidList
    {
        public const string guidFormatArrangementPkgString = "6273ccde-7c8b-4f45-b234-6518819dc0fd";
        public const string guidFormatArrangementCmdSetString = "04d14637-e8d0-48e5-a6c3-3029e352908e";

        public static readonly Guid guidFormatArrangementCmdSet = new Guid(guidFormatArrangementCmdSetString);
    };
}