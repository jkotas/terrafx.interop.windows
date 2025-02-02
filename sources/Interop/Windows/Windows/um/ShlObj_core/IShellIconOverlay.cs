// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellIconOverlay.xml' path='doc/member[@name="IShellIconOverlay"]/*' />
[Guid("7D688A70-C613-11D0-999B-00C04FD655E1")]
[NativeTypeName("struct IShellIconOverlay : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellIconOverlay : IShellIconOverlay.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellIconOverlay));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellIconOverlay*, Guid*, void**, int>)(lpVtbl[0]))((IShellIconOverlay*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellIconOverlay*, uint>)(lpVtbl[1]))((IShellIconOverlay*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellIconOverlay*, uint>)(lpVtbl[2]))((IShellIconOverlay*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellIconOverlay.xml' path='doc/member[@name="IShellIconOverlay.GetOverlayIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOverlayIndex([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int* pIndex)
    {
        return ((delegate* unmanaged<IShellIconOverlay*, ITEMIDLIST*, int*, int>)(lpVtbl[3]))((IShellIconOverlay*)Unsafe.AsPointer(ref this), pidl, pIndex);
    }

    /// <include file='IShellIconOverlay.xml' path='doc/member[@name="IShellIconOverlay.GetOverlayIconIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOverlayIconIndex([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int* pIconIndex)
    {
        return ((delegate* unmanaged<IShellIconOverlay*, ITEMIDLIST*, int*, int>)(lpVtbl[4]))((IShellIconOverlay*)Unsafe.AsPointer(ref this), pidl, pIconIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOverlayIndex([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int* pIndex);

        [VtblIndex(4)]
        HRESULT GetOverlayIconIndex([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int* pIconIndex);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int*, int> GetOverlayIndex;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, int *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int*, int> GetOverlayIconIndex;
    }
}
