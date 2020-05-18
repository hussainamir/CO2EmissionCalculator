using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class Bus : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmision { get; set; }
        public Bus()
        {
            TransportEmision = new Dictionary<TransportationTypeEnum, int>();
            TransportEmision.Add(TransportationTypeEnum.bus, 27);
        }
    }
}
