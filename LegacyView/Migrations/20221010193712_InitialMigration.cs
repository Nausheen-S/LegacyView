using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LegacyView.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DVD",
                columns: table => new
                {
                    DVDId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DVDName = table.Column<string>(nullable: true),
                    DVDGenre = table.Column<string>(nullable: true),
                    DVDDescription = table.Column<string>(nullable: true),
                    DVDPrice = table.Column<decimal>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    DVDCustomerReview = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVD", x => x.DVDId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DVD");
        }
    }
}
