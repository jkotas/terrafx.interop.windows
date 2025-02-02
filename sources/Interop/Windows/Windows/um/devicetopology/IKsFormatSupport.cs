// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IKsFormatSupport.xml' path='doc/member[@name="IKsFormatSupport"]/*' />
[Guid("3CB4A69D-BB6F-4D2B-95B7-452D2C155DB5")]
[NativeTypeName("struct IKsFormatSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsFormatSupport : IKsFormatSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsFormatSupport));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsFormatSupport*, Guid*, void**, int>)(lpVtbl[0]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKsFormatSupport*, uint>)(lpVtbl[1]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsFormatSupport*, uint>)(lpVtbl[2]))((IKsFormatSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IKsFormatSupport.xml' path='doc/member[@name="IKsFormatSupport.IsFormatSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsFormatSupported([NativeTypeName("PKSDATAFORMAT")] KSDATAFORMAT* pKsFormat, [NativeTypeName("DWORD")] uint cbFormat, BOOL* pbSupported)
    {
        return ((delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT*, uint, BOOL*, int>)(lpVtbl[3]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), pKsFormat, cbFormat, pbSupported);
    }

    /// <include file='IKsFormatSupport.xml' path='doc/member[@name="IKsFormatSupport.GetDevicePreferredFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDevicePreferredFormat([NativeTypeName("PKSDATAFORMAT *")] KSDATAFORMAT** ppKsFormat)
    {
        return ((delegate* unmanaged<IKsFormatSupport*, KSDATAFORMAT**, int>)(lpVtbl[4]))((IKsFormatSupport*)Unsafe.AsPointer(ref this), ppKsFormat);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsFormatSupported([NativeTypeName("PKSDATAFORMAT")] KSDATAFORMAT* pKsFormat, [NativeTypeName("DWORD")] uint cbFormat, BOOL* pbSupported);

        [VtblIndex(4)]
        HRESULT GetDevicePreferredFormat([NativeTypeName("PKSDATAFORMAT *")] KSDATAFORMAT** ppKsFormat);
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

        [NativeTypeName("HRESULT (PKSDATAFORMAT, DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, KSDATAFORMAT*, uint, BOOL*, int> IsFormatSupported;

        [NativeTypeName("HRESULT (PKSDATAFORMAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, KSDATAFORMAT**, int> GetDevicePreferredFormat;
    }
}
