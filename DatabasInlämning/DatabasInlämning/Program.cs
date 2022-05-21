using DatabasInlämning.Models;

namespace DatabasInlämning
{
    public class Program
    {
        static void Main(string[] args)
        {
            SkolService service = new SkolService(new SkolKontext());
            Console.WriteLine("Lägg till elev");
            Console.WriteLine("PersonNummer: ");
            string persNr = Console.ReadLine();
            Console.WriteLine("Förnamn: ");
            string förnamn = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            string efternamn = Console.ReadLine();
            
            Elev elev = new Elev();
            //elev.Förnamn = förnamn;
            //elev.Efternamn = efternamn;
            //elev.PersonNr = persNr;
            service.LäggTillElev(elev);
        }
    }
}