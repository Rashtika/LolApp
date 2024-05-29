using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<LOLPlayer> list = new List<LOLPlayer>();
            LOLPlayer playerOne = new LuxPlayer("Bara");


            bool quit = false;
            while (!quit)
            {
                //int option = Console.ReadLine();
                //switch (int.Parse(option))
                //{
                //    case 1:
                //        Console.WriteLine($"");
                //        break;
                //}
            }

        }
        public static void Play()
        {
            Console.WriteLine($"Choose option:" +
                $"1. Add new character" +
                $"2. Choose your character" +
                $"3. Change character" +
                $"4. Attack opponent" +
                $"5. Remove charcter" +
                $"6. Quit" +
                $"7. Print options");

        }
    }
}
