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
            var split = value.Split('-');           
            if (split.Length >= 1)
            {
                TrasportationCategoryEnum transportEnum;
                if (Enum.TryParse(split[0], out transportEnum))
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

            var transporterTypeString = value.Replace('-', '_');
            TransportationTypeEnum enumtype;

            if (Enum.TryParse(transporterTypeString, out enumtype))
                return transport.TransportEmision[enumtype];

            return 0;

        }
    }
    
}
