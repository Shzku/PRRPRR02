namespace PersonalRegister
{
    public class Säljare : Anställd
    {
        private double provision;
        private double försäljning;

        public Säljare(string n, double p, double f):base(n)
        {
            provision = p;
            försäljning = f;
        }

        public double BeräknaLön()
        {
            return försäljning * provision / 100;
        }

        public string ToString()
        {
            return "hi";
        }
    }
}