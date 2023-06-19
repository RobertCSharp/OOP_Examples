using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace OverLoad_Project
{
    internal class Class1
    {
        public static void Print()
        {
            Console.WriteLine("Hello World");
        }

        public static  void Print(string nume)
        {
            Console.WriteLine($"Salut {nume}");
        }

        public static void Print(string nume, string prenume)
        {
            Console.WriteLine($"salut {nume} , {prenume}");
        }

        public static void Print(string nume, string prenume, int varsta)
        {
            Console.WriteLine($"Salut {nume} , {prenume} , {varsta}");
        }

        public static void Print(string masina, int pret)
        {
            Console.WriteLine($"salut {masina} , {pret}");
        }

        public static void Print(int pret, string masina)
        {

        }

        public static void Print(string nume, double pret)
        {

        }
    }
}
