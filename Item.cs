using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IDescription
    {
        string getDescription();
    }
    public abstract class Item : IDescription
    {
        public string Name { get; set; }
        public abstract void OnEquip (Champion champion);
        public abstract void OnUnEquip(Champion champion);

        public abstract string getDescription();

        public Item(string name)
        {
            Name = name;
        }
    }
    public class Inventory
    {
        public List<Item> Items { get; set; }
        public Inventory()
        {
            Items = new List<Item>(6);
        }
    }
    public class Champion
    {
        private Inventory Inventory;
        public string Name { set; get; }
        public Champion(string name)
        {
            Name = name;
            Inventory = new Inventory();
        }
        public void Equip(Item item)
        {
            if (Inventory.Items.Count < 6)
            {
                Inventory.Items.Add(item);
                item.OnEquip(this);
            }
        }
        public void UnEquip(Item item)
        {
            if (Inventory.Items.Contains(item))
            {
                Inventory.Items.Remove(item);
                item.OnUnEquip(this);
            }
        }
    }
    public class SupermenoveGache : Item
    {
        public override void OnEquip(Champion champion)
        {
            Console.WriteLine($"{champion.Name} upravo si obukao gachiche!");
        }
        public override void OnUnEquip(Champion champion)
        {
            Console.WriteLine($"{champion.Name} upravo si skinuo gachiche!");
        }
        public override string getDescription()
        {
            return "Ove gache nose se preko hlača kao da si izgubio okladu.";
        }
        public SupermenoveGache() : base("SupermenoveGache")
        {

        }
    }

}
