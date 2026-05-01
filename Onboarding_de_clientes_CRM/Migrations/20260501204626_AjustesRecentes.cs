using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Onboarding_de_clientes_CRM.Migrations
{
    /// <inheritdoc />
    public partial class AjustesRecentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Onboardings");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Onboardings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Onboardings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Prazo",
                table: "Onboardings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Prioridade",
                table: "Onboardings",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Onboardings");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Onboardings");

            migrationBuilder.DropColumn(
                name: "Prazo",
                table: "Onboardings");

            migrationBuilder.DropColumn(
                name: "Prioridade",
                table: "Onboardings");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Onboardings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
