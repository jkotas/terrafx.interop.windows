// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class LIBID
{
    public static ref readonly Guid LIBID_UIAnimation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0x24, 0xCA, 0x44,
                    0x92, 0x1A,
                    0x49, 0x41,
                    0xBA,
                    0xB5,
                    0xFB,
                    0x14,
                    0xD6,
                    0x4B,
                    0x40,
                    0x1E
                };

            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
