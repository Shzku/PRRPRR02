using System;

namespace ConsoleApp1
{
    public class Cykel:Fordon
    {
        private int antalVäxlar;

        public Cykel(int f_ägare, int f_antalVäxlar) : base(f_ägare)
        {
            antalVäxlar = f_antalVäxlar;
        }

        public void nyUtskrift()
        {
            base.utskrift();
            Console.WriteLine("Antal växlar: " + antalVäxlar);
        }
    }
}