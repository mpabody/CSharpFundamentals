using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InClass_Inheritance
{
    public class Dragon : Animal
    {
        public bool HasWings { get; set; }
        public Dragon()
        {
            IsMammal = false;
        }

        public Dragon(int numberOfLegs, bool hasFur, DietType dietType)
            : base(numberOfLegs, false, hasFur, dietType)
        {

        }

        public override void Fly()
        {

        }
    }
}
