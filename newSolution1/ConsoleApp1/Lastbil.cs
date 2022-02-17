using System;

namespace ConsoleApp1
{
    public class Lastbil:Motorfordon
    {
        private int maxLast;

        public Lastbil(int f_ägare, string f_regNummer, int f_maxLast) : base(f_ägare, f_regNummer)
        {
            maxLast = f_maxLast;
        }

        public void nyyUtskrift()
        {
            base.nyUtskrift();
            Console.WriteLine("Maxlast: " + maxLast);
        }
    }
}