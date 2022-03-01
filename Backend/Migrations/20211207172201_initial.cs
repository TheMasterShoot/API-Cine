using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administradores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(70)", nullable: false),
                    email = table.Column<string>(type: "varchar(70)", nullable: true),
                    password = table.Column<string>(type: "varchar(100)", nullable: false),
                    fecha = table.Column<DateTime>(type: "date", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administradores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    direccion = table.Column<string>(type: "varchar(70)", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false),
                    imagen = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", nullable: true),
                    telefono = table.Column<string>(type: "nchar(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cine", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    idPelicula = table.Column<int>(type: "int", nullable: false),
                    idCine = table.Column<int>(type: "int", nullable: false),
                    idSala = table.Column<int>(type: "int", nullable: false),
                    idHorario = table.Column<int>(type: "int", nullable: false),
                    idModalidad = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(18)", nullable: false),
                    precio = table.Column<decimal>(type: "numeric(18)", nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genero = table.Column<string>(type: "varchar(50)", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCine = table.Column<int>(type: "int", nullable: false),
                    idSala = table.Column<int>(type: "int", nullable: false),
                    idPelicula = table.Column<int>(type: "int", nullable: false),
                    dia = table.Column<DateTime>(type: "date", nullable: false),
                    hora = table.Column<TimeSpan>(type: "time(7)", nullable: false),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Modalidad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idSala = table.Column<int>(type: "int", nullable: false),
                    idCine = table.Column<int>(type: "int", nullable: false),
                    tipo = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Precio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCine = table.Column<int>(type: "int", nullable: false),
                    idModalidad = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<decimal>(type: "numeric(18)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sala = table.Column<string>(type: "varchar(50)", nullable: false),
                    idCine = table.Column<int>(type: "int", nullable: false),
                    capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Slider",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    imagen = table.Column<string>(type: "varchar(100)", nullable: false),
                    titulo1 = table.Column<string>(type: "varchar(50)", nullable: true),
                    titulo2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    titulo3 = table.Column<string>(type: "varchar(50)", nullable: true),
                    boton = table.Column<string>(type: "varchar(50)", nullable: true),
                    url = table.Column<string>(type: "varchar(50)", nullable: true),
                    orden = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slider", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    password = table.Column<string>(type: "varchar(100)", nullable: false),
                    email = table.Column<string>(type: "varchar(70)", nullable: false),
                    fecha = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administradores");

            migrationBuilder.DropTable(
                name: "Cine");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Modalidad");

            migrationBuilder.DropTable(
                name: "Precio");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropTable(
                name: "Slider");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
