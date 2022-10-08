using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FINMUE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inmueble",
                columns: table => new
                {
                    InmuebleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoDeInmueble = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Domicilio = table.Column<string>(type: "TEXT", nullable: false),
                    Costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmueble", x => x.InmuebleId);
                });

            migrationBuilder.CreateTable(
                name: "Casa",
                columns: table => new
                {
                    CasaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroDeCasa = table.Column<string>(type: "TEXT", nullable: false),
                    MetrosCuadrados = table.Column<int>(type: "INTEGER", nullable: false),
                    InmuebleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casa", x => x.CasaId);
                    table.ForeignKey(
                        name: "FK_Casa_Inmueble_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmueble",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inquilino",
                columns: table => new
                {
                    InquilinoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Identificacion = table.Column<string>(type: "TEXT", nullable: false),
                    Sexo = table.Column<string>(type: "TEXT", nullable: false),
                    FechaDeAlta = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaDeBaja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InmuebleId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquilino", x => x.InquilinoId);
                    table.ForeignKey(
                        name: "FK_Inquilino_Inmueble_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmueble",
                        principalColumn: "InmuebleId");
                });

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    LocalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroDeLocal = table.Column<string>(type: "TEXT", nullable: false),
                    MetrosCuadrados = table.Column<int>(type: "INTEGER", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    InmuebleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.LocalId);
                    table.ForeignKey(
                        name: "FK_Local_Inmueble_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmueble",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movimiento",
                columns: table => new
                {
                    MovimientoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<decimal>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    InmuebleId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaDeMovimiento = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimiento", x => x.MovimientoId);
                    table.ForeignKey(
                        name: "FK_Movimiento_Inmueble_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmueble",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Piso",
                columns: table => new
                {
                    PisoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroDePiso = table.Column<int>(type: "INTEGER", nullable: false),
                    MetrosCuadrados = table.Column<int>(type: "INTEGER", nullable: false),
                    InmuebleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piso", x => x.PisoId);
                    table.ForeignKey(
                        name: "FK_Piso_Inmueble_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmueble",
                        principalColumn: "InmuebleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recibo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ValorUnicoRecibo = table.Column<string>(type: "TEXT", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Importe = table.Column<decimal>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    CargoAgua = table.Column<decimal>(type: "TEXT", nullable: false),
                    CargoElectricidad = table.Column<decimal>(type: "TEXT", nullable: false),
                    CargoTelefono = table.Column<decimal>(type: "TEXT", nullable: false),
                    CargoGas = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    InmuebleId = table.Column<int>(type: "INTEGER", nullable: false),
                    InquilinoId = table.Column<int>(type: "INTEGER", nullable: true),
                    MovimientoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recibo_Inquilino_InquilinoId",
                        column: x => x.InquilinoId,
                        principalTable: "Inquilino",
                        principalColumn: "InquilinoId");
                    table.ForeignKey(
                        name: "FK_Recibo_Movimiento_MovimientoId",
                        column: x => x.MovimientoId,
                        principalTable: "Movimiento",
                        principalColumn: "MovimientoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Casa_InmuebleId",
                table: "Casa",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquilino_InmuebleId",
                table: "Inquilino",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Local_InmuebleId",
                table: "Local",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimiento_InmuebleId",
                table: "Movimiento",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Piso_InmuebleId",
                table: "Piso",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Recibo_InquilinoId",
                table: "Recibo",
                column: "InquilinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recibo_MovimientoId",
                table: "Recibo",
                column: "MovimientoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casa");

            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropTable(
                name: "Piso");

            migrationBuilder.DropTable(
                name: "Recibo");

            migrationBuilder.DropTable(
                name: "Inquilino");

            migrationBuilder.DropTable(
                name: "Movimiento");

            migrationBuilder.DropTable(
                name: "Inmueble");
        }
    }
}
