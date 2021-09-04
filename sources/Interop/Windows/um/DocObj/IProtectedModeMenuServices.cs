// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73C105EE-9DFF-4A07-B83C-7EFF290C266E")]
    [NativeTypeName("struct IProtectedModeMenuServices : IUnknown")]
    public unsafe partial struct IProtectedModeMenuServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProtectedModeMenuServices*, Guid*, void**, int>)(lpVtbl[0]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProtectedModeMenuServices*, uint>)(lpVtbl[1]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProtectedModeMenuServices*, uint>)(lpVtbl[2]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMenu([NativeTypeName("HMENU *")] IntPtr* phMenu)
        {
            return ((delegate* unmanaged<IProtectedModeMenuServices*, IntPtr*, int>)(lpVtbl[3]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), phMenu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadMenuW([NativeTypeName("LPCWSTR")] ushort* pszModuleName, [NativeTypeName("LPCWSTR")] ushort* pszMenuName, [NativeTypeName("HMENU *")] IntPtr* phMenu)
        {
            return ((delegate* unmanaged<IProtectedModeMenuServices*, ushort*, ushort*, IntPtr*, int>)(lpVtbl[4]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), pszModuleName, pszMenuName, phMenu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadMenuID([NativeTypeName("LPCWSTR")] ushort* pszModuleName, [NativeTypeName("WORD")] ushort wResourceID, [NativeTypeName("HMENU *")] IntPtr* phMenu)
        {
            return ((delegate* unmanaged<IProtectedModeMenuServices*, ushort*, ushort, IntPtr*, int>)(lpVtbl[5]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), pszModuleName, wResourceID, phMenu);
        }
    }
}
