// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ConflictFolder" /> struct.</summary>
public static unsafe partial class ConflictFolderTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ConflictFolder" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ConflictFolder).GUID, Is.EqualTo(IID_ConflictFolder));
    }

    /// <summary>Validates that the <see cref="ConflictFolder" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ConflictFolder>(), Is.EqualTo(sizeof(ConflictFolder)));
    }

    /// <summary>Validates that the <see cref="ConflictFolder" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ConflictFolder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ConflictFolder" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ConflictFolder), Is.EqualTo(1));
    }
}
