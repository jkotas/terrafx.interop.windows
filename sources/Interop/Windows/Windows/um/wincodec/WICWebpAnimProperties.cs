// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='WICWebpAnimProperties.xml' path='doc/member[@name="WICWebpAnimProperties"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public enum WICWebpAnimProperties : uint
{
    /// <include file='WICWebpAnimProperties.xml' path='doc/member[@name="WICWebpAnimProperties.WICWebpAnimLoopCount"]/*' />
    WICWebpAnimLoopCount = 0x1,

    /// <include file='WICWebpAnimProperties.xml' path='doc/member[@name="WICWebpAnimProperties.WICWebpAnimProperties_FORCE_DWORD"]/*' />
    WICWebpAnimProperties_FORCE_DWORD = 0x7fffffff,
}
