// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDXGIFactory6" /> struct.</summary>
[SupportedOSPlatform("windows10.0.17134.0")]
public static unsafe partial class IDXGIFactory6Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIFactory6" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXGIFactory6).GUID, Is.EqualTo(IID_IDXGIFactory6));
    }

    /// <summary>Validates that the <see cref="IDXGIFactory6" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDXGIFactory6>(), Is.EqualTo(sizeof(IDXGIFactory6)));
    }

    /// <summary>Validates that the <see cref="IDXGIFactory6" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXGIFactory6).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDXGIFactory6" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXGIFactory6), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXGIFactory6), Is.EqualTo(4));
        }
    }
}
