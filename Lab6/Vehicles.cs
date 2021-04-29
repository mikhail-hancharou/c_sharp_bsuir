using System;
using System.Collections.Generic;

namespace lab6
{
    public class Vehicles
    {
        private List<Vehicle> vehicles;

        public Vehicles()
        {
            vehicles = new List<Vehicle>();
            amountOfVehicles = 0;
        }

        public Vehicle this[int index]
        {
            get
            {
                if (index < 0 || index >= amountOfVehicles)
                {
                    throw new ArgumentException("Try again\n");
                }
                return vehicles[index];
            }
            set
            {
                vehicles.Insert(index, value);
                ++amountOfVehicles;
            }
        }

        public void ShowMinInfo(string vin)
        {
            if (vin.Length != 17)
            {
                Console.WriteLine("Invalid input\n");
                ShowMinInfo(vin);
                return;
            }
            for (int index = 0; index < amountOfVehicles; ++index)
            {
                if (vehicles[index].Vincode == vin)
                {
                    Console.WriteLine("\n---------------------");
                    Console.WriteLine($"Name: {vehicles[index].Name}");
                    Console.WriteLine($"Type of vehicle: {vehicles[index].TypeOfVehicle}");
                    Console.WriteLine($"Type of color: {vehicles[index].TypeOfColor}");
                    Console.WriteLine($"Color: {vehicles[index].Color}");
                    Console.WriteLine($"Type of engine: {vehicles[index].TypeOfEngine}");
                    Console.WriteLine($"Type of fuel: {vehicles[index].TypeOfFuel}");
                    Console.WriteLine($"Engine capacity: {vehicles[index].EngineCapacity}");
                    Console.WriteLine($"Average fuel consumption: {vehicles[index].AverageFuelСonsumption}");
                    Console.WriteLine($"Year of release: {vehicles[index].YearOfRelease}");
                    Console.WriteLine($"Vin code: {vehicles[index].Vincode}");
                    Console.WriteLine("---------------------\n");
                    break;
                }
            }
        }

        public void ShowMinInfo(int index)
        {
            ShowMinInfo(vehicles[index].Vincode);
        }
        private static int amountOfVehicles;
    }
}
