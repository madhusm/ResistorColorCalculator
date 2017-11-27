using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistorColorCalculator.Models;

namespace TestResistorCalculator.UnitTests
{
    [TestClass]
    public class ResitorUnitTest
    {
        [TestMethod]
        public void ShouldReturnZeroWhenBandValueIsNull()
        {
            var sut = new Resistor();
            var isReturningZero = sut.CalculateOhmValue();
            Assert.AreEqual(isReturningZero, 0.0);
        }
        [TestMethod]
        public void ShouldReturnValueWhenBandValueIsNotNull()
        {
            var sut = new Resistor();
            sut.BandAColor = "Brown";
            sut.BandBColor = "Orange";
            sut.BandCColor = "Gold";
            sut.BandDColor = "Violet";
            var isReturningZero = sut.CalculateOhmValue();
            Assert.AreNotEqual(isReturningZero, 0.0);
        }

        [TestMethod]
        public void ShouldReturnDefinetValueWhenBandValueIsNotNull()
        {
            var sut = new Resistor();
            sut.BandAColor = "Brown";
            sut.BandBColor = "green";
            sut.BandCColor = "Silver";
            sut.BandDColor = "Violet";
            var isReturningZero = sut.CalculateOhmValue();
            Assert.AreEqual(isReturningZero, 0.15);
        }
    }
}
