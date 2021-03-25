using System;
using System.Collections.Generic;

namespace Lab3
{
    public class Vehicles
    {
        List<Vehicle> vehicles;
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
                    throw new Exception("Try again\n");
                }
                return vehicles[index];
            }
            set
            {
                vehicles.Insert(index, value);
                ++amountOfVehicles;
            }
        }
        public void ShowInfo(int index)
        {
            if (index < 0 || index >= amountOfVehicles)
            {
                Console.WriteLine("Try again\n");
                ShowInfo(index);
                return;
            }
            Console.WriteLine("\n---------------------");
            Console.WriteLine($"Name: {vehicles[index].name}");
            Console.WriteLine($"Type of vehicle: {vehicles[index].TypeOfVehicle}");
            Console.WriteLine($"Type of color: {vehicles[index].TypeOfColor}");
            Console.WriteLine($"Color: {vehicles[index].Color}");
            Console.WriteLine($"Type of engine: {vehicles[index].TypeOfEngine}");
            Console.WriteLine($"Type of fuel: {vehicles[index].TypeOfFuel}");
            Console.WriteLine($"Engine capacity: {vehicles[index].EngineCapacity}");
            Console.WriteLine($"Weight: {vehicles[index].Weight}");
            Console.WriteLine($"Up to 100kmph: {vehicles[index].UpTo100}");
            Console.WriteLine($"Average fuel consumption: {vehicles[index].AverageFuelСonsumption}");
            Console.WriteLine($"Amount of seats: {vehicles[index].AmountOfSeats}");
            Console.WriteLine($"Year of release: {vehicles[index].YearOfRelease}");
            Console.WriteLine($"Vin code: {vehicles[index].Vincode}");
            Console.WriteLine("---------------------\n");
        }
        public void ShowInfo(string vin)
        {
            if (vin.Length != 17)
            {
                Console.WriteLine("Try again\n");
                ShowInfo(vin);
                return;
            }
            for (int i = 0; i < amountOfVehicles; ++i)
            {
                if (vehicles[i].Vincode == vin)
                {
                    ShowInfo(i);
                    break;
                }
            }
        }
        private static int amountOfVehicles;
    }
}