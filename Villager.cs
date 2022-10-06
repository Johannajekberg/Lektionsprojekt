using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektionsprojekt
{
    internal class Villager : Characters, IHuman
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Dictionary<string,int> Inventory {get; set;}

        public Villager(string name, string description)
        {
            Name = name;
            Description = description;
            Hp = 20;
            Damage = 5;
            Inventory = new Dictionary<string,int>();
        }

        public void Trade()
        {
            Console.WriteLine("Nu byter vi grejer!");
        }

        protected override void Speak()
        {
            Console.WriteLine("HejHej!");
        }

    }
}
