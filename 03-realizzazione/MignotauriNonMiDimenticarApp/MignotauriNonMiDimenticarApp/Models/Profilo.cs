using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MignotauriNonMiDimenticarApp.Models
{
    public class Profilo
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }

        public string sesso { get; set; }
        public string tipo { get; set; }
        public int distanza { get; set; }
        public Posizione posizione { get; set; }
    }
}
