using Microsoft.EntityFrameworkCore.Migrations;

namespace eParking.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skracenica = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKorisnika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "ParkingMjesta",
                columns: table => new
                {
                    ParkingMjestoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingMjesta", x => x.ParkingMjestoID);
                });

            migrationBuilder.CreateTable(
                name: "TipParkingMijesta",
                columns: table => new
                {
                    TipParkingMjestaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipParkingMijesta", x => x.TipParkingMjestaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skracenica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipParkingMjestaParkingMjesta",
                columns: table => new
                {
                    TipParkingMjestaParkingMjestoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipParkingMjestaID = table.Column<int>(type: "int", nullable: false),
                    ParkingMjestoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipParkingMjestaParkingMjesta", x => x.TipParkingMjestaParkingMjestoID);
                    table.ForeignKey(
                        name: "FK_TipParkingMjestaParkingMjesta_ParkingMjesta_ParkingMjestoID",
                        column: x => x.ParkingMjestoID,
                        principalTable: "ParkingMjesta",
                        principalColumn: "ParkingMjestoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipParkingMjestaParkingMjesta_TipParkingMijesta_TipParkingMjestaID",
                        column: x => x.TipParkingMjestaID,
                        principalTable: "TipParkingMijesta",
                        principalColumn: "TipParkingMjestaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parkinzi",
                columns: table => new
                {
                    ParkingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XKoordinata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YKoordinata = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadnoVrijeme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkinzi", x => x.ParkingID);
                    table.ForeignKey(
                        name: "FK_Parkinzi_Gradovi_GradID",
                        column: x => x.GradID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkingParkingMjesta",
                columns: table => new
                {
                    TipParkingMjestaParkingMjestoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkingID = table.Column<int>(type: "int", nullable: false),
                    ParkingMjestoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingParkingMjesta", x => x.TipParkingMjestaParkingMjestoID);
                    table.ForeignKey(
                        name: "FK_ParkingParkingMjesta_ParkingMjesta_ParkingMjestoID",
                        column: x => x.ParkingMjestoID,
                        principalTable: "ParkingMjesta",
                        principalColumn: "ParkingMjestoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParkingParkingMjesta_Parkinzi_ParkingID",
                        column: x => x.ParkingID,
                        principalTable: "Parkinzi",
                        principalColumn: "ParkingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingParkingMjesta_ParkingID",
                table: "ParkingParkingMjesta",
                column: "ParkingID");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingParkingMjesta_ParkingMjestoID",
                table: "ParkingParkingMjesta",
                column: "ParkingMjestoID");

            migrationBuilder.CreateIndex(
                name: "IX_Parkinzi_GradID",
                table: "Parkinzi",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_TipParkingMjestaParkingMjesta_ParkingMjestoID",
                table: "TipParkingMjestaParkingMjesta",
                column: "ParkingMjestoID");

            migrationBuilder.CreateIndex(
                name: "IX_TipParkingMjestaParkingMjesta_TipParkingMjestaID",
                table: "TipParkingMjestaParkingMjesta",
                column: "TipParkingMjestaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "ParkingParkingMjesta");

            migrationBuilder.DropTable(
                name: "TipParkingMjestaParkingMjesta");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Parkinzi");

            migrationBuilder.DropTable(
                name: "ParkingMjesta");

            migrationBuilder.DropTable(
                name: "TipParkingMijesta");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
