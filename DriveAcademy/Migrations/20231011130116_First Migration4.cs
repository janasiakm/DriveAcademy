using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveAcademyApi.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "Timetables",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AddColumn<int>(
                name: "Paid",
                table: "Timetables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Students",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modification",
                table: "Students",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Cars",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modification",
                table: "Cars",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Modification",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Modification",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Timetables",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
