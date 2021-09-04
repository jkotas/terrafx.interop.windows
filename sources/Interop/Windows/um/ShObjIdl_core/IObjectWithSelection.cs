// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C9CD5BB-98E9-4491-A60F-31AACC72B83C")]
    [NativeTypeName("struct IObjectWithSelection : IUnknown")]
    public unsafe partial struct IObjectWithSelection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithSelection*, uint>)(lpVtbl[1]))((IObjectWithSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithSelection*, uint>)(lpVtbl[2]))((IObjectWithSelection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelection(IShellItemArray* psia)
        {
            return ((delegate* unmanaged<IObjectWithSelection*, IShellItemArray*, int>)(lpVtbl[3]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), psia);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IObjectWithSelection*, Guid*, void**, int>)(lpVtbl[4]))((IObjectWithSelection*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
