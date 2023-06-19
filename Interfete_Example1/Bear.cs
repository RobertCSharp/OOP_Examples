using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete_Example1
{
    public class Bear : Animal, ICarnivore
    {
        public Bear(string breed, int age, string color, string gender) : base(breed, age, color, gender)
        {
        }

        public string EatMeat()
        {
            return GetType().Name + " eat salmon";
        }
    }
}
