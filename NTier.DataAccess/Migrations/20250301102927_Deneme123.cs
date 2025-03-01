using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IcerikUretimSistemi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Deneme123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Follows",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserID1",
                table: "Follows",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Follows_UserID",
                table: "Follows",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_UserID1",
                table: "Follows",
                column: "UserID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Follows_Users_UserID",
                table: "Follows",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Follows_Users_UserID1",
                table: "Follows",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Follows_Users_UserID",
                table: "Follows");

            migrationBuilder.DropForeignKey(
                name: "FK_Follows_Users_UserID1",
                table: "Follows");

            migrationBuilder.DropIndex(
                name: "IX_Follows_UserID",
                table: "Follows");

            migrationBuilder.DropIndex(
                name: "IX_Follows_UserID1",
                table: "Follows");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Follows");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Follows");
        }
    }
}
