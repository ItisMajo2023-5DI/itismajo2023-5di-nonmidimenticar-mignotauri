using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MignotauriNonMiDimenticarApp.Models
{
    public class Scuola
    {
        [Key]
        public int id { get; set; }
        public string denominazione { get; set; }
        public string ente { get; set; }
        public string indirizzo { get; set; }

        public int indiceOccupazione { get; set; }
        public string sitoWeb { get; set; }
        public Posizione posizione { get; set; }
        public ICollection<Diplomato> diplomati { get; set; }
    }
}
