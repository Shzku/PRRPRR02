namespace Clipart
{
    public abstract class Figur
    {
        private double _bredd;
        private double _höjd;

        public Figur(double bredd, double höjd)
        {
            _bredd = bredd;
            _höjd = höjd;
        }
    }
}