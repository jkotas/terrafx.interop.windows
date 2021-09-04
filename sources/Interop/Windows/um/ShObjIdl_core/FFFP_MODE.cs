// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum FFFP_MODE
    {
        FFFP_EXACTMATCH = 0,
        FFFP_NEARESTPARENTMATCH = (FFFP_EXACTMATCH + 1),
    }
}
