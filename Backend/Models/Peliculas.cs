using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Peliculas
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int IdGenero { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Estado { get; set; }
        [Required]
        [Column(TypeName = "varchar(80)")]
        public string Titulo { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Duracion { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Director { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Actores { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime FechaEstreno { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string Clasificacion { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Portada { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Multimedia { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Sipnosis { get; set; }
        [Column(TypeName = "int")]
        public int Ventas { get; set; }
    }
}
