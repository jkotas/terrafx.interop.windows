// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISyncMgrSessionCreator" /> struct.</summary>
public static unsafe partial class ISyncMgrSessionCreatorTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISyncMgrSessionCreator" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISyncMgrSessionCreator).GUID, Is.EqualTo(IID_ISyncMgrSessionCreator));
    }

    /// <summary>Validates that the <see cref="ISyncMgrSessionCreator" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISyncMgrSessionCreator>(), Is.EqualTo(sizeof(ISyncMgrSessionCreator)));
    }

    /// <summary>Validates that the <see cref="ISyncMgrSessionCreator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISyncMgrSessionCreator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISyncMgrSessionCreator" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISyncMgrSessionCreator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISyncMgrSessionCreator), Is.EqualTo(4));
        }
    }
}
