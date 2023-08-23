using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cp1_enterprise.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_HOSPEDE_TB_HOSPEDE_HospedeId1",
                table: "TB_HOSPEDE");

            migrationBuilder.DropIndex(
                name: "IX_TB_HOSPEDE_HospedeId1",
                table: "TB_HOSPEDE");

            migrationBuilder.DropColumn(
                name: "HospedeId1",
                table: "TB_HOSPEDE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HospedeId1",
                table: "TB_HOSPEDE",
                type: "NUMBER(10)",
                nullable: true);

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
        }
    }
}
