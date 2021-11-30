using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesCompanySystemAPI.Migrations
{
    public partial class AddSalesCompanySystemDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id_Customer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    documentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identificationNumber = table.Column<int>(type: "int", nullable: false),
                    nameCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastNameCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addressCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumberCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id_Customer);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
