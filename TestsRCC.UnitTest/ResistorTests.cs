using NUnit.Framework;
using ResistorColorCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsRCC.UnitTest
{
    [TestFixture]
    public class ResistorTests
    {
        [Test]
        public void ShouldReturnZeroWhenBandValueIsNull()
        {
            var sut = new Resistor();
            var isReturningZero = sut.CalculateOhmValue();
            Assert.That(isReturningZero, Is.EqualTo(0));
        }
    }
}
