using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class SeaCreature
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public SeaCreature(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}";
        }
    }
}
