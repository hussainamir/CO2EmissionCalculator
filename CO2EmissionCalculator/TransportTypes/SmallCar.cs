using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class SmallCar : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmision { get; set; }
        public SmallCar()
        {
            TransportEmision = new Dictionary<TransportationTypeEnum, int>();
            TransportEmision.Add(TransportationTypeEnum.small_diesel_car, 142);
            TransportEmision.Add(TransportationTypeEnum.small_petrol_car, 154);
            TransportEmision.Add(TransportationTypeEnum.small_plugin_hybrid_car, 73);
            TransportEmision.Add(TransportationTypeEnum.small_electric_car, 50);
        }
    }
}
