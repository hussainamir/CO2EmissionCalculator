using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Interfaces
{
   
    public interface ITransport
    {
        public Dictionary<TransportationTypeEnum, int> TransportEmission { get; set; }
    }
}
