using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Compras
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idUsuario { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idPelicula { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idCine { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idSala { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idHorario { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int idModalidad { get; set; }
        [Required]
        [Column(TypeName = "numeric(18)")]
        public int cantidad { get; set; }
        [Required]
        [Column(TypeName = "numeric(18)")]
        public int precio { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime fecha { get; set; }
    }
}
