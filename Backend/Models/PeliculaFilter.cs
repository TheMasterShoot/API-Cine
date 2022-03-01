using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class PeliculaFilter
    {
        public int estado { get; set; }
        public DateTime fechaEstreno { get; set; }
        public int proxima { get; set; }
        public int estreno { get; set; }
        public int cartelera { get; set; }
        public int taquillera { get; set; }
        public int proximamente { get; set; }
        public int favoritas { get; set; }
    }
}
