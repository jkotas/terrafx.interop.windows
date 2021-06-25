// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IRpcSyntaxNegotiate" /> struct.</summary>
    public static unsafe class IRpcSyntaxNegotiateTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IRpcSyntaxNegotiate" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IRpcSyntaxNegotiate).GUID, Is.EqualTo(IID_IRpcSyntaxNegotiate));
        }

        /// <summary>Validates that the <see cref="IRpcSyntaxNegotiate" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IRpcSyntaxNegotiate>(), Is.EqualTo(sizeof(IRpcSyntaxNegotiate)));
        }

        /// <summary>Validates that the <see cref="IRpcSyntaxNegotiate" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IRpcSyntaxNegotiate).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IRpcSyntaxNegotiate" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IRpcSyntaxNegotiate), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IRpcSyntaxNegotiate), Is.EqualTo(4));
            }
        }
    }
}
