using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AutoConfiguratorApp.Migrations
{
    public partial class Initial : Migration
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
                    Model = table.Column<string>(nullable: false),
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
                    { 100, "LandRover" },
                    { 101, "Porsche" },
                    { 102, "Tesla" },
                    { 103, "AUDI" },
                    { 104, "MercedesBenz" },
                    { 105, "BMW" },
                    { 106, "VW" }
                });

            migrationBuilder.InsertData(
                table: "AutoModellen",
                columns: new[] { "AutoModellId", "Hersteller_RefId", "ModelName" },
                values: new object[,]
                {
                    { 200, 100, "RangeRover" },
                    { 215, 105, "8er" },
                    { 214, 104, "G-Klasse" },
                    { 213, 104, "GLE" },
                    { 212, 104, "AMG GT" },
                    { 211, 103, "RS7" },
                    { 210, 103, "R8" },
                    { 209, 103, "RSQ8" },
                    { 208, 102, "Model 3" },
                    { 207, 102, "Model S" },
                    { 206, 102, "Model X" },
                    { 205, 101, "Macan" },
                    { 204, 101, "Cayenne" },
                    { 203, 101, "911" },
                    { 202, 100, "RangeRover Velar" },
                    { 201, 100, "RangeRover Sport" },
                    { 216, 105, "X6" },
                    { 217, 105, "7er" }
                });

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
