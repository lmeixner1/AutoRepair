using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.AutoRepair.BL.Test
{
    [TestClass]
    public class CustomerCollectionTest
    {

        [TestMethod]
        public void CustomerCollectionLoadTest()
        {
            CustomerCollectionTest customerCollection = new CustomerCollectionTest();
            customerCollection.LoadTestCustomers();

            Thread.Sleep(2000);
            if (customerCollection.Count == 0) Assert.Fail();

        }
    }

}

