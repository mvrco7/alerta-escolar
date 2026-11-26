using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AlertaEscolar.Api.Migrations.PostgreSQL
{
    /// <inheritdoc />
    public partial class InicialPostgreSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    UsuarioResponsableId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorialCasos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CasoId = table.Column<int>(type: "integer", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DescripcionAccion = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialCasos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Correo = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Rol = table.Column<string>(type: "text", nullable: false),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casos");

            migrationBuilder.DropTable(
                name: "HistorialCasos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
