using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SyncPoint365.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Competencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VrstaKompetencija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaKompetencija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VrstaKompetencija_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Competencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VrstaKompetencijeId = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: true),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competencies_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Competencies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Competencies_VrstaKompetencija_VrstaKompetencijeId",
                        column: x => x.VrstaKompetencijeId,
                        principalTable: "VrstaKompetencija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competencies_CountryID",
                table: "Competencies",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Competencies_UserId",
                table: "Competencies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Competencies_VrstaKompetencijeId",
                table: "Competencies",
                column: "VrstaKompetencijeId");

            migrationBuilder.CreateIndex(
                name: "IX_VrstaKompetencija_CompanyId",
                table: "VrstaKompetencija",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competencies");

            migrationBuilder.DropTable(
                name: "VrstaKompetencija");
        }
    }
}
