using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class LargeCar : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmission { get; set; }
        public LargeCar()
        {
            TransportEmission = new Dictionary<TransportationTypeEnum, int>();
            TransportEmission.Add(TransportationTypeEnum.large_diesel_car, 209);
            TransportEmission.Add(TransportationTypeEnum.large_petrol_car, 282);
            TransportEmission.Add(TransportationTypeEnum.large_plugin_hybrid_car, 126);
            TransportEmission.Add(TransportationTypeEnum.large_electric_car, 73);
        }
    }
}
