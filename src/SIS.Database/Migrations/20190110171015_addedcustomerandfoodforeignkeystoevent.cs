using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class addedcustomerandfoodforeignkeystoevent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "Food",
                table: "EventTableAccess");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfEvent",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EventTableAccess_CustomerID",
                table: "EventTableAccess",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_EventTableAccess_FoodID",
                table: "EventTableAccess",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventTableAccess_CustomerTableAccess_CustomerID",
                table: "EventTableAccess",
                column: "CustomerID",
                principalTable: "CustomerTableAccess",
                principalColumn: "CustID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventTableAccess_FoodTableAccess_FoodID",
                table: "EventTableAccess",
                column: "FoodID",
                principalTable: "FoodTableAccess",
                principalColumn: "FoodID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventTableAccess_CustomerTableAccess_CustomerID",
                table: "EventTableAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_EventTableAccess_FoodTableAccess_FoodID",
                table: "EventTableAccess");

            migrationBuilder.DropIndex(
                name: "IX_EventTableAccess_CustomerID",
                table: "EventTableAccess");

            migrationBuilder.DropIndex(
                name: "IX_EventTableAccess_FoodID",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "DateOfEvent",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "EventTableAccess");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Food",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: "");
        }
    }
}
