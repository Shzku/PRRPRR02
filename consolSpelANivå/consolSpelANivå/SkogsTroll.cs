using System;

namespace consolSpelANivå
{
    public class SkogsTroll : Troll
    {
        private Random rand = new Random();
        private int arrow_hit;

        public SkogsTroll(
            string name, 
            int health, 
            int normalDamage, 
            int critHit, 
            int arrowHit
            ) : base(name, health, normalDamage, critHit)
        {
            arrow_hit = (rand.NextDouble() < 0.33) ? arrowHit : 0;
        }

        public void Attack()
        {
            Console.WriteLine(_name + " gör " + _normalDamage +" i normalskada");
            Console.WriteLine("Trollet " + _name + " ger också en extra 'crit hit' på " + crit_Hit);
            Console.WriteLine("Trollet " + _name + " som är ett skogstroll fick också till en 'arrow hit' på " + arrow_hit);
            Console.WriteLine("===============================================");
        }

        public int STrollTotDamage
        {
            get
            {
                return _normalDamage + crit_Hit + arrow_hit;
            }
        }

        public int STrollHealth
        {
            get
            {
                return _health;
            }
        }
    }
}