using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Backend.Models.Administradores> Administradores { get; set; }
        public DbSet<Backend.Models.Cine> Cine { get; set; }
        public DbSet<Backend.Models.Compras> Compras { get; set; }
        public DbSet<Backend.Models.Generos> Generos { get; set; }
        public DbSet<Backend.Models.Horarios> Horarios { get; set; }
        public DbSet<Backend.Models.Modalidad> Modalidad { get; set; }
        public DbSet<Backend.Models.Precio> Precio { get; set; }
        public DbSet<Backend.Models.Sala> Sala { get; set; }
        public DbSet<Backend.Models.Slider> Slider { get; set; }
        public DbSet<Backend.Models.Usuarios> Usuarios { get; set; }
        public DbSet<Backend.Models.Contacto> Contacto { get; set; }
    }
}
