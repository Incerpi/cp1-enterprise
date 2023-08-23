using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp1_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdReserva",
                table: "TB_PAGAMENTO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PAGAMENTO_IdReserva",
                table: "TB_PAGAMENTO",
                column: "IdReserva");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PAGAMENTO_TB_RESERVA_IdReserva",
                table: "TB_PAGAMENTO",
                column: "IdReserva",
                principalTable: "TB_RESERVA",
                principalColumn: "IdReserva",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PAGAMENTO_TB_RESERVA_IdReserva",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropIndex(
                name: "IX_TB_PAGAMENTO_IdReserva",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropColumn(
                name: "IdReserva",
                table: "TB_PAGAMENTO");
        }
    }
}
