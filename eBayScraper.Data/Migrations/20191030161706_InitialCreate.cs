using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBayScraper.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ListingTitle = table.Column<string>(nullable: true),
                    Condition = table.Column<int>(nullable: false),
                    CurrentBid = table.Column<double>(nullable: false),
                    ShippingPrice = table.Column<double>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ISBN = table.Column<long>(nullable: false),
                    TimeLeft = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
