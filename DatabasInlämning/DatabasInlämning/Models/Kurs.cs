using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasInlämning.Models
{
    public class Kurs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KursID { get; set; }
        public string KursNamn { get; set; }
        public string KursKod { get; set; }
    }
}
