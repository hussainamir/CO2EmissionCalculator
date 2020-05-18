using CO2EmissionCalculator.Interfaces;
using CO2EmissionCalculator.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CO2EmissionCalculator
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            RegisterServices();
           // args = new string[] { "--transportation-method", "medium-diesel-car", "--distance=15", "--unit-of-distance=km" };
            var calculatEmission= _serviceProvider.GetService<ICalculateEmission>();

            calculatEmission.GetUserCommand(args);
            Console.WriteLine($"Your trip caused {calculatEmission.Emission_Calculator()} of CO2-equivalent");

            DisposeServices();
        }
        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IParseCommand, ParseCommand>();
            collection.AddScoped<ICalculateEmission, CalculateEmission>();
            _serviceProvider = collection.BuildServiceProvider();
        }
        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
