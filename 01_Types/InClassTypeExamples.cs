using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            // Numbers
            int age; //Declare
            age = 31; //Initialize

            byte smallWholeNumber = 255;
            //short and long

            double numberWithADecimal = 123.45666666666d; //"d" suffix not neccessary
            float smallNumber = 123.456f;
            decimal bigDecimal = 123.45666666666666666666666666666666666m;

            char letter = 'm'; //only a single character
            bool trueFalseValue = true;
        }
        [TestMethod]
        public void ReferenceTypes()
        {
            string randomCharacters = "1a? !";
            string specialCharacters = @"\\"; // "@" disables all special characters so you can use " or \ etc

            DateTime rightNow = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime yesterday = new DateTime(2019, 7, 9); // "new" it up?
            DateTime birthday = yesterday;

            string[] names = {"Josh", "Marth", "Josh", "Oliver", "Michael"};
            List<string> fruits = new List<string>();  //Could use a refresher on this ish
            fruits.Add(randomCharacters);
            fruits.Add("Some string here");

            Dictionary<char, double> dictionary = new Dictionary<char, double>();
            dictionary.Add('x', 3.27d);

            Console.WriteLine(names[1]);
            Console.WriteLine(dictionary['x']);
        }

    }
}
