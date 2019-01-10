using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class changecustomerIDtocustId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventTableAccess_CustomerTableAccess_CustomerID",
                table: "EventTableAccess");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "EventTableAccess",
                newName: "CustID");

            migrationBuilder.RenameIndex(
                name: "IX_EventTableAccess_CustomerID",
                table: "EventTableAccess",
                newName: "IX_EventTableAccess_CustID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventTableAccess_CustomerTableAccess_CustID",
                table: "EventTableAccess",
                column: "CustID",
                principalTable: "CustomerTableAccess",
                principalColumn: "CustID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventTableAccess_CustomerTableAccess_CustID",
                table: "EventTableAccess");

            migrationBuilder.RenameColumn(
                name: "CustID",
                table: "EventTableAccess",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_EventTableAccess_CustID",
                table: "EventTableAccess",
                newName: "IX_EventTableAccess_CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventTableAccess_CustomerTableAccess_CustomerID",
                table: "EventTableAccess",
                column: "CustomerID",
                principalTable: "CustomerTableAccess",
                principalColumn: "CustID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
