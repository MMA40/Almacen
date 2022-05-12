using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIAlmacen.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Estateria",
                table: "UbicacionesProductos",
                newName: "Estanteria");

            migrationBuilder.InsertData(
                table: "DistribuidoresProductos",
                columns: new[] { "DistribuidorId", "ProductoId", "UnidadesVendidas" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 1, 2, 0 },
                    { 1, 4, 0 },
                    { 1, 7, 0 },
                    { 1, 9, 0 },
                    { 2, 1, 0 },
                    { 2, 2, 0 },
                    { 2, 3, 0 },
                    { 2, 5, 0 },
                    { 2, 6, 0 },
                    { 2, 7, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "DistribuidoresProductos",
                keyColumns: new[] { "DistribuidorId", "ProductoId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.RenameColumn(
                name: "Estanteria",
                table: "UbicacionesProductos",
                newName: "Estateria");
        }
    }
}
