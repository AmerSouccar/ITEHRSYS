using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class LeaveRequestProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Custodies_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Custodies");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_ReadEmployeeCardDtoId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveSettings_EmployeeCards_EmployeeCardId",
                table: "LeaveSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_LeaveSettings_EmployeeCardId",
                table: "LeaveSettings");

            migrationBuilder.DropColumn(
                name: "EmployeeCardId",
                table: "LeaveSettings");

            migrationBuilder.RenameColumn(
                name: "ReadEmployeeCardDtoId",
                table: "Transfers",
                newName: "EmployeeCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_ReadEmployeeCardDtoId",
                table: "Transfers",
                newName: "IX_Transfers_EmployeeCardId");

            migrationBuilder.RenameColumn(
                name: "ReadEmployeeCardDtoId",
                table: "LeaveRequests",
                newName: "EmployeeCardId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequests_ReadEmployeeCardDtoId",
                table: "LeaveRequests",
                newName: "IX_LeaveRequests_EmployeeCardId");

            migrationBuilder.RenameColumn(
                name: "ReadEmployeeCardDtoId",
                table: "Custodies",
                newName: "EmployeeCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Custodies_ReadEmployeeCardDtoId",
                table: "Custodies",
                newName: "IX_Custodies_EmployeeCardId");

            migrationBuilder.AddColumn<bool>(
                name: "isPaidLeave",
                table: "LeaveSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "LeaveRequests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndHour",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LeaveRequestStatus",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartHour",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isHourly",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "AttendanceFormId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCards_AttendanceFormId",
                table: "EmployeeCards",
                column: "AttendanceFormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Custodies_EmployeeCards_EmployeeCardId",
                table: "Custodies",
                column: "EmployeeCardId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_AttendanceForms_AttendanceFormId",
                table: "EmployeeCards",
                column: "AttendanceFormId",
                principalTable: "AttendanceForms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_EmployeeCardId",
                table: "LeaveRequests",
                column: "EmployeeCardId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_Employees_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_EmployeeCards_EmployeeCardId",
                table: "Transfers",
                column: "EmployeeCardId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Custodies_EmployeeCards_EmployeeCardId",
                table: "Custodies");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_AttendanceForms_AttendanceFormId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_EmployeeCardId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_Employees_EmployeeId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_EmployeeCards_EmployeeCardId",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeCards_AttendanceFormId",
                table: "EmployeeCards");

            migrationBuilder.DropColumn(
                name: "isPaidLeave",
                table: "LeaveSettings");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "EndHour",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "LeaveRequestStatus",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "StartHour",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "isHourly",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "AttendanceFormId",
                table: "EmployeeCards");

            migrationBuilder.RenameColumn(
                name: "EmployeeCardId",
                table: "Transfers",
                newName: "ReadEmployeeCardDtoId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_EmployeeCardId",
                table: "Transfers",
                newName: "IX_Transfers_ReadEmployeeCardDtoId");

            migrationBuilder.RenameColumn(
                name: "EmployeeCardId",
                table: "LeaveRequests",
                newName: "ReadEmployeeCardDtoId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequests_EmployeeCardId",
                table: "LeaveRequests",
                newName: "IX_LeaveRequests_ReadEmployeeCardDtoId");

            migrationBuilder.RenameColumn(
                name: "EmployeeCardId",
                table: "Custodies",
                newName: "ReadEmployeeCardDtoId");

            migrationBuilder.RenameIndex(
                name: "IX_Custodies_EmployeeCardId",
                table: "Custodies",
                newName: "IX_Custodies_ReadEmployeeCardDtoId");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeCardId",
                table: "LeaveSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_LeaveSettings_EmployeeCardId",
                table: "LeaveSettings",
                column: "EmployeeCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Custodies_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Custodies",
                column: "ReadEmployeeCardDtoId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_ReadEmployeeCardDtoId",
                table: "LeaveRequests",
                column: "ReadEmployeeCardDtoId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveSettings_EmployeeCards_EmployeeCardId",
                table: "LeaveSettings",
                column: "EmployeeCardId",
                principalTable: "EmployeeCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Transfers",
                column: "ReadEmployeeCardDtoId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");
        }
    }
}
