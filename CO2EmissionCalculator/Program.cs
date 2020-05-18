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
            // Resolve dependency injection 
            RegisterServices();
         
            // args = new string[] { "--transportation-method", "medium-diesel-car", "--distance=15", "--unit-of-distance=km" };
            // Get ICalculateEmission instance 
            var calculatEmission= _serviceProvider.GetService<ICalculateEmission>();
            
            // Parse UserInformation 
            calculatEmission.GetUserCommand(args);
            // Calculate emission rate by given distance and transporter type
            var output = calculatEmission.Emission_Calculator();
            // Display output into console window
            Console.WriteLine($"Your trip caused {output} of CO2-equivalent");

           // releasing unmanaged resources
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
