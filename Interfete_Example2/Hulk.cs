namespace Interface_Example2
{
    public class Hulk : Hero, IPower
    {
        public Hulk(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public string Power()
        {
            return GetType().Name + " he is so strong, with super power";
        }
    }
}
