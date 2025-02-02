// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ApplicationAssociationRegistration" /> struct.</summary>
public static unsafe partial class ApplicationAssociationRegistrationTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ApplicationAssociationRegistration" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ApplicationAssociationRegistration).GUID, Is.EqualTo(IID_ApplicationAssociationRegistration));
    }

    /// <summary>Validates that the <see cref="ApplicationAssociationRegistration" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ApplicationAssociationRegistration>(), Is.EqualTo(sizeof(ApplicationAssociationRegistration)));
    }

    /// <summary>Validates that the <see cref="ApplicationAssociationRegistration" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ApplicationAssociationRegistration).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ApplicationAssociationRegistration" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ApplicationAssociationRegistration), Is.EqualTo(1));
    }
}
