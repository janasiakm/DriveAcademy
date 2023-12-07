using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DriveAcademyApi.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: false),
                    DateOfBirth = table.Column<string>(type: "varchar(10)", nullable: false),
                    IdNumber = table.Column<string>(type: "varchar(8)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Modification = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
