using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class InClassClassTests
    {
        [TestMethod]
        public void AddressTests()
        {
            int age = 31;
                Address myHouse = new Address();
            myHouse.HouseNumber = "12345";
            myHouse.HouseNumber = "544321";
        }
    }
}
