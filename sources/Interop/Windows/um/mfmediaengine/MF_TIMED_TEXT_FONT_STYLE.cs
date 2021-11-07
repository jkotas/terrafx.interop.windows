// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public enum MF_TIMED_TEXT_FONT_STYLE
    {
        MF_TIMED_TEXT_FONT_STYLE_NORMAL = 0,
        MF_TIMED_TEXT_FONT_STYLE_OBLIQUE = 1,
        MF_TIMED_TEXT_FONT_STYLE_ITALIC = 2,
    }
}
