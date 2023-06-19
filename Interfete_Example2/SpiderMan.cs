namespace Interface_Example2
{
    public class SpiderMan : Hero, IPower
    {
        public SpiderMan(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public string Power()
        {
            return GetType().Name + " have super power";
        }
    }
}
