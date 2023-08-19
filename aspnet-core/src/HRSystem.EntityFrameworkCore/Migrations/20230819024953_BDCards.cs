using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class BDCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "DeductionCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "BenefitCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_DeductionCards_EmployeeId",
                table: "DeductionCards",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BenefitCards_EmployeeId",
                table: "BenefitCards",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BenefitCards_Employees_EmployeeId",
                table: "BenefitCards",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeductionCards_Employees_EmployeeId",
                table: "DeductionCards",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BenefitCards_Employees_EmployeeId",
                table: "BenefitCards");

            migrationBuilder.DropForeignKey(
                name: "FK_DeductionCards_Employees_EmployeeId",
                table: "DeductionCards");

            migrationBuilder.DropIndex(
                name: "IX_DeductionCards_EmployeeId",
                table: "DeductionCards");

            migrationBuilder.DropIndex(
                name: "IX_BenefitCards_EmployeeId",
                table: "BenefitCards");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "DeductionCards");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "BenefitCards");
        }
    }
}
