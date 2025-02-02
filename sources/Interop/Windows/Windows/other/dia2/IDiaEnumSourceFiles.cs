// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles"]/*' />
[Guid("10F3DBD9-664F-4469-B808-9471C7A50538")]
[NativeTypeName("struct IDiaEnumSourceFiles : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumSourceFiles : IDiaEnumSourceFiles.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumSourceFiles));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, uint>)(lpVtbl[1]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, uint>)(lpVtbl[2]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, int*, int>)(lpVtbl[4]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSourceFile** sourceFile)
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, uint, IDiaSourceFile**, int>)(lpVtbl[5]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this), index, sourceFile);
    }

    /// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSourceFile** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, uint, IDiaSourceFile**, uint*, int>)(lpVtbl[6]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, uint, int>)(lpVtbl[7]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, int>)(lpVtbl[8]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumSourceFiles.xml' path='doc/member[@name="IDiaEnumSourceFiles.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(IDiaEnumSourceFiles** ppenum)
    {
        return ((delegate* unmanaged<IDiaEnumSourceFiles*, IDiaEnumSourceFiles**, int>)(lpVtbl[9]))((IDiaEnumSourceFiles*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSourceFile** sourceFile);

        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSourceFile** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(7)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(8)]
        HRESULT Reset();

        [VtblIndex(9)]
        HRESULT Clone(IDiaEnumSourceFiles** ppenum);
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__NewEnum;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (DWORD, IDiaSourceFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSourceFile**, int> Item;

        [NativeTypeName("HRESULT (ULONG, IDiaSourceFile **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSourceFile**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumSourceFiles **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSourceFiles**, int> Clone;
    }
}
