﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleVendas.Migrations
{
    /// <inheritdoc />
    public partial class createnivelacesso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NivelAcesso",
                columns: table => new
                {
                    NivelAcessoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelAcesso", x => x.NivelAcessoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NivelAcesso");
        }
    }
}
