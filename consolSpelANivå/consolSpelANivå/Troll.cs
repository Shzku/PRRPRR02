using System;

namespace consolSpelANivå
{
    public class Troll : Varelse
    {
        private Random rand = new Random();
        protected int crit_Hit;

        public Troll(string name, int health, int normalDamage, int critHit) : base(name, health, normalDamage)
        {
            crit_Hit = (rand.NextDouble() < 0.25) ? critHit : 0;
        }

        private void Attack()
        {
            
        }
    }
}