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

        public void KurserPerElev(int id)
        {
            var x = (from läser in Kontext.tblLäser
                     join elev in Kontext.tblElever on läser.ElevID equals elev.Id
                     join kurs in Kontext.tblKurser on läser.KursID equals kurs.KursID
                     select new
                     {
                         elevNamn = elev.Förnamn,
                         läserKod = läser.KursID,
                         kursNamn = kurs.KursKod
                     });
            foreach(var bruh in x)
            {
                Console.WriteLine(bruh.läserKod + " " + bruh.elevNamn + " " + bruh.kursNamn);
            }
            return;
        }

        public void EleverPerKurs()
        {
            /*var qry = (from läser in Kontext.tblLäser

                       join kurs in Kontext.tblKurser on läser.KursID equals kurs.KursID
                       into groupedCollection

                        select new
                        {
                            Students = groupedCollection,
                            StandardName = läser.KursID
                        });
            

            var qry = (from läser in Kontext.tblLäser
                     join kurs in Kontext.tblKurser on läser.KursID equals kurs.KursID
                     
                     select new
                     {
                         läserKod = läser.KursID,
                         kursNamn = kurs.KursKod
                     });

            var qry = (from läser in Kontext.tblLäser
                       group läser by läser.KursID).ToList();*/

            

            var qry2 = Kontext.tblLäser.AsEnumerable()
                        .GroupBy(läser => läser.KursID)
                        .ToList();

            Console.WriteLine(qry2);
            foreach( var bruh in qry2)
            {
                Console.WriteLine("KursID: {0}", bruh.Key);
                Console.WriteLine(bruh.Count());
            }
            return;
        }
    }
}
