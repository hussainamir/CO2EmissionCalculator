using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class Bus : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmission { get; set; }
        public Bus()
        {
            TransportEmission = new Dictionary<TransportationTypeEnum, int>();
            TransportEmission.Add(TransportationTypeEnum.bus, 27);
        }
    }
}
