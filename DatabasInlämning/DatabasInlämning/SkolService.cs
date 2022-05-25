using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabasInlämning.Models;

namespace DatabasInlämning
{
    public class SkolService
    {
        private readonly SkolKontext Kontext;

        public SkolService(SkolKontext Kontext)
        {
            this.Kontext = Kontext;
        }

        public Elev LäggTillElev(Elev elev)
        {
            Kontext.tblElever.Add(elev);
            Kontext.SaveChanges();

            return elev;
        }

        public Kurs LäggTillKurs(Kurs kurs)
        {
            Kontext.tblKurser.Add(kurs);
            Kontext.SaveChanges();

            return kurs;
        }

        public Läser LäggTillLäser(Läser läser)
        {
            Kontext.tblLäser.Add(läser);
            Kontext.SaveChanges();

            return läser;
        }

        public void findelev(int id)
        {
            var elev = Kontext.tblElever.Find(id);
            Console.WriteLine(elev.Förnamn);
            return;
        }

        public void findkurs(int id)
        {
            var kurs = Kontext.tblKurser.Find(id);
            Console.WriteLine(kurs.KursNamn + " " + kurs.KursKod);
            return;
        }

        public void AllaElevPoster()
        {
            foreach(var elev in Kontext.tblElever)
            {
                Console.WriteLine(elev.Id + " " + elev.PersonNr + " " + elev.Förnamn + " " + elev.Efternamn);
            }
            return;
        }

        public void AllaKursPoster()
        {
            foreach(var kurs in Kontext.tblKurser)
            {
                Console.WriteLine(kurs.KursID + " " + kurs.KursNamn + " " + kurs.KursKod);
            }
            return;
        }

        public void AllaLäserPoster()
        {
            foreach(var läser in Kontext.tblLäser)
            {
                Console.WriteLine(läser.ID + " " + läser.ElevID + " " + läser.KursID);
            }
            return;
        }

        public void TaBortLäser(int id)
        {
            var x = (from y in Kontext.tblLäser
                     where y.ID == id
                     select y).FirstOrDefault();
            if(x != null)
            {
                Kontext.tblLäser.Remove(x);
                Kontext.SaveChanges();
            }
            return;
        }

        public void KurserPerElev()
        {
            var query = (from läser in Kontext.tblLäser
                        join elev in Kontext.tblElever on läser.ElevID equals elev.Id
                        select new
                        {
                            elevFör = elev.Förnamn,
                            elevEfter = elev.Efternamn,
                            elevId = läser.ElevID
                        })
                        .AsEnumerable()
                        .OrderBy(läser => läser.elevId)
                        .GroupBy(läser => läser.elevId)
                        .ToList();

            string format = "{0,-12} {1,-11} {2}";
            Console.WriteLine(format, "Förnamn", "Efternamn", "Antal kurser");

            foreach (var elev in query)
            {
                var tmp = elev.ElementAt(0);
                Console.WriteLine(format, tmp.elevFör, tmp.elevEfter, elev.Count());
            }
            return;
        }

        public void EleverPerKurs()
        {
            var query = (from läser in Kontext.tblLäser
                        join kurs in Kontext.tblKurser on läser.KursID equals kurs.KursID
                        select new
                        {
                            kursKod = kurs.KursKod,
                            kursNamn = kurs.KursNamn,
                            kursId = läser.KursID
                        })
                        .AsEnumerable()
                        .OrderBy(x => x.kursId)
                        .GroupBy(läser => läser.kursId)
                        .ToList();

            string format = "{0,-17} {1,-10} {2}";
            Console.WriteLine(format, "Kursnamn", "Kurskod", "Mängd Elever");
            
            foreach(var item in query)
            {
                var tmp = item.ElementAt(0);
                Console.WriteLine(format, tmp.kursNamn, tmp.kursKod, item.Count());
            }
            return;
        }

        public Bok LäggTillBok(Bok bok)
        {
            Kontext.tblBok.Add(bok);
            Kontext.SaveChanges();

            return bok;
        }

        public void AllaBokPoster()
        {
            foreach(var bok in Kontext.tblBok)
            {
                Console.WriteLine(bok.BokId + " " + bok.Titel + " " + bok.Ämne);
            }
        }

        public BokLån LäggTillLån(BokLån bokLån)
        {
            Kontext.tblBokLån.Add(bokLån);
            Kontext.SaveChanges();

            return bokLån;
        }
    }
}
