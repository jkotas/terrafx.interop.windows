// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct FILE_IN_CABINET_INFO64_A
{
    [NativeTypeName("PCSTR")]
    public sbyte* NameInCabinet;

    [NativeTypeName("DWORD")]
    public uint FileSize;

    [NativeTypeName("DWORD")]
    public uint Win32Error;

    [NativeTypeName("WORD")]
    public ushort DosDate;

    [NativeTypeName("WORD")]
    public ushort DosTime;

    [NativeTypeName("WORD")]
    public ushort DosAttribs;

    [NativeTypeName("CHAR [260]")]
    public fixed sbyte FullTargetName[260];
}
