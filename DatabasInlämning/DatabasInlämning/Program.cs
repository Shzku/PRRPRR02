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
            Console.Write("\r\nVälj ett alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Lägg till elev");
                    Console.WriteLine("--------------");
                    Console.Write("PersonNummer: ");
                    string persNr = Console.ReadLine();
                    Console.Write("Förnamn: ");
                    string förnamn = Console.ReadLine();
                    Console.Write("Efternamn: ");
                    string efternamn = Console.ReadLine();
                    Elev elev = new Elev();
                    elev.Förnamn = förnamn;
                    elev.Efternamn = efternamn;
                    elev.PersonNr = persNr;
                    service.LäggTillElev(elev);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Lägg till kurs");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Kursnamnet: ");
                    string kursNamn = Console.ReadLine();
                    Console.WriteLine("Kurskoden: ");
                    string kursKod = Console.ReadLine();
                    Kurs kurs = new Kurs();
                    kurs.KursNamn = kursNamn;
                    kurs.KursKod = kursKod;
                    service.LäggTillKurs(kurs);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Lägg till läser");
                    Console.WriteLine("---------------");

                    service.AllaElevPoster();
                    Console.Write("\r\nVälj elev: ");
                    int elevId = int.Parse(Console.ReadLine());

                    service.AllaKursPoster();
                    Console.Write("\r\nVälj kurs: ");
                    int kursId = int.Parse(Console.ReadLine());

                    Läser läser = new Läser();
                    läser.ElevID = elevId;
                    läser.KursID = kursId;
                    service.LäggTillLäser(läser);
                    break;
                default:
                    break;
            }

        }

        private static void TaBortMenyn()
        {
            Console.Clear();
            Console.WriteLine("Lägg till post");
            Console.WriteLine("--------------");
            Console.WriteLine("1) Ta bort elev");
            Console.WriteLine("2) Ta bort kurs");
            Console.WriteLine("3) Ta bort läser");
            Console.WriteLine("4) Gå tillbaka");
            Console.Write("\r\nVälj ett alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Ta bort post");
                    Console.WriteLine("------------");
                    service.AllaLäserPoster();
                    Console.Write("\r\nVälj post: ");
                    int id = int.Parse(Console.ReadLine());
                    service.TaBortLäser(id);
                    break;
                default:
                    break;
            }
        }

        private static void VisaPostMenyn()
        {
            Console.Clear();
            Console.WriteLine("Visa poster");
            Console.WriteLine("--------------");
            Console.WriteLine("1) Visa alla elever");
            Console.WriteLine("2) Visa alla kurser");
            Console.WriteLine("3) Visa alla läser");
            Console.WriteLine("4) Visa kurser per elev");
            Console.WriteLine("5) Visa elever per kurs");
            Console.WriteLine("6) Gå tillbaka");
            Console.Write("\r\nVälj ett alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    service.AllaElevPoster();
                    Console.ReadLine();
                    break;
                case "2":
                    service.AllaKursPoster();
                    Console.ReadLine();
                    break;
                case "3":
                    service.AllaLäserPoster();
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Visa kurser per elev");
                    Console.WriteLine("------------------");
                    service.KurserPerElev();
                    Console.ReadLine();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Visa elever för varje kurs");
                    Console.WriteLine("--------------------------");
                    service.EleverPerKurs();
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}