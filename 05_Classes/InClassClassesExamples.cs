using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Address
    {
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ApartmentNumber { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int myVar;



        public string Height { get; set; }
        public int Weight { get; set; }

        public int Age
        {
            get
            {
                TimeSpan lifeSpan = DateTime.Now - Birthday;
                int ageInYears = Convert.ToInt32(lifeSpan.Days / 365.25);
                return ageInYears;
            }
        }
        public DateTime Birthday { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        //public int MyProperty
        //{
        //    get
        //    {
        //        return myVar;
        //    }
        //    set
        //    {
        //        if( > 0)
        //        {
        //            myVar = value;
        //        }
        //    }
        //}
    }
}
