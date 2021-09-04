// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7CC7AED8-290E-49BC-8945-C1401CC9306C")]
    [NativeTypeName("struct INameSpaceTreeControl2 : INameSpaceTreeControl")]
    public unsafe partial struct INameSpaceTreeControl2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, Guid*, void**, int>)(lpVtbl[0]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint>)(lpVtbl[1]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint>)(lpVtbl[2]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("HWND")] IntPtr hwndParent, RECT* prc, [NativeTypeName("NSTCSTYLE")] uint nsctsFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IntPtr, RECT*, uint, int>)(lpVtbl[3]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), hwndParent, prc, nsctsFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TreeAdvise(IUnknown* punk, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IUnknown*, uint*, int>)(lpVtbl[4]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), punk, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TreeUnadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, int>)(lpVtbl[5]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AppendRoot(IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[6]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiRoot, grfEnumFlags, grfRootStyle, pif);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertRoot(int iIndex, IShellItem* psiRoot, [NativeTypeName("SHCONTF")] uint grfEnumFlags, [NativeTypeName("NSTCROOTSTYLE")] uint grfRootStyle, IShellItemFilter* pif)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, int, IShellItem*, uint, uint, IShellItemFilter*, int>)(lpVtbl[7]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), iIndex, psiRoot, grfEnumFlags, grfRootStyle, pif);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveRoot(IShellItem* psiRoot)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int>)(lpVtbl[8]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllRoots()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, int>)(lpVtbl[9]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRootItems(IShellItemArray** ppsiaRootItems)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int>)(lpVtbl[10]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), ppsiaRootItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE")] uint nstcisFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint, int>)(lpVtbl[11]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcisMask, nstcisFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemState(IShellItem* psi, [NativeTypeName("NSTCITEMSTATE")] uint nstcisMask, [NativeTypeName("NSTCITEMSTATE *")] uint* pnstcisFlags)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, uint, uint*, int>)(lpVtbl[12]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcisMask, pnstcisFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedItems(IShellItemArray** psiaItems)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItemArray**, int>)(lpVtbl[13]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psiaItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemCustomState(IShellItem* psi, int* piStateNumber)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int*, int>)(lpVtbl[14]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, piStateNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItemCustomState(IShellItem* psi, int iStateNumber)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int, int>)(lpVtbl[15]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, iStateNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnsureItemVisible(IShellItem* psi)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, int>)(lpVtbl[16]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTheme([NativeTypeName("LPCWSTR")] ushort* pszTheme)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, ushort*, int>)(lpVtbl[17]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), pszTheme);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNextItem(IShellItem* psi, NSTCGNI nstcgi, IShellItem** ppsiNext)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, NSTCGNI, IShellItem**, int>)(lpVtbl[18]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, nstcgi, ppsiNext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HitTest(POINT* ppt, IShellItem** ppsiOut)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, POINT*, IShellItem**, int>)(lpVtbl[19]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), ppt, ppsiOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemRect(IShellItem* psi, RECT* prect)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, IShellItem*, RECT*, int>)(lpVtbl[20]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), psi, prect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CollapseAll()
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, int>)(lpVtbl[21]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE")] uint nstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, uint, int>)(lpVtbl[22]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, nstcsStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetControlStyle([NativeTypeName("NSTCSTYLE")] uint nstcsMask, [NativeTypeName("NSTCSTYLE *")] uint* pnstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, uint, uint*, int>)(lpVtbl[23]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, pnstcsStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2 nstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2, int>)(lpVtbl[24]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, nstcsStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetControlStyle2(NSTCSTYLE2 nstcsMask, NSTCSTYLE2* pnstcsStyle)
        {
            return ((delegate* unmanaged<INameSpaceTreeControl2*, NSTCSTYLE2, NSTCSTYLE2*, int>)(lpVtbl[25]))((INameSpaceTreeControl2*)Unsafe.AsPointer(ref this), nstcsMask, pnstcsStyle);
        }
    }
}
