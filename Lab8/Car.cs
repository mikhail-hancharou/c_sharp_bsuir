using System;

namespace lab6
{
    public class Car : Vehicle, IComparable<Car>
    {
        public int CompareTo(Car car)
        {
            if (YearOfRelease == car.YearOfRelease)
                return 0;
            else if (YearOfRelease > car.YearOfRelease)
                return 1;
            else
                return -1;
        }

        public Car() : base()
        {
            AmountOfSeats = 0;
            AmountOfDoors = 0;
        }

    public Car(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel, double engineCapacity, double averageFuelСonsumption, int amountOfSeats, int amountOfDoors, int yearOfRelease, string vincode) 
            : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel, engineCapacity, averageFuelСonsumption, yearOfRelease, vincode)
        {
            AmountOfSeats = amountOfSeats;
            AmountOfDoors = amountOfDoors;
        }

        public Car(string nameCar, TypesOfVehicle typesOfVehicle, TypesOfColor typesOfColor, Colors colors, TypesOfEngine typesOfEngine, TypesOfFuel typesOfFuel) 
            : base(nameCar, typesOfVehicle, typesOfColor, colors, typesOfEngine, typesOfFuel) { }

        public Car(string nameCar, double engineCapacity, double averageFuelСonsumption, int amountOfSeats, int amountOfDoors, int yearOfRelease, string vincode) 
            : base(nameCar, engineCapacity, averageFuelСonsumption, yearOfRelease, vincode)
        {
            AmountOfSeats = amountOfSeats;
            AmountOfDoors = amountOfDoors;
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
You can get vehicle info by using 'GetVehicleInfo';
You can set vin code by using 'SetVin';
You can set rate of safetu by using 'SetRateOfSafety' (double rate);
");
        }

        public int AmountOfSeats { get; set; } = 0;
        public int AmountOfDoors { get; set; } = 0;
        public double RateOfSafety { get; set; } = 0;

        public void SetRateOfSafety(double rate)
        {
            if (rate < 0 || rate > 5.0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                RateOfSafety = rate;
            }
        }

        public override void GetVehicleInfo()
        {
            Console.WriteLine($"Amount of seats: {AmountOfSeats}");
            Console.WriteLine($"Amount of doors: {AmountOfDoors}");
            Console.WriteLine($"Rate of safety: {RateOfSafety}");
            base.GetVehicleInfo();
        }
    }
}
