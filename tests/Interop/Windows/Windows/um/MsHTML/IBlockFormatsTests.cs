// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IBlockFormats" /> struct.</summary>
public static unsafe partial class IBlockFormatsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IBlockFormats" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBlockFormats).GUID, Is.EqualTo(IID_IBlockFormats));
    }

    /// <summary>Validates that the <see cref="IBlockFormats" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBlockFormats>(), Is.EqualTo(sizeof(IBlockFormats)));
    }

    /// <summary>Validates that the <see cref="IBlockFormats" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBlockFormats).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IBlockFormats" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBlockFormats), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBlockFormats), Is.EqualTo(4));
        }
    }
}
