using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CopywritingWebSite.DataAccess.Migrations
{
    public partial class Updatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CopywritingStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CopywritingStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Question = table.Column<string>(type: "text", nullable: false),
                    ChooseOne = table.Column<string>(type: "text", nullable: false),
                    ChooseTwo = table.Column<string>(type: "text", nullable: false),
                    ChooseThree = table.Column<string>(type: "text", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Salt = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    CreateAt = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceStatuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CopyWritingStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CountSymbol = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceStatuses_CopywritingStatuses_CopyWritingStatusId",
                        column: x => x.CopyWritingStatusId,
                        principalTable: "CopywritingStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArticleText = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTheEmpolyeers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardNumber = table.Column<string>(type: "text", nullable: false),
                    CardMmYy = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTheEmpolyeers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerTheEmpolyeers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerWorkers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CountTheWork = table.Column<int>(type: "integer", nullable: false),
                    CardNumber = table.Column<string>(type: "text", nullable: false),
                    CardMmYy = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerWorkers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerWorkers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerTheEmpolyeerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerWorkerIdId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerWorkerId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CopywritingStatusId = table.Column<long>(type: "bigint", nullable: false),
                    LanguageStatus = table.Column<int>(type: "integer", nullable: false),
                    AttachedFile = table.Column<string>(type: "text", nullable: false),
                    LifeTime = table.Column<string>(type: "text", nullable: false),
                    CopyWrirtingLevel = table.Column<int>(type: "integer", nullable: false),
                    PriceStatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreateAt = table.Column<string>(type: "text", nullable: false),
                    ArticeStatus = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_CopywritingStatuses_CopywritingStatusId",
                        column: x => x.CopywritingStatusId,
                        principalTable: "CopywritingStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_CustomerTheEmpolyeers_CustomerTheEmpolyeerId",
                        column: x => x.CustomerTheEmpolyeerId,
                        principalTable: "CustomerTheEmpolyeers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_CustomerWorkers_CustomerWorkerId",
                        column: x => x.CustomerWorkerId,
                        principalTable: "CustomerWorkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_PriceStatuses_PriceStatusId",
                        column: x => x.PriceStatusId,
                        principalTable: "PriceStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TermAccounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerTheEmpolyeerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerWorkerIdId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerWorkerId = table.Column<long>(type: "bigint", nullable: false),
                    ArticleStatus = table.Column<int>(type: "integer", nullable: false),
                    Done = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermAccounts_CustomerTheEmpolyeers_CustomerTheEmpolyeerId",
                        column: x => x.CustomerTheEmpolyeerId,
                        principalTable: "CustomerTheEmpolyeers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TermAccounts_CustomerWorkers_CustomerWorkerId",
                        column: x => x.CustomerWorkerId,
                        principalTable: "CustomerWorkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTheEmpolyeers_UserId",
                table: "CustomerTheEmpolyeers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerWorkers_UserId",
                table: "CustomerWorkers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CopywritingStatusId",
                table: "Orders",
                column: "CopywritingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerTheEmpolyeerId",
                table: "Orders",
                column: "CustomerTheEmpolyeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerWorkerId",
                table: "Orders",
                column: "CustomerWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PriceStatusId",
                table: "Orders",
                column: "PriceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PriceStatuses_CopyWritingStatusId",
                table: "PriceStatuses",
                column: "CopyWritingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TermAccounts_CustomerTheEmpolyeerId",
                table: "TermAccounts",
                column: "CustomerTheEmpolyeerId");

            migrationBuilder.CreateIndex(
                name: "IX_TermAccounts_CustomerWorkerId",
                table: "TermAccounts",
                column: "CustomerWorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TermAccounts");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "PriceStatuses");

            migrationBuilder.DropTable(
                name: "CustomerTheEmpolyeers");

            migrationBuilder.DropTable(
                name: "CustomerWorkers");

            migrationBuilder.DropTable(
                name: "CopywritingStatuses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
