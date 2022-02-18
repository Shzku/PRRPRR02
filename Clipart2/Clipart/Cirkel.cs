using System;

namespace Clipart
{
    public class Cirkel : Figur, IArea
    {
        private double _bredd;
        private double _höjd;
        
        public Cirkel(double bredd, double höjd, string info) : base(bredd, höjd, info)
        {
            _bredd = bredd;
            _höjd = höjd;
        }

        public double BeräknaArea()
        {
            return (_bredd / 2) * (_höjd / 2) * Math.PI;
        }
    }
}