namespace ClrCoder.Starship.Tests
{
    using System;

    using FluentAssertions;

    using NUnit.Framework;

    [TestFixture]
    public class NuclearReactorTests
    {
        [Test]
        public void SimpleTest()
        {
            // Trying to get 1MW forever.
            new NuclearReactor().GetRunningTimeForConsuption(1000000.0).Should().Be(TimeSpan.MaxValue);
        }
    }
}
