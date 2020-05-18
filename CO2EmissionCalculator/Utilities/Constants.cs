using System;
using System.Collections.Generic;
using System.Text;

namespace CO2EmissionCalculator.Utilities
{
    public static class Constants
    {
        //define distance and weight units 
        public const string KiloMetter = "km";
        public const string Metter = "m";
        public const string KiloGram = "kg";
        public const string Gram = "g";

        //define flags contants 
        public const string TransportationMethod = "--transportation-method";
        public const string Distance = "--distance";
        public const string UnitOfDistance = "--unit-of-distance";
        public const string OutPut = "--output";

        public const char EqualSign = '=';
    }
    /// <summary>
    /// Define Transportion type enum, this enum consist all type of transport
    /// </summary>
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
    /// <summary>
    /// Define transprotation category enum 
    /// </summary>
    public enum TransportationCategoryEnum
    {
        small,
        medium,
        large,
        bus,
        train
    };
}
