using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverseInfoSite.Migrations
{
    public partial class _Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    PlanetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlanetName = table.Column<string>(nullable: true),
                    RotationalPeriod = table.Column<int>(nullable: false),
                    OrbitalPeriod = table.Column<int>(nullable: false),
                    Diameter = table.Column<int>(nullable: false),
                    Climate = table.Column<string>(nullable: true),
                    Gravity = table.Column<int>(nullable: false),
                    PlanetID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.PlanetID);
                    table.ForeignKey(
                        name: "FK_Planets_Planets_PlanetID1",
                        column: x => x.PlanetID1,
                        principalTable: "Planets",
                        principalColumn: "PlanetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    StarshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    MaxAtmoshperingSpeed = table.Column<string>(nullable: true),
                    Crew = table.Column<int>(nullable: false),
                    Passengers = table.Column<int>(nullable: false),
                    CargoCapacity = table.Column<int>(nullable: false),
                    Consumables = table.Column<int>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    HyperdriveRating = table.Column<double>(nullable: false),
                    StarshipID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.StarshipID);
                    table.ForeignKey(
                        name: "FK_Starships_Starships_StarshipID1",
                        column: x => x.StarshipID1,
                        principalTable: "Starships",
                        principalColumn: "StarshipID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SWSpecies",
                columns: table => new
                {
                    SpeciesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpeciesName = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    AvgHeight = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    AvgLifeSpan = table.Column<int>(nullable: false),
                    Homeworld = table.Column<string>(nullable: true),
                    SpeciesID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWSpecies", x => x.SpeciesID);
                    table.ForeignKey(
                        name: "FK_SWSpecies_SWSpecies_SpeciesID1",
                        column: x => x.SpeciesID1,
                        principalTable: "SWSpecies",
                        principalColumn: "SpeciesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    MaxAtmoshperingSpeed = table.Column<string>(nullable: true),
                    Passengers = table.Column<int>(nullable: false),
                    CargoCapacity = table.Column<int>(nullable: false),
                    Consumables = table.Column<int>(nullable: false),
                    Class = table.Column<int>(nullable: false),
                    VehicleID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                    table.ForeignKey(
                        name: "FK_Vehicles_Vehicles_VehicleID1",
                        column: x => x.VehicleID1,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planets_PlanetID1",
                table: "Planets",
                column: "PlanetID1");

            migrationBuilder.CreateIndex(
                name: "IX_Starships_StarshipID1",
                table: "Starships",
                column: "StarshipID1");

            migrationBuilder.CreateIndex(
                name: "IX_SWSpecies_SpeciesID1",
                table: "SWSpecies",
                column: "SpeciesID1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleID1",
                table: "Vehicles",
                column: "VehicleID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropTable(
                name: "SWSpecies");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
