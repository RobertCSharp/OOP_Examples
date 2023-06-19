using System;

namespace Abstract_Project 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("pitbull", "white", 2);
            dog.MakeSound();
            Console.WriteLine(dog);
        }
    }
}