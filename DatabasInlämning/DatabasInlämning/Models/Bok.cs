using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabasInlämning.Models
{
    public class Bok
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BokId { get; set; }
        public string Titel { get; set; }
        public string Ämne { get; set; }
    }
}
