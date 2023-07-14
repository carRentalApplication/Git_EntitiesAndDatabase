using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalDatabase.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ResetpasswordExpiry",
                table: "AuthUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ResetpasswordToken",
                table: "AuthUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResetpasswordExpiry",
                table: "AuthUsers");

            migrationBuilder.DropColumn(
                name: "ResetpasswordToken",
                table: "AuthUsers");
        }
    }
}
