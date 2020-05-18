using CO2EmissionCalculator.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculatorTest.ServicesTest
{
   public class TransportationFactoryTest
    {
        TranportationFactory tFactory;

          [SetUp]
        public void SetUp()
        {
            tFactory = new TranportationFactory();

        }
        [TestCase("small-diesel-car", 142)]
        [TestCase("small-petrol-car ", 154)]
        [TestCase("small-plugin-hybrid-car", 73)]
        [TestCase("small-electric-car", 50)]
        [TestCase("medium-diesel-car", 171)]
        [TestCase("medium-petrol-car", 192)]
        [TestCase("medium-plugin-hybrid-car", 110)]
        [TestCase("medium-electric-car", 58)]
        [TestCase("large-diesel-car", 209)]
        [TestCase("large-petrol-car", 282)]
        [TestCase("large-plugin-hybrid-car", 126)]
        [TestCase("large-electric-car", 73)]
        [TestCase("bus", 27)]
        [TestCase("train", 6)]
        public void GetEmision_True(string transportType, int actualEmissionrate)
        {
           
            var calculatedEmsion = tFactory.GetEmission(transportType);
            Assert.AreEqual(calculatedEmsion, actualEmissionrate);

        }
        [TestCase("smalldiesel-car", 142)]
        [TestCase("small-petrolcar ", 154)]
        [TestCase("smallplugin-ybrid-car", 73)]

        public void GetEmision_False(string transportType, int actualEmissionrate)
        {
        
            var calculatedEmsion = tFactory.GetEmission(transportType);
            Assert.AreNotEqual(calculatedEmsion, actualEmissionrate);

        }
    }
}
