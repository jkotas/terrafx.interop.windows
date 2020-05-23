// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5E5A32A3-8DFF-4773-9FF6-0696EAB77267")]
    public unsafe partial struct IDWriteBitmapRenderTarget
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteBitmapRenderTarget* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteBitmapRenderTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteBitmapRenderTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DrawGlyphRun(IDWriteBitmapRenderTarget* pThis, [NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("COLORREF")] uint textColor, [NativeTypeName("RECT *")] RECT* blackBoxRect = null);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HDC")]
        public delegate IntPtr _GetMemoryDC(IDWriteBitmapRenderTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetPixelsPerDip(IDWriteBitmapRenderTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPixelsPerDip(IDWriteBitmapRenderTarget* pThis, [NativeTypeName("FLOAT")] float pixelsPerDip);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentTransform(IDWriteBitmapRenderTarget* pThis, [NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetCurrentTransform(IDWriteBitmapRenderTarget* pThis, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSize(IDWriteBitmapRenderTarget* pThis, [NativeTypeName("SIZE *")] SIZE* size);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Resize(IDWriteBitmapRenderTarget* pThis, [NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DrawGlyphRun([NativeTypeName("FLOAT")] float baselineOriginX, [NativeTypeName("FLOAT")] float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("COLORREF")] uint textColor, [NativeTypeName("RECT *")] RECT* blackBoxRect = null)
        {
            return Marshal.GetDelegateForFunctionPointer<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
        }

        [return: NativeTypeName("HDC")]
        public IntPtr GetMemoryDC()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMemoryDC>(lpVtbl->GetMemoryDC)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetPixelsPerDip()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPixelsPerDip>(lpVtbl->GetPixelsPerDip)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPixelsPerDip([NativeTypeName("FLOAT")] float pixelsPerDip)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPixelsPerDip>(lpVtbl->SetPixelsPerDip)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), pixelsPerDip);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentTransform([NativeTypeName("DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentTransform>(lpVtbl->GetCurrentTransform)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCurrentTransform([NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetCurrentTransform>(lpVtbl->SetCurrentTransform)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSize([NativeTypeName("SIZE *")] SIZE* size)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int Resize([NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height)
        {
            return Marshal.GetDelegateForFunctionPointer<_Resize>(lpVtbl->Resize)((IDWriteBitmapRenderTarget*)Unsafe.AsPointer(ref this), width, height);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, const DWRITE_GLYPH_RUN *, IDWriteRenderingParams *, COLORREF, RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr DrawGlyphRun;

            [NativeTypeName("HDC () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMemoryDC;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPixelsPerDip;

            [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetPixelsPerDip;

            [NativeTypeName("HRESULT (DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetCurrentTransform;

            [NativeTypeName("HRESULT (const DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr SetCurrentTransform;

            [NativeTypeName("HRESULT (SIZE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSize;

            [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Resize;
        }
    }
}
