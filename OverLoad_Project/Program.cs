using System;

namespace OverLoad_Project // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.Print();
            Class1.Print("Robert");
            Class1.Print("robert", "Robert");
            Class1.Print("Robert", "Robert", 34);
            Class1.Print("audi", 54);
        }
    }
}