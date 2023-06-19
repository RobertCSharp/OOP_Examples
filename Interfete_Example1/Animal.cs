using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete_Example1
{
    public abstract class  Animal
    {
        public string Breed { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public string Gender { get; set; }

        public Animal(string breed, int age, string color, string gender)
        {
            Breed = breed;
            Age = age;
            Color = color;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"breed: {Breed} age: {Age} color: {Color} gender: {Gender}";
        }
    }
}
