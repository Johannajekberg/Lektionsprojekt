using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektionsprojekt
{
    internal abstract class Characters 
    {
        string? Name { get; set; }
        string? Description { get; set; }

        protected int Hp { get; set; }
        protected int Damage { get; set; }

        protected abstract void Speak();

       
       
    }
}
