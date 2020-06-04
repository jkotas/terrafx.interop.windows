// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="REDIRECTION_FUNCTION_DESCRIPTOR" /> struct.</summary>
    public static unsafe class REDIRECTION_FUNCTION_DESCRIPTORTests
    {
        /// <summary>Validates that the <see cref="REDIRECTION_FUNCTION_DESCRIPTOR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<REDIRECTION_FUNCTION_DESCRIPTOR>(), Is.EqualTo(sizeof(REDIRECTION_FUNCTION_DESCRIPTOR)));
        }

        /// <summary>Validates that the <see cref="REDIRECTION_FUNCTION_DESCRIPTOR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(REDIRECTION_FUNCTION_DESCRIPTOR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="REDIRECTION_FUNCTION_DESCRIPTOR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(REDIRECTION_FUNCTION_DESCRIPTOR), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(REDIRECTION_FUNCTION_DESCRIPTOR), Is.EqualTo(12));
            }
        }
    }
}
