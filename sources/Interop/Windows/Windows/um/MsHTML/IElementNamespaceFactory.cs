// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IElementNamespaceFactory.xml' path='doc/member[@name="IElementNamespaceFactory"]/*' />
[Guid("3050F672-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementNamespaceFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementNamespaceFactory : IElementNamespaceFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementNamespaceFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementNamespaceFactory*, Guid*, void**, int>)(lpVtbl[0]))((IElementNamespaceFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementNamespaceFactory*, uint>)(lpVtbl[1]))((IElementNamespaceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementNamespaceFactory*, uint>)(lpVtbl[2]))((IElementNamespaceFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementNamespaceFactory.xml' path='doc/member[@name="IElementNamespaceFactory.Create"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Create(IElementNamespace* pNamespace)
    {
        return ((delegate* unmanaged<IElementNamespaceFactory*, IElementNamespace*, int>)(lpVtbl[3]))((IElementNamespaceFactory*)Unsafe.AsPointer(ref this), pNamespace);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Create(IElementNamespace* pNamespace);
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

        [NativeTypeName("HRESULT (IElementNamespace *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IElementNamespace*, int> Create;
    }
}
