using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MignotauriNonMiDimenticarApp.Models
{
    public class Posizione
    {
        [Key]
        public int id { get; set; }
        public string indirizzo { get; set; }

        public string comune { get; set; }
        public string provincia { get; set; }
        public string longitudine { get; set; }
        public string latitudine { get; set; }
        public ICollection<Profilo> profili { get; set; }
        public ICollection<Scuola> scuole { get; set; }
    }
}
