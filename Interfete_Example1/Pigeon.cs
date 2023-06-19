using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete_Example1
{
    public class Pigeon : Animal, IFlying
    {
        public Pigeon(string breed, int age, string color, string gender) : base(breed, age, color, gender)
        {
        }

        public string Fly()
        {
            return GetType().Name + " is flying in the city";
        }
    }
}
