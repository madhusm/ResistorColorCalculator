// <copyright file="ResistorTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistorColorCalculator.Models;

namespace ResistorColorCalculator.Models.Tests
{
    /// <summary>This class contains parameterized unit tests for Resistor</summary>
    [PexClass(typeof(Resistor))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ResistorTest
    {
        /// <summary>Test stub for CalculateOhmValue()</summary>
        [PexMethod]
        public double CalculateOhmValueTest([PexAssumeUnderTest]Resistor target)
        {
            double result = target.CalculateOhmValue();
            return result;
            // TODO: add assertions to method ResistorTest.CalculateOhmValueTest(Resistor)
        }
    }
}
