using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasInlämning.Models
{
    public class Elev
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Column(TypeName = "varchar")]
        //public string PersonNr { get; set; }
        //public string Förnamn { get; set; }
        //public string Efternamn { get; set; }
    }
}
