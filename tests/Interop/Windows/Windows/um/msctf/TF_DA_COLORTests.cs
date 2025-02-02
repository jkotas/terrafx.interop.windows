// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TF_DA_COLOR" /> struct.</summary>
public static unsafe partial class TF_DA_COLORTests
{
    /// <summary>Validates that the <see cref="TF_DA_COLOR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TF_DA_COLOR>(), Is.EqualTo(sizeof(TF_DA_COLOR)));
    }

    /// <summary>Validates that the <see cref="TF_DA_COLOR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TF_DA_COLOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TF_DA_COLOR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TF_DA_COLOR), Is.EqualTo(8));
    }
}
