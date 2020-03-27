using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_InClass_Inheritance
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void AnimalExamples()
        {
            Animal firstAnimal = new Dragon();
            firstAnimal.NumberOfLegs = 4;

            Dragon firstDragon = new WingedDragon();
            firstDragon.HasWings = true;

            List<Animal> pettingZoo = new List<Animal>();
            pettingZoo.Add(firstAnimal);
            pettingZoo.Add(firstDragon);

            foreach (Animal animal in pettingZoo)
            {
                animal.Move();

                if (animal is Dragon)
                {
                    Console.WriteLine(animal.GetType());
                    Dragon dragon = (Dragon)animal;
                    dragon.HasWings = true;
                }

                if (animal.GetType() == typeof(Dragon))
                {
                    Console.WriteLine("I am a dragon");
                }
            }
         }
    }
}
