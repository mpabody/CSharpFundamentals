using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;
            cookie.Name = "Chocolate Chip"; // -- this would override line 13

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;
            anotherCookie.HasNuts = false;
            anotherCookie.NumberOfChocolateChips = 15;
            
            //--------------more cluttered code^^^------------------------------------------


            Cookie snickerdoodle = new Cookie("snickerdoodle", false, 11.5, 0);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150.0, 1);

        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Car,
                Make = "Honda",
                Model = "Civic"
            };
        }
    }
}
