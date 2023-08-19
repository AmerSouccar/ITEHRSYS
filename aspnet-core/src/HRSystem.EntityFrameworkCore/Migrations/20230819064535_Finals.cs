using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class Finals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyCards_Months_MonthId",
                table: "MonthlyCards");

            migrationBuilder.AddColumn<Guid>(
                name: "RequiredTypeId",
                table: "Workflows",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "MonthId",
                table: "MonthlyCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyCards_Months_MonthId",
                table: "MonthlyCards",
                column: "MonthId",
                principalTable: "Months",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthlyCards_Months_MonthId",
                table: "MonthlyCards");

            migrationBuilder.DropColumn(
                name: "RequiredTypeId",
                table: "Workflows");

            migrationBuilder.AlterColumn<Guid>(
                name: "MonthId",
                table: "MonthlyCards",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthlyCards_Months_MonthId",
                table: "MonthlyCards",
                column: "MonthId",
                principalTable: "Months",
                principalColumn: "Id");
        }
    }
}
