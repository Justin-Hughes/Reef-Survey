using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    BatchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BatchCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.BatchID);
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    SurveyIndex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Fish",
                columns: table => new
                {
                    ScientificName = table.Column<string>(nullable: false),
                    FishID = table.Column<int>(nullable: false),
                    Family = table.Column<string>(nullable: true),
                    CommonName = table.Column<string>(nullable: true),
                    TrophicID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish", x => x.ScientificName);
                });

            migrationBuilder.CreateTable(
                name: "FishData",
                columns: table => new
                {
                    FishID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FishCount = table.Column<int>(nullable: false),
                    StructureID = table.Column<int>(nullable: false),
                    FishLength = table.Column<double>(nullable: false),
                    LocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishData", x => x.FishID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    StudyArea = table.Column<string>(nullable: false),
                    RegionID = table.Column<int>(nullable: false),
                    SubRegion = table.Column<string>(nullable: true),
                    LocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.StudyArea);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegionName = table.Column<string>(nullable: true),
                    Management = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionID);
                });

            migrationBuilder.CreateTable(
                name: "Structure",
                columns: table => new
                {
                    StructureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StructureType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structure", x => x.StructureID);
                });

            migrationBuilder.CreateTable(
                name: "SurveyData",
                columns: table => new
                {
                    SurveyDate = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyIndex = table.Column<int>(nullable: false),
                    BatchID = table.Column<int>(nullable: false),
                    ScientificName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyData", x => x.SurveyDate);
                });

            migrationBuilder.CreateTable(
                name: "Trophic",
                columns: table => new
                {
                    TrophicID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrophicCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trophic", x => x.TrophicID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "Fish");

            migrationBuilder.DropTable(
                name: "FishData");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Structure");

            migrationBuilder.DropTable(
                name: "SurveyData");

            migrationBuilder.DropTable(
                name: "Trophic");
        }
    }
}
