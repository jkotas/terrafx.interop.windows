// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="OLEMENUGROUPWIDTHS" /> struct.</summary>
public static unsafe partial class OLEMENUGROUPWIDTHSTests
{
    /// <summary>Validates that the <see cref="OLEMENUGROUPWIDTHS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OLEMENUGROUPWIDTHS>(), Is.EqualTo(sizeof(OLEMENUGROUPWIDTHS)));
    }

    /// <summary>Validates that the <see cref="OLEMENUGROUPWIDTHS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OLEMENUGROUPWIDTHS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="OLEMENUGROUPWIDTHS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(OLEMENUGROUPWIDTHS), Is.EqualTo(24));
    }
}
