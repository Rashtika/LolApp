using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Inventory
    {
        public List<Item> Items { get; set; }
        public Inventory()
        {
            Items = new List<Item>(6);
        }
    }
}
