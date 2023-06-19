using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete_Example1
{
    public class Sheep : Animal, IGrass
    {
        public Sheep(string breed, int age, string color, string gender) : base(breed, age, color, gender)
        {
        }

        public string EatGrass()
        {
            return GetType().Name + " eating more grass..";
        }
    }
}
