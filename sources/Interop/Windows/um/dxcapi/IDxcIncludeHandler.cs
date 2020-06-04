// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7f61fc7d-950d-467f-b3e3-3c02fb49187c")]
    public unsafe partial struct IDxcIncludeHandler
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDxcIncludeHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDxcIncludeHandler*, uint>)(lpVtbl[1]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDxcIncludeHandler*, uint>)(lpVtbl[2]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadSource([NativeTypeName("LPCWSTR")] ushort* pFilename, [NativeTypeName("IDxcBlob **")] IDxcBlob** ppIncludeSource)
        {
            return ((delegate* stdcall<IDxcIncludeHandler*, ushort*, IDxcBlob**, int>)(lpVtbl[3]))((IDxcIncludeHandler*)Unsafe.AsPointer(ref this), pFilename, ppIncludeSource);
        }
    }
}
