using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AutoConfiguratorApp.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FahrSicherheitsSysteme",
                columns: table => new
                {
                    FahrSicherheitsSystemId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FahrSicherheitsSysteme", x => x.FahrSicherheitsSystemId);
                });

            migrationBuilder.CreateTable(
                name: "Felgen",
                columns: table => new
                {
                    FelgeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Material = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felgen", x => x.FelgeId);
                });

            migrationBuilder.CreateTable(
                name: "Hersteller",
                columns: table => new
                {
                    HerstellerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hersteller", x => x.HerstellerId);
                });

            migrationBuilder.CreateTable(
                name: "KlimaAnlagen",
                columns: table => new
                {
                    KlimaAnlageId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlimaAnlagen", x => x.KlimaAnlageId);
                });

            migrationBuilder.CreateTable(
                name: "Lackierungen",
                columns: table => new
                {
                    LackierungId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lackierungen", x => x.LackierungId);
                });

            migrationBuilder.CreateTable(
                name: "Motoren",
                columns: table => new
                {
                    MotorId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Leistung = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoren", x => x.MotorId);
                });

            migrationBuilder.CreateTable(
                name: "NavigationsSysteme",
                columns: table => new
                {
                    NavigationsSystemId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Model = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavigationsSysteme", x => x.NavigationsSystemId);
                });

            migrationBuilder.CreateTable(
                name: "ParkAssistentSysteme",
                columns: table => new
                {
                    ParkAssistentSystemId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Model = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkAssistentSysteme", x => x.ParkAssistentSystemId);
                });

            migrationBuilder.CreateTable(
                name: "SoundSysteme",
                columns: table => new
                {
                    SoundSystemId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Model = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoundSysteme", x => x.SoundSystemId);
                });

            migrationBuilder.CreateTable(
                name: "AutoModellen",
                columns: table => new
                {
                    AutoModellId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ModelName = table.Column<string>(maxLength: 30, nullable: false),
                    Hersteller_RefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModellen", x => x.AutoModellId);
                    table.ForeignKey(
                        name: "FK_AutoModellen_Hersteller_Hersteller_RefId",
                        column: x => x.Hersteller_RefId,
                        principalTable: "Hersteller",
                        principalColumn: "HerstellerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutoModelle_Felgen",
                columns: table => new
                {
                    AutoModell_FelgeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AutoModellRefId = table.Column<int>(nullable: false),
                    FelgeRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModelle_Felgen", x => x.AutoModell_FelgeId);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Felgen_AutoModellen_AutoModellRefId",
                        column: x => x.AutoModellRefId,
                        principalTable: "AutoModellen",
                        principalColumn: "AutoModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Felgen_Felgen_FelgeRefId",
                        column: x => x.FelgeRefId,
                        principalTable: "Felgen",
                        principalColumn: "FelgeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutoModelle_Lackierungen",
                columns: table => new
                {
                    AutoModell_LackierungId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AutoModellRefId = table.Column<int>(nullable: false),
                    LackierungRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModelle_Lackierungen", x => x.AutoModell_LackierungId);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Lackierungen_AutoModellen_AutoModellRefId",
                        column: x => x.AutoModellRefId,
                        principalTable: "AutoModellen",
                        principalColumn: "AutoModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Lackierungen_Lackierungen_LackierungRefId",
                        column: x => x.LackierungRefId,
                        principalTable: "Lackierungen",
                        principalColumn: "LackierungId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutoModelle_Motoren",
                columns: table => new
                {
                    AutoModell_MotorId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AutoModellRefId = table.Column<int>(nullable: false),
                    MotorRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModelle_Motoren", x => x.AutoModell_MotorId);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Motoren_AutoModellen_AutoModellRefId",
                        column: x => x.AutoModellRefId,
                        principalTable: "AutoModellen",
                        principalColumn: "AutoModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Motoren_Motoren_MotorRefId",
                        column: x => x.MotorRefId,
                        principalTable: "Motoren",
                        principalColumn: "MotorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutoKonfigurationen",
                columns: table => new
                {
                    AutoKonfigurationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    AM_F_RefId = table.Column<int>(nullable: false),
                    AM_L_RefId = table.Column<int>(nullable: false),
                    AM_M_RefId = table.Column<int>(nullable: false),
                    FSS_RefId = table.Column<int>(nullable: true),
                    KA_RefId = table.Column<int>(nullable: true),
                    NS_RefId = table.Column<int>(nullable: true),
                    PAS_RefId = table.Column<int>(nullable: true),
                    SS_RefId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoKonfigurationen", x => x.AutoKonfigurationId);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_AutoModelle_Felgen_AM_F_RefId",
                        column: x => x.AM_F_RefId,
                        principalTable: "AutoModelle_Felgen",
                        principalColumn: "AutoModell_FelgeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_AutoModelle_Lackierungen_AM_L_RefId",
                        column: x => x.AM_L_RefId,
                        principalTable: "AutoModelle_Lackierungen",
                        principalColumn: "AutoModell_LackierungId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_AutoModelle_Motoren_AM_M_RefId",
                        column: x => x.AM_M_RefId,
                        principalTable: "AutoModelle_Motoren",
                        principalColumn: "AutoModell_MotorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_FahrSicherheitsSysteme_FSS_RefId",
                        column: x => x.FSS_RefId,
                        principalTable: "FahrSicherheitsSysteme",
                        principalColumn: "FahrSicherheitsSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_KlimaAnlagen_KA_RefId",
                        column: x => x.KA_RefId,
                        principalTable: "KlimaAnlagen",
                        principalColumn: "KlimaAnlageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_NavigationsSysteme_NS_RefId",
                        column: x => x.NS_RefId,
                        principalTable: "NavigationsSysteme",
                        principalColumn: "NavigationsSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_ParkAssistentSysteme_PAS_RefId",
                        column: x => x.PAS_RefId,
                        principalTable: "ParkAssistentSysteme",
                        principalColumn: "ParkAssistentSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_SoundSysteme_SS_RefId",
                        column: x => x.SS_RefId,
                        principalTable: "SoundSysteme",
                        principalColumn: "SoundSystemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "FahrSicherheitsSysteme",
                columns: new[] { "FahrSicherheitsSystemId", "Name" },
                values: new object[,]
                {
                    { 6100, "FSS1" },
                    { 6101, "FSS2" }
                });

            migrationBuilder.InsertData(
                table: "Felgen",
                columns: new[] { "FelgeId", "Material", "Size" },
                values: new object[,]
                {
                    { 300, null, 18 },
                    { 301, null, 19 },
                    { 302, null, 20 },
                    { 303, null, 21 },
                    { 304, null, 22 }
                });

            migrationBuilder.InsertData(
                table: "Hersteller",
                columns: new[] { "HerstellerId", "Name" },
                values: new object[,]
                {
                    { 106, "VW" },
                    { 104, "MercedesBenz" },
                    { 105, "BMW" },
                    { 102, "Tesla" },
                    { 101, "Porsche" },
                    { 100, "LandRover" },
                    { 103, "AUDI" }
                });

            migrationBuilder.InsertData(
                table: "KlimaAnlagen",
                columns: new[] { "KlimaAnlageId", "Name" },
                values: new object[,]
                {
                    { 6201, "KA2" },
                    { 6200, "KA1" }
                });

            migrationBuilder.InsertData(
                table: "Lackierungen",
                columns: new[] { "LackierungId", "Code", "Name" },
                values: new object[,]
                {
                    { 410, 0, "Gold" },
                    { 413, 0, "Azurblau" },
                    { 412, 0, "Cyan" },
                    { 411, 0, "Gelb" },
                    { 409, 0, "Oliv" },
                    { 406, 0, "Orange" },
                    { 407, 0, "Blau" },
                    { 405, 0, "Braun" },
                    { 404, 0, "Rot" },
                    { 403, 0, "Gruen" },
                    { 402, 0, "Schwarz" },
                    { 401, 0, "Grau" },
                    { 400, 0, "Weiss" },
                    { 408, 0, "Silber" }
                });

            migrationBuilder.InsertData(
                table: "Motoren",
                columns: new[] { "MotorId", "Leistung", "Model" },
                values: new object[,]
                {
                    { 500, 250, null },
                    { 501, 550, null }
                });

            migrationBuilder.InsertData(
                table: "NavigationsSysteme",
                columns: new[] { "NavigationsSystemId", "Model" },
                values: new object[,]
                {
                    { 6300, "NS1" },
                    { 6301, "NS2" }
                });

            migrationBuilder.InsertData(
                table: "ParkAssistentSysteme",
                columns: new[] { "ParkAssistentSystemId", "Model" },
                values: new object[,]
                {
                    { 6400, "PAS1" },
                    { 6401, "PAS2" }
                });

            migrationBuilder.InsertData(
                table: "SoundSysteme",
                columns: new[] { "SoundSystemId", "Model" },
                values: new object[,]
                {
                    { 6500, "SS1" },
                    { 6501, "SS2" }
                });

            migrationBuilder.InsertData(
                table: "AutoModellen",
                columns: new[] { "AutoModellId", "Hersteller_RefId", "ModelName" },
                values: new object[,]
                {
                    { 200, 100, "RangeRover Velar" },
                    { 201, 100, "RangeRover Sport" },
                    { 202, 101, "911" },
                    { 203, 101, "Cayenne" },
                    { 204, 102, "Model S" },
                    { 205, 102, "Model X" },
                    { 206, 103, "RS7" },
                    { 207, 103, "RSQ8" },
                    { 208, 104, "AMG GT" },
                    { 209, 104, "GLE" },
                    { 210, 105, "8er" },
                    { 211, 105, "X6" }
                });

            migrationBuilder.InsertData(
                table: "AutoModelle_Felgen",
                columns: new[] { "AutoModell_FelgeId", "AutoModellRefId", "FelgeRefId" },
                values: new object[,]
                {
                    { 23000, 200, 301 },
                    { 23026, 208, 300 },
                    { 23032, 210, 300 },
                    { 23015, 204, 300 },
                    { 23016, 204, 301 },
                    { 23031, 209, 304 },
                    { 23030, 209, 303 },
                    { 23017, 205, 301 },
                    { 23018, 205, 302 },
                    { 23013, 203, 303 },
                    { 23019, 205, 303 },
                    { 23029, 209, 302 },
                    { 23021, 206, 302 },
                    { 23022, 206, 303 },
                    { 23028, 208, 302 },
                    { 23027, 208, 301 },
                    { 23023, 207, 302 },
                    { 23024, 207, 303 },
                    { 23025, 207, 304 },
                    { 23020, 205, 304 },
                    { 23012, 203, 302 },
                    { 23014, 203, 304 },
                    { 23033, 210, 301 },
                    { 23001, 200, 302 },
                    { 23002, 200, 303 },
                    { 23003, 200, 304 },
                    { 23038, 211, 304 },
                    { 23037, 211, 303 },
                    { 23036, 211, 302 },
                    { 23004, 201, 301 },
                    { 23005, 201, 302 },
                    { 23011, 203, 301 },
                    { 23007, 201, 304 },
                    { 23006, 201, 303 },
                    { 23008, 202, 300 },
                    { 23009, 202, 301 },
                    { 23010, 202, 302 },
                    { 23034, 210, 302 },
                    { 23035, 211, 301 }
                });

            migrationBuilder.InsertData(
                table: "AutoModelle_Lackierungen",
                columns: new[] { "AutoModell_LackierungId", "AutoModellRefId", "LackierungRefId" },
                values: new object[,]
                {
                    { 240032, 210, 405 },
                    { 240031, 210, 402 },
                    { 240027, 209, 400 },
                    { 240026, 208, 413 },
                    { 240025, 208, 402 },
                    { 240028, 209, 401 },
                    { 240024, 208, 400 },
                    { 240029, 209, 407 },
                    { 240033, 211, 400 },
                    { 240030, 210, 401 },
                    { 240023, 207, 403 },
                    { 240015, 205, 400 },
                    { 240021, 207, 400 },
                    { 24000, 200, 400 },
                    { 24001, 200, 402 },
                    { 24002, 200, 405 },
                    { 24003, 201, 400 },
                    { 24004, 201, 401 },
                    { 24005, 201, 409 },
                    { 24006, 202, 400 },
                    { 24007, 202, 404 },
                    { 24008, 202, 407 },
                    { 240022, 207, 410 },
                    { 24009, 203, 402 },
                    { 240011, 203, 407 },
                    { 240012, 204, 400 },
                    { 240013, 204, 401 },
                    { 240014, 204, 402 },
                    { 240034, 211, 402 },
                    { 240016, 205, 402 },
                    { 240017, 205, 404 },
                    { 240018, 206, 400 },
                    { 240019, 206, 401 },
                    { 240020, 206, 412 },
                    { 240010, 203, 403 },
                    { 240035, 211, 409 }
                });

            migrationBuilder.InsertData(
                table: "AutoModelle_Motoren",
                columns: new[] { "AutoModell_MotorId", "AutoModellRefId", "MotorRefId" },
                values: new object[] { 25000, 200, 501 });

            migrationBuilder.InsertData(
                table: "AutoKonfigurationen",
                columns: new[] { "AutoKonfigurationId", "AM_F_RefId", "AM_L_RefId", "AM_M_RefId", "FSS_RefId", "KA_RefId", "NS_RefId", "PAS_RefId", "SS_RefId" },
                values: new object[] { 700000, 23003, 24002, 25000, 6100, 6200, 6300, 6400, 6500 });

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_AM_F_RefId",
                table: "AutoKonfigurationen",
                column: "AM_F_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_AM_L_RefId",
                table: "AutoKonfigurationen",
                column: "AM_L_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_AM_M_RefId",
                table: "AutoKonfigurationen",
                column: "AM_M_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_FSS_RefId",
                table: "AutoKonfigurationen",
                column: "FSS_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_KA_RefId",
                table: "AutoKonfigurationen",
                column: "KA_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_NS_RefId",
                table: "AutoKonfigurationen",
                column: "NS_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_PAS_RefId",
                table: "AutoKonfigurationen",
                column: "PAS_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_SS_RefId",
                table: "AutoKonfigurationen",
                column: "SS_RefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Felgen_AutoModellRefId",
                table: "AutoModelle_Felgen",
                column: "AutoModellRefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Felgen_FelgeRefId",
                table: "AutoModelle_Felgen",
                column: "FelgeRefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Lackierungen_AutoModellRefId",
                table: "AutoModelle_Lackierungen",
                column: "AutoModellRefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Lackierungen_LackierungRefId",
                table: "AutoModelle_Lackierungen",
                column: "LackierungRefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Motoren_AutoModellRefId",
                table: "AutoModelle_Motoren",
                column: "AutoModellRefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Motoren_MotorRefId",
                table: "AutoModelle_Motoren",
                column: "MotorRefId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModellen_Hersteller_RefId",
                table: "AutoModellen",
                column: "Hersteller_RefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoKonfigurationen");

            migrationBuilder.DropTable(
                name: "AutoModelle_Felgen");

            migrationBuilder.DropTable(
                name: "AutoModelle_Lackierungen");

            migrationBuilder.DropTable(
                name: "AutoModelle_Motoren");

            migrationBuilder.DropTable(
                name: "FahrSicherheitsSysteme");

            migrationBuilder.DropTable(
                name: "KlimaAnlagen");

            migrationBuilder.DropTable(
                name: "NavigationsSysteme");

            migrationBuilder.DropTable(
                name: "ParkAssistentSysteme");

            migrationBuilder.DropTable(
                name: "SoundSysteme");

            migrationBuilder.DropTable(
                name: "Felgen");

            migrationBuilder.DropTable(
                name: "Lackierungen");

            migrationBuilder.DropTable(
                name: "AutoModellen");

            migrationBuilder.DropTable(
                name: "Motoren");

            migrationBuilder.DropTable(
                name: "Hersteller");
        }
    }
}
