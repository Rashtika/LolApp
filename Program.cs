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

            List<Champion> list = new List<Champion>();
            Champion championOne = new Champion("Bara");
            Item itemOne = new SupermenoveGache();
            Item itemTwo = new Shilterica();
            Item itemThree = new BucketHelmet();
            Item itemFour = new AmuletOfLost();

            bool quit = false;
            Play();
            while (!quit)
            {
                string option = Console.ReadLine();
                switch (int.Parse(option))
                {
                    case 0:
                        Console.WriteLine($"Choose item:" +
                $"press" +
                $"0 - to add SupermenoveGache" +
                $"1 - to add Shilterica" +
                $"2 - to add BucketHelmet" +
                $"3 - to add AmuletOfLost" +
                $"4 - to print options");
                        
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }

        }
        public static void Play()
        {
            Console.WriteLine($"Available actions:" +
                $"press" +
                $"0 - to add new item of choice" +
                $"1 - to remove an item of choice" +
                $"2 - to print list of items" +
                $"3 - to quit" +
                $"4 - to print options");

        }

    }
}
