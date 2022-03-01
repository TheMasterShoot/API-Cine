using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Contacto
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string email { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string mensaje { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime fecha { get; set; }
    }
}
