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
    }
}
