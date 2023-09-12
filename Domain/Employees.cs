using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_HomeWork8.Domain
{
    public class Employees
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Employees() { }
        public Employees(string fullName, string position, int salary)
        {
            FullName = fullName;
            Position = position;
            Salary = salary;
        }
        public void ShowMenu(Menu menu)
        {
            Console.WriteLine($"\n{FullName} ({Position}) is viewing the menu:");
            menu.ShowMenu();
        }
        public override string ToString()
        {
            return $"{FullName}    ({Position}) (salary {Salary})";
        }
    }
}
