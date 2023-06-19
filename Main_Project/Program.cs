using System;
using Curs70;

namespace Main_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Elev elev = new Elev("Popescu", "Mihai", 32);

            // aici folosim metoda (get) din proprietatea Age
            Console.WriteLine(elev.Age);

            //aici folosim metoda (set) din proprietatea Age
            elev.Age = 75;
            Console.WriteLine(elev.Age);

            Caine caine = new Caine("thor", "pitbull", "white", 7);

            Console.WriteLine(caine.Age);
            Console.WriteLine(caine.Breed);
            Console.WriteLine(caine.Color);
            Console.WriteLine(caine.Name);
        }
    }
}