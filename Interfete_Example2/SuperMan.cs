namespace Interface_Example2
{
    public class SuperMan : Hero, IFlying, ISpeed, IPower
    {
        public SuperMan(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public string Fly()
        {
            return GetType().Name + " is flying so hight";
        }

        public string Speed()
        {
            return GetType().Name + " he have so big speed..";
        }

        public string Power()
        {
            return GetType().Name + " so strong guy";
        }
    }
}
