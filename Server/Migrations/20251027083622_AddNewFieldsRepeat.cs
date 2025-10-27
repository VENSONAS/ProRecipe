using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldsRepeat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCalories",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TotalProtein",
                table: "Recipes");

            migrationBuilder.AddColumn<decimal>(
                name: "CaloriePer100",
                table: "Ingredient",
                type: "TEXT",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ProteinPer100",
                table: "Ingredient",
                type: "TEXT",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriePer100",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "ProteinPer100",
                table: "Ingredient");

            migrationBuilder.AddColumn<int>(
                name: "TotalCalories",
                table: "Recipes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalProtein",
                table: "Recipes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
