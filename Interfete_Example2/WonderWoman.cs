namespace Interface_Example2
{
    public class WonderWoman : Hero, IFlying, IPower
    {
        public WonderWoman(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public string Fly()
        {
            return GetType().Name + " is flying on top of bullding";
        }

        public string Power()
        {
            return GetType().Name + " She is so strong.. ";
        }
    }
}
