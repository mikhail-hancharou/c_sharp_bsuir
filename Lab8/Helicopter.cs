using System;

namespace lab6
{
    public class Helicopter : Vehicle, IComparable<Helicopter>
    {
        public int CompareTo(Helicopter helicopter)
        {
            if (CurrentWorkload == helicopter.CurrentWorkload)
                return 0;
            else if (CurrentWorkload > helicopter.CurrentWorkload)
                return 1;
            else
                return -1;
        }

        public Helicopter() : base()
        {
            TypeOfHelicopter = TypesOfHelicopters.undefined;
            TypeOfProperty = TypesOfProperty.undefined;
            LiftingCapacity = 0;
    }

        public Helicopter(int liftingCapacity, TypesOfHelicopters typeOfHelicopter, TypesOfProperty typesOfProperty, string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity, double averageFuelСonsumption, int amountOfSeats, int amountOfDoors, int yearOfRelease, string vincode)
                : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel, engineCapacity, averageFuelСonsumption, yearOfRelease, vincode)
        {
            TypeOfHelicopter = typeOfHelicopter;
            TypeOfProperty = typesOfProperty;
            LiftingCapacity = liftingCapacity;
        }

        public Helicopter(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel)
            : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel) { }

        public Helicopter(int liftingCapacity, TypesOfHelicopters typeOfHelicopter, TypesOfProperty typesOfProperty, string nameCar, double engineCapacity, double averageFuelСonsumption, int yearOfRelease, string vincode)
            : base(nameCar, engineCapacity, averageFuelСonsumption, yearOfRelease, vincode)
        {
            TypeOfHelicopter = typeOfHelicopter;
            TypeOfProperty = typesOfProperty;
            LiftingCapacity = liftingCapacity;
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
First constructor get: int liftingCapacity, TypesOfHelicopters typeOfHelicopter, 
    TypesOfProperty typesOfProperty, string nameCar, TypesOfVehicle typesOfVehicle, 
    TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, 
    double engineCapacity, double averageFuelСonsumption, int yearOfRelease, string vincode;
-----------------------------------------------------------------------------------------------
Second constructor get: string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
    Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel;
-----------------------------------------------------------------------------------------------
Third constructor get: int liftingCapacity, int liftingCapacity, TypesOfHelicopters typeOfHelicopter,
    TypesOfProperty typesOfProperty, string nameCar, double engineCapacity, double averageFuelСonsumption,
    int yearOfRelease, string vincode;
-----------------------------------------------------------------------------------------------
You can get vehicle info by using 'GetVehicleInfo';
You can set vin code by using 'SetVin';
You can set current workload capacity by using 'SetCurrentWorkload' (int capacity);
You can add cargo weight by using 'AddCargo' (int cargo);
");
        }

        public int CurrentWorkload { get; set; } = 0;
        public int LiftingCapacity { get; set; } = 0;
        public TypesOfHelicopters TypeOfHelicopter { get; set; }
        public TypesOfProperty TypeOfProperty { get; set; }

        public enum TypesOfHelicopters
        {
            singleScrew,
            zhirodin,
            jet,
            coaxial,
            transversePropeller,
            longitudinalPropeller,
            multiRotor,
            undefined
        }

        public enum TypesOfProperty
        {
            state,
            personal,
            undefined
        }

        public void SetCurrentWorkload(int capacity)
        {
            if (capacity < 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                CurrentWorkload = capacity;
            }
        }

        public void AddCargo(int cargo)
        {
            int tmp = LiftingCapacity - CurrentWorkload;
            if (cargo < 0)
            {
                Console.WriteLine("Invalid input");
            }
            else if (cargo > tmp)
            {
                Console.WriteLine("\nYour cargo is to big, there no enough place\n");
            }
            else
            {
                CurrentWorkload += cargo;
            }
        }

        public override void GetVehicleInfo()
        {
            Console.WriteLine($"Amount of seats: {CurrentWorkload}");
            Console.WriteLine($"Amount of doors: {LiftingCapacity}");
            Console.WriteLine($"Type of helicopter: {TypeOfHelicopter}");
            Console.WriteLine($"Type of helicopter: {TypeOfProperty}");
            base.GetVehicleInfo();
        }
    }
}
