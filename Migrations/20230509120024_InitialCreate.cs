using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Materialempfehlung.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artikelnummer_Carini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualität = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artikeltyp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dicke_mm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grammgewicht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preis = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Äußerer_Einfluss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Äußerer_Einfluss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Bedingungen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Bedingungen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Besonderheit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Besonderheit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Druckverfahren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Druckverfahren", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Kategorien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Kategorien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Klebstoffe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Klebstoffe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Oberfläche_Beschaffenheiten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Oberfläche_Beschaffenheiten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Oberfläche_Farben",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Oberfläche_Farben", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Oberfläche_Formen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Oberfläche_Formen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Oberfläche_Zustände",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Oberfläche_Zustände", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEL_Oberflächen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bemerkung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Erstellungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Änderungsdatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEL_Oberflächen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialÄußerer_Einfluss",
                columns: table => new
                {
                    MaterialienId = table.Column<int>(type: "int", nullable: false),
                    Äußere_EinflüsseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialÄußerer_Einfluss", x => new { x.MaterialienId, x.Äußere_EinflüsseId });
                    table.ForeignKey(
                        name: "FK_MaterialÄußerer_Einfluss_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialÄußerer_Einfluss_MEL_Äußerer_Einfluss_Äußere_EinflüsseId",
                        column: x => x.Äußere_EinflüsseId,
                        principalTable: "MEL_Äußerer_Einfluss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BedingungMaterial",
                columns: table => new
                {
                    BedingungenId = table.Column<int>(type: "int", nullable: false),
                    MaterialienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedingungMaterial", x => new { x.BedingungenId, x.MaterialienId });
                    table.ForeignKey(
                        name: "FK_BedingungMaterial_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedingungMaterial_MEL_Bedingungen_BedingungenId",
                        column: x => x.BedingungenId,
                        principalTable: "MEL_Bedingungen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesonderheitMaterial",
                columns: table => new
                {
                    BesonderheitenId = table.Column<int>(type: "int", nullable: false),
                    MaterialienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesonderheitMaterial", x => new { x.BesonderheitenId, x.MaterialienId });
                    table.ForeignKey(
                        name: "FK_BesonderheitMaterial_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesonderheitMaterial_MEL_Besonderheit_BesonderheitenId",
                        column: x => x.BesonderheitenId,
                        principalTable: "MEL_Besonderheit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DruckverfahrenMaterial",
                columns: table => new
                {
                    DruckverfahrenId = table.Column<int>(type: "int", nullable: false),
                    MaterialienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DruckverfahrenMaterial", x => new { x.DruckverfahrenId, x.MaterialienId });
                    table.ForeignKey(
                        name: "FK_DruckverfahrenMaterial_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DruckverfahrenMaterial_MEL_Druckverfahren_DruckverfahrenId",
                        column: x => x.DruckverfahrenId,
                        principalTable: "MEL_Druckverfahren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KategorieMaterial",
                columns: table => new
                {
                    KategorienId = table.Column<int>(type: "int", nullable: false),
                    MaterialienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorieMaterial", x => new { x.KategorienId, x.MaterialienId });
                    table.ForeignKey(
                        name: "FK_KategorieMaterial_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategorieMaterial_MEL_Kategorien_KategorienId",
                        column: x => x.KategorienId,
                        principalTable: "MEL_Kategorien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KlebstoffMaterial",
                columns: table => new
                {
                    KlebstoffeId = table.Column<int>(type: "int", nullable: false),
                    MaterialienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlebstoffMaterial", x => new { x.KlebstoffeId, x.MaterialienId });
                    table.ForeignKey(
                        name: "FK_KlebstoffMaterial_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlebstoffMaterial_MEL_Klebstoffe_KlebstoffeId",
                        column: x => x.KlebstoffeId,
                        principalTable: "MEL_Klebstoffe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialOberfläche_Beschaffenheit",
                columns: table => new
                {
                    MaterialienId = table.Column<int>(type: "int", nullable: false),
                    Oberfläche_BeschaffenheitenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialOberfläche_Beschaffenheit", x => new { x.MaterialienId, x.Oberfläche_BeschaffenheitenId });
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Beschaffenheit_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Beschaffenheit_MEL_Oberfläche_Beschaffenheiten_Oberfläche_BeschaffenheitenId",
                        column: x => x.Oberfläche_BeschaffenheitenId,
                        principalTable: "MEL_Oberfläche_Beschaffenheiten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialOberfläche_Farbe",
                columns: table => new
                {
                    MaterialienId = table.Column<int>(type: "int", nullable: false),
                    Oberfläche_FarbenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialOberfläche_Farbe", x => new { x.MaterialienId, x.Oberfläche_FarbenId });
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Farbe_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Farbe_MEL_Oberfläche_Farben_Oberfläche_FarbenId",
                        column: x => x.Oberfläche_FarbenId,
                        principalTable: "MEL_Oberfläche_Farben",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialOberfläche_Form",
                columns: table => new
                {
                    MaterialienId = table.Column<int>(type: "int", nullable: false),
                    Oberfläche_FormenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialOberfläche_Form", x => new { x.MaterialienId, x.Oberfläche_FormenId });
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Form_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Form_MEL_Oberfläche_Formen_Oberfläche_FormenId",
                        column: x => x.Oberfläche_FormenId,
                        principalTable: "MEL_Oberfläche_Formen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialOberfläche_Zustand",
                columns: table => new
                {
                    MaterialienId = table.Column<int>(type: "int", nullable: false),
                    Oberfläche_ZuständeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialOberfläche_Zustand", x => new { x.MaterialienId, x.Oberfläche_ZuständeId });
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Zustand_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Zustand_MEL_Oberfläche_Zustände_Oberfläche_ZuständeId",
                        column: x => x.Oberfläche_ZuständeId,
                        principalTable: "MEL_Oberfläche_Zustände",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialOberfläche",
                columns: table => new
                {
                    MaterialienId = table.Column<int>(type: "int", nullable: false),
                    OberflächenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialOberfläche", x => new { x.MaterialienId, x.OberflächenId });
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_Material_MaterialienId",
                        column: x => x.MaterialienId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialOberfläche_MEL_Oberflächen_OberflächenId",
                        column: x => x.OberflächenId,
                        principalTable: "MEL_Oberflächen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedingungMaterial_MaterialienId",
                table: "BedingungMaterial",
                column: "MaterialienId");

            migrationBuilder.CreateIndex(
                name: "IX_BesonderheitMaterial_MaterialienId",
                table: "BesonderheitMaterial",
                column: "MaterialienId");

            migrationBuilder.CreateIndex(
                name: "IX_DruckverfahrenMaterial_MaterialienId",
                table: "DruckverfahrenMaterial",
                column: "MaterialienId");

            migrationBuilder.CreateIndex(
                name: "IX_KategorieMaterial_MaterialienId",
                table: "KategorieMaterial",
                column: "MaterialienId");

            migrationBuilder.CreateIndex(
                name: "IX_KlebstoffMaterial_MaterialienId",
                table: "KlebstoffMaterial",
                column: "MaterialienId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialÄußerer_Einfluss_Äußere_EinflüsseId",
                table: "MaterialÄußerer_Einfluss",
                column: "Äußere_EinflüsseId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOberfläche_OberflächenId",
                table: "MaterialOberfläche",
                column: "OberflächenId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOberfläche_Beschaffenheit_Oberfläche_BeschaffenheitenId",
                table: "MaterialOberfläche_Beschaffenheit",
                column: "Oberfläche_BeschaffenheitenId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOberfläche_Farbe_Oberfläche_FarbenId",
                table: "MaterialOberfläche_Farbe",
                column: "Oberfläche_FarbenId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOberfläche_Form_Oberfläche_FormenId",
                table: "MaterialOberfläche_Form",
                column: "Oberfläche_FormenId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialOberfläche_Zustand_Oberfläche_ZuständeId",
                table: "MaterialOberfläche_Zustand",
                column: "Oberfläche_ZuständeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedingungMaterial");

            migrationBuilder.DropTable(
                name: "BesonderheitMaterial");

            migrationBuilder.DropTable(
                name: "DruckverfahrenMaterial");

            migrationBuilder.DropTable(
                name: "KategorieMaterial");

            migrationBuilder.DropTable(
                name: "KlebstoffMaterial");

            migrationBuilder.DropTable(
                name: "MaterialÄußerer_Einfluss");

            migrationBuilder.DropTable(
                name: "MaterialOberfläche");

            migrationBuilder.DropTable(
                name: "MaterialOberfläche_Beschaffenheit");

            migrationBuilder.DropTable(
                name: "MaterialOberfläche_Farbe");

            migrationBuilder.DropTable(
                name: "MaterialOberfläche_Form");

            migrationBuilder.DropTable(
                name: "MaterialOberfläche_Zustand");

            migrationBuilder.DropTable(
                name: "MEL_Bedingungen");

            migrationBuilder.DropTable(
                name: "MEL_Besonderheit");

            migrationBuilder.DropTable(
                name: "MEL_Druckverfahren");

            migrationBuilder.DropTable(
                name: "MEL_Kategorien");

            migrationBuilder.DropTable(
                name: "MEL_Klebstoffe");

            migrationBuilder.DropTable(
                name: "MEL_Äußerer_Einfluss");

            migrationBuilder.DropTable(
                name: "MEL_Oberflächen");

            migrationBuilder.DropTable(
                name: "MEL_Oberfläche_Beschaffenheiten");

            migrationBuilder.DropTable(
                name: "MEL_Oberfläche_Farben");

            migrationBuilder.DropTable(
                name: "MEL_Oberfläche_Formen");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "MEL_Oberfläche_Zustände");
        }
    }
}
