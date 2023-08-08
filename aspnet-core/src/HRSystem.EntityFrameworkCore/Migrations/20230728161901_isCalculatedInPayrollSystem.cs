using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class isCalculatedInPayrollSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Custodies_EmployeeCards_EmployeeCardId",
                table: "Custodies");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_Grades_GradeId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_JobDescriptions_JobDescriptionId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_JobTitles_JobTitleId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_Positions_PositionId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_EmployeeCardId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_EmployeeCards_EmployeeCardId",
                table: "Transfers");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "PositionId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "JobTitleId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "JobDescriptionId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<bool>(
                name: "isCalculatedInPayrollSystem",
                table: "DeductionCards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isCalculatedInPayrollSystem",
                table: "BenefitCards",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Custodies_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Custodies",
                column: "ReadEmployeeCardDtoId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_Grades_GradeId",
                table: "EmployeeCards",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_JobDescriptions_JobDescriptionId",
                table: "EmployeeCards",
                column: "JobDescriptionId",
                principalTable: "JobDescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_JobTitles_JobTitleId",
                table: "EmployeeCards",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_Positions_PositionId",
                table: "EmployeeCards",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_ReadEmployeeCardDtoId",
                table: "LeaveRequests",
                column: "ReadEmployeeCardDtoId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Transfers",
                column: "ReadEmployeeCardDtoId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Custodies_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Custodies");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_Grades_GradeId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_JobDescriptions_JobDescriptionId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_JobTitles_JobTitleId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeCards_Positions_PositionId",
                table: "EmployeeCards");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_ReadEmployeeCardDtoId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_EmployeeCards_ReadEmployeeCardDtoId",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "isCalculatedInPayrollSystem",
                table: "DeductionCards");

            migrationBuilder.DropColumn(
                name: "isCalculatedInPayrollSystem",
                table: "BenefitCards");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "PositionId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "JobTitleId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "JobDescriptionId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "EmployeeCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Custodies_EmployeeCards_EmployeeCardId",
                table: "Custodies",
                column: "EmployeeCardId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_Grades_GradeId",
                table: "EmployeeCards",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_JobDescriptions_JobDescriptionId",
                table: "EmployeeCards",
                column: "JobDescriptionId",
                principalTable: "JobDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_JobTitles_JobTitleId",
                table: "EmployeeCards",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeCards_Positions_PositionId",
                table: "EmployeeCards",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_EmployeeCards_EmployeeCardId",
                table: "LeaveRequests",
                column: "EmployeeCardId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_EmployeeCards_EmployeeCardId",
                table: "Transfers",
                column: "EmployeeCardId",
                principalTable: "EmployeeCards",
                principalColumn: "Id");
        }
    }
}
