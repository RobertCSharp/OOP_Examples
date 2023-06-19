using Main_Project_1;

namespace Project_1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //Override (supra scriere) vs Overload (supra incarcare)
            // Override se poate face doar daca exista mostenire altfel nu se poate.

            Cat cat = new Cat();
            cat.MakeSound();
            

            Dog dog = new Dog();
            dog.MakeSound();

            Lion lion = new Lion();
            lion.MakeSound();
        }
    }
}