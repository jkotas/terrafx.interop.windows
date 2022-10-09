// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncDDSurround90DegreeePhaseShift.xml' path='doc/member[@name="CODECAPI_AVEncDDSurround90DegreeePhaseShift"]/*' />
[Guid("25ECEC9D-3553-42C0-BB56-D25792104F80")]
public unsafe partial struct CODECAPI_AVEncDDSurround90DegreeePhaseShift : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncDDSurround90DegreeePhaseShift));
}
