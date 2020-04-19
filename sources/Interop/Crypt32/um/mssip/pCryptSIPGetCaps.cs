// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int pCryptSIPGetCaps([NativeTypeName("SIP_SUBJECTINFO *")] SIP_SUBJECTINFO* pSubjInfo, [NativeTypeName("SIP_CAP_SET *")] SIP_CAP_SET_V3* pCaps);
}
