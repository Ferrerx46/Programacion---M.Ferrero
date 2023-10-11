using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaEntidadFinanciera.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "NumeroCuenta",
                table: "CuentasBancarias",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumeroCuenta",
                table: "CuentasBancarias",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
