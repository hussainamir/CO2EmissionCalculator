using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Utilities
{
    public static class Constants
    {
        public const string KiloMetter = "km";
        public const string Metter = "m";
        public const string KiloGram = "kg";
        public const string Gram = "g";

        public const string TransportationMethod = "--transportation-method";
        public const string Distance = "--distance";
        public const string UnitOfDistance = "--unit-of-distance";
        public const string OutPut = "--output";

        public const char EqualSign = '=';
    }
    public enum TransportationTypeEnum
    {
        small_diesel_car,
        small_petrol_car,
        small_plugin_hybrid_car,
        small_electric_car,
        medium_diesel_car,
        medium_petrol_car,
        medium_plugin_hybrid_car,
        medium_electric_car,
        large_diesel_car,
        large_petrol_car,
        large_plugin_hybrid_car,
        large_electric_car,
        bus,
        train
    }
    public enum TrasportationCategoryEnum
    {
        small,
        medium,
        large,
        bus,
        train
    };
}
