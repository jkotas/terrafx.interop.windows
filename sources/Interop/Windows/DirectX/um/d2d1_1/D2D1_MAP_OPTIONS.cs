// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_MAP_OPTIONS.xml' path='doc/member[@name="D2D1_MAP_OPTIONS"]/*' />
[Flags]
public enum D2D1_MAP_OPTIONS : uint
{
    /// <include file='D2D1_MAP_OPTIONS.xml' path='doc/member[@name="D2D1_MAP_OPTIONS.D2D1_MAP_OPTIONS_NONE"]/*' />
    D2D1_MAP_OPTIONS_NONE = 0,

    /// <include file='D2D1_MAP_OPTIONS.xml' path='doc/member[@name="D2D1_MAP_OPTIONS.D2D1_MAP_OPTIONS_READ"]/*' />
    D2D1_MAP_OPTIONS_READ = 1,

    /// <include file='D2D1_MAP_OPTIONS.xml' path='doc/member[@name="D2D1_MAP_OPTIONS.D2D1_MAP_OPTIONS_WRITE"]/*' />
    D2D1_MAP_OPTIONS_WRITE = 2,

    /// <include file='D2D1_MAP_OPTIONS.xml' path='doc/member[@name="D2D1_MAP_OPTIONS.D2D1_MAP_OPTIONS_DISCARD"]/*' />
    D2D1_MAP_OPTIONS_DISCARD = 4,

    /// <include file='D2D1_MAP_OPTIONS.xml' path='doc/member[@name="D2D1_MAP_OPTIONS.D2D1_MAP_OPTIONS_FORCE_DWORD"]/*' />
    D2D1_MAP_OPTIONS_FORCE_DWORD = 0xffffffff,
}
