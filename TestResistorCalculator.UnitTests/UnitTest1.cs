using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistorColorCalculator.Models;

namespace TestResistorCalculator.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnZeroWhenBandValueIsNull()
        {
            var sut = new Resistor();
            var isReturningZero = sut.CalculateOhmValue();
            Assert.AreEqual(isReturningZero, 0.0);
        }
        [TestMethod]
        public void ShouldReturnZeroWhenBandValueIsNull()
        {
            var sut = new Resistor();
            var isReturningZero = sut.CalculateOhmValue();
            Assert.AreEqual(isReturningZero, 0.0);
        }
    }
}
