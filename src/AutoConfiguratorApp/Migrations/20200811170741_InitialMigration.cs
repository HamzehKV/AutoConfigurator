using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AutoConfiguratorApp.Migrations
{
    public partial class InitialMigration : Migration
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
                    HerstellerRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModellen", x => x.AutoModellId);
                    table.ForeignKey(
                        name: "FK_AutoModellen_Hersteller_HerstellerRefId",
                        column: x => x.HerstellerRefId,
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
                    AutoModellId = table.Column<int>(nullable: false),
                    FelgeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModelle_Felgen", x => x.AutoModell_FelgeId);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Felgen_AutoModellen_AutoModellId",
                        column: x => x.AutoModellId,
                        principalTable: "AutoModellen",
                        principalColumn: "AutoModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Felgen_Felgen_FelgeId",
                        column: x => x.FelgeId,
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
                    AutoModellId = table.Column<int>(nullable: false),
                    LackierungId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModelle_Lackierungen", x => x.AutoModell_LackierungId);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Lackierungen_AutoModellen_AutoModellId",
                        column: x => x.AutoModellId,
                        principalTable: "AutoModellen",
                        principalColumn: "AutoModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Lackierungen_Lackierungen_LackierungId",
                        column: x => x.LackierungId,
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
                    AutoModellId = table.Column<int>(nullable: false),
                    MotorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoModelle_Motoren", x => x.AutoModell_MotorId);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Motoren_AutoModellen_AutoModellId",
                        column: x => x.AutoModellId,
                        principalTable: "AutoModellen",
                        principalColumn: "AutoModellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoModelle_Motoren_Motoren_MotorId",
                        column: x => x.MotorId,
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
                    IdRef_AM_F = table.Column<int>(nullable: false),
                    IdRef_AM_L = table.Column<int>(nullable: false),
                    IdRef_AM_M = table.Column<int>(nullable: false),
                    IdRefFSS = table.Column<int>(nullable: true),
                    IdRefKA = table.Column<int>(nullable: true),
                    IdRefNS = table.Column<int>(nullable: true),
                    IdRefPAS = table.Column<int>(nullable: true),
                    IdRefSS = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoKonfigurationen", x => x.AutoKonfigurationId);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_FahrSicherheitsSysteme_IdRefFSS",
                        column: x => x.IdRefFSS,
                        principalTable: "FahrSicherheitsSysteme",
                        principalColumn: "FahrSicherheitsSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_KlimaAnlagen_IdRefKA",
                        column: x => x.IdRefKA,
                        principalTable: "KlimaAnlagen",
                        principalColumn: "KlimaAnlageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_NavigationsSysteme_IdRefNS",
                        column: x => x.IdRefNS,
                        principalTable: "NavigationsSysteme",
                        principalColumn: "NavigationsSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_ParkAssistentSysteme_IdRefPAS",
                        column: x => x.IdRefPAS,
                        principalTable: "ParkAssistentSysteme",
                        principalColumn: "ParkAssistentSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_SoundSysteme_IdRefSS",
                        column: x => x.IdRefSS,
                        principalTable: "SoundSysteme",
                        principalColumn: "SoundSystemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_AutoModelle_Felgen_IdRef_AM_F",
                        column: x => x.IdRef_AM_F,
                        principalTable: "AutoModelle_Felgen",
                        principalColumn: "AutoModell_FelgeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_AutoModelle_Lackierungen_IdRef_AM_L",
                        column: x => x.IdRef_AM_L,
                        principalTable: "AutoModelle_Lackierungen",
                        principalColumn: "AutoModell_LackierungId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoKonfigurationen_AutoModelle_Motoren_IdRef_AM_M",
                        column: x => x.IdRef_AM_M,
                        principalTable: "AutoModelle_Motoren",
                        principalColumn: "AutoModell_MotorId",
                        onDelete: ReferentialAction.Cascade);
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
                    { 102, "AUDI" },
                    { 103, "MercedesBenz" },
                    { 104, "BMW" },
                    { 105, "VW" }
                });

            migrationBuilder.InsertData(
                table: "AutoModellen",
                columns: new[] { "AutoModellId", "HerstellerRefId", "ModelName" },
                values: new object[,]
                {
                    { 200, 100, "RangeRover" },
                    { 201, 100, "RangeRover Sport" },
                    { 202, 100, "RangeRover Velar" },
                    { 203, 101, "911" },
                    { 204, 101, "Cayenne" },
                    { 205, 101, "Macan" },
                    { 206, 102, "RSQ8" },
                    { 207, 102, "R8" },
                    { 208, 102, "RS7" },
                    { 209, 103, "AMG GT" },
                    { 210, 103, "GLE" },
                    { 211, 103, "G-Klasse" },
                    { 212, 104, "8er" },
                    { 213, 104, "X6" },
                    { 214, 104, "7er" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRefFSS",
                table: "AutoKonfigurationen",
                column: "IdRefFSS");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRefKA",
                table: "AutoKonfigurationen",
                column: "IdRefKA");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRefNS",
                table: "AutoKonfigurationen",
                column: "IdRefNS");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRefPAS",
                table: "AutoKonfigurationen",
                column: "IdRefPAS");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRefSS",
                table: "AutoKonfigurationen",
                column: "IdRefSS");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRef_AM_F",
                table: "AutoKonfigurationen",
                column: "IdRef_AM_F");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRef_AM_L",
                table: "AutoKonfigurationen",
                column: "IdRef_AM_L");

            migrationBuilder.CreateIndex(
                name: "IX_AutoKonfigurationen_IdRef_AM_M",
                table: "AutoKonfigurationen",
                column: "IdRef_AM_M");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Felgen_AutoModellId",
                table: "AutoModelle_Felgen",
                column: "AutoModellId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Felgen_FelgeId",
                table: "AutoModelle_Felgen",
                column: "FelgeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Lackierungen_AutoModellId",
                table: "AutoModelle_Lackierungen",
                column: "AutoModellId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Lackierungen_LackierungId",
                table: "AutoModelle_Lackierungen",
                column: "LackierungId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Motoren_AutoModellId",
                table: "AutoModelle_Motoren",
                column: "AutoModellId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModelle_Motoren_MotorId",
                table: "AutoModelle_Motoren",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoModellen_HerstellerRefId",
                table: "AutoModellen",
                column: "HerstellerRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoKonfigurationen");

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
                name: "AutoModelle_Felgen");

            migrationBuilder.DropTable(
                name: "AutoModelle_Lackierungen");

            migrationBuilder.DropTable(
                name: "AutoModelle_Motoren");

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
