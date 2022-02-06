using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Compass.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FormName = table.Column<string>(type: "TEXT", nullable: false),
                    FormUri = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserCreated = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserUpdated = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.FormId);
                });

            migrationBuilder.CreateTable(
                name: "IcrHeaders",
                columns: table => new
                {
                    ICRHeaderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FormID = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryCode = table.Column<string>(type: "TEXT", nullable: true),
                    FacilityCode = table.Column<string>(type: "TEXT", nullable: true),
                    MeterialBalanceArea = table.Column<string>(type: "TEXT", nullable: true),
                    ConsiceNoteReportLevel = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReportStatus = table.Column<string>(type: "TEXT", nullable: true),
                    PeriodCoveredByReportFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PeriodCoveredByReportTo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EncoderName = table.Column<string>(type: "TEXT", nullable: true),
                    UserCreated = table.Column<string>(type: "TEXT", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserUpdated = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcrHeaders", x => x.ICRHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "ICRValues",
                columns: table => new
                {
                    ICRValueId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ICRHeaderId = table.Column<int>(type: "INTEGER", nullable: false),
                    EntryStatus = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfInventoryChange = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MbaCountryFrom = table.Column<string>(type: "TEXT", nullable: true),
                    MbaCountryTo = table.Column<string>(type: "TEXT", nullable: true),
                    TypeOfInventoryChange = table.Column<string>(type: "TEXT", nullable: true),
                    KmpCode = table.Column<string>(type: "TEXT", nullable: true),
                    NameOrNumberOfBatch = table.Column<string>(type: "TEXT", maxLength: 16, nullable: true),
                    NumberOfItemsInBatch = table.Column<string>(type: "TEXT", nullable: true),
                    ShipperBatch = table.Column<string>(type: "TEXT", maxLength: 16, nullable: true),
                    BurnUp = table.Column<double>(type: "REAL", maxLength: 10, nullable: false),
                    MeterialDesc = table.Column<string>(type: "TEXT", nullable: true),
                    Element = table.Column<string>(type: "TEXT", nullable: true),
                    WeightOfElement = table.Column<double>(type: "REAL", maxLength: 16, nullable: false),
                    WeightOfFissileIsotopes = table.Column<double>(type: "REAL", maxLength: 16, nullable: false),
                    IsotopeCode = table.Column<string>(type: "TEXT", nullable: true),
                    MeasurBasis = table.Column<string>(type: "TEXT", nullable: true),
                    ConciseNoteEntry = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectionToReportNo = table.Column<int>(type: "INTEGER", nullable: false),
                    CorrectionToEntryNo = table.Column<int>(type: "INTEGER", nullable: false),
                    UserCreated = table.Column<string>(type: "TEXT", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserUpdated = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ICRValues", x => x.ICRValueId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "IcrHeaders");

            migrationBuilder.DropTable(
                name: "ICRValues");
        }
    }
}
