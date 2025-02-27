using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IcerikUretimSistemi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AdminNamePassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminPassword",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "AdminPassword",
                table: "Admin");
        }
    }
}
