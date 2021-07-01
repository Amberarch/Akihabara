﻿using System;
using System.Runtime.InteropServices;

namespace Akihabara.Native.Framework
{
    public partial class UnsafeNativeMethods : NativeMethods
    {
        [DllImport (MediaPipeLibrary, ExactSpelling = true)]
        public static extern MpReturnCode mp_api__ConvertFromCalculatorGraphConfigTextFormat(string configText, out IntPtr serializedProto);        
    }
}