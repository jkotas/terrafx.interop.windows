// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("A65C9109-42AB-4B94-A7B1-DD2E4E68515E")]
[NativeTypeName("struct IUnbufferedFileHandleProvider : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IUnbufferedFileHandleProvider : IUnbufferedFileHandleProvider.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, Guid*, void**, int>)(lpVtbl[0]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, uint>)(lpVtbl[1]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, uint>)(lpVtbl[2]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OpenUnbufferedFileHandle(IUnbufferedFileHandleOplockCallback* oplockBreakCallback, [NativeTypeName("DWORD_PTR *")] nuint* fileHandle)
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, IUnbufferedFileHandleOplockCallback*, nuint*, int>)(lpVtbl[3]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this), oplockBreakCallback, fileHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CloseUnbufferedFileHandle()
    {
        return ((delegate* unmanaged<IUnbufferedFileHandleProvider*, int>)(lpVtbl[4]))((IUnbufferedFileHandleProvider*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OpenUnbufferedFileHandle(IUnbufferedFileHandleOplockCallback* oplockBreakCallback, [NativeTypeName("DWORD_PTR *")] nuint* fileHandle);

        [VtblIndex(4)]
        HRESULT CloseUnbufferedFileHandle();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleProvider*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleProvider*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleProvider*, uint> Release;

        [NativeTypeName("HRESULT (IUnbufferedFileHandleOplockCallback *, DWORD_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleProvider*, IUnbufferedFileHandleOplockCallback*, nuint*, int> OpenUnbufferedFileHandle;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IUnbufferedFileHandleProvider*, int> CloseUnbufferedFileHandle;
    }
}
