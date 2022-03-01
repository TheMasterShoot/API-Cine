using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Slider
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string imagen { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string titulo1 { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string titulo2 { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string titulo3 { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string boton { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string url { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int orden { get; set; }
        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }
    }
}
