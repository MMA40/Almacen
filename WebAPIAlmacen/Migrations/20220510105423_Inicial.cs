using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAlmacen.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribuidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Familias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "date", nullable: false),
                    Descatalogado = table.Column<bool>(type: "bit", nullable: false),
                    FotoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamiliaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Familias_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistribuidoresProductos",
                columns: table => new
                {
                    DistribuidorId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    UnidadesVendidas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistribuidoresProductos", x => new { x.DistribuidorId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_DistribuidoresProductos_Distribuidores_DistribuidorId",
                        column: x => x.DistribuidorId,
                        principalTable: "Distribuidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistribuidoresProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistribuidorProducto",
                columns: table => new
                {
                    DistribuidoresId = table.Column<int>(type: "int", nullable: false),
                    ProductosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistribuidorProducto", x => new { x.DistribuidoresId, x.ProductosId });
                    table.ForeignKey(
                        name: "FK_DistribuidorProducto_Distribuidores_DistribuidoresId",
                        column: x => x.DistribuidoresId,
                        principalTable: "Distribuidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistribuidorProducto_Productos_ProductosId",
                        column: x => x.ProductosId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UbicacionesProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pasillo = table.Column<int>(type: "int", nullable: false),
                    Estateria = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UbicacionesProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UbicacionesProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Familias",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Tecnología" });

            migrationBuilder.InsertData(
                table: "Familias",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Moda" });

            migrationBuilder.InsertData(
                table: "Familias",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Hogar" });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Descatalogado", "FamiliaId", "FechaAlta", "FotoURL", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, false, 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Portátil", 1000m },
                    { 2, false, 1, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Impresora", 100m },
                    { 3, true, 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "IBM", 1800m },
                    { 4, false, 2, new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Camisa", 10m },
                    { 5, false, 2, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pantalón", 20m },
                    { 6, true, 2, new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Traje", 150m },
                    { 7, false, 3, new DateTime(2018, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lavadora", 800m },
                    { 8, false, 3, new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Microondas", 120m },
                    { 9, true, 3, new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cafetera", 150m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistribuidoresProductos_ProductoId",
                table: "DistribuidoresProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_DistribuidorProducto_ProductosId",
                table: "DistribuidorProducto",
                column: "ProductosId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_FamiliaId",
                table: "Productos",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_UbicacionesProductos_ProductoId",
                table: "UbicacionesProductos",
                column: "ProductoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistribuidoresProductos");

            migrationBuilder.DropTable(
                name: "DistribuidorProducto");

            migrationBuilder.DropTable(
                name: "UbicacionesProductos");

            migrationBuilder.DropTable(
                name: "Distribuidores");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Familias");
        }
    }
}
