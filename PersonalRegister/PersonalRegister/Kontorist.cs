namespace PersonalRegister
{
    public class Kontorist : Anställd
    {
        private double månadsLön;

        public Kontorist(string n, double m) : base(n)
        {
            månadsLön = m;
        }

        public override double BeräknaLön()
        {
            return månadsLön;
        }

        public override string ToString()
        {
            return Namn + ": " + BeräknaLön();
        }
    }
}