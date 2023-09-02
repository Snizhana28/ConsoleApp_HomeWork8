using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class Shark : SeaCreature
    {      
        public bool HasSharpTeeth { get; set; }

        public Shark(string name, bool hasSharpTeeth): base(name, "Shark")
        {
            HasSharpTeeth = hasSharpTeeth;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, HasSharpTeeth: {HasSharpTeeth}";
        }
    }
}
