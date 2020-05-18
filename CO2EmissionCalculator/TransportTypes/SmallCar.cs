using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class SmallCar : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmission { get; set; }
        public SmallCar()
        {
            TransportEmission = new Dictionary<TransportationTypeEnum, int>();
            TransportEmission.Add(TransportationTypeEnum.small_diesel_car, 142);
            TransportEmission.Add(TransportationTypeEnum.small_petrol_car, 154);
            TransportEmission.Add(TransportationTypeEnum.small_plugin_hybrid_car, 73);
            TransportEmission.Add(TransportationTypeEnum.small_electric_car, 50);
        }
    }
}
