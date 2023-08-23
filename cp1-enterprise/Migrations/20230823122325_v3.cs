using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp1_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdPagamento",
                table: "TB_RESERVA",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_RESERVA_IdPagamento",
                table: "TB_RESERVA",
                column: "IdPagamento");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_RESERVA_TB_PAGAMENTO_IdPagamento",
                table: "TB_RESERVA",
                column: "IdPagamento",
                principalTable: "TB_PAGAMENTO",
                principalColumn: "IdPagamento",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_RESERVA_TB_PAGAMENTO_IdPagamento",
                table: "TB_RESERVA");

            migrationBuilder.DropIndex(
                name: "IX_TB_RESERVA_IdPagamento",
                table: "TB_RESERVA");

            migrationBuilder.DropColumn(
                name: "IdPagamento",
                table: "TB_RESERVA");
        }
    }
}
