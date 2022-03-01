using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Modalidad
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idSala { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idCine { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string tipo { get; set; }
    }
}
