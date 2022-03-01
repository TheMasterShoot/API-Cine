using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Sala
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string sala { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idCine { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int capacidad { get; set; }
    }
}
