using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp1_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class action : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ValorTotal",
                table: "Reserva",
                type: "BINARY_FLOAT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "PrecoPorNoite",
                table: "Quarto",
                type: "BINARY_FLOAT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Valor",
                table: "Pagamento",
                type: "BINARY_FLOAT",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Reserva",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "BINARY_FLOAT");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoPorNoite",
                table: "Quarto",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "BINARY_FLOAT");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Pagamento",
                type: "DECIMAL(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "BINARY_FLOAT");
        }
    }
}
