using System;
using NUnit.Framework;

namespace SampleLibrary.Tests
{
    public class GreetingGeneratorTests
    {
        private GreetingGenerator greetingGenerator;

        [SetUp]
        public void Setup()
        {
            greetingGenerator = new GreetingGenerator();
        }

        [Test]
        public void ReturnsGivenNameInGreeting()
        {
            string greeting = greetingGenerator.GenerateGreeting("John");

            Assert.AreEqual("Hello, John!", greeting);
        }

        [Test]
        public void ThrowsForNullName()
        {
            Assert.Throws<ArgumentNullException>(() => greetingGenerator.GenerateGreeting(null));
        }
    }
}