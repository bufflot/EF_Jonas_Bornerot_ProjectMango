using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mango.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Organic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bananas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Organic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bananas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oranges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Organic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oranges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaterMelons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Organic = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterMelons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FruitBaskets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppleId = table.Column<int>(nullable: true),
                    BananaId = table.Column<int>(nullable: true),
                    OrangeId = table.Column<int>(nullable: true),
                    WaterMelonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FruitBaskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FruitBaskets_Apples_AppleId",
                        column: x => x.AppleId,
                        principalTable: "Apples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FruitBaskets_Bananas_BananaId",
                        column: x => x.BananaId,
                        principalTable: "Bananas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FruitBaskets_Oranges_OrangeId",
                        column: x => x.OrangeId,
                        principalTable: "Oranges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FruitBaskets_WaterMelons_WaterMelonId",
                        column: x => x.WaterMelonId,
                        principalTable: "WaterMelons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FruitBasketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_FruitBaskets_FruitBasketId",
                        column: x => x.FruitBasketId,
                        principalTable: "FruitBaskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FruitBaskets_AppleId",
                table: "FruitBaskets",
                column: "AppleId");

            migrationBuilder.CreateIndex(
                name: "IX_FruitBaskets_BananaId",
                table: "FruitBaskets",
                column: "BananaId");

            migrationBuilder.CreateIndex(
                name: "IX_FruitBaskets_OrangeId",
                table: "FruitBaskets",
                column: "OrangeId");

            migrationBuilder.CreateIndex(
                name: "IX_FruitBaskets_WaterMelonId",
                table: "FruitBaskets",
                column: "WaterMelonId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FruitBasketId",
                table: "Orders",
                column: "FruitBasketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "FruitBaskets");

            migrationBuilder.DropTable(
                name: "Apples");

            migrationBuilder.DropTable(
                name: "Bananas");

            migrationBuilder.DropTable(
                name: "Oranges");

            migrationBuilder.DropTable(
                name: "WaterMelons");
        }
    }
}
