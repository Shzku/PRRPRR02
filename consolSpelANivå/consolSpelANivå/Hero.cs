using System;

namespace consolSpelANivå
{
    public class Hero : Varelse
    {
        private Random rand = new Random();
        private int _heroDamage, _hitHealth;

        public Hero(string name, int health, int normalDamage, int heroDamage, int hitHealth) : base(name, health, normalDamage)
        {
            _heroDamage = (rand.NextDouble() < 0.5) ? heroDamage : 0;
            _hitHealth = (rand.NextDouble() < 0.33) ? hitHealth : 0;
        }

        public void Attack()
        {
            Console.WriteLine(_name + " gör " + _normalDamage +" i normalskada");
            Console.WriteLine(_name + " som är vår hero ger en 'hero damage' på " + _heroDamage + " och får samtidigt en 'hit health' på " + _hitHealth);
            Console.WriteLine("===============================================");
        }

        public int HeroTotDamage
        {
            get => _normalDamage + _heroDamage;
        }

        public int HeroHealth
        {
            get => _health + _hitHealth;
        }
    }
}