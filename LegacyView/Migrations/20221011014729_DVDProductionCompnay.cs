using Microsoft.EntityFrameworkCore.Migrations;

namespace LegacyView.Migrations
{
    public partial class DVDProductionCompnay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DVDPrice",
                table: "DVD",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DVDCustomerReview",
                table: "DVD",
                type: "decimal(2, 1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "DVDProductionCompany",
                table: "DVD",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DVDProductionCompany",
                table: "DVD");

            migrationBuilder.AlterColumn<decimal>(
                name: "DVDPrice",
                table: "DVD",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DVDCustomerReview",
                table: "DVD",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2, 1)");
        }
    }
}
