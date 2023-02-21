using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.AutoRepair.BL
{
    public class Person
    {
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        protected DateTime DOB { get; set; }
        //Protected means that you can use it while using inheritance
        //private you have to be in the class

        // readonly
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //methods
        public override string ToString()
        {
            return FullName;
        }
    }
}
