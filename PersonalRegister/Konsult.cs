namespace PersonalRegister
{
    public class Konsult : Anställd
    {
        private double arbetadeTimmar;
        private double timLön;

        public Konsult(string n, double a, double t) : base(n)
        {
            arbetadeTimmar = a;
            timLön = t;
        }

        public double BeräknaLön()
        {
            return timLön * arbetadeTimmar;
        }

        public string ToString()
        {
            return "hi";
        }
    }
}