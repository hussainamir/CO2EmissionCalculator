using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Model
{
  public  class UserData
    {
       
        public double Emission { get; set; }
        public double Distance { get; set; }
        public string UnitOfDistance { get; set; }
        public string UnitOfOuput { get; set; }
    }
}
