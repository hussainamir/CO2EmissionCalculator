using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.TransportTypes
{
    public class Train : ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmission { get; set; }
        public Train()
        {
            TransportEmission = new Dictionary<TransportationTypeEnum, int>();
            TransportEmission.Add(TransportationTypeEnum.train, 6);
        }
    }
}
