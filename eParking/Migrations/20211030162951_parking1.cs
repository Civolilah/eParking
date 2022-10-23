using Microsoft.EntityFrameworkCore.Migrations;

namespace eParking.Migrations
{
    public partial class parking1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KorisnikParking",
                columns: table => new
                {
                    KorisnikParkingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    ParkingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikParking", x => x.KorisnikParkingID);
                    table.ForeignKey(
                        name: "FK_KorisnikParking_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikParking_Parkinzi_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkinzi",
                        principalColumn: "ParkingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikParking_KorisnikID",
                table: "KorisnikParking",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikParking_ParkingID",
                table: "KorisnikParking",
                column: "ParkingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisnikParking");
        }
    }
}
