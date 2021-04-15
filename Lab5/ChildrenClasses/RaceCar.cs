﻿using System;

namespace Lab5
{
    public sealed class RaceCar : Car
    {
        public RaceCar() : base()
        {
            UpTo100 = 0;
            AverageRate = 0;
            NameOfTeam = null;
            CaptainName = null;
            TotalCost = 0;
            AmountOfRaceStaff = 0;
            AmountOfTrackStaff = 0;
            OwningCompanyName = null;
            RepresentingCompanyName = null;
        }

        public RaceCar(double averageRate, string nameOfTeam, string captainName, int totalCost, int amountOfRaceStaff, int amountOfTrackStaff, string owningCompanyName, string representingCompanyName,
        string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity, double upTo100, double averageFuelСonsumption, int amountOfSeats, int amountOfDoors, int yearOfRelease, string vincode) 
            : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel, engineCapacity, averageFuelСonsumption, amountOfSeats, amountOfDoors, yearOfRelease, vincode)
        {
            UpTo100 = upTo100;
            AverageRate = averageRate;
            NameOfTeam = nameOfTeam;
            CaptainName = captainName;
            TotalCost = totalCost;
            AmountOfRaceStaff = amountOfRaceStaff;
            AmountOfTrackStaff = amountOfTrackStaff;
            OwningCompanyName = owningCompanyName;
            RepresentingCompanyName = representingCompanyName;
        }

        public RaceCar(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel)
            : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel) { }

        public RaceCar(string nameCar, double engineCapacity, double upTo100, double averageFuelСonsumption, int amountOfSeats, int amountOfDoors, int yearOfRelease, string vincode) 
            : base(nameCar, engineCapacity, averageFuelСonsumption, amountOfSeats, amountOfDoors, yearOfRelease, vincode)
        {
            UpTo100 = upTo100;
        }

        public double UpTo100 { get; set; } = 0;
        public double AverageRate { get; private set; } = 0;
        public string NameOfTeam { get; set; } = null;
        public string CaptainName { get; set; } = null;
        public int TotalCost { get; set; } = 0;
        public int AmountOfRaceStaff { get; set; } = 0;
        public int AmountOfTrackStaff { get; set; } = 0;
        public string OwningCompanyName { get; set; } = null;
        public string RepresentingCompanyName { get; set; } = null;

        public override void GetVehicleInfo()
        {
            Console.WriteLine($"Up to 100kmph: {UpTo100}");
            base.GetVehicleInfo();
        }

        public override void HelpInfo()
        {
            Console.WriteLine(@"
TypesOfVehicle(L, M, N, O); 
TypesOfColor(metalic, nonmetalic); 
Colors(blue, yellow, grey, white, black, brown, green, red, purple, pink);
TypesOfEngine(internalCombustionEngine, electric);
TypesOfFuel(petrol, gasoline, energy, kerosene, diesel, gas);
-----------------------------------------------------------------------------------------------
First constructor get: string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
    Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity,
    double averageFuelСonsumption, int amountOfSeats, int amountOfDoors, int yearOfRelease, string vincode;
-----------------------------------------------------------------------------------------------
Second constructor get: string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
    Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel;
-----------------------------------------------------------------------------------------------
Third constructor get: string nameCar, double engineCapacity, double averageFuelСonsumption, 
    int amountOfSeats, int amountOfDoors, int yearOfRelease, string vincode;
-----------------------------------------------------------------------------------------------
You can get vehicle info by using 'GetVehicleInfo' ;
You can set vin code by using 'SetVin';
You can set team info by using 'SetTeamInfo' (double averageRate, string nameOfTeam, 
    string captainName, int totalCost, int amountOfRaceStaff, int amountOfTrackStaff, 
    string owningCompanyName, string representingCompanyName);
You can get team info by using 'GetTeamInfo'; 
You can set rate of sport car by using 'SetRate' (double rate);
You can upgrade your rate by using 'UpRate' (double up);
You can set rate of safetu by using 'SetRateOfSafety' (double rate);
");
        }

        public void SetRate(double rate)
        {
            if (rate < 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                AverageRate = rate;
            }
        }

        public void UpRate(double up)
        {
            if (up < 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                AverageRate += up;
                Console.WriteLine("Current rate is {0}", AverageRate);
            }
        }

        public void SetTeamInfo(double averageRate, string nameOfTeam, string captainName, int totalCost, int amountOfRaceStaff, int amountOfTrackStaff, string owningCompanyName, string representingCompanyName)
        {
            AverageRate = averageRate;
            NameOfTeam = nameOfTeam;
            CaptainName = captainName;
            TotalCost = totalCost;
            AmountOfRaceStaff = amountOfRaceStaff;
            AmountOfTrackStaff = amountOfTrackStaff;
            OwningCompanyName = owningCompanyName;
            RepresentingCompanyName = representingCompanyName;
        }

        public void GetTeamInfo()
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine($"Name of team: {NameOfTeam}");
            Console.WriteLine($"Average rate: {AverageRate}");
            Console.WriteLine($"The Captain of team: {CaptainName}");
            Console.WriteLine($"Total cost of team: {TotalCost}");
            Console.WriteLine($"Amount of race staff: {AmountOfRaceStaff}");
            Console.WriteLine($"Amount of track staff: {AmountOfTrackStaff}");
            Console.WriteLine($"Name of owning company: {OwningCompanyName}");
            Console.WriteLine($"Name of representing company: {RepresentingCompanyName}");
            Console.WriteLine("---------------------\n");
        }
    }
}
