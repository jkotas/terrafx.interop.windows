// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D001F200-EF97-11CE-9BC9-00AA00608E01")]
    public unsafe partial struct IOleUndoManager
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IOleUndoManager*, Guid*, void**, int>)(lpVtbl[0]))((IOleUndoManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IOleUndoManager*, uint>)(lpVtbl[1]))((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IOleUndoManager*, uint>)(lpVtbl[2]))((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU)
        {
            return ((delegate* stdcall<IOleUndoManager*, IOleParentUndoUnit*, int>)(lpVtbl[3]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("IOleParentUndoUnit *")] IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit)
        {
            return ((delegate* stdcall<IOleUndoManager*, IOleParentUndoUnit*, int, int>)(lpVtbl[4]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU, fCommit);
        }

        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return ((delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[5]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOpenParentState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return ((delegate* stdcall<IOleUndoManager*, uint*, int>)(lpVtbl[6]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pdwState);
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardFrom([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return ((delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[7]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int UndoTo([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return ((delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[8]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int RedoTo([NativeTypeName("IOleUndoUnit *")] IOleUndoUnit* pUU)
        {
            return ((delegate* stdcall<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[9]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumUndoable([NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum)
        {
            return ((delegate* stdcall<IOleUndoManager*, IEnumOleUndoUnits**, int>)(lpVtbl[10]))((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumRedoable([NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum)
        {
            return ((delegate* stdcall<IOleUndoManager*, IEnumOleUndoUnits**, int>)(lpVtbl[11]))((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastUndoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* stdcall<IOleUndoManager*, ushort**, int>)(lpVtbl[12]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLastRedoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* stdcall<IOleUndoManager*, ushort**, int>)(lpVtbl[13]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* stdcall<IOleUndoManager*, int, int>)(lpVtbl[14]))((IOleUndoManager*)Unsafe.AsPointer(ref this), fEnable);
        }
    }
}
