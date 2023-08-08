using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class OrgLevels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_OrganizationLevel_OrganizationLevelId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationLevel",
                table: "OrganizationLevel");

            migrationBuilder.RenameTable(
                name: "OrganizationLevel",
                newName: "OrganizationLevels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationLevels",
                table: "OrganizationLevels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_OrganizationLevels_OrganizationLevelId",
                table: "Grades",
                column: "OrganizationLevelId",
                principalTable: "OrganizationLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_OrganizationLevels_OrganizationLevelId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationLevels",
                table: "OrganizationLevels");

            migrationBuilder.RenameTable(
                name: "OrganizationLevels",
                newName: "OrganizationLevel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationLevel",
                table: "OrganizationLevel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_OrganizationLevel_OrganizationLevelId",
                table: "Grades",
                column: "OrganizationLevelId",
                principalTable: "OrganizationLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
