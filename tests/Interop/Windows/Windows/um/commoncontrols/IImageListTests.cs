// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IImageList" /> struct.</summary>
public static unsafe partial class IImageListTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IImageList" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IImageList).GUID, Is.EqualTo(IID_IImageList));
    }

    /// <summary>Validates that the <see cref="IImageList" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IImageList>(), Is.EqualTo(sizeof(IImageList)));
    }

    /// <summary>Validates that the <see cref="IImageList" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IImageList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IImageList" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IImageList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IImageList), Is.EqualTo(4));
        }
    }
}
