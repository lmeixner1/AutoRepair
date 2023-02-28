using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.AutoRepair.BL
{
    public class InvalidYearException : Exception
    {
        //constructor
        public int InvalidYear { get; set; }
        //properties
        public InvalidYearException(int invalidYear)
            // use the Exception constructor that takes a string parameter
            : base(invalidYear + " is not valid")
        {
            InvalidYear = invalidYear;
          
        }
    }
}
