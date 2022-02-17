using System;

namespace consolSpelANivå
{
    public class BergsTroll : Troll
    {
        private Random rand = new Random();
        private int rock_hit;

        public BergsTroll(
            string name, 
            int health, 
            int normalDamage, 
            int critHit, 
            int rockHit
            ) : base(name, health, normalDamage, critHit)
        {
            rock_hit = (rand.NextDouble() < 0.2) ? rockHit : 0;
        }

        public void Attack()
        {
            Console.WriteLine(_name + " gör " + _normalDamage +" i normalskada");
            Console.WriteLine("Trollet " + _name + " ger också en extra 'crit hit' på " + crit_Hit);
            Console.WriteLine("Trollet " + _name + " som är ett bergsstroll fick också till en 'rock hit' på " + rock_hit);
            Console.WriteLine("===============================================");
        }

        public int BTrollTotDamage
        {
            get
            {
                return _normalDamage + crit_Hit + rock_hit;
            }
        }

        public int BTrollHealth
        {
            get
            {
                return _health;
            }
        }
    }
}