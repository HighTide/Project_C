using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TCGshopTestEnvironment.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Price = table.Column<float>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Grade = table.Column<string>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Updated = table.Column<DateTime>(nullable: false),
                    Views_Listed = table.Column<int>(nullable: false),
                    Views_Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Product_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
