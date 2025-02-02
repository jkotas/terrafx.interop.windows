// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SecPkgContext_IssuerListInfoEx" /> struct.</summary>
public static unsafe partial class SecPkgContext_IssuerListInfoExTests
{
    /// <summary>Validates that the <see cref="SecPkgContext_IssuerListInfoEx" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SecPkgContext_IssuerListInfoEx>(), Is.EqualTo(sizeof(SecPkgContext_IssuerListInfoEx)));
    }

    /// <summary>Validates that the <see cref="SecPkgContext_IssuerListInfoEx" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_IssuerListInfoEx).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SecPkgContext_IssuerListInfoEx" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SecPkgContext_IssuerListInfoEx), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SecPkgContext_IssuerListInfoEx), Is.EqualTo(8));
        }
    }
}
