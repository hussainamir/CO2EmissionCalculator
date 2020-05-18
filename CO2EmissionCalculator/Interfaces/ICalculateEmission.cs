using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Interfaces
{
  public interface ICalculateEmission
    {
        public void GetUserCommand(string[] args);
        public string Emission_Calculator();
    }
}
