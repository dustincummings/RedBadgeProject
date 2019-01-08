using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class CustomerTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerTableAccess",
                columns: table => new
                {
                    CustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustFirstName = table.Column<string>(nullable: false),
                    CustLastName = table.Column<string>(nullable: false),
                    CustEmail = table.Column<string>(nullable: false),
                    CustPhone = table.Column<string>(nullable: false),
                    CustAddress = table.Column<string>(nullable: false),
                    CustCityStZip = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTableAccess", x => x.CustID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerTableAccess");
        }
    }
}
