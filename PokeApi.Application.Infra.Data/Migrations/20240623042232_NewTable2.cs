using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokeApi.Application.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "order",
                table: "PokeDTO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "weight",
                table: "PokeDTO",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order",
                table: "PokeDTO");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "PokeDTO");
        }
    }
}
