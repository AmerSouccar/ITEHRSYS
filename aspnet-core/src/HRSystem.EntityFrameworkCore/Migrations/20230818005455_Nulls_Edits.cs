using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class Nulls_Edits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceMonthlyCards_AttendanceRecords_AttendanceRecordId",
                table: "AttendanceMonthlyCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationalities_SecondaryNationalityId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Nodes_Nodes_ParentId",
                table: "Nodes");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "Nodes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SecondaryNationalityId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AttendanceRecordId",
                table: "AttendanceMonthlyCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceMonthlyCards_AttendanceRecords_AttendanceRecordId",
                table: "AttendanceMonthlyCards",
                column: "AttendanceRecordId",
                principalTable: "AttendanceRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationalities_SecondaryNationalityId",
                table: "Employees",
                column: "SecondaryNationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nodes_Nodes_ParentId",
                table: "Nodes",
                column: "ParentId",
                principalTable: "Nodes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceMonthlyCards_AttendanceRecords_AttendanceRecordId",
                table: "AttendanceMonthlyCards");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationalities_SecondaryNationalityId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Nodes_Nodes_ParentId",
                table: "Nodes");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "Nodes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SecondaryNationalityId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AttendanceRecordId",
                table: "AttendanceMonthlyCards",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceMonthlyCards_AttendanceRecords_AttendanceRecordId",
                table: "AttendanceMonthlyCards",
                column: "AttendanceRecordId",
                principalTable: "AttendanceRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationalities_SecondaryNationalityId",
                table: "Employees",
                column: "SecondaryNationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nodes_Nodes_ParentId",
                table: "Nodes",
                column: "ParentId",
                principalTable: "Nodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
