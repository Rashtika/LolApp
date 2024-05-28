using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IPlayerAction
    {
        void TakeDamage(int damage);
        void SpecialMove();
        void LevelUp();
        bool IsAlive();


    }
}
