namespace PersonalRegister
{
    public class Anställd
    {
        private string namn;

        public Anställd(string n)
        {
            namn = n;
        }

        public string Namn => namn;

        public double BeräknaLön()
        {
            return 0;
        }

        public override string ToString()
        {
            return namn;
        }
    }
}