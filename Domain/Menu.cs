using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class Menu
    {
        public List<string> Categories { get; set; }
        public Dictionary<string, List<string>> Dishes { get; set; }

        public Menu()
        {
            Categories = new List<string>();
            Dishes = new Dictionary<string, List<string>>();
        }

        public void AddCategory(string category)
        {
            Categories.Add(category);
            Dishes[category] = new List<string>();
        }

        public void AddDish(string category, string dish)
        {
            if (Dishes.ContainsKey(category))
            {
                Dishes[category].Add(dish);
            }
            else
            {
                Console.WriteLine("Unknown category: " + category);
            }
        }
        public void ShowMenu()
        {
            Console.WriteLine("--------MENU--------");
            foreach (var category in Categories)
            {
                Console.WriteLine(category + ":");
                foreach (var dish in Dishes[category])
                {
                    Console.WriteLine("  - " + dish);
                }
            }
        }
    }
}
