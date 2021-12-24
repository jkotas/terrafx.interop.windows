// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus.UnitTests;

/// <summary>Provides validation of the <see cref="WmfPlaceableFileHeader" /> struct.</summary>
public static unsafe partial class WmfPlaceableFileHeaderTests
{
    /// <summary>Validates that the <see cref="WmfPlaceableFileHeader" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WmfPlaceableFileHeader>(), Is.EqualTo(sizeof(WmfPlaceableFileHeader)));
    }

    /// <summary>Validates that the <see cref="WmfPlaceableFileHeader" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WmfPlaceableFileHeader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WmfPlaceableFileHeader" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WmfPlaceableFileHeader), Is.EqualTo(22));
    }
}
