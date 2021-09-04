// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D92995F8-CF5E-4A76-BF59-EAD39EA2B97E")]
    [NativeTypeName("struct INamespaceWalkCB : IUnknown")]
    public unsafe partial struct INamespaceWalkCB
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INamespaceWalkCB*, Guid*, void**, int>)(lpVtbl[0]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INamespaceWalkCB*, uint>)(lpVtbl[1]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INamespaceWalkCB*, uint>)(lpVtbl[2]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FoundItem(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<INamespaceWalkCB*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[3]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), psf, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnterFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<INamespaceWalkCB*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[4]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), psf, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LeaveFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<INamespaceWalkCB*, IShellFolder*, ITEMIDLIST*, int>)(lpVtbl[5]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), psf, pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitializeProgressDialog([NativeTypeName("LPWSTR *")] ushort** ppszTitle, [NativeTypeName("LPWSTR *")] ushort** ppszCancel)
        {
            return ((delegate* unmanaged<INamespaceWalkCB*, ushort**, ushort**, int>)(lpVtbl[6]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), ppszTitle, ppszCancel);
        }
    }
}
