using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle auto = new Vehicle();
            auto.name = "Tesla Car";
            auto.TypeOfVehicle = Vehicle.TypesOfVehicle.M;
            auto.TypeOfColor = Vehicle.TypesOfColor.metalic;
            auto.Color = Vehicle.Colors.red;
            auto.TypeOfEngine = Vehicle.TypesOfEngine.electric;
            auto.TypeOfFuel = Vehicle.TypesOfFuel.energy;
            auto.EngineCapacity = 90; //kWh or liters
            auto.Weight = 1890;
            auto.UpTo100 = 1.9;
            auto.AverageFuelСonsumption = 200; //W*h/km or liters
            auto.AmountOfSeats = 6;
            auto.YearOfRelease = 2021;
            auto.SetVin("1294HFJ93JDSD4325");
            Console.WriteLine($"Name: {auto.name}");
            Console.WriteLine($"Type of vehicle: {auto.TypeOfVehicle}");
            Console.WriteLine($"Type of color: {auto.TypeOfColor}");
            Console.WriteLine($"Color: {auto.Color}");
            Console.WriteLine($"Type of engine: {auto.TypeOfEngine}");
            Console.WriteLine($"Type of fuel: {auto.TypeOfFuel}");
            Console.WriteLine($"Engine capacity: {auto.EngineCapacity}");
            Console.WriteLine($"Weight: {auto.Weight}");
            Console.WriteLine($"Up to 100kmph: {auto.UpTo100}");
            Console.WriteLine($"Average fuel consumption: {auto.AverageFuelСonsumption}");
            Console.WriteLine($"Amount of seats: {auto.AmountOfSeats}");
            Console.WriteLine($"Year of release: {auto.YearOfRelease}");
            Console.WriteLine($"Vin code: {auto.Vincode}");
            Vehicles vehicles = new Vehicles();
            vehicles[0] = auto;
            vehicles.ShowInfo(0);
            vehicles.ShowInfo("1294HFJ93JDSD4325");
            Console.ReadKey();
        }
    }
}
