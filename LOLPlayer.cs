using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class LOLPlayer : IPlayerAction
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public abstract void TakeDamage(int damage);
        public abstract void SpecialMove();

        public LOLPlayer(string name)
        {
            Name = name;
            Health = 2000;
            Score = 0;
            Level = 0;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public bool HasSpecialMove()
        {
            if (Level > 6)
            {
                return true;
            }
            return false;

        }



        public void LevelUp()
        {
            Level++;
            Console.WriteLine($"{Name} has leveled up to level {Level}!");
        }
    }
}
