using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class LOLPlayer : IPlayerAction
    {
        public string UserName { get; set; }
        public int Health { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public bool Alive { get; set; }
        public abstract void TakeDamage(int damage, LOLPlayer opponent);
        public abstract void SpecialMove(LOLPlayer opponent);

        public enum LolChampion {
            lux,
            darius,
            teemo,
            annie,

        }
        public LOLPlayer(string name, LolChampion c)
        {
            UserName = name;
            Health = 2000;
            Score = 0;
            Level = 0;
            switch (c)
            {
                case LolChampion.lux:
                    LOLPlayer lolPlayer = new LuxPlayer(name);
                    break;
                case LolChampion.darius:
                    LOLPlayer lolPlayer1 = new DariusPlayer(name);
                    break;
                case LolChampion.teemo:
                    break;



            }
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
            Console.WriteLine($"{UserName} has leveled up to level {Level}!");
        }
    }
}
