using ConsoleApp_HomeWork8.Domain;

namespace ConsoleApp_HomeWork8.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oceanarium oceanarium = new Oceanarium();
            oceanarium.AddCreature(new JellyFish("Nelly", false));
            oceanarium.AddCreature(new Crab("Garik", true));
            oceanarium.AddCreature(new Shark("Daisy", true));

            Console.WriteLine(oceanarium.ToString());

            foreach (var creature in oceanarium)
            {
                Console.WriteLine(creature);
            }
        }
    }
}