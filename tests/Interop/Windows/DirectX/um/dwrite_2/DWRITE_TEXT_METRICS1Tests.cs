// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DWRITE_TEXT_METRICS1" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class DWRITE_TEXT_METRICS1Tests
{
    /// <summary>Validates that the <see cref="DWRITE_TEXT_METRICS1" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DWRITE_TEXT_METRICS1>(), Is.EqualTo(sizeof(DWRITE_TEXT_METRICS1)));
    }

    /// <summary>Validates that the <see cref="DWRITE_TEXT_METRICS1" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_TEXT_METRICS1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DWRITE_TEXT_METRICS1" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DWRITE_TEXT_METRICS1), Is.EqualTo(40));
    }
}
