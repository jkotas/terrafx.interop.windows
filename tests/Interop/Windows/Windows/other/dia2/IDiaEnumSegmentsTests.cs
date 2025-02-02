// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDiaEnumSegments" /> struct.</summary>
public static unsafe partial class IDiaEnumSegmentsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDiaEnumSegments" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaEnumSegments).GUID, Is.EqualTo(IID_IDiaEnumSegments));
    }

    /// <summary>Validates that the <see cref="IDiaEnumSegments" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiaEnumSegments>(), Is.EqualTo(sizeof(IDiaEnumSegments)));
    }

    /// <summary>Validates that the <see cref="IDiaEnumSegments" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiaEnumSegments).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDiaEnumSegments" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiaEnumSegments), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiaEnumSegments), Is.EqualTo(4));
        }
    }
}
