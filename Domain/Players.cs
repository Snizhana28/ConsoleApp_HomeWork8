using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork8.Domain
{
    public class Players
    {
        public Players(string fullname, int age, int number, string position)
        {
            FullName = fullname;
            Age = age;
            Number = number;
            Position = position;
        }

        public string FullName { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"\tName: {FullName} \n\tPosition: {Position} \n\tAge: {Age}, Number: {Number}\n";
        }
    }
}
