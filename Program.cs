using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static Car;

namespace CarModel
{
    internal class UserClass
    {
        public static void Main(string[] args)
        {
            //Car c1 = new Car("Tata", "Tiago", 2024, false, true, true);
            //c1.DisplayCarDetails();
            //Car myCar = new Car("Toyota", "Camry", 2022, true, true, false);
            //myCar.DisplayCarDetails();

            //foreach (Colour clr in Enum.GetValues(typeof(Colour)))
            //{
            //    Console.WriteLine(clr);
            //}

            // using For Loop :- 
            //var temp = Enum.GetValues(typeof(Colour));
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine(temp.GetValue(i));
            //}

            Alto altoCar = new Alto("Maruti Suzuki", "Alto 800", 2023, false, true, true, Car.Colour.RED, Car.Seater.FIVE, Car.FuelType.PETROL, Car.PowerWindow.TWO,20,35);
            altoCar.DisplayCarDetails();
            Console.WriteLine();
            altoCar.StartEngine(); altoCar.PlayRadio();

            Console.WriteLine();
            altoCar.Accelerate(30);

            Console.WriteLine();
            altoCar.ShiftGear(5);

            Console.WriteLine();
            altoCar.CalculateFuelConsumption(100);

            Console.WriteLine();
            altoCar.ApplyBrakes();

            Console.WriteLine();
            altoCar.StopEngine();
            int currentGear = altoCar.ShiftGear(2, 25);
            //Console.WriteLine($"Current Gear: {currentGear}");


        }
    }
}

