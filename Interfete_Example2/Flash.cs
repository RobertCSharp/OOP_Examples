namespace Interface_Example2
{
    public class Flash : Hero, ISpeed
    {
        public Flash(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public string Speed()
        {
            return GetType().Name + " have run so fast..";
        }
    }
}
