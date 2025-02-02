// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFMuxStreamMediaTypeManager.xml' path='doc/member[@name="IMFMuxStreamMediaTypeManager"]/*' />
[Guid("505A2C72-42F7-4690-AEAB-8F513D0FFDB8")]
[NativeTypeName("struct IMFMuxStreamMediaTypeManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFMuxStreamMediaTypeManager : IMFMuxStreamMediaTypeManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMuxStreamMediaTypeManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, uint>)(lpVtbl[1]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, uint>)(lpVtbl[2]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMuxStreamMediaTypeManager.xml' path='doc/member[@name="IMFMuxStreamMediaTypeManager.GetStreamCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, uint*, int>)(lpVtbl[3]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), pdwMuxStreamCount);
    }

    /// <include file='IMFMuxStreamMediaTypeManager.xml' path='doc/member[@name="IMFMuxStreamMediaTypeManager.GetMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMediaType([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, uint, IMFMediaType**, int>)(lpVtbl[4]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), dwMuxStreamIndex, ppMediaType);
    }

    /// <include file='IMFMuxStreamMediaTypeManager.xml' path='doc/member[@name="IMFMuxStreamMediaTypeManager.GetStreamConfigurationCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStreamConfigurationCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, uint*, int>)(lpVtbl[5]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IMFMuxStreamMediaTypeManager.xml' path='doc/member[@name="IMFMuxStreamMediaTypeManager.AddStreamConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddStreamConfiguration([NativeTypeName("ULONGLONG")] ulong ullStreamMask)
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, ulong, int>)(lpVtbl[6]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), ullStreamMask);
    }

    /// <include file='IMFMuxStreamMediaTypeManager.xml' path='doc/member[@name="IMFMuxStreamMediaTypeManager.RemoveStreamConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveStreamConfiguration([NativeTypeName("ULONGLONG")] ulong ullStreamMask)
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, ulong, int>)(lpVtbl[7]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), ullStreamMask);
    }

    /// <include file='IMFMuxStreamMediaTypeManager.xml' path='doc/member[@name="IMFMuxStreamMediaTypeManager.GetStreamConfiguration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamConfiguration([NativeTypeName("DWORD")] uint ulIndex, [NativeTypeName("ULONGLONG *")] ulong* pullStreamMask)
    {
        return ((delegate* unmanaged<IMFMuxStreamMediaTypeManager*, uint, ulong*, int>)(lpVtbl[8]))((IMFMuxStreamMediaTypeManager*)Unsafe.AsPointer(ref this), ulIndex, pullStreamMask);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount);

        [VtblIndex(4)]
        HRESULT GetMediaType([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFMediaType** ppMediaType);

        [VtblIndex(5)]
        HRESULT GetStreamConfigurationCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(6)]
        HRESULT AddStreamConfiguration([NativeTypeName("ULONGLONG")] ulong ullStreamMask);

        [VtblIndex(7)]
        HRESULT RemoveStreamConfiguration([NativeTypeName("ULONGLONG")] ulong ullStreamMask);

        [VtblIndex(8)]
        HRESULT GetStreamConfiguration([NativeTypeName("DWORD")] uint ulIndex, [NativeTypeName("ULONGLONG *")] ulong* pullStreamMask);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStreamCount;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetMediaType;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStreamConfigurationCount;

        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> AddStreamConfiguration;

        [NativeTypeName("HRESULT (ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> RemoveStreamConfiguration;

        [NativeTypeName("HRESULT (DWORD, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong*, int> GetStreamConfiguration;
    }
}
