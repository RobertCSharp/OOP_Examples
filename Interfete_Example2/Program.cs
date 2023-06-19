namespace Interface_Example2 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class: Spiderman , Superman, wonder Woman, Flash, Hulk, Joker, BatMan, captainAmerica. <>
            // Fields: name, health, damage,  <>
            // Methods: in addition to ToString, let's have the "fight" method which takes as parameter another hero called enemy and which is simply inherited. <>
            // Methods: "fly" but only with the ability to fly.  <>
            // Methods: "SuperSpeed" as well as only heroes who have super speed. 
            // Methods: "SuperPower" only for heroes who have extreme power. 

            Flash flash = new Flash("flash", 200, 400);
            Hulk hulk = new Hulk("hulk", 300, 600);
            Joker joker = new Joker("joker", 140, 160);
            SpiderMan spiderMan = new SpiderMan("Spider-Man", 250, 360);
            SuperMan superMan = new SuperMan(" Super-Man", 340, 444);
            WonderWoman wonderWoman = new WonderWoman("WWonder-Woman", 210, 333);

            List <Hero> heroes = new  List<Hero>(){ wonderWoman, flash, hulk, spiderMan, superMan, joker };

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero);
            }

            Console.WriteLine(hulk.Power());
            Console.WriteLine(joker);
            Console.WriteLine(wonderWoman.Fly(), wonderWoman.Power());
            Console.WriteLine(spiderMan.Power());
            Console.WriteLine(superMan.Fly(), spiderMan.Power(), superMan.Speed());
            Console.WriteLine(flash.Speed());
        }
    }
}