namespace Interface_Example2
{
    public abstract class Hero
    {
        public string Name  { get; set; }

        public int Health { get; set; }

        public int Damage { get; set; }

        public Hero(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public override string ToString()
        {
            return $"name: {Name} health: {Health} damage: {Damage}";
        }

        public string Fight(string enemy)
        {
            return "fight";
        }
    }
}
