using System;

namespace WindowsFormsApp2
{
    public class Cykel:Fordon
    {
        private int antalVäxlar;

        public Cykel(int f_ägare, int f_antalVäxlar) : base(f_ägare)
        {
            antalVäxlar = f_antalVäxlar;
        }

        public string nyUtskrift()
        {
            return base.utskrift() + "\nAntal växlar: " + antalVäxlar;
        }
    }
}