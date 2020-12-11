using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeterReading.Migrations
{
    public partial class addMeterAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppMeterAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MeterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMeterID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVirtual = table.Column<bool>(type: "bit", nullable: false),
                    SpareFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteNO1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteNO2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteNO3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlantID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportCycleID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeterID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Magnification = table.Column<float>(type: "real", nullable: false),
                    Peak = table.Column<int>(type: "int", nullable: false),
                    Valley = table.Column<int>(type: "int", nullable: false),
                    Flat = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<long>(type: "bigint", nullable: false),
                    PerValue = table.Column<long>(type: "bigint", nullable: false),
                    DiffValue = table.Column<float>(type: "real", nullable: false),
                    Adjustment = table.Column<float>(type: "real", nullable: false),
                    ReportValue = table.Column<float>(type: "real", nullable: false),
                    PerReportValue = table.Column<float>(type: "real", nullable: false),
                    DiffReportValue = table.Column<float>(type: "real", nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: false),
                    Pressure = table.Column<float>(type: "real", nullable: false),
                    CurrentCycle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BalanceRatio = table.Column<float>(type: "real", nullable: false),
                    IsBalance = table.Column<bool>(type: "bit", nullable: false),
                    IsEnable = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMeterAccounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppMeterAccounts");
        }
    }
}
