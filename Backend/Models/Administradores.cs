using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Administradores
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(70)")]
        public string nombre { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string email { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string password { get; set; }
        [Required]
        [Column(TypeName = "date")] 
        public DateTime fecha { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int estado { get; set; }
    }
}
