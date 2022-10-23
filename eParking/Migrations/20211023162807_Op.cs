using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eParking.Migrations
{
    public partial class Op : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RadnoVrijeme",
                table: "Parkinzi");

            migrationBuilder.AddColumn<DateTime>(
                name: "RadnoVrijemeDO",
                table: "Parkinzi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RadnoVrijemeOD",
                table: "Parkinzi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RadnoVrijemeDO",
                table: "Parkinzi");

            migrationBuilder.DropColumn(
                name: "RadnoVrijemeOD",
                table: "Parkinzi");

            migrationBuilder.AddColumn<string>(
                name: "RadnoVrijeme",
                table: "Parkinzi",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
