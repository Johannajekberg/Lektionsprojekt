using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektionsprojekt
{
    interface IMonster
    {
        string Type { get; }
        string Description { get; }

        bool IsHostile { get; }
    }
}
