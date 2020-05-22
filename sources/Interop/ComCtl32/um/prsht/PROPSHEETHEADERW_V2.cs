// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETHEADERW_V2
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/prsht.h:526:5)")]
        public _Anonymous_e__Union1 Anonymous1;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszCaption;

        [NativeTypeName("UINT")]
        public uint nPages;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/prsht.h:526:5)")]
        public _Anonymous_e__Union2 Anonymous2;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/prsht.h:526:5)")]
        public _Anonymous_e__Union3 Anonymous3;

        [NativeTypeName("PFNPROPSHEETCALLBACK")]
        public IntPtr pfnCallback;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/prsht.h:527:5)")]
        public _Anonymous_e__Union4 Anonymous4;

        [NativeTypeName("HPALETTE")]
        public IntPtr hplWatermark;

        [NativeTypeName("_PROPSHEETHEADERW_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/prsht.h:533:5)")]
        public _Anonymous_e__Union5 Anonymous5;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union1
        {
            [FieldOffset(0)]
            [NativeTypeName("HICON")]
            public IntPtr hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszIcon;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union2
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint nStartPage;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pStartPage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union3
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCPROPSHEETPAGEW")]
            public PROPSHEETPAGEW* ppsp;

            [FieldOffset(0)]
            [NativeTypeName("HPROPSHEETPAGE *")]
            public IntPtr* phpage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union4
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hbmWatermark;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszbmWatermark;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union5
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hbmHeader;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszbmHeader;
        }
    }
}
