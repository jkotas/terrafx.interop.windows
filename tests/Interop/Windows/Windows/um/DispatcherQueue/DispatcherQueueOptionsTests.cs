// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DispatcherQueue.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DispatcherQueueOptions" /> struct.</summary>
public static unsafe partial class DispatcherQueueOptionsTests
{
    /// <summary>Validates that the <see cref="DispatcherQueueOptions" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispatcherQueueOptions>(), Is.EqualTo(sizeof(DispatcherQueueOptions)));
    }

    /// <summary>Validates that the <see cref="DispatcherQueueOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispatcherQueueOptions).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DispatcherQueueOptions" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DispatcherQueueOptions), Is.EqualTo(12));
    }
}
