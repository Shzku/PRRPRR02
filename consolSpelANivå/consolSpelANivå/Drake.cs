using System;

namespace consolSpelANivå
{
    public class Drake : Varelse
    {
        private Random rand = new Random();
        private int _fireDamage;

        public Drake(string name, int health, int normalDamage, int fireDamage) : base(name, health, normalDamage)
        {
            _fireDamage = (rand.NextDouble() < 0.5) ? fireDamage : 0;
        }

        public void Attack()
        {
            Console.WriteLine(_name + " gör " + _normalDamage +" i normalskada");
            Console.WriteLine("Draken " + _name + " ger 'fire damage' på " + _fireDamage);
            Console.WriteLine("===============================================");
        }

        public int DrakeTotDamage
        {
            get
            {
                return _normalDamage + _fireDamage;
            }
        }

        public int DrakeHealth
        {
            get
            {
                return _health;
            }
        }
    }
}