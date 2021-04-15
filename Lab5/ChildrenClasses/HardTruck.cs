using System;

namespace Lab5
{
    class HardTruck : Vehicle
    {
        public HardTruck() : base()
        {
            Weight = 0;
            TypeOfTruck = TypesOfTruck.undefined;
        }

        public HardTruck(TypesOfTruck typeOfTruck, int weight, string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
            Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity,
            double averageFuelСonsumption, int yearOfRelease, string vincode)
            : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel,
                  engineCapacity, averageFuelСonsumption, yearOfRelease, vincode)
        {
            TypeOfTruck = typeOfTruck;
            Weight = weight;
        }

        public HardTruck(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
            Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel)
            : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel) { }

        public HardTruck(TypesOfTruck typeOfTruck, int weight, string nameCar, double engineCapacity, double averageFuelСonsumption,
            int yearOfRelease, string vincode)
            : base(nameCar, engineCapacity, averageFuelСonsumption, yearOfRelease, vincode)
        {
            Weight = weight;
            TypeOfTruck = typeOfTruck;
        }

        public enum TypesOfTruck
        {
            excavators,
            bulldozers,
            truckCranes,
            pipeLayingMachines,
            pileDrivingMachines,
            concreteMixers,
            concreteFeeding,
            machines, 
            undefined,
            noOne
        }
        public TypesOfTruck TypeOfTruck { get; set; }
        public int Weight { get; set; }
        public int WeightPossibilities { get; set; }
        public TypesOfTruck AddedSkill { get; set; } = TypesOfTruck.noOne;

        public override void HelpInfo()
        {
            Console.WriteLine(@"
TypesOfVehicle(L, M, N, O); 
TypesOfColor(metalic, nonmetalic); 
Colors(blue, yellow, grey, white, black, brown, green, red, purple, pink);
TypesOfEngine(internalCombustionEngine, electric);
TypesOfFuel(petrol, gasoline, energy, kerosene, diesel, gas);
-----------------------------------------------------------------------------------------------
First constructor get: TypesOfTruck typeOfTruck, int weight, string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
    Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity,
    double averageFuelСonsumption, int yearOfRelease, string vincode;
-----------------------------------------------------------------------------------------------
Second constructor get: string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor,
    Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel;
-----------------------------------------------------------------------------------------------
Third constructor get: TypesOfTruck typeOfTruck, int weight, string nameCar, double engineCapacity, double averageFuelСonsumption, 
    int yearOfRelease, string vincode;
-----------------------------------------------------------------------------------------------
You can get vehicle info by using 'GetVehicleInfo' ;
You can set vin code by using 'SetVin';
You can add skill by using 'AddSkill' (TypesOfTruck skill)
You can set weight possibilities by using 'SetWeightPossibilities' (int weight);
You can upgrade your weight possibilities by using 'UpWeightPossibilities' (int up);
");
        }

        public void AddSkill(TypesOfTruck skill)
        {
            AddedSkill = skill;
        }

        public void SetWeightPossibilities(int weight)
        {
            if (weight < 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                WeightPossibilities = weight;
            }
        }

        public void UpWeightPossibilities(int up)
        {
            if (up < 0)
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                WeightPossibilities += up;
                Console.WriteLine("Your current weight possibilities is {0}", WeightPossibilities);
            }
        }

        public override void GetVehicleInfo()
        {
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Weight possibilities: {WeightPossibilities}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Additional skill: {AddedSkill}");
            base.GetVehicleInfo();
        }
    }
}
