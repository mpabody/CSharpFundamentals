using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InClass_Inheritance
{
    public enum DietType { Herbivore = 1, Omnivore, Carnivore, }
    public abstract class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; internal set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }

        public Animal() { }
        public Animal(int numberOfLegs, bool isMammal, bool hasFur, DietType dietType)
        {
            NumberOfLegs = numberOfLegs;
            IsMammal = isMammal;
            HasFur = hasFur;
            DietType = dietType;
        }

        public abstract void Fly();

        public virtual void Move()
        {
            Console.WriteLine($"This {this.GetType().Name} moves.");
        }
    }
}
