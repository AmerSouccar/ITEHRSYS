using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class Attendance_Edits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NormalShifts_Workshops_WorkshopId",
                table: "NormalShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshops_AttendanceForms_AttendanceFormId",
                table: "Workshops");

            migrationBuilder.AlterColumn<Guid>(
                name: "AttendanceFormId",
                table: "Workshops",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkshopId",
                table: "NormalShifts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NormalShifts_Workshops_WorkshopId",
                table: "NormalShifts",
                column: "WorkshopId",
                principalTable: "Workshops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshops_AttendanceForms_AttendanceFormId",
                table: "Workshops",
                column: "AttendanceFormId",
                principalTable: "AttendanceForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NormalShifts_Workshops_WorkshopId",
                table: "NormalShifts");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshops_AttendanceForms_AttendanceFormId",
                table: "Workshops");

            migrationBuilder.AlterColumn<Guid>(
                name: "AttendanceFormId",
                table: "Workshops",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkshopId",
                table: "NormalShifts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_NormalShifts_Workshops_WorkshopId",
                table: "NormalShifts",
                column: "WorkshopId",
                principalTable: "Workshops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workshops_AttendanceForms_AttendanceFormId",
                table: "Workshops",
                column: "AttendanceFormId",
                principalTable: "AttendanceForms",
                principalColumn: "Id");
        }
    }
}
