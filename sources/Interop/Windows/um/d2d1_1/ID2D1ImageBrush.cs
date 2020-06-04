// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FE9E984D-3F95-407C-B5DB-CB94D4E8F87C")]
    public unsafe partial struct ID2D1ImageBrush
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1ImageBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1ImageBrush*, uint>)(lpVtbl[1]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1ImageBrush*, uint>)(lpVtbl[2]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, float, void>)(lpVtbl[4]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return ((delegate* stdcall<ID2D1ImageBrush*, float>)(lpVtbl[6]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, ID2D1Image*, void>)(lpVtbl[8]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), image);
        }

        public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, D2D1_EXTEND_MODE, void>)(lpVtbl[9]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), extendModeX);
        }

        public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, D2D1_EXTEND_MODE, void>)(lpVtbl[10]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), extendModeY);
        }

        public void SetInterpolationMode(D2D1_INTERPOLATION_MODE interpolationMode)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, D2D1_INTERPOLATION_MODE, void>)(lpVtbl[11]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        public void SetSourceRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, D2D_RECT_F*, void>)(lpVtbl[12]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), sourceRectangle);
        }

        public void GetImage([NativeTypeName("ID2D1Image **")] ID2D1Image** image)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, ID2D1Image**, void>)(lpVtbl[13]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), image);
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            return ((delegate* stdcall<ID2D1ImageBrush*, D2D1_EXTEND_MODE>)(lpVtbl[14]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            return ((delegate* stdcall<ID2D1ImageBrush*, D2D1_EXTEND_MODE>)(lpVtbl[15]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
        }

        public D2D1_INTERPOLATION_MODE GetInterpolationMode()
        {
            return ((delegate* stdcall<ID2D1ImageBrush*, D2D1_INTERPOLATION_MODE>)(lpVtbl[16]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetSourceRectangle([NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle)
        {
            ((delegate* stdcall<ID2D1ImageBrush*, D2D_RECT_F*, void>)(lpVtbl[17]))((ID2D1ImageBrush*)Unsafe.AsPointer(ref this), sourceRectangle);
        }
    }
}
