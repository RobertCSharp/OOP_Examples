using System;

namespace Interfete_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear("bear", 23, "black", "male");
            Cow cow = new Cow("cow", 44, "white", "female");
            Crocodile crocodile = new Crocodile("crocodile", 55, "green", "female");
            Parrot parrot = new Parrot("parrot", 2, "blue", "male");
            Sheep sheep = new Sheep("sheep", 3, "white", "male");
            Pigeon pigeon = new Pigeon("pigeon", 35, "green", "female");

            List<Animal> animals = new List<Animal>
            {
                bear, cow, crocodile, parrot, sheep, pigeon
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine(pigeon.Fly());
            Console.WriteLine(parrot.Fly());
            Console.WriteLine(bear.EatMeat());
            Console.WriteLine(crocodile.EatMeat());
            Console.WriteLine(cow.EatGrass());
            Console.WriteLine(sheep.EatGrass());
        }
    }
}