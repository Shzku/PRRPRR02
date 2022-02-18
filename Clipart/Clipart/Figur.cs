namespace Clipart
{
    public abstract class Figur
    {
        private double _bredd;
        private double _höjd;
        private string _info;

        public Figur(double bredd, double höjd, string info)
        {
            _bredd = bredd;
            _höjd = höjd;
            _info = info;
        }

        public string Info => _info;
    }
}