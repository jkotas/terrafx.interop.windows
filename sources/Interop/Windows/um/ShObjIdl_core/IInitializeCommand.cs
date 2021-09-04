// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("85075ACF-231F-40EA-9610-D26B7B58F638")]
    [NativeTypeName("struct IInitializeCommand : IUnknown")]
    public unsafe partial struct IInitializeCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInitializeCommand*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInitializeCommand*, uint>)(lpVtbl[1]))((IInitializeCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInitializeCommand*, uint>)(lpVtbl[2]))((IInitializeCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("LPCWSTR")] ushort* pszCommandName, IPropertyBag* ppb)
        {
            return ((delegate* unmanaged<IInitializeCommand*, ushort*, IPropertyBag*, int>)(lpVtbl[3]))((IInitializeCommand*)Unsafe.AsPointer(ref this), pszCommandName, ppb);
        }
    }
}
