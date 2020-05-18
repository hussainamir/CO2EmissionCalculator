using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class Train : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmision { get; set; }
        public Train()
        {
            TransportEmision = new Dictionary<TransportationTypeEnum, int>();
            TransportEmision.Add(TransportationTypeEnum.train, 6);
        }
    }
}
