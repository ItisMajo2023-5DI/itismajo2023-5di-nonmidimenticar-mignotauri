using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MignotauriNonMiDimenticarApp.Models
{
    public class Diplomato
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public string luogoNascita { get; set; }
        public string dataNascita { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public int dataDiploma { get; set; }
        public int votoDiploma { get; set; }
        public string occupazione { get; set; }
        public Scuola scuola { get; set; }
    }
}
