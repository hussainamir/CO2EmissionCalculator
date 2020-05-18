using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.TransportTypes;
using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Services
{
  public class TranportationFactory
    {
        /// <summary>
        /// Get Emission by using Factory Design Pattern
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public double GetEmission(string value)
        {
            ITransport transport = null;          
            //split user input string, as it contains '-' 
            var split = value.Split('-');           
            if (split.Length >= 1)
            {
                //Convert first element of splitted string into 
                //TransportationCategoryEnum type
                TrasportationCategoryEnum transportEnum;
                if (Enum.TryParse(split[0], out transportEnum))
                {
                    //Create trasport object at runtime (Factory desing pattern)
                    switch (transportEnum)
                    {
                        case TrasportationCategoryEnum.train:
                            transport = new Train();
                            break;
                        case TrasportationCategoryEnum.bus:
                            transport = new Bus();
                            break;
                        case TrasportationCategoryEnum.medium:
                            transport = new MediumCar();
                            break;
                        case TrasportationCategoryEnum.small:
                            transport = new SmallCar();
                            break;
                        case TrasportationCategoryEnum.large:
                            transport = new LargeCar();
                            break;
                    }
                }

            }


         return   getEmissionFromTransportType(value, transport);
        }
        /// <summary>
        /// get emission from transport type object 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="transport"></param>
        /// <returns></returns>
        private double getEmissionFromTransportType(string value, ITransport transport)
        {
            //Replace user input string from '-' to '_'
            var transporterTypeString = value.Replace('-', '_');
            TransportationTypeEnum enumtype;
            //Convert transporterTypeString string into 
            // TransportationTypeEnum type
            if (Enum.TryParse(transporterTypeString, out enumtype))
            //get emission from  TransportEmission Dictionary
                return transport.TransportEmission[enumtype];

            return 0;
        }
    }
    
}
