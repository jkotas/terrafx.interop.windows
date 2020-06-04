// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9BFBBC02-EFF1-101A-84ED-00AA00341D07")]
    public unsafe partial struct IPropertyNotifySink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyNotifySink*, uint>)(lpVtbl[1]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyNotifySink*, uint>)(lpVtbl[2]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnChanged([NativeTypeName("DISPID")] int dispID)
        {
            return ((delegate* stdcall<IPropertyNotifySink*, int, int>)(lpVtbl[3]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnRequestEdit([NativeTypeName("DISPID")] int dispID)
        {
            return ((delegate* stdcall<IPropertyNotifySink*, int, int>)(lpVtbl[4]))((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
        }
    }
}
