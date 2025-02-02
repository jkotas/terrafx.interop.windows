// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDVEnc" /> struct.</summary>
public static unsafe partial class IDVEncTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDVEnc" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDVEnc).GUID, Is.EqualTo(IID_IDVEnc));
    }

    /// <summary>Validates that the <see cref="IDVEnc" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDVEnc>(), Is.EqualTo(sizeof(IDVEnc)));
    }

    /// <summary>Validates that the <see cref="IDVEnc" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDVEnc).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDVEnc" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDVEnc), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDVEnc), Is.EqualTo(4));
        }
    }
}
