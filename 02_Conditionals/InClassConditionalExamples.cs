using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class InClassConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int studentCount = 20;
            if (studentCount >= 20)
            {
                Console.WriteLine("We need more help!");
            }
            else
            {
                if (studentCount >= 10)
                {
                    Console.WriteLine("We're totally fine!");
                }
                else
                {
                    //if (condition) {}
                }
            }

            switch (studentCount)
            {
                case 10:
                    Console.WriteLine("Hey it's our class");
                    break;
            }

            bool result = (studentCount == 10) ? true : false;
            string isGoodSize = (studentCount < 50) ? "This is manageable" : "Uh oh";
        }
    }
}
