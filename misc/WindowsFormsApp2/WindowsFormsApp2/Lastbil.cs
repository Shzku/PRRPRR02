using System;

namespace WindowsFormsApp2
{
    public class Lastbil:Motorfordon
    {
        private int maxLast;

        public Lastbil(int f_ägare, string f_regNummer, int f_maxLast) : base(f_ägare, f_regNummer)
        {
            maxLast = f_maxLast;
        }

        public string nyyUtskrift()
        {
            return base.nyUtskrift() + "\nMaxlast: " + maxLast;
        }
    }
}