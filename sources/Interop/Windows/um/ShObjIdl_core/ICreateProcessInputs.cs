// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F6EF6140-E26F-4D82-BAC4-E9BA5FD239A8")]
    [NativeTypeName("struct ICreateProcessInputs : IUnknown")]
    public unsafe partial struct ICreateProcessInputs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, Guid*, void**, int>)(lpVtbl[0]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, uint>)(lpVtbl[1]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, uint>)(lpVtbl[2]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCreateFlags([NativeTypeName("DWORD *")] uint* pdwCreationFlags)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, uint*, int>)(lpVtbl[3]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), pdwCreationFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCreateFlags([NativeTypeName("DWORD")] uint dwCreationFlags)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, uint, int>)(lpVtbl[4]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), dwCreationFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddCreateFlags([NativeTypeName("DWORD")] uint dwCreationFlags)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, uint, int>)(lpVtbl[5]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), dwCreationFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHotKey([NativeTypeName("WORD")] ushort wHotKey)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, ushort, int>)(lpVtbl[6]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), wHotKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddStartupFlags([NativeTypeName("DWORD")] uint dwStartupInfoFlags)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, uint, int>)(lpVtbl[7]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), dwStartupInfoFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, ushort*, int>)(lpVtbl[8]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), pszTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszValue)
        {
            return ((delegate* unmanaged<ICreateProcessInputs*, ushort*, ushort*, int>)(lpVtbl[9]))((ICreateProcessInputs*)Unsafe.AsPointer(ref this), pszName, pszValue);
        }
    }
}
