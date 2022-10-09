// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct DRAGINFOA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(DRAGINFO32A));
            }
            else
            {
                return (uint)(sizeof(DRAGINFO64A));
            }
        }
    }

    [FieldOffset(0)]
    public DRAGINFO32A _value32;

    [FieldOffset(0)]
    public DRAGINFO64A _value64;

    [UnscopedRef]
    public ref uint uSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.uSize;
            }
            else
            {
                return ref _value64.uSize;
            }
        }
    }

    [UnscopedRef]
    public ref POINT pt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pt;
            }
            else
            {
                return ref _value64.pt;
            }
        }
    }

    [UnscopedRef]
    public ref BOOL fNC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.fNC;
            }
            else
            {
                return ref _value64.fNC;
            }
        }
    }

    [NativeTypeName("PZZSTR")]
    [UnscopedRef]
    public ref sbyte* lpFileList
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpFileList;
            }
            else
            {
                return ref _value64.lpFileList;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint grfKeyState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.grfKeyState;
            }
            else
            {
                return ref _value64.grfKeyState;
            }
        }
    }
}
