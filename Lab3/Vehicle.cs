using System;

namespace Lab3
{
    public class Vehicle
    {
        public enum TypesOfVehicle
        {
            L,
            M,
            N,
            O,
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
        public string name { get; set; }
        public TypesOfVehicle TypeOfVehicle { get; set; }
        public TypesOfColor TypeOfColor { get; set; }
        public Colors Color { get; set; }
        public TypesOfEngine TypeOfEngine { get; set; }
        public TypesOfFuel TypeOfFuel { get; set; }
        public double EngineCapacity { get; set; }
        public int Weight { get; set; }
        public double UpTo100 { get; set; }
        public double AverageFuelСonsumption { get; set; }
        public int AmountOfSeats { get; set; }
        public int YearOfRelease { get; set; }
        public string Vincode { get; private set; }
        public Vehicle()
        {
            name = null;
            TypeOfVehicle = TypesOfVehicle.undefined;
            TypeOfColor = TypesOfColor.undefined;
            Color = Colors.undefined;
            TypeOfEngine = TypesOfEngine.undefined;
            TypeOfFuel = TypesOfFuel.undefined;
            EngineCapacity = 0;
            Weight = 0;
            UpTo100 = 0;
            AverageFuelСonsumption = 0;
            AmountOfSeats = 0;
            YearOfRelease = 0;
            Vincode = null;
        }
        public Vehicle(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity, int weight, double upTo100, double averageFuelСonsumption, int amountOfSeats, int yearOfRelease, string vincode)
        {
            name = nameCar;
            TypeOfVehicle = typesOfVehicle;
            TypeOfColor = typesOfColor;
            Color = colors;
            TypeOfEngine = typesOfEngine;
            TypeOfFuel = typesOfFuel;
            EngineCapacity = engineCapacity;
            Weight = weight;
            UpTo100 = upTo100;
            AverageFuelСonsumption = averageFuelСonsumption;
            AmountOfSeats = amountOfSeats;
            YearOfRelease = yearOfRelease;
            Vincode = vincode;
        }
        public Vehicle(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel)
        {
            name = nameCar;
            TypeOfVehicle = typesOfVehicle;
            TypeOfColor = typesOfColor;
            Color = colors;
            TypeOfEngine = typesOfEngine;
            TypeOfFuel = typesOfFuel;
        }
        public Vehicle(string nameCar, double engineCapacity, int weight, double upTo100, double averageFuelСonsumption, int amountOfSeats, int yearOfRelease, string vincode)
        {
            name = nameCar;
            EngineCapacity = engineCapacity;
            Weight = weight;
            UpTo100 = upTo100;
            AverageFuelСonsumption = averageFuelСonsumption;
            AmountOfSeats = amountOfSeats;
            YearOfRelease = yearOfRelease;
            Vincode = vincode;
        }
        public void SetVin(string vin)
        {
            Vincode = vin;
        }
    }
}