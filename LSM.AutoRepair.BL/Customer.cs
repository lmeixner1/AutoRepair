using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.AutoRepair.BL
{
    public class Customer : Person
    {

        public string PhoneNumber { get; set; } = "";

        public List<Vehicle> vehicles { get; set; } = new List<Vehicle>();
        //List is a class type not primitive

       public Customer() 
        {
            FirstName = "Luke";
            DOB = new DateTime(1983, 6, 17);
        }
    }
}
