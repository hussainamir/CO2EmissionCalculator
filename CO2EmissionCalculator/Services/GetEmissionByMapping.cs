using CO2EmissionCalculator.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Services
{
  public  class GetEmissionByMapping
    {
        Dictionary<TransportationTypeEnum, int> TrasportMap = new Dictionary<TransportationTypeEnum, int>();
        public GetEmissionByMapping()
        {
            TrasportMap.Add(TransportationTypeEnum.small_diesel_car, 142);
            TrasportMap.Add(TransportationTypeEnum.small_petrol_car, 154);
            TrasportMap.Add(TransportationTypeEnum.small_plugin_hybrid_car, 73);
            TrasportMap.Add(TransportationTypeEnum.small_electric_car, 50);
            TrasportMap.Add(TransportationTypeEnum.medium_diesel_car, 171);
            TrasportMap.Add(TransportationTypeEnum.medium_petrol_car, 192);
            TrasportMap.Add(TransportationTypeEnum.medium_plugin_hybrid_car, 110);
            TrasportMap.Add(TransportationTypeEnum.medium_electric_car, 58);
            TrasportMap.Add(TransportationTypeEnum.large_diesel_car, 209);
            TrasportMap.Add(TransportationTypeEnum.large_petrol_car, 282);
            TrasportMap.Add(TransportationTypeEnum.large_plugin_hybrid_car, 126);
            TrasportMap.Add(TransportationTypeEnum.large_electric_car, 73);
            TrasportMap.Add(TransportationTypeEnum.bus, 27);
            TrasportMap.Add(TransportationTypeEnum.train, 6);
        }
        public double GetEmission(string value)
        {
            value = value.Replace('-', '_');
            TransportationTypeEnum enumtype;
            if (Enum.TryParse(value, out enumtype))
            {
                return TrasportMap[enumtype];
            }
            return 0;
            //Runtime complexity O(1)
        }
    }
}
