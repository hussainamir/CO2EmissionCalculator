using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Model;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CO2EmissionCalculator.Services
{
   public class ParseCommand: IParseCommand
    {
        //public double Emission { get; set; }
        //public double Distance { get; set; }
        //public string UnitOfDistance { get; set; }
        //public string UnitOfOuput { get; set; }
        public UserData UserInput { get; set; }
        List<string> Args = new List<string>();
        public ParseCommand()
        {
            UserInput = new UserData();
           
        }
       /// <summary>
       /// Parse User command
       /// </summary>
       /// <param name="args"></param>
        public UserData ParseArgs(string[] args)
        {
            splitFlagsAndValues(args);

            for (int i = 1; i < Args.Count; i += 2)
            {
                var arg = Args[i - 1];
                var value = Args[i];
                if (new Regex(@"^--").IsMatch(arg) && !(new Regex(@"^--").IsMatch(value)))
                {
                    switch (arg)
                    {
                        case Constants.TransportationMethod:
                            UserInput.Emission = emissionByFactoryMethod(value);
                            break;
                        case Constants.Distance:
                            double _distance = 0;
                            double.TryParse(value, out _distance);
                            UserInput.Distance = _distance;
                            break;
                        case Constants.UnitOfDistance:
                            UserInput.UnitOfDistance = value;
                            break;
                        case Constants.OutPut:
                            UserInput.UnitOfOuput = value;
                            break;
                        default:
                            break;
                    }
                }
            }
           
            //runtime complexity is O(N/2)
            return UserInput;
        }
        /// <summary>
        /// Split user command line into Flag and value and add into list
        /// </summary>
        /// <param name="args"></param>
        private void splitFlagsAndValues(string[] args)
        {
            
            for (int i = 0; i < args.Length; i++)
            {
                var arg = args[i];
                var equalSing = Constants.EqualSign;
                if (arg.Contains(equalSing) || arg.Any(char.IsWhiteSpace))
                {
                    var split = arg.Split(new char[] { equalSing, ' ' });
                    Args.Add(split[0]);
                    Args.Insert(Args.Count, split[1]);
                }
                else
                {
                    Args.Add(arg);
                }
            }
            // Runtime complexity O(N)
        }

        /// <summary>
        /// Get Emission by using Factory design pattern 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private double emissionByFactoryMethod(string value)
        {
            return new TranportationFactory().GetEmission(value);
        }
        /// <summary>
        /// Get Emission by using Mapping(C# Dictionary) technique
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private double emissionByMappingMethod(string value)
        {

            return new GetEmissionByMapping().GetEmission(value);
        }
    }
}
