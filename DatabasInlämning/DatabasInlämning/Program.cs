using DatabasInlämning.Models;

namespace DatabasInlämning
{
    public class Program
    {
        private static readonly SkolService service = new SkolService(new SkolKontext());
        static void Main(string[] args)
        {
            bool visaMeny = true;
            while (visaMeny)
            {
                visaMeny = HuvudMeny();
            }
        }

        private static bool HuvudMeny()
        {
            Console.Clear();
            Console.WriteLine("Skoldatabasen");
            Console.WriteLine("-------------");
            Console.WriteLine("1) Lägg till en post");
            Console.WriteLine("2) Ta bort en post");
            Console.WriteLine("3) Visa post");
            Console.WriteLine("4) Avsluta");
            Console.Write("\r\nVälj ett alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    LäggTillMenyn();
                    return true;
                case "2":
                    TaBortMenyn();
                    return true;
                case "3":
                    VisaPostMenyn();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        private static void LäggTillMenyn()
        {
            Console.Clear();
            Console.WriteLine("Lägg till post");
            Console.WriteLine("--------------");
            Console.WriteLine("1) Lägg till elev");
            Console.WriteLine("2) Lägg till kurs");
            Console.WriteLine("3) Lägg till läser");
            Console.WriteLine("4) Gå tillbaka");
            Console.Write("\r\nVälj ett alternativ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Lägg till elev");
                    Console.WriteLine("--------------");
                    Console.Write("PersonNummer: ");
                    string persNr = Console.ReadLine();
                    Console.WriteLine("Förnamn: ");
                    string förnamn = Console.ReadLine();
                    Console.WriteLine("Efternamn: ");
                    string efternamn = Console.ReadLine();
                    Elev elev = new Elev();
                    elev.Förnamn = förnamn;
                    elev.Efternamn = efternamn;
                    elev.PersonNr = persNr;
                    service.LäggTillElev(elev);
                    break;
                default:
                    break;
            }

        }

        private static void TaBortMenyn()
        {

        }

        private static void VisaPostMenyn()
        {

        }

        /*Console.WriteLine("Lägg till elev");
            
        

        */
    }
}