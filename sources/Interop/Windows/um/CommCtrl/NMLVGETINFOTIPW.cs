// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NMLVGETINFOTIPW
    {
        public NMHDR hdr;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPWSTR")]
        public ushort* pszText;

        public int cchTextMax;

        public int iItem;

        public int iSubItem;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
