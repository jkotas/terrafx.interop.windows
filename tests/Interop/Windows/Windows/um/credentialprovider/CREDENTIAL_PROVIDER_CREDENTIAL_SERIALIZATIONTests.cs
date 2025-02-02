// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION" /> struct.</summary>
public static unsafe partial class CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATIONTests
{
    /// <summary>Validates that the <see cref="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION>(), Is.EqualTo(sizeof(CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION)));
    }

    /// <summary>Validates that the <see cref="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION), Is.EqualTo(28));
        }
    }
}
