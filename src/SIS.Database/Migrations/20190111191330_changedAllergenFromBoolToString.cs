using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class changedAllergenFromBoolToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Allergen",
                table: "FoodTableAccess",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Allergen",
                table: "FoodTableAccess",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
