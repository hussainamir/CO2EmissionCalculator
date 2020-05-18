using CO2EmissionCalculator.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Interfaces
{
   public interface IParseCommand
    {
        public UserData UserInput { get; set; }
        //public double Emission { get; set; }
        //public double Distance { get; set; }
        //public string UnitOfDistance { get; set; }
        //public string UnitOfOuput { get; set; }
        public UserData ParseArgs(string[] args);
    }
}
