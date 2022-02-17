using System;

namespace WindowsFormsApp2
{
    public class Motorfordon:Fordon
    {
        protected string registreringsNummer;

        public Motorfordon(int f_ägare, string f_regNummer):base(f_ägare)
        {
            registreringsNummer = f_regNummer;
        }

        public string nyUtskrift()
        {
            return (base.utskrift() + "\nRegnummer: " + registreringsNummer);
        }
    }
}