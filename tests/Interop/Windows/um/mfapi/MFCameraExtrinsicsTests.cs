// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFCameraExtrinsics" /> struct.</summary>
    [SupportedOSPlatform("windows10.0")]
    public static unsafe partial class MFCameraExtrinsicsTests
    {
        /// <summary>Validates that the <see cref="MFCameraExtrinsics" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFCameraExtrinsics>(), Is.EqualTo(sizeof(MFCameraExtrinsics)));
        }

        /// <summary>Validates that the <see cref="MFCameraExtrinsics" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MFCameraExtrinsics).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MFCameraExtrinsics" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MFCameraExtrinsics), Is.EqualTo(48));
        }
    }
}
