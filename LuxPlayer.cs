using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LuxPlayer : LOLPlayer
    {
        override public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                 = false;
            }
        }

        override public void SpecialMove()
        {
            if (base.HasSpecialMove())
            {
                Console.WriteLine($"{Name} is using special move");
                Health -= 1000;
            }

        }


    }
}
