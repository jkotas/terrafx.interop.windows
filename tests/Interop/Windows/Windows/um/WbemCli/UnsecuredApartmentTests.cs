// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="UnsecuredApartment" /> struct.</summary>
public static unsafe partial class UnsecuredApartmentTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="UnsecuredApartment" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(UnsecuredApartment).GUID, Is.EqualTo(IID_UnsecuredApartment));
    }

    /// <summary>Validates that the <see cref="UnsecuredApartment" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UnsecuredApartment>(), Is.EqualTo(sizeof(UnsecuredApartment)));
    }

    /// <summary>Validates that the <see cref="UnsecuredApartment" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UnsecuredApartment).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="UnsecuredApartment" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UnsecuredApartment), Is.EqualTo(1));
    }
}
