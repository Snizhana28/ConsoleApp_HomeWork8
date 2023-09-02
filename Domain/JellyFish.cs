using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class JellyFish : SeaCreature
    {
        public bool HasTentacles { get; set; }
        public JellyFish(string name, bool hasTentacles) : base(name, "JellyFish")
        {
            HasTentacles = hasTentacles;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, HasTentacles: {HasTentacles}";
        }
    }
}
