using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class ManagerPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTitles_Grades_GradeId",
                table: "JobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_JobDescriptions_ManagerId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_JobTitles_ManagerJobTitleId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_ManagerJobTitleId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "ManagerJobTitleId",
                table: "Positions");

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "JobTitles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitles_Grades_GradeId",
                table: "JobTitles",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Positions_ManagerId",
                table: "Positions",
                column: "ManagerId",
                principalTable: "Positions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTitles_Grades_GradeId",
                table: "JobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Positions_ManagerId",
                table: "Positions");

            migrationBuilder.AddColumn<Guid>(
                name: "ManagerJobTitleId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "GradeId",
                table: "JobTitles",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_ManagerJobTitleId",
                table: "Positions",
                column: "ManagerJobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitles_Grades_GradeId",
                table: "JobTitles",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_JobDescriptions_ManagerId",
                table: "Positions",
                column: "ManagerId",
                principalTable: "JobDescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_JobTitles_ManagerJobTitleId",
                table: "Positions",
                column: "ManagerJobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id");
        }
    }
}
