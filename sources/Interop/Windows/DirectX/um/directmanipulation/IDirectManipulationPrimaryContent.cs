// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("C12851E4-1698-4625-B9B1-7CA3EC18630B")]
[NativeTypeName("struct IDirectManipulationPrimaryContent : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IDirectManipulationPrimaryContent : IDirectManipulationPrimaryContent.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, uint>)(lpVtbl[1]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, uint>)(lpVtbl[2]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSnapInterval(DIRECTMANIPULATION_MOTION_TYPES motion, float interval, float offset)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, float, float, int>)(lpVtbl[3]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, interval, offset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSnapPoints(DIRECTMANIPULATION_MOTION_TYPES motion, [NativeTypeName("const float *")] float* points, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, float*, uint, int>)(lpVtbl[4]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, points, pointCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSnapType(DIRECTMANIPULATION_MOTION_TYPES motion, DIRECTMANIPULATION_SNAPPOINT_TYPE type)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_TYPE, int>)(lpVtbl[5]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSnapCoordinate(DIRECTMANIPULATION_MOTION_TYPES motion, DIRECTMANIPULATION_SNAPPOINT_COORDINATE coordinate, float origin)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_COORDINATE, float, int>)(lpVtbl[6]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), motion, coordinate, origin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetZoomBoundaries(float zoomMinimum, float zoomMaximum)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, float, float, int>)(lpVtbl[7]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), zoomMinimum, zoomMaximum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetHorizontalAlignment(DIRECTMANIPULATION_HORIZONTALALIGNMENT alignment)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_HORIZONTALALIGNMENT, int>)(lpVtbl[8]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), alignment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetVerticalAlignment(DIRECTMANIPULATION_VERTICALALIGNMENT alignment)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_VERTICALALIGNMENT, int>)(lpVtbl[9]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), alignment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInertiaEndTransform(float* matrix, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, float*, uint, int>)(lpVtbl[10]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), matrix, pointCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCenterPoint(float* centerX, float* centerY)
    {
        return ((delegate* unmanaged<IDirectManipulationPrimaryContent*, float*, float*, int>)(lpVtbl[11]))((IDirectManipulationPrimaryContent*)Unsafe.AsPointer(ref this), centerX, centerY);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSnapInterval(DIRECTMANIPULATION_MOTION_TYPES motion, float interval, float offset);

        [VtblIndex(4)]
        HRESULT SetSnapPoints(DIRECTMANIPULATION_MOTION_TYPES motion, [NativeTypeName("const float *")] float* points, [NativeTypeName("DWORD")] uint pointCount);

        [VtblIndex(5)]
        HRESULT SetSnapType(DIRECTMANIPULATION_MOTION_TYPES motion, DIRECTMANIPULATION_SNAPPOINT_TYPE type);

        [VtblIndex(6)]
        HRESULT SetSnapCoordinate(DIRECTMANIPULATION_MOTION_TYPES motion, DIRECTMANIPULATION_SNAPPOINT_COORDINATE coordinate, float origin);

        [VtblIndex(7)]
        HRESULT SetZoomBoundaries(float zoomMinimum, float zoomMaximum);

        [VtblIndex(8)]
        HRESULT SetHorizontalAlignment(DIRECTMANIPULATION_HORIZONTALALIGNMENT alignment);

        [VtblIndex(9)]
        HRESULT SetVerticalAlignment(DIRECTMANIPULATION_VERTICALALIGNMENT alignment);

        [VtblIndex(10)]
        HRESULT GetInertiaEndTransform(float* matrix, [NativeTypeName("DWORD")] uint pointCount);

        [VtblIndex(11)]
        HRESULT GetCenterPoint(float* centerX, float* centerY);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, uint> Release;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_MOTION_TYPES, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, float, float, int> SetSnapInterval;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_MOTION_TYPES, const float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, float*, uint, int> SetSnapPoints;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_TYPE, int> SetSnapType;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_COORDINATE, float) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_SNAPPOINT_COORDINATE, float, int> SetSnapCoordinate;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, float, float, int> SetZoomBoundaries;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_HORIZONTALALIGNMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_HORIZONTALALIGNMENT, int> SetHorizontalAlignment;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_VERTICALALIGNMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, DIRECTMANIPULATION_VERTICALALIGNMENT, int> SetVerticalAlignment;

        [NativeTypeName("HRESULT (float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, float*, uint, int> GetInertiaEndTransform;

        [NativeTypeName("HRESULT (float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDirectManipulationPrimaryContent*, float*, float*, int> GetCenterPoint;
    }
}
