using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class Crab : SeaCreature
    {
        public bool HasClaws { get; set; }
        public Crab(string name, bool hasClaws) : base(name, "Crab")
        {
            HasClaws = hasClaws;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, HasClaws: {HasClaws}";
        }
    }
}
