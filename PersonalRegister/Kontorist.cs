namespace PersonalRegister
{
    public class Kontorist : Anställd
    {
        private double månadsLön;

        public Kontorist(string n, double m) : base(n)
        {
            månadsLön = m;
        }

        public double BeräknaLön()
        {
            return månadsLön;
        }

        public string ToString()
        {
            return "hi";
        }
    }
}