using System.Xml;

namespace consolSpelANivå
{
    public class Varelse
    {
        protected string _name;
        protected int _health, _normalDamage;

        public Varelse(string name, int health, int normalDamage)
        {
            _name = name;
            _health = health;
            _normalDamage = normalDamage;
        }

        private void Attack()
        {
            
        }
    }
}