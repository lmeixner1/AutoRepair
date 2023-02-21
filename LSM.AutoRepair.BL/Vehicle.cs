using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.AutoRepair.BL
{
    public class Vehicle //internal class Vehicle (internal) means public to the product
    {
        public string Make { get; set; } = "";

        public string Model { get; set; } = "";

        public int Year { get; set; } = 0;



        public Vehicle() { }

        public Vehicle(string make, string model, int year) 
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return Make + " " + Model + " (" + Year + ")";
        }
    }
}
