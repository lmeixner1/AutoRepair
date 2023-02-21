using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.AutoRepair.BL
{
    public class CustomerCollection : List<Customer>
    {
        public void LoadTestCustomers()
        {
            Customer customer;
            Vehicle car;

            customer = new Customer();
            customer.FirstName = "Ryan";
            customer.LastName = "Appel";
            customer.PhoneNumber= "1234567890";
            Add(customer);
            customer.vehicles.Add(new Vehicle("Maserati", "MC20", 2022));
            customer.vehicles.Add(new Vehicle("Chevy", "Camaro", 2023));

            customer = new Customer();
            customer.FirstName = "Lucas";
            customer.LastName = "Meixner";
            customer.PhoneNumber = "6085568248";
            Add(customer);
            customer.vehicles.Add(new Vehicle("BMW", "M5", 2022));

            customer = new Customer();
            customer.FirstName = "Ben";
            customer.LastName = "M";
            customer.PhoneNumber = "9200690420";
            Add(customer);
            customer.vehicles.Add(new Vehicle("Mini", "Cooper", 2022));
        }
    }
}
