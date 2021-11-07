// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    public enum WICDdsAlphaMode
    {
        WICDdsAlphaModeUnknown = 0,
        WICDdsAlphaModeStraight = 0x1,
        WICDdsAlphaModePremultiplied = 0x2,
        WICDdsAlphaModeOpaque = 0x3,
        WICDdsAlphaModeCustom = 0x4,
        WICDDSALPHAMODE_FORCE_DWORD = 0x7fffffff,
    }
}
