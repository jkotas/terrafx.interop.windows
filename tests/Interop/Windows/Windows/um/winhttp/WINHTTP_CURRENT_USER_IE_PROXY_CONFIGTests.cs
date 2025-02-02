// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG" /> struct.</summary>
public static unsafe partial class WINHTTP_CURRENT_USER_IE_PROXY_CONFIGTests
{
    /// <summary>Validates that the <see cref="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_CURRENT_USER_IE_PROXY_CONFIG>(), Is.EqualTo(sizeof(WINHTTP_CURRENT_USER_IE_PROXY_CONFIG)));
    }

    /// <summary>Validates that the <see cref="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_CURRENT_USER_IE_PROXY_CONFIG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WINHTTP_CURRENT_USER_IE_PROXY_CONFIG" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WINHTTP_CURRENT_USER_IE_PROXY_CONFIG), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(WINHTTP_CURRENT_USER_IE_PROXY_CONFIG), Is.EqualTo(16));
        }
    }
}
