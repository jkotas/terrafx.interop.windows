// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1791E8F6-21C7-4340-882A-A6A93E3FD73B")]
    [NativeTypeName("struct ILaunchUIContext : IUnknown")]
    public unsafe partial struct ILaunchUIContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILaunchUIContext*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchUIContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILaunchUIContext*, uint>)(lpVtbl[1]))((ILaunchUIContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILaunchUIContext*, uint>)(lpVtbl[2]))((ILaunchUIContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAssociatedWindow([NativeTypeName("HWND")] IntPtr value)
        {
            return ((delegate* unmanaged<ILaunchUIContext*, IntPtr, int>)(lpVtbl[3]))((ILaunchUIContext*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTabGroupingPreference([NativeTypeName("DWORD")] uint value)
        {
            return ((delegate* unmanaged<ILaunchUIContext*, uint, int>)(lpVtbl[4]))((ILaunchUIContext*)Unsafe.AsPointer(ref this), value);
        }
    }
}
