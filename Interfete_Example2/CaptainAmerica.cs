namespace Interface_Example2
{
    public class CaptainAmerica : Hero, IFlying
    {
        public CaptainAmerica(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public string Fly()
        {
            return GetType().Name + " is flying till the sky";
        }
    }
}
