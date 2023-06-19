using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Project
{
    public abstract class Animal
    {
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Animal(string breed, string color, int age)
        {
            Breed = breed;
            Color = color;
            Age = age;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"breed: {Breed} color: {Color} age: {Age}";
        }
    }
}
