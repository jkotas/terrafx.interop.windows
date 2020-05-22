// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MEMORY_BASIC_INFORMATION
    {
        [NativeTypeName("PVOID")]
        public void* BaseAddress;

        [NativeTypeName("PVOID")]
        public void* AllocationBase;

        [NativeTypeName("DWORD")]
        public uint AllocationProtect;

        [NativeTypeName("SIZE_T")]
        public nuint RegionSize;

        [NativeTypeName("DWORD")]
        public uint State;

        [NativeTypeName("DWORD")]
        public uint Protect;

        [NativeTypeName("DWORD")]
        public uint Type;
    }
}
