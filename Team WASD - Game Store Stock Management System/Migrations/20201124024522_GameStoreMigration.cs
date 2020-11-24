using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_WASD___Game_Store_Stock_Management_System.Migrations
{
    public partial class GameStoreMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDeveloper",
                columns: table => new
                {
                    DeveloperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeveloperName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDeveloper", x => x.DeveloperId);
                });

            migrationBuilder.CreateTable(
                name: "tblGenre",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGenre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "tblImage",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblImage", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "tblPlatform",
                columns: table => new
                {
                    PlatformId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlatform", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "tblPublisher",
                columns: table => new
                {
                    PublisherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPublisher", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "tblGame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    PublisherId = table.Column<int>(nullable: true),
                    DeveloperId = table.Column<int>(nullable: true),
                    GenreId = table.Column<int>(nullable: true),
                    PlatformId = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InStockAmount = table.Column<int>(nullable: false),
                    ImageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblGame_tblDeveloper_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "tblDeveloper",
                        principalColumn: "DeveloperId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblGame_tblGenre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "tblGenre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblGame_tblImage_ImageId",
                        column: x => x.ImageId,
                        principalTable: "tblImage",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblGame_tblPlatform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "tblPlatform",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblGame_tblPublisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "tblPublisher",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblGame_DeveloperId",
                table: "tblGame",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_tblGame_GenreId",
                table: "tblGame",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_tblGame_ImageId",
                table: "tblGame",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_tblGame_PlatformId",
                table: "tblGame",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_tblGame_PublisherId",
                table: "tblGame",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblGame");

            migrationBuilder.DropTable(
                name: "tblDeveloper");

            migrationBuilder.DropTable(
                name: "tblGenre");

            migrationBuilder.DropTable(
                name: "tblImage");

            migrationBuilder.DropTable(
                name: "tblPlatform");

            migrationBuilder.DropTable(
                name: "tblPublisher");
        }
    }
}
