// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WTSSESSION_NOTIFICATION" /> struct.</summary>
    public static unsafe class WTSSESSION_NOTIFICATIONTests
    {
        /// <summary>Validates that the <see cref="WTSSESSION_NOTIFICATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WTSSESSION_NOTIFICATION>(), Is.EqualTo(sizeof(WTSSESSION_NOTIFICATION)));
        }

        /// <summary>Validates that the <see cref="WTSSESSION_NOTIFICATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WTSSESSION_NOTIFICATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WTSSESSION_NOTIFICATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WTSSESSION_NOTIFICATION), Is.EqualTo(8));
        }
    }
}
