// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SIP_CAP_SET_V3
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("BOOL")]
        public int isMultiSign;

        [NativeTypeName("_SIP_CAP_SET_V3::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/mssip.h:191:5)")]
        public _Anonymous_e__Union _Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwFlags;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwReserved;
        }
    }
}
