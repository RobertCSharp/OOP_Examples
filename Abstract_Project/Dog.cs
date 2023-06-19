using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Project
{
    public class Dog : Animal
    {
        public Dog(string breed, string color, int age) : base(breed, color, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ham ham ham");
        }
    }
}
