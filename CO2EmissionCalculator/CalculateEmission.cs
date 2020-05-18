using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Model;
using CO2EmissionCalculator.Services;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator
{
 public class CalculateEmission: ICalculateEmission
    {
        private IParseCommand _parseCommand;
        
        double _gram = 1.0;
        string weightSign = string.Empty;
        private UserData _userInput { get; set; }
       
        public CalculateEmission(IParseCommand parseCommand)
        {
            _parseCommand = parseCommand;          
           
        }
        public void GetUserCommand(string[] args)
        {
          _userInput=  _parseCommand.ParseArgs(args);
        }
        public string Emission_Calculator()
        {
           
            findOutPutUnit();
            var emission = _userInput.Emission * convertedDistance() / _gram;            
            return $"{Math.Round(emission, 1)}{weightSign}";
        }
        private void findOutPutUnit()
        {
            
            if (_userInput.UnitOfDistance == Constants.Metter)
            {
                if (_userInput.UnitOfOuput == Constants.KiloGram)
                {
                    _gram = 1000; weightSign = Constants.KiloGram;
                }
                else { _gram = 1; weightSign = Constants.Gram; }
            }
            else
            {
                if (_userInput.UnitOfOuput == Constants.Gram)
                {
                    _gram = 1; weightSign = Constants.Gram;
                }
                else { _gram = 1000; weightSign = Constants.KiloGram; }
            }

        }  
        
        //convert distance into km if distance is m
        private double convertedDistance()
        {
          
            var distance = _userInput.Distance;
            distance = _userInput.UnitOfDistance == Constants.Metter ? distance / 1000 : distance;
            return distance;
        }
    }
}
