// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IActiveIMMMessagePumpOwner" /> struct.</summary>
    public static unsafe class IActiveIMMMessagePumpOwnerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IActiveIMMMessagePumpOwner" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IActiveIMMMessagePumpOwner).GUID, Is.EqualTo(IID_IActiveIMMMessagePumpOwner));
        }

        /// <summary>Validates that the <see cref="IActiveIMMMessagePumpOwner" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IActiveIMMMessagePumpOwner>(), Is.EqualTo(sizeof(IActiveIMMMessagePumpOwner)));
        }

        /// <summary>Validates that the <see cref="IActiveIMMMessagePumpOwner" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IActiveIMMMessagePumpOwner).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IActiveIMMMessagePumpOwner" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IActiveIMMMessagePumpOwner), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IActiveIMMMessagePumpOwner), Is.EqualTo(4));
            }
        }
    }
}
