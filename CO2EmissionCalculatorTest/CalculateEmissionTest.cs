using CO2EmissionCalculator;
using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculatorTest
{
 public   class CalculateEmissionTest
    {
        ICalculateEmission cEmission;
        [SetUp]
        public void SetUp()
        {
            cEmission = new CalculateEmission(new ParseCommand());

        }
        /// <summary>
        /// Test Emission method for true values, 
        /// </summary>
        /// <param name="argValue"></param>
        /// <param name="actualResult"></param>
        [TestCase(new string[] { "--transportation-method", "medium-diesel-car", "--distance 15", "--unit-of-distance km" }, "2.6kg")]
        [TestCase(new string[] { "--transportation-method", "large-petrol-car", "--distance=1800.5" }, "507.7kg")]
        [TestCase(new string[] { "--unit-of-distance=m", "--distance", "14500", "--transportation-method=train" }, "87g")]
        [TestCase(new string[] { "--unit-of-distance=m", "--distance=14500", "--transportation-method=train", "--output", "kg" }, "0.1kg")]
        [TestCase(new string[] { "--unit-of-distance=km", "--distance 15", "--transportation-method=medium-diesel-car " }, "2.6kg")]
        [TestCase(new string[] { "--unit-of-distance=km", "--distance", "15", "--transportation-method=medium-diesel-car " }, "2.6kg")]
        public void Emission_True(string[] argValue, string actualResult)
        {            
            cEmission.GetUserCommand(argValue);
            var expected = cEmission.Emission_Calculator();
            Assert.AreEqual(expected, actualResult);
        }
        /// <summary>
        /// Test Emission method with false values, 
        /// </summary>
        /// <param name="argValue"></param>
        /// <param name="actualResult"></param>
        [TestCase(new string[] { "--transportation-method", "medium-diesel-car", "--distance", "--15", "--unit-of-distance km" }, "2.6kg")]
        [TestCase(new string[] { "--transportation-methodlarge-petrol-car", "--distance=1800.5" }, "507.7kg")]
        [TestCase(new string[] { "--unit-of-distance=m", "--distance", "140500", "--transportation-method=train" }, "87g")]
        [TestCase(new string[] { "--unit-of-distance=m", "--distance 14500--transportation-method=train", "--output", "kg" }, "0.1kg")]
        [TestCase(new string[] { "--unit-of-distance=km", "--distance 1005", "--transportation-method=medium-diesel-car " }, "2.6kg")]
        [TestCase(new string[] { "--unit-of-distance=km", "--distance", "15", "--transportation-methodmedium-diesel-car " }, "2.6kg")]
        public void Emission_False(string[] argValue, string actualResult)
        {
           
            cEmission.GetUserCommand(argValue);
            var expected = cEmission.Emission_Calculator();
            Assert.AreNotEqual(expected, actualResult);
        }
    }
}
