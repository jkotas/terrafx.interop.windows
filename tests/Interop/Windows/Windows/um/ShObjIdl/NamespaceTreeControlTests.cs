// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="NamespaceTreeControl" /> struct.</summary>
public static unsafe partial class NamespaceTreeControlTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="NamespaceTreeControl" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(NamespaceTreeControl).GUID, Is.EqualTo(IID_NamespaceTreeControl));
    }

    /// <summary>Validates that the <see cref="NamespaceTreeControl" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NamespaceTreeControl>(), Is.EqualTo(sizeof(NamespaceTreeControl)));
    }

    /// <summary>Validates that the <see cref="NamespaceTreeControl" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NamespaceTreeControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="NamespaceTreeControl" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NamespaceTreeControl), Is.EqualTo(1));
    }
}
