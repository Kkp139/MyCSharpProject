using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace CarModel
{
    class Alto : Car
    {
        public override bool HasSunroof {  get; set; } = false; 
        public Alto(string companyName, string model, int year, bool hasSunroof, bool hasAC, bool hasBackWiper, Colour colour, Seater seater, FuelType fuelType, PowerWindow powerWindow, double fuelEfficiency, double fuelTankCapacity) : base (companyName,model,year,hasSunroof,hasAC,hasBackWiper, colour, seater, fuelType, powerWindow, fuelEfficiency, fuelTankCapacity)
        {
            Console.WriteLine("These are Alto car details :- ");
        }

        public override void DisplayCarDetails()
        {
            base.DisplayCarDetails();
            Console.WriteLine("Additional features of Alto :- ");
        }

    }
}
