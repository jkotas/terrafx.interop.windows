// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDiaSourceFile" /> struct.</summary>
public static unsafe partial class IDiaSourceFileTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDiaSourceFile" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaSourceFile).GUID, Is.EqualTo(IID_IDiaSourceFile));
    }

    /// <summary>Validates that the <see cref="IDiaSourceFile" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiaSourceFile>(), Is.EqualTo(sizeof(IDiaSourceFile)));
    }

    /// <summary>Validates that the <see cref="IDiaSourceFile" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiaSourceFile).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDiaSourceFile" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiaSourceFile), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiaSourceFile), Is.EqualTo(4));
        }
    }
}
