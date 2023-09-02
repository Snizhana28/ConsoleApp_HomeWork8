using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class Oceanarium
    {
        public List<SeaCreature> creatures;

        public Oceanarium()
        {
            creatures = new List<SeaCreature>();
        }

        public void AddCreature(SeaCreature creature)
        {
            creatures.Add(creature);
        }

        public IEnumerator<SeaCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        public override string ToString()
        {
            return $"Oceanarium has {creatures.Count} creatures";
        }
    }
}
