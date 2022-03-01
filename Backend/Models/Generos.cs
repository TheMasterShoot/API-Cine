using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Backend.Models
{
    public class Generos
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string genero { get; set; }
        [Column(TypeName = "bit")]
        public Boolean estado { get; set; }
    }
}
