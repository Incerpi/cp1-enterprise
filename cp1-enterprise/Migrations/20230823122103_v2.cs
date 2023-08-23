using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp1_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoQuarto",
                table: "TipoQuarto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reserva",
                table: "Reserva");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quarto",
                table: "Quarto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospede",
                table: "Hospede");

            migrationBuilder.RenameTable(
                name: "TipoQuarto",
                newName: "TB_TIPOQUARTO");

            migrationBuilder.RenameTable(
                name: "Reserva",
                newName: "TB_RESERVA");

            migrationBuilder.RenameTable(
                name: "Quarto",
                newName: "TB_QUARTO");

            migrationBuilder.RenameTable(
                name: "Pagamento",
                newName: "TB_PAGAMENTO");

            migrationBuilder.RenameTable(
                name: "Hospede",
                newName: "TB_HOSPEDE");

            migrationBuilder.AddColumn<int>(
                name: "IdHospede",
                table: "TB_RESERVA",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HospedeId1",
                table: "TB_HOSPEDE",
                type: "NUMBER(10)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_TIPOQUARTO",
                table: "TB_TIPOQUARTO",
                column: "IdTipoQuarto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_RESERVA",
                table: "TB_RESERVA",
                column: "IdReserva");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_QUARTO",
                table: "TB_QUARTO",
                column: "QuartoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PAGAMENTO",
                table: "TB_PAGAMENTO",
                column: "IdPagamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_HOSPEDE",
                table: "TB_HOSPEDE",
                column: "HospedeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_RESERVA_IdHospede",
                table: "TB_RESERVA",
                column: "IdHospede");

            migrationBuilder.CreateIndex(
                name: "IX_TB_HOSPEDE_HospedeId1",
                table: "TB_HOSPEDE",
                column: "HospedeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_HOSPEDE_TB_HOSPEDE_HospedeId1",
                table: "TB_HOSPEDE",
                column: "HospedeId1",
                principalTable: "TB_HOSPEDE",
                principalColumn: "HospedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_RESERVA_TB_HOSPEDE_IdHospede",
                table: "TB_RESERVA",
                column: "IdHospede",
                principalTable: "TB_HOSPEDE",
                principalColumn: "HospedeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_HOSPEDE_TB_HOSPEDE_HospedeId1",
                table: "TB_HOSPEDE");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_RESERVA_TB_HOSPEDE_IdHospede",
                table: "TB_RESERVA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_TIPOQUARTO",
                table: "TB_TIPOQUARTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_RESERVA",
                table: "TB_RESERVA");

            migrationBuilder.DropIndex(
                name: "IX_TB_RESERVA_IdHospede",
                table: "TB_RESERVA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_QUARTO",
                table: "TB_QUARTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PAGAMENTO",
                table: "TB_PAGAMENTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_HOSPEDE",
                table: "TB_HOSPEDE");

            migrationBuilder.DropIndex(
                name: "IX_TB_HOSPEDE_HospedeId1",
                table: "TB_HOSPEDE");

            migrationBuilder.DropColumn(
                name: "IdHospede",
                table: "TB_RESERVA");

            migrationBuilder.DropColumn(
                name: "HospedeId1",
                table: "TB_HOSPEDE");

            migrationBuilder.RenameTable(
                name: "TB_TIPOQUARTO",
                newName: "TipoQuarto");

            migrationBuilder.RenameTable(
                name: "TB_RESERVA",
                newName: "Reserva");

            migrationBuilder.RenameTable(
                name: "TB_QUARTO",
                newName: "Quarto");

            migrationBuilder.RenameTable(
                name: "TB_PAGAMENTO",
                newName: "Pagamento");

            migrationBuilder.RenameTable(
                name: "TB_HOSPEDE",
                newName: "Hospede");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoQuarto",
                table: "TipoQuarto",
                column: "IdTipoQuarto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reserva",
                table: "Reserva",
                column: "IdReserva");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quarto",
                table: "Quarto",
                column: "QuartoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento",
                column: "IdPagamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospede",
                table: "Hospede",
                column: "HospedeId");
        }
    }
}
