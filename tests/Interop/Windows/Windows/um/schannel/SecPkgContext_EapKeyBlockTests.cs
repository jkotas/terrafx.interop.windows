// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SecPkgContext_EapKeyBlock" /> struct.</summary>
public static unsafe partial class SecPkgContext_EapKeyBlockTests
{
    /// <summary>Validates that the <see cref="SecPkgContext_EapKeyBlock" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SecPkgContext_EapKeyBlock>(), Is.EqualTo(sizeof(SecPkgContext_EapKeyBlock)));
    }

    /// <summary>Validates that the <see cref="SecPkgContext_EapKeyBlock" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SecPkgContext_EapKeyBlock).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SecPkgContext_EapKeyBlock" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SecPkgContext_EapKeyBlock), Is.EqualTo(192));
    }
}
