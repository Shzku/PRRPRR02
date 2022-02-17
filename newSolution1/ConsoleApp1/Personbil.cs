using System;

namespace ConsoleApp1
{
    public class Personbil:Motorfordon
    {
        private int antalPlatser;

        public Personbil(int f_ägare, string f_regNummer, int f_antalPlatser) : base(f_ägare, f_regNummer)
        {
            antalPlatser = f_antalPlatser;
        }

        public void nyyUtskrift()
        {
            base.nyUtskrift();
            Console.WriteLine("Antal Platser: " + antalPlatser);
        }
    }
}