// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public enum D3D11_VIDEO_PROCESSOR_FILTER
    {
        D3D11_VIDEO_PROCESSOR_FILTER_BRIGHTNESS = 0,
        D3D11_VIDEO_PROCESSOR_FILTER_CONTRAST = 1,
        D3D11_VIDEO_PROCESSOR_FILTER_HUE = 2,
        D3D11_VIDEO_PROCESSOR_FILTER_SATURATION = 3,
        D3D11_VIDEO_PROCESSOR_FILTER_NOISE_REDUCTION = 4,
        D3D11_VIDEO_PROCESSOR_FILTER_EDGE_ENHANCEMENT = 5,
        D3D11_VIDEO_PROCESSOR_FILTER_ANAMORPHIC_SCALING = 6,
        D3D11_VIDEO_PROCESSOR_FILTER_STEREO_ADJUSTMENT = 7,
    }
}
