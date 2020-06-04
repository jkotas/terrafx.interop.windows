// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("711C7600-6B48-11D1-B403-00AA00B92AF1")]
    public unsafe partial struct ICatalogFileInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ICatalogFileInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ICatalogFileInfo*, uint>)(lpVtbl[1]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ICatalogFileInfo*, uint>)(lpVtbl[2]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile)
        {
            return ((delegate* stdcall<ICatalogFileInfo*, sbyte**, int>)(lpVtbl[3]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppszCatalogFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJavaTrust([NativeTypeName("void **")] void** ppJavaTrust)
        {
            return ((delegate* stdcall<ICatalogFileInfo*, void**, int>)(lpVtbl[4]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppJavaTrust);
        }
    }
}
