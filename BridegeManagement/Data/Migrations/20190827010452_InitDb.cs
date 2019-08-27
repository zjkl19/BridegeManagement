using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BridegeManagement.Data.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bridges",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PierNum = table.Column<string>(nullable: true),
                    RouteName = table.Column<string>(nullable: true),
                    RouteGrade = table.Column<int>(nullable: false),
                    Functions = table.Column<string>(nullable: true),
                    DesignLoad = table.Column<int>(nullable: false),
                    Pavement = table.Column<string>(nullable: true),
                    BuildYear = table.Column<DateTime>(nullable: false),
                    TotalLength = table.Column<decimal>(nullable: false),
                    MaxSpan = table.Column<decimal>(nullable: false),
                    TotalWidth = table.Column<decimal>(nullable: false),
                    RoadWidth = table.Column<decimal>(nullable: false),
                    MainType = table.Column<int>(nullable: false),
                    SubType = table.Column<int>(nullable: false),
                    Score = table.Column<decimal>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    CheckYear = table.Column<DateTime>(nullable: false),
                    GeoCondition = table.Column<int>(nullable: false),
                    Longitude = table.Column<decimal>(nullable: false),
                    Latitude = table.Column<decimal>(nullable: false),
                    TrafficVolume = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bridges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ComponentName = table.Column<string>(nullable: true),
                    CompBelongTo = table.Column<int>(nullable: false),
                    CompImportance = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    CompAmount = table.Column<int>(nullable: false),
                    CompAvgScore = table.Column<decimal>(nullable: false),
                    CompMinScore = table.Column<decimal>(nullable: false),
                    CoeffT = table.Column<decimal>(nullable: false),
                    CompScore = table.Column<decimal>(nullable: false),
                    CompGrade = table.Column<int>(nullable: false),
                    BridgeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Components_Bridges_BridgeId",
                        column: x => x.BridgeId,
                        principalTable: "Bridges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Damages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DamageName = table.Column<string>(nullable: true),
                    DamageAmount = table.Column<int>(nullable: false),
                    DamageLength = table.Column<decimal>(nullable: false),
                    DamageArea = table.Column<decimal>(nullable: false),
                    MaxWidth = table.Column<decimal>(nullable: false),
                    ComponentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Damages_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Components_BridgeId",
                table: "Components",
                column: "BridgeId");

            migrationBuilder.CreateIndex(
                name: "IX_Damages_ComponentId",
                table: "Damages",
                column: "ComponentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Damages");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Bridges");
        }
    }
}
