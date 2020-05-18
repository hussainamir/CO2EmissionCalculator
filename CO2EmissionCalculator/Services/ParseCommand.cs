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
        
        public UserData UserInput { get; set; }
        List<string> Args = new List<string>();
        public ParseCommand()
        {
            UserInput = new UserData();
           
        }
       /// <summary>
       /// this method parse user information from string array to UserData
       /// </summary>
       /// <param name="args"></param>
        public UserData ParseArgs(string[] args)
        {
            //if any array element consist of equal sign or space then split
            // and add into list
            splitFlagsAndValues(args);

            //Split Flages and values from Args List
            for (int i = 1; i < Args.Count; i += 2)
            {
                //assume that (i-1)th elment is flag and ith element is value
                var arg = Args[i - 1];
                var value = Args[i];
                //(i-1)th element should be flag and ith element should be value
                // where flag sting consist on -- and value are without -- characters 
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
            
            return UserInput;

            //runtime complexity is O(N/2)
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
                var equalSign = Constants.EqualSign;
                //split ith element if it contains euqal sign or space character,
                if (arg.Contains(equalSign) || arg.Any(char.IsWhiteSpace))
                {
                    var split = arg.Split(new char[] { equalSign, ' ' });
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
