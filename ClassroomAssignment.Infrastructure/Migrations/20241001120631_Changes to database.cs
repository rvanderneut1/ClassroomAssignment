using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassroomAssignment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Changestodatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentClass_StudentClassId",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Student",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentClassId",
                table: "Student",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "AdressId",
                table: "Student",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_AdressId",
                table: "Student",
                column: "AdressId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentId",
                table: "Student",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Adress_AdressId",
                table: "Student",
                column: "AdressId",
                principalTable: "Adress",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentClass_StudentClassId",
                table: "Student",
                column: "StudentClassId",
                principalTable: "StudentClass",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Adress_AdressId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentClass_StudentClassId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropIndex(
                name: "IX_Student_AdressId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "StudentClassId",
                table: "Student",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentClass_StudentClassId",
                table: "Student",
                column: "StudentClassId",
                principalTable: "StudentClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
