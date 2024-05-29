using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DariusPlayer : LOLPlayer
    {
        public DariusPlayer(string name) : base(name)
        {
        }

        override public void TakeDamage(int damage, LOLPlayer opponent)
        {
            opponent.Health -= damage;
            if (opponent.Health < 0)
            {
                opponent.Health = 0;
                Alive = false;
            }
        }

        override public void SpecialMove(LOLPlayer opponent)
        {
            if (base.HasSpecialMove())
            {
                Console.WriteLine($"{UserName} is using special move");
                opponent.Health -= 900;
            }

        }
    }
}
