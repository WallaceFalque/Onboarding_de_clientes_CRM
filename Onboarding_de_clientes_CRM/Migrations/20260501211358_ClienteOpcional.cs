using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Onboarding_de_clientes_CRM.Migrations
{
    /// <inheritdoc />
    public partial class ClienteOpcional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Onboardings_Clientes_ClienteId",
                table: "Onboardings");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Onboardings",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Onboardings_Clientes_ClienteId",
                table: "Onboardings",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Onboardings_Clientes_ClienteId",
                table: "Onboardings");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Onboardings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Onboardings_Clientes_ClienteId",
                table: "Onboardings",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
