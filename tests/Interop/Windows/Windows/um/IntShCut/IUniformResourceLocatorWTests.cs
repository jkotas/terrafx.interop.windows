// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IUniformResourceLocatorW" /> struct.</summary>
public static unsafe partial class IUniformResourceLocatorWTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUniformResourceLocatorW" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IUniformResourceLocatorW).GUID, Is.EqualTo(IID_IUniformResourceLocatorW));
    }

    /// <summary>Validates that the <see cref="IUniformResourceLocatorW" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IUniformResourceLocatorW>(), Is.EqualTo(sizeof(IUniformResourceLocatorW)));
    }

    /// <summary>Validates that the <see cref="IUniformResourceLocatorW" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUniformResourceLocatorW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IUniformResourceLocatorW" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUniformResourceLocatorW), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUniformResourceLocatorW), Is.EqualTo(4));
        }
    }
}
