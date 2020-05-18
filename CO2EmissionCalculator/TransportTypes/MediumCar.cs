using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class MediumCar : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmission { get; set; }
        public MediumCar()
        {
            TransportEmission = new Dictionary<TransportationTypeEnum, int>();
            TransportEmission.Add(TransportationTypeEnum.medium_diesel_car, 171);
            TransportEmission.Add(TransportationTypeEnum.medium_petrol_car, 192);
            TransportEmission.Add(TransportationTypeEnum.medium_plugin_hybrid_car, 110);
            TransportEmission.Add(TransportationTypeEnum.medium_electric_car, 58);
        }
    }
}
