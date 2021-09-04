// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct IMEMENUITEMINFOW
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint fType;

        [NativeTypeName("UINT")]
        public uint fState;

        [NativeTypeName("UINT")]
        public uint wID;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmpChecked;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmpUnchecked;

        [NativeTypeName("DWORD")]
        public uint dwItemData;

        [NativeTypeName("WCHAR [80]")]
        public fixed ushort szString[80];

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmpItem;
    }
}
