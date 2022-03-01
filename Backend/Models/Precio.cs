using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Precio
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
        public int idModalidad { get; set; }
        [Required]
        [Column(TypeName = "numeric(18)")]
        public int precio { get; set; }
    }
}
