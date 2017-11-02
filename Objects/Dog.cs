using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Dog: Mammal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public int RealYears { get; set; }
        public Dog()
        {
            Name = "Rex";
            Age = 2;
            Color = "Brown";
        }

        public void Bark()
        {
            Console.WriteLine("Auh auh!!!");
        }

        public int CalculateDogYears()
        {
            RealYears = Age * 7;
            return RealYears;
        }
    }
}