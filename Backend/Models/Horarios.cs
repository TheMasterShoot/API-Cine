using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Horarios
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idCine { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idSala { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idPelicula { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime dia { get; set; }
        [Required]
        [Column(TypeName = "time(7)")]
        public TimeSpan hora { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int estado { get; set; }
    }
}
