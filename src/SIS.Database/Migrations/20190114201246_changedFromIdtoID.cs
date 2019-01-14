using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class changedFromIdtoID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "EventTableAccess",
                newName: "OwnerID");

            migrationBuilder.RenameColumn(
                name: "EventEntityId",
                table: "EventTableAccess",
                newName: "EventEntityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OwnerID",
                table: "EventTableAccess",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "EventEntityID",
                table: "EventTableAccess",
                newName: "EventEntityId");
        }
    }
}
