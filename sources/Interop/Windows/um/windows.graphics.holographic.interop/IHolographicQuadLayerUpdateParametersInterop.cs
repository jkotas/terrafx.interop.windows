// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.19041.0")]
    [Guid("E5F549CD-C909-444F-8809-7CC18A9C8920")]
    [NativeTypeName("struct IHolographicQuadLayerUpdateParametersInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IHolographicQuadLayerUpdateParametersInterop : IHolographicQuadLayerUpdateParametersInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, Guid*, void**, int>)(lpVtbl[0]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, uint>)(lpVtbl[1]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, uint>)(lpVtbl[2]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, HSTRING*, int>)(lpVtbl[4]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, TrustLevel*, int>)(lpVtbl[5]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CommitDirect3D12Resource(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue)
        {
            return ((delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, int>)(lpVtbl[6]))((IHolographicQuadLayerUpdateParametersInterop*)Unsafe.AsPointer(ref this), pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue);
        }

        public interface Interface : IInspectable.Interface
        {
            [VtblIndex(6)]
            HRESULT CommitDirect3D12Resource(ID3D12Resource* pColorResourceToCommit, ID3D12Fence* pColorResourceFence, [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (ID3D12Resource *, ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop*, ID3D12Resource*, ID3D12Fence*, ulong, int> CommitDirect3D12Resource;
        }
    }
}
