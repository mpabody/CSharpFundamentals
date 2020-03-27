using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class InClassLoopExamples
    {
        [TestMethod]
        public void Loops()
        {
            int studentCount = 10;

            // For  loops
            for (int i = 0; i < studentCount; i++)  //i = i + 1  --> 'i = i + 3' is the same as 'i += 3'
            {
                Console.WriteLine(i);
            }

            // Foreach loops
            string[] names = { "Michael", "Michael", "Michael", "Lance", "David", "Stephen" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //While loops
            while (studentCount > 0)
            {
                break;
            }

        }
    }
}
