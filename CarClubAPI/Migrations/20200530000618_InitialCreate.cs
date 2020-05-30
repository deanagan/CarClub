using Microsoft.EntityFrameworkCore.Migrations;

namespace CarClubAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlateNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(nullable: true),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlateNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_PlateNumbers_Id",
                        column: x => x.Id,
                        principalTable: "PlateNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PlateNumbers",
                columns: new[] { "Id", "Number", "VehicleId" },
                values: new object[,]
                {
                    { 1, "ABC123", 1 },
                    { 2, "DEF456", 2 },
                    { 3, "GHI789", 3 },
                    { 4, "JKLC098", 4 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Make", "Model" },
                values: new object[,]
                {
                    { 1, "Toyota", "Corolla" },
                    { 2, "Nissan", "Micra" },
                    { 3, "Honda", "Jazz" },
                    { 4, "Suzuki", "Swift" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "PlateNumbers");
        }
    }
}
