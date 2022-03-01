using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGenero = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(80)", nullable: false),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    Director = table.Column<string>(type: "varchar(50)", nullable: false),
                    Actores = table.Column<string>(type: "text", nullable: false),
                    FechaEstreno = table.Column<DateTime>(type: "date", nullable: false),
                    Clasificacion = table.Column<string>(type: "varchar(5)", nullable: false),
                    Portada = table.Column<string>(type: "text", nullable: false),
                    Multimedia = table.Column<string>(type: "text", nullable: false),
                    Sipnosis = table.Column<string>(type: "text", nullable: false),
                    Ventas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");
        }
    }
}
