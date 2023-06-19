using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs70
{
    public class Caine
    {
        private string name;
        private string breed;
        private string color;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Caine(string name, string breed, string color, int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }
    }
}
