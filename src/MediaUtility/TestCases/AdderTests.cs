using System;
using NUnit.Framework;
using MediaLibrary;

namespace TestCases
{
    [TestFixture]
    public class AdderTests
    {
        [Test]
        public void TestSum()
        {
            var a = 3;
            var b = 7;

            var expected = 10;

            var adder = new Adder();

            var actual = adder.Sum(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}