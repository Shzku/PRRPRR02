using System;

namespace ConsoleApp1
{
    public class Motorfordon:Fordon
    {
        protected string registreringsNummer;

        public Motorfordon(int f_ägare, string f_regNummer):base(f_ägare)
        {
            registreringsNummer = f_regNummer;
        }

        public void nyUtskrift()
        {
            base.utskrift();
            Console.WriteLine("Regnummer: " + registreringsNummer);
        }
    }
}