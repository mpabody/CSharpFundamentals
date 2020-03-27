using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_InClass_Inheritance
{
    public class WingedDragon : Dragon
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("It flies through the sky!");
        }
    }
}
