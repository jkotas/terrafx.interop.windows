// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserConsentVerifierInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="IUserConsentVerifierInterop" /> struct.</summary>
public static unsafe partial class IUserConsentVerifierInteropTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUserConsentVerifierInterop" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IUserConsentVerifierInterop).GUID, Is.EqualTo(IID_IUserConsentVerifierInterop));
    }

    /// <summary>Validates that the <see cref="IUserConsentVerifierInterop" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IUserConsentVerifierInterop>(), Is.EqualTo(sizeof(IUserConsentVerifierInterop)));
    }

    /// <summary>Validates that the <see cref="IUserConsentVerifierInterop" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUserConsentVerifierInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IUserConsentVerifierInterop" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUserConsentVerifierInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUserConsentVerifierInterop), Is.EqualTo(4));
        }
    }
}
