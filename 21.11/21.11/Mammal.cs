using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Mammal
    {
        public Mammal()
        {
            Numberofeyes = 2;
            Iscarnivore = true;
            Breathe();
        }

        protected int Age { get; set; }
        public int Numberofeyes { get; set; }
        public bool Iscarnivore { get; set; }
        public void Breathe()
        {
            Console.WriteLine("I am breathing");

        }
        public void Setage(int age)
        {
            Age = age;
        }
    }
}
