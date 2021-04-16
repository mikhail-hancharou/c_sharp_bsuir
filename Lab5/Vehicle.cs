using System;

namespace Lab5
{
    public abstract class Vehicle
    {
        public enum TypesOfVehicle
        {
            L,
            M,
            N,
            O,
            Flying,
            undefined
        }

        public enum TypesOfColor
        {
            metalic,
            nonmetalic,
            undefined
        }

        public enum Colors
        {
            blue,
            yellow,
            grey,
            white,
            black,
            brown,
            green,
            red,
            purple,
            pink,
            undefined
        }

        public enum TypesOfEngine
        {
            internalCombustionEngine,
            electric,
            undefined
        }

        public enum TypesOfFuel
        {
            petrol,
            gasoline,
            energy,
            kerosene,
            diesel,
            gas,
            undefined
        }

        public string Name { get; set; }
        public TypesOfVehicle TypeOfVehicle { get; set; }
        public TypesOfColor TypeOfColor { get; set; }
        public Colors Color { get; set; }
        public TypesOfEngine TypeOfEngine { get; set; }
        public TypesOfFuel TypeOfFuel { get; set; }
        public double EngineCapacity { get; set; }
        public double AverageFuelСonsumption { get; set; }
        public int YearOfRelease { get; set; }
        public string Vincode { get; private set; }

        public Vehicle()
        {
            Name = null;
            TypeOfVehicle = TypesOfVehicle.undefined;
            TypeOfColor = TypesOfColor.undefined;
            Color = Colors.undefined;
            TypeOfEngine = TypesOfEngine.undefined;
            TypeOfFuel = TypesOfFuel.undefined;
            EngineCapacity = 0;
            AverageFuelСonsumption = 0;
            YearOfRelease = 0;
            Vincode = null;
        }

        public Vehicle(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity, double averageFuelСonsumption, int yearOfRelease, string vincode)
        {
            Name = nameCar;
            TypeOfVehicle = typesOfVehicle;
            TypeOfColor = typesOfColor;
            Color = colors;
            TypeOfEngine = typesOfEngine;
            TypeOfFuel = typesOfFuel;
            EngineCapacity = engineCapacity;
            AverageFuelСonsumption = averageFuelСonsumption;
            YearOfRelease = yearOfRelease;
            Vincode = vincode;
        }

        public Vehicle(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel)
        {
            Name = nameCar;
            TypeOfVehicle = typesOfVehicle;
            TypeOfColor = typesOfColor;
            Color = colors;
            TypeOfEngine = typesOfEngine;
            TypeOfFuel = typesOfFuel;
        }

        public Vehicle(string nameCar, double engineCapacity, double averageFuelСonsumption, int yearOfRelease, string vincode)
        {
            Name = nameCar;
            EngineCapacity = engineCapacity;
            AverageFuelСonsumption = averageFuelСonsumption;
            YearOfRelease = yearOfRelease;
            Vincode = vincode;
        }

        public void SetVin(string vin)
        {
            Vincode = vin;
        }

        public virtual void HelpInfo()
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
                    double averageFuelСonsumption, int yearOfRelease, string vincode;
                -----------------------------------------------------------------------------------------------
                Second constructor get: string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
                    Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel;
                -----------------------------------------------------------------------------------------------
                Third constructor get: string nameCar, double engineCapacity, double averageFuelСonsumption, 
                    int yearOfRelease, string vincode;
                -----------------------------------------------------------------------------------------------
                You can get vehicle info by using 'GetVehicleInfo';
                You can set vin code by using 'SetVin';
                ");
        }

        public virtual void GetVehicleInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type of vehicle: {TypeOfVehicle}");
            Console.WriteLine($"Type of color: {TypeOfColor}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Type of engine: {TypeOfEngine}");
            Console.WriteLine($"Type of fuel: {TypeOfFuel}");
            Console.WriteLine($"Engine capacity: {EngineCapacity}");
            Console.WriteLine($"Average fuel consumption: {AverageFuelСonsumption}");
            Console.WriteLine($"Year of release: {YearOfRelease}");
            Console.WriteLine($"Vin code: {Vincode}");
            Console.WriteLine("---------------------\n");
        }
    }
}
