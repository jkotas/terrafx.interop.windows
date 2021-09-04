// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8A68FDDA-1FDC-4C20-8CEB-416643B5A625")]
    [NativeTypeName("struct IStreamUnbufferedInfo : IUnknown")]
    public unsafe partial struct IStreamUnbufferedInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamUnbufferedInfo*, Guid*, void**, int>)(lpVtbl[0]))((IStreamUnbufferedInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamUnbufferedInfo*, uint>)(lpVtbl[1]))((IStreamUnbufferedInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamUnbufferedInfo*, uint>)(lpVtbl[2]))((IStreamUnbufferedInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSectorSize([NativeTypeName("ULONG *")] uint* pcbSectorSize)
        {
            return ((delegate* unmanaged<IStreamUnbufferedInfo*, uint*, int>)(lpVtbl[3]))((IStreamUnbufferedInfo*)Unsafe.AsPointer(ref this), pcbSectorSize);
        }
    }
}
