// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="HTMLLocation" /> struct.</summary>
public static unsafe partial class HTMLLocationTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLLocation" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLLocation).GUID, Is.EqualTo(IID_HTMLLocation));
    }

    /// <summary>Validates that the <see cref="HTMLLocation" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLLocation>(), Is.EqualTo(sizeof(HTMLLocation)));
    }

    /// <summary>Validates that the <see cref="HTMLLocation" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLLocation).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="HTMLLocation" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLLocation), Is.EqualTo(1));
    }
}
