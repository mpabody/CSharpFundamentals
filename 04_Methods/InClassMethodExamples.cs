using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class InClassMethodExamples
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
                                                    // Test methods must have different method signatures (line 24) -- name can be the same but parameters must be diff
        [TestMethod]
        public void TestMethod()
        {
            PetTheDog("Holly");
            PetTheDog("Crosby");
        }

        // Reusable chunks of code
        // Should serve one purpose
        // Input, what they do, and an output

                                       // Method Signature
        // Access Modifier  Return Type  MethodName(Parameters)
        // { 
        //    Method Body
        // }


        private void PetTheDog(string dogName)
        {
            Console.WriteLine($"You pet {dogName}");
            Console.WriteLine($"{dogName} is happy");
        }
    }
}
