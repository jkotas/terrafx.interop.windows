// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("321A6A6A-D61F-4BF3-97AE-14BE2986BB36")]
    [NativeTypeName("struct IObjectWithBackReferences : IUnknown")]
    public unsafe partial struct IObjectWithBackReferences
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithBackReferences*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithBackReferences*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithBackReferences*, uint>)(lpVtbl[1]))((IObjectWithBackReferences*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithBackReferences*, uint>)(lpVtbl[2]))((IObjectWithBackReferences*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveBackReferences()
        {
            return ((delegate* unmanaged<IObjectWithBackReferences*, int>)(lpVtbl[3]))((IObjectWithBackReferences*)Unsafe.AsPointer(ref this));
        }
    }
}
