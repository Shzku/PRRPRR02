namespace Clipart
{
    public class Triangel : Figur, IArea
    {
        private double _bredd;
        private double _höjd;
        
        public Triangel(double bredd, double höjd): base(bredd, höjd)
        {
            _bredd = bredd;
            _höjd = höjd;
        }

        public double BeräknaArea()
        {
            return (_bredd * _höjd) / 2;
        }
    }
}