// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [Flags]
    [SupportedOSPlatform("windows8.0")]
    public enum D3D11_VIDEO_PROCESSOR_FEATURE_CAPS
    {
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_FILL = 0x1,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_CONSTRICTION = 0x2,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LUMA_KEY = 0x4,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_PALETTE = 0x8,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_LEGACY = 0x10,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_STEREO = 0x20,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ROTATION = 0x40,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_ALPHA_STREAM = 0x80,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_PIXEL_ASPECT_RATIO = 0x100,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_MIRROR = 0x200,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_SHADER_USAGE = 0x400,
        D3D11_VIDEO_PROCESSOR_FEATURE_CAPS_METADATA_HDR10 = 0x800,
    }
}
