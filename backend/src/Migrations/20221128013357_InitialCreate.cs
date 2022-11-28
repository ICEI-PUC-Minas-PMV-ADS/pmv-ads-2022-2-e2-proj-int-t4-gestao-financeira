using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestão_Financeira.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DespesasComuns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DespesasComuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DespesasVariaveis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DespesasVariaveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ObjetivosFinanceiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFinalObjetivo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorObjetivo = table.Column<float>(type: "real", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdSaldo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjetivosFinanceiros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservasEmergenciais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservasEmergenciais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<float>(type: "real", nullable: false),
                    TipoTransacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataTransacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanejamentosCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPrevistaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeveRepetir = table.Column<bool>(type: "bit", nullable: false),
                    ValorPlanejado = table.Column<float>(type: "real", nullable: false),
                    Finalizado = table.Column<bool>(type: "bit", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanejamentosCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanejamentosCompras_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanejamentosCompras_ItemId",
                table: "PlanejamentosCompras",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DespesasComuns");

            migrationBuilder.DropTable(
                name: "DespesasVariaveis");

            migrationBuilder.DropTable(
                name: "ObjetivosFinanceiros");

            migrationBuilder.DropTable(
                name: "PlanejamentosCompras");

            migrationBuilder.DropTable(
                name: "ReservasEmergenciais");

            migrationBuilder.DropTable(
                name: "Transacoes");

            migrationBuilder.DropTable(
                name: "Itens");
        }
    }
}
