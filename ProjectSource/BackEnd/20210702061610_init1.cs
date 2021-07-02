using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LadanANDAsma.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anbars",
                columns: table => new
                {
                    inventoryID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    inventoryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anbars", x => x.inventoryID);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerName = table.Column<string>(type: "text", nullable: true),
                    CustomerLastName = table.Column<string>(type: "text", nullable: true),
                    CustomerAddress = table.Column<string>(type: "text", nullable: true),
                    CustomerPhoneNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "exits",
                columns: table => new
                {
                    LicenseID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    applicantName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exits", x => x.LicenseID);
                });

            migrationBuilder.CreateTable(
                name: "factors",
                columns: table => new
                {
                    customerID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    factorID = table.Column<int>(type: "integer", nullable: false),
                    IssueDate = table.Column<int>(type: "integer", nullable: false),
                    customerAddress = table.Column<string>(type: "text", nullable: true),
                    productType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factors", x => x.customerID);
                });

            migrationBuilder.CreateTable(
                name: "kalas",
                columns: table => new
                {
                    kalaID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    kalacode = table.Column<int>(type: "integer", nullable: false),
                    kalaname = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kalas", x => x.kalaID);
                });

            migrationBuilder.CreateTable(
                name: "mojavezs",
                columns: table => new
                {
                    licenseID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    licensenum = table.Column<int>(type: "integer", nullable: false),
                    licensedate = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mojavezs", x => x.licenseID);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ordernum = table.Column<int>(type: "integer", nullable: false),
                    orderdate = table.Column<int>(type: "integer", nullable: false),
                    customernum = table.Column<int>(type: "integer", nullable: false),
                    customername = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.orderID);
                });

            migrationBuilder.CreateTable(
                name: "referres",
                columns: table => new
                {
                    referredID = table.Column<string>(type: "text", nullable: false),
                    referredname = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_referres", x => x.referredID);
                });

            migrationBuilder.CreateTable(
                name: "resids",
                columns: table => new
                {
                    residID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    residnum = table.Column<int>(type: "integer", nullable: false),
                    date = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resids", x => x.residID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anbars");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "exits");

            migrationBuilder.DropTable(
                name: "factors");

            migrationBuilder.DropTable(
                name: "kalas");

            migrationBuilder.DropTable(
                name: "mojavezs");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "referres");

            migrationBuilder.DropTable(
                name: "resids");
        }
    }
}
