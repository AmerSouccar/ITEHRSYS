using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class CompleteMissing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_JobDescriptions_ManagerId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_JobTitles_ManagerJobTitleId",
                table: "Positions");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerJobTitleId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_JobDescriptions_ManagerId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_JobTitles_ManagerJobTitleId",
                table: "Positions");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerJobTitleId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerId",
                table: "Positions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_JobDescriptions_ManagerId",
                table: "Positions",
                column: "ManagerId",
                principalTable: "JobDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_JobTitles_ManagerJobTitleId",
                table: "Positions",
                column: "ManagerJobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
