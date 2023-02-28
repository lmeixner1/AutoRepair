namespace LSM.AutoRepair.BL.Test
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void EmptyConstructorTest()
        {
            Person person = new Person();

            Assert.IsNotNull(person);
        }
    }
}