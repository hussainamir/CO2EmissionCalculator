
# Name of the poject
CO2 emission calculator

 Create a program that returns the amount of CO2-equivalent that will be caused 
 when traveling a given distance using a given transportation method.

## Getting started
```shell
1) .NetCor 3.1 
2)  Visual Studio 2019
3)  Nuget Packges
        (i) Microsoft Extension Dependency Injection (3.1.4)
        (ii) NUnit (3.12.0)
```
## How to run 
```shell
In project folder click on "ExectueProgram.bat"  
the console window will open atuomatically, 
```

Write command i.e   dotnet run YourCOmmand
dotnet run -- --unit-of-distance=km --distance 15 --transportation-method=medium-diesel-car

## CO2EmissionCalculator
Project divided into four parts according to functionality 
1) Take user information and parse it            **(IParseCommand.cs)**

2) Find Emission rate accroding to transport type
        i) Mapping method                        **(GetEmissionByMapping.cs)**
        or 
        ii) Factory design pattern               **(TransportationFactory.cs)**

3) Calculte Emission by given distance           **(ICalculateEmission.cs)**

4) Resolve dependency injection and display output **(Program.cs)**

##CO2EmissionCalculatorTest
This project is used to write unit test for "CO2EmissionCalculator" project
