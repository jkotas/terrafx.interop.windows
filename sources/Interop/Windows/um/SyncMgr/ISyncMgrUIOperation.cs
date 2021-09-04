// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC7CFA47-DFE1-45B5-A049-8CFD82BEC271")]
    [NativeTypeName("struct ISyncMgrUIOperation : IUnknown")]
    public unsafe partial struct ISyncMgrUIOperation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrUIOperation*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrUIOperation*, uint>)(lpVtbl[1]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrUIOperation*, uint>)(lpVtbl[2]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Run([NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<ISyncMgrUIOperation*, IntPtr, int>)(lpVtbl[3]))((ISyncMgrUIOperation*)Unsafe.AsPointer(ref this), hwndOwner);
        }
    }
}
