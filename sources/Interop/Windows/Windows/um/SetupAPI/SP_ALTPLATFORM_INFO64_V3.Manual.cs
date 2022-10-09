// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct SP_ALTPLATFORM_INFO64_V3
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint Platform;

    [NativeTypeName("DWORD")]
    public uint MajorVersion;

    [NativeTypeName("DWORD")]
    public uint MinorVersion;

    [NativeTypeName("WORD")]
    public ushort ProcessorArchitecture;

    [NativeTypeName("_SP_ALTPLATFORM_INFO_V3::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/SetupAPI.h:164:5)")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint FirstValidatedMajorVersion;

    [NativeTypeName("DWORD")]
    public uint FirstValidatedMinorVersion;

    public byte ProductType;

    [NativeTypeName("WORD")]
    public ushort SuiteMask;

    [NativeTypeName("DWORD")]
    public uint BuildNumber;

    [UnscopedRef]
    public ref ushort Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Reserved;
        }
    }

    [UnscopedRef]
    public ref ushort Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Flags;
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Reserved;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Flags;
    }
}
