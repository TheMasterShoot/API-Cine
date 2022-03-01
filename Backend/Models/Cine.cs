using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Cine
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(70)")]
        public string direccion { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int estado { get; set; }
        [Column(TypeName = "text")]
        public string imagen { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string email { get; set; }
        [Column(TypeName = "nchar(11)")]
        public string telefono { get; set; }
    }
}
