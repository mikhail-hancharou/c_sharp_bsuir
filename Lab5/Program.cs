using System;
using System.Collections.Generic;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car
            {
                Name = "Tesla Car",
                TypeOfVehicle = Vehicle.TypesOfVehicle.M,
                TypeOfColor = Vehicle.TypesOfColor.metalic,
                Color = Vehicle.Colors.red,
                TypeOfEngine = Vehicle.TypesOfEngine.electric,
                TypeOfFuel = Vehicle.TypesOfFuel.energy,
                EngineCapacity = 90, //kWh or liters
                AverageFuelСonsumption = 200, //W*h/km or liters
                AmountOfSeats = 6,
                YearOfRelease = 2021
            };
            auto.SetVin("1294HFJ93JDSD4325");
            RaceCar sportCar = new RaceCar
            {
                Name = "Toyota Subaru",
                TypeOfVehicle = Vehicle.TypesOfVehicle.M,
                TypeOfColor = Vehicle.TypesOfColor.metalic,
                Color = Vehicle.Colors.white,
                TypeOfEngine = Vehicle.TypesOfEngine.internalCombustionEngine,
                TypeOfFuel = Vehicle.TypesOfFuel.gasoline,
                EngineCapacity = 4, //kWh or liters
                AverageFuelСonsumption = 9, //W*h/km or liters
                AmountOfSeats = 2,
                YearOfRelease = 2012,
            };
            sportCar.SetRate(7.6);
            sportCar.UpRate(0.1);
            sportCar.SetRateOfSafety(4.2);
            sportCar.SetTeamInfo(7.6, "Subaru Masters", "Cederico Dajabello", 5600000, 6, 4, "Toyota", "Toyota");
            sportCar.SetVin("1264NUTQPXOAM0285");
            sportCar.GetVehicleInfo();
            sportCar.GetTeamInfo();
            Vehicles vehicles = new Vehicles();
            vehicles[0] = auto;
            vehicles[1] = sportCar;
            vehicles.ShowMinInfo(1);
            vehicles.ShowMinInfo("1294HFJ93JDSD4325");
            sportCar.HelpInfo();
            HardTruck truck = new HardTruck
            {
                Name = "Thunder Truck",
                TypeOfVehicle = Vehicle.TypesOfVehicle.N,
                TypeOfColor = Vehicle.TypesOfColor.metalic,
                Color = Vehicle.Colors.yellow,
                TypeOfEngine = Vehicle.TypesOfEngine.internalCombustionEngine,
                TypeOfFuel = Vehicle.TypesOfFuel.petrol,
                EngineCapacity = 320, //kWh or liters
                AverageFuelСonsumption = 20, //W*h/km or liters
                YearOfRelease = 2020,
                Weight = 7250,
                TypeOfTruck = HardTruck.TypesOfTruck.pileDrivingMachines
            };
            truck.SetVin("6842AMCHRYSSI8214");
            truck.SetWeightPossibilities(12000);
            truck.UpWeightPossibilities(1000);
            truck.AddSkill(HardTruck.TypesOfTruck.pipeLayingMachines);
            truck.GetVehicleInfo();
            Helicopter copter = new Helicopter
            {
                Name = "Heli-Meli-Copter",
                TypeOfVehicle = Vehicle.TypesOfVehicle.Flying,
                TypeOfColor = Vehicle.TypesOfColor.nonmetalic,
                Color = Vehicle.Colors.green,
                TypeOfEngine = Vehicle.TypesOfEngine.internalCombustionEngine,
                TypeOfFuel = Vehicle.TypesOfFuel.diesel,
                EngineCapacity = 400, //kWh or liters
                AverageFuelСonsumption = 17, //W*h/km or liters
                YearOfRelease = 2020,
                TypeOfHelicopter = Helicopter.TypesOfHelicopters.jet,
                TypeOfProperty = Helicopter.TypesOfProperty.personal,
                LiftingCapacity = 7000
            };
            copter.SetVin("1234CMYEFGGHI6789");
            copter.SetCurrentWorkload(3500);
            copter.AddCargo(4000);
            copter.GetVehicleInfo();
            Vehicle transport = new Car();
            Car peca = new RaceCar();
            RaceCar pecoe = new RaceCar();
            transport.GetVehicleInfo();
            peca.GetVehicleInfo();
            peca.HelpInfo();
            Console.ReadKey();
        }
    }
}