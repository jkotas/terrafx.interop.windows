// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_SPRITE_OPTIONS.xml' path='doc/member[@name="D2D1_SPRITE_OPTIONS"]/*' />
[Flags]
public enum D2D1_SPRITE_OPTIONS : uint
{
    /// <include file='D2D1_SPRITE_OPTIONS.xml' path='doc/member[@name="D2D1_SPRITE_OPTIONS.D2D1_SPRITE_OPTIONS_NONE"]/*' />
    D2D1_SPRITE_OPTIONS_NONE = 0,

    /// <include file='D2D1_SPRITE_OPTIONS.xml' path='doc/member[@name="D2D1_SPRITE_OPTIONS.D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE"]/*' />
    D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE = 1,

    /// <include file='D2D1_SPRITE_OPTIONS.xml' path='doc/member[@name="D2D1_SPRITE_OPTIONS.D2D1_SPRITE_OPTIONS_FORCE_DWORD"]/*' />
    D2D1_SPRITE_OPTIONS_FORCE_DWORD = 0xffffffff,
}
