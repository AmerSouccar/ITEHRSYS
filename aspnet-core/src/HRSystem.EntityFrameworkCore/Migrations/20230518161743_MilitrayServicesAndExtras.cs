using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRSystem.Migrations
{
    /// <inheritdoc />
    public partial class MilitrayServicesAndExtras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ConvictionId",
                table: "Attachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DriverLicenseId",
                table: "Attachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MilitaryServiceId",
                table: "Attachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Convictions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isConvicted = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convictions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Convictions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DriverLicenseTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicenseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MilitaryStatus = table.Column<int>(type: "int", nullable: false),
                    IsPermanentExemption = table.Column<bool>(type: "bit", nullable: true),
                    ExemptionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExemptionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DelayReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelayDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MilitaryServiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryServiceDocIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Granter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Years = table.Column<int>(type: "int", nullable: true),
                    Months = table.Column<int>(type: "int", nullable: true),
                    Days = table.Column<int>(type: "int", nullable: true),
                    ServiceStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoldDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReserveStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MilitaryServices_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DriverLicenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverLicenseTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlaceofIssuanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverLicenses_Cities_PlaceofIssuanceId",
                        column: x => x.PlaceofIssuanceId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DriverLicenses_DriverLicenseTypes_DriverLicenseTypeId",
                        column: x => x.DriverLicenseTypeId,
                        principalTable: "DriverLicenseTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DriverLicenses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_ConvictionId",
                table: "Attachments",
                column: "ConvictionId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_DriverLicenseId",
                table: "Attachments",
                column: "DriverLicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_MilitaryServiceId",
                table: "Attachments",
                column: "MilitaryServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Convictions_EmployeeId",
                table: "Convictions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_DriverLicenseTypeId",
                table: "DriverLicenses",
                column: "DriverLicenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_EmployeeId",
                table: "DriverLicenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_PlaceofIssuanceId",
                table: "DriverLicenses",
                column: "PlaceofIssuanceId");

            migrationBuilder.CreateIndex(
                name: "IX_MilitaryServices_EmployeeId",
                table: "MilitaryServices",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Convictions_ConvictionId",
                table: "Attachments",
                column: "ConvictionId",
                principalTable: "Convictions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_DriverLicenses_DriverLicenseId",
                table: "Attachments",
                column: "DriverLicenseId",
                principalTable: "DriverLicenses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_MilitaryServices_MilitaryServiceId",
                table: "Attachments",
                column: "MilitaryServiceId",
                principalTable: "MilitaryServices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Convictions_ConvictionId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_DriverLicenses_DriverLicenseId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_MilitaryServices_MilitaryServiceId",
                table: "Attachments");

            migrationBuilder.DropTable(
                name: "Convictions");

            migrationBuilder.DropTable(
                name: "DriverLicenses");

            migrationBuilder.DropTable(
                name: "MilitaryServices");

            migrationBuilder.DropTable(
                name: "DriverLicenseTypes");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_ConvictionId",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_DriverLicenseId",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_MilitaryServiceId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "ConvictionId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "DriverLicenseId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "MilitaryServiceId",
                table: "Attachments");
        }
    }
}
