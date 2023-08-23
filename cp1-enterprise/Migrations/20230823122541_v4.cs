using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp1_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTipoQuarto",
                table: "TB_QUARTO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_QUARTO_IdTipoQuarto",
                table: "TB_QUARTO",
                column: "IdTipoQuarto");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_QUARTO_TB_TIPOQUARTO_IdTipoQuarto",
                table: "TB_QUARTO",
                column: "IdTipoQuarto",
                principalTable: "TB_TIPOQUARTO",
                principalColumn: "IdTipoQuarto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_QUARTO_TB_TIPOQUARTO_IdTipoQuarto",
                table: "TB_QUARTO");

            migrationBuilder.DropIndex(
                name: "IX_TB_QUARTO_IdTipoQuarto",
                table: "TB_QUARTO");

            migrationBuilder.DropColumn(
                name: "IdTipoQuarto",
                table: "TB_QUARTO");
        }
    }
}
