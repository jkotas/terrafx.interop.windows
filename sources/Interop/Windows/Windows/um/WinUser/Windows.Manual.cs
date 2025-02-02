// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.EWX;
using static TerraFX.Interop.Windows.POINTER;
using static TerraFX.Interop.Windows.RIDEV;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static int GUI_16BITTASK
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 0x00000020;
            }
            else
            {
                return 0x00000000;
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_INTRESOURCE([NativeTypeName("ULONG_PTR")] nuint _r)
    {
        return (_r >> 16) == 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("LPWSTR")]
    public static ushort* MAKEINTRESOURCE(ushort i) => (ushort*)(nuint)i;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static POINT POINTSTOPOINT(POINTS pts)
    {
        return new POINT {
            x = unchecked((int)(short)LOWORD(*(int*)&pts)),
            y = unchecked((int)(short)HIWORD(*(int*)&pts)),
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int POINTTOPOINTS(POINTS pt) => unchecked(MAKELONG((nuint)(short)pt.x, (nuint)(short)pt.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static WPARAM MAKEWPARAM([NativeTypeName("DWORD_PTR")] nuint l, [NativeTypeName("DWORD_PTR")] nuint h) => unchecked((WPARAM)(uint)MAKELONG(l, h));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static WPARAM MAKEWPARAM(nint l, nint h) => unchecked(MAKEWPARAM((nuint)(l), (nuint)(h)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LPARAM MAKELPARAM([NativeTypeName("DWORD_PTR")] nuint l, [NativeTypeName("DWORD_PTR")] nuint h) => unchecked((LPARAM)(uint)MAKELONG(l, h));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LPARAM MAKELPARAM(nint l, nint h) => unchecked(MAKELPARAM((nuint)(l), (nuint)(h)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LRESULT MAKELRESULT([NativeTypeName("DWORD_PTR")] nuint l, [NativeTypeName("DWORD_PTR")] nuint h) => unchecked((LRESULT)(uint)MAKELONG(l, h));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LRESULT MAKELRESULT(nint l, nint h) => unchecked(MAKELRESULT((nuint)(l), (nuint)(h)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short GET_APPCOMMAND_LPARAM(LPARAM lParam) => unchecked((short)(HIWORD((uint)lParam) & ~FAPPCOMMAND_MASK));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_DEVICE_LPARAM(LPARAM lParam) => unchecked((ushort)(HIWORD((uint)lParam) & FAPPCOMMAND_MASK));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_MOUSEORKEY_LPARAM(LPARAM lParam) => GET_DEVICE_LPARAM(lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_FLAGS_LPARAM(LPARAM lParam) => LOWORD(unchecked((uint)lParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_KEYSTATE_LPARAM(LPARAM lParam) => GET_FLAGS_LPARAM(lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short GET_WHEEL_DELTA_WPARAM(WPARAM wParam) => unchecked((short)HIWORD((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_KEYSTATE_WPARAM(WPARAM wParam) => LOWORD(unchecked((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short GET_NCHITTEST_WPARAM(WPARAM wParam) => unchecked((short)LOWORD((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_XBUTTON_WPARAM(WPARAM wParam) => HIWORD(unchecked((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL ExitWindows(uint dwReserved, int Code) => ExitWindowsEx(EWX_LOGOFF, 0xFFFFFFFF);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL PostAppMessageA([NativeTypeName("DWORD")] uint idThread, uint wMsg, WPARAM wParam, LPARAM lParam) => PostThreadMessageA(idThread, wMsg, wParam, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL PostAppMessageW([NativeTypeName("DWORD")] uint idThread, uint wMsg, WPARAM wParam, LPARAM lParam) => PostThreadMessageW(idThread, wMsg, wParam, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateWindowA([NativeTypeName("LPCSTR")] sbyte* lpClassName, [NativeTypeName("LPCSTR")] sbyte* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExA(0, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateWindowW([NativeTypeName("LPCWSTR")] ushort* lpClassName, [NativeTypeName("LPCWSTR")] ushort* lpWindowName, [NativeTypeName("DWORD")] uint dwStyle, int x, int y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, [NativeTypeName("LPVOID")] void* lpParam) => CreateWindowExW(0, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, hMenu, hInstance, lpParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogParamA(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpName, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogParamW(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogIndirectA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogIndirectW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => CreateDialogIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static IntPtr DialogBoxA(HINSTANCE hInstance, [NativeTypeName("LPCSTR")] sbyte* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static IntPtr DialogBoxW(HINSTANCE hInstance, [NativeTypeName("LPCWSTR")] ushort* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static IntPtr DialogBoxIndirectA(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static IntPtr DialogBoxIndirectW(HINSTANCE hInstance, [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate, HWND hWndParent, [NativeTypeName("DLGPROC")] delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> lpDialogFunc) => DialogBoxIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int TOUCH_COORD_TO_PIXEL(int l) => l / 100;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_POINTERID_WPARAM(WPARAM wParam) => LOWORD(unchecked((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_FLAG_SET_WPARAM(WPARAM wParam, uint flag) => (HIWORD(unchecked((uint)wParam)) & flag) == flag;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_NEW_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_NEW);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_INRANGE_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INRANGE);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_INCONTACT_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_INCONTACT);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_FIRSTBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIRSTBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_SECONDBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_SECONDBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_THIRDBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_THIRDBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_FOURTHBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FOURTHBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_FIFTHBUTTON_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_FIFTHBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_PRIMARY_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_PRIMARY);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HAS_POINTER_CONFIDENCE_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CONFIDENCE);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IS_POINTER_CANCELED_WPARAM(WPARAM wParam) => IS_POINTER_FLAG_SET_WPARAM(wParam, POINTER_MESSAGE_FLAG_CANCELED);

    [NativeTypeName("#define GetWindowLongPtr GetWindowLongPtrW")]
    public static delegate*<HWND, int, nint> GetWindowLongPtr => &GetWindowLongPtrW;

    [return: NativeTypeName("LONG_PTR")]
    public static nint GetWindowLongPtrA(HWND hWnd, int nIndex)
    {
        if (sizeof(nint) == 4)
        {
            return GetWindowLongA(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetWindowLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _GetWindowLongPtrA(HWND hWnd, int nIndex);

            return _GetWindowLongPtrA(hWnd, nIndex);
        }
    }

    [return: NativeTypeName("LONG_PTR")]
    public static nint GetWindowLongPtrW(HWND hWnd, int nIndex)
    {
        if (sizeof(nint) == 4)
        {
            return GetWindowLongW(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetWindowLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _GetWindowLongPtrW(HWND hWnd, int nIndex);

            return _GetWindowLongPtrW(hWnd, nIndex);
        }
    }

    [NativeTypeName("#define SetWindowLongPtr SetWindowLongPtrW")]
    public static delegate*<HWND, int, nint, nint> SetWindowLongPtr => &SetWindowLongPtrW;

    [return: NativeTypeName("LONG_PTR")]
    public static nint SetWindowLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
    {
        if (sizeof(nint) == 4)
        {
            return SetWindowLongA(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetWindowLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _SetWindowLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

            return _SetWindowLongPtrA(hWnd, nIndex, dwNewLong);
        }
    }

    [return: NativeTypeName("LONG_PTR")]
    public static nint SetWindowLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
    {
        if (sizeof(nint) == 4)
        {
            return SetWindowLongW(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetWindowLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _SetWindowLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

            return _SetWindowLongPtrW(hWnd, nIndex, dwNewLong);
        }
    }

    [NativeTypeName("#define GetClassLongPtr GetClassLongPtrW")]
    public static delegate*<HWND, int, nuint> GetClassLongPtr => &GetClassLongPtrW;

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint GetClassLongPtrA(HWND hWnd, int nIndex)
    {
        if (sizeof(nuint) == 4)
        {
            return GetClassLongA(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetClassLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _GetClassLongPtrA(HWND hWnd, int nIndex);

            return _GetClassLongPtrA(hWnd, nIndex);
        }
    }

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint GetClassLongPtrW(HWND hWnd, int nIndex)
    {
        if (sizeof(nuint) == 4)
        {
            return GetClassLongW(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetClassLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _GetClassLongPtrW(HWND hWnd, int nIndex);

            return _GetClassLongPtrW(hWnd, nIndex);
        }
    }

    [NativeTypeName("#define SetClassLongPtr SetClassLongPtrW")]
    public static delegate*<HWND, int, nint, nuint> SetClassLongPtr => &SetClassLongPtrW;

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint SetClassLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
    {
        if (sizeof(nuint) == 4)
        {
            return SetClassLongA(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetClassLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _SetClassLongPtrA(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

            return _SetClassLongPtrA(hWnd, nIndex, dwNewLong);
        }
    }

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint SetClassLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong)
    {
        if (sizeof(nuint) == 4)
        {
            return SetClassLongW(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetClassLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _SetClassLongPtrW(HWND hWnd, int nIndex, [NativeTypeName("LONG_PTR")] nint dwNewLong);

            return _SetClassLongPtrW(hWnd, nIndex, dwNewLong);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL EnumTaskWindows(IntPtr hTask, [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, LPARAM, BOOL> lpfn, LPARAM lParam) => EnumThreadWindows((uint)hTask, lpfn, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND GetNextWindow(HWND hWnd, ushort wCmd) => GetWindow(hWnd, wCmd);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND GetSysModalWindow() => (HWND)(NULL);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND SetSysModalWindow(HWND hWnd) => (HWND)(NULL);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HANDLE GetWindowTask(HWND hWnd) => (HANDLE)GetWindowThreadProcessId(hWnd, null);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static LRESULT DefHookProc(int nCode, WPARAM wParam, LPARAM lParam, HHOOK phhk) => CallNextHookEx(phhk, nCode, wParam, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GET_SC_WPARAM(WPARAM wParam) => unchecked((int)(wParam & 0xFFF0));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static nuint GET_RAWINPUT_CODE_WPARAM(WPARAM wParam) => wParam & (nuint)(0xFFu);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static nint RAWINPUT_ALIGN(nint x) => (x + sizeof(nint) - 1) & ~(sizeof(nint) - 1);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RAWINPUT* NEXTRAWINPUTBLOCK(RAWINPUT* ptr) => (RAWINPUT*)(RAWINPUT_ALIGN((nint)ptr) + ptr->header.dwSize);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int RIDEV_EXMODE(int mode) => mode & RIDEV_EXMODEMASK;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_DEVICE_CHANGE_WPARAM(WPARAM wParam) => LOWORD(unchecked((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GET_DEVICE_CHANGE_LPARAM(LPARAM lParam) => LOWORD(unchecked((uint)lParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GID_ROTATE_ANGLE_TO_ARGUMENT(ushort _arg_) => (ushort)((_arg_ + (2.0 * 3.14159265)) / (4.0 * 3.14159265) * 65535.0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double GID_ROTATE_ANGLE_FROM_ARGUMENT(double _arg_) => (_arg_ / 65535.0 * 4.0 * 3.14159265) - (2.0 * 3.14159265);

    [NativeTypeName("#define GR_GLOBAL ((HANDLE)-2)")]
    public static HANDLE GR_GLOBAL => ((HANDLE)(-2));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.wsprintfW"]/*' />
    [DllImport("user32", CallingConvention = CallingConvention.Cdecl, EntryPoint = "wsprintfW", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int wsprintf([NativeTypeName("LPWSTR")] ushort* param0, [NativeTypeName("LPCWSTR")] ushort* param1, __arglist);
}
