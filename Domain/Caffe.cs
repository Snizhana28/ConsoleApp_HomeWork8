using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class Caffe : IEnumerable<Employees>
    {
        public List<Employees> employees { get; set; }
        public Menu menu;

        public Caffe()
        {
            employees = new List<Employees>();
            menu = new Menu();
        }
        public IEnumerator<Employees> GetEnumerator()
        {
            return employees.GetEnumerator();
        }
        public void AddEmployee(Employees employee)
        {
            employees.Add(employee);
        }
        public void CreateMenu()
        {
            menu.AddCategory("Pizza");
            menu.AddDish("Pizza", "Margarita");
            menu.AddDish("Pizza", "Pepperoni");
            menu.AddDish("Pizza", "4 cheeses");
            menu.AddCategory("Sushi");
            menu.AddDish("Sushi", "Philadelphia");
            menu.AddDish("Sushi", "California");
            menu.AddDish("Sushi", "Dragon");
            menu.AddCategory("Drinks");
            menu.AddDish("Drinks", "Coca-cola");
            menu.AddDish("Drinks", "Sprite");
            menu.AddDish("Drinks", "Fanta");
        }
        public void ShowEmployees()
        {
            Console.WriteLine("--------EMPLOYEES--------");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
        public IEnumerator<Employees> GetEnumeratorr() => employees.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
