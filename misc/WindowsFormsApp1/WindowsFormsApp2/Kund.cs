using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public class Kund
    {
        private string _namn;
        private string _destination;
        private int _antalDagar;
        private Dictionary<string, int> trips;

        public Kund(string namn, string destination, int antalDagar)
        {
            _namn = namn;
            _destination = destination;
            _antalDagar = antalDagar;
        }

        private void newTrip(string destination, int antalDagar)
        {
            trips.Add(destination, antalDagar);
        }
    }
}