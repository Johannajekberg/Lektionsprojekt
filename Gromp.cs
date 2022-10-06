using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektionsprojekt
{
    internal class Gromp : Characters, IMonster
    {
        public string Type { get; set; }

        public string Description { get; set; }    

        public bool IsHostile { get; set; }

        public Gromp(string type, string description, bool isHostile)
        {
            Type = type;
            Description = description;
            IsHostile = isHostile;
        }

        protected override void Speak()
        {
            Console.WriteLine("Croak, croak");
        }
    }
}
