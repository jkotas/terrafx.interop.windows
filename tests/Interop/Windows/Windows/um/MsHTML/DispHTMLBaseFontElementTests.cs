// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DispHTMLBaseFontElement" /> struct.</summary>
public static unsafe partial class DispHTMLBaseFontElementTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispHTMLBaseFontElement" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispHTMLBaseFontElement).GUID, Is.EqualTo(IID_DispHTMLBaseFontElement));
    }

    /// <summary>Validates that the <see cref="DispHTMLBaseFontElement" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispHTMLBaseFontElement>(), Is.EqualTo(sizeof(DispHTMLBaseFontElement)));
    }

    /// <summary>Validates that the <see cref="DispHTMLBaseFontElement" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispHTMLBaseFontElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DispHTMLBaseFontElement" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispHTMLBaseFontElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispHTMLBaseFontElement), Is.EqualTo(4));
        }
    }
}
