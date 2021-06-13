using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class V9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.CreateTable(
                name: "EstateStatuses",
                columns: table => new
                {
                    EstateStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Months = table.Column<int>(type: "int", nullable: false),
                    OccupiedSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OccupiedTill = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateStatuses", x => x.EstateStatusId);
                    table.ForeignKey(
                        name: "FK_EstateStatuses_Estates_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estates",
                        principalColumn: "EstateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstateStatuses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 18, 6, 7, 604, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 18, 6, 7, 611, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 18, 6, 7, 611, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 18, 6, 7, 611, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "x784jJmk93TwaDlYMMEBRbI7+X8=", "udZnnnzwiQLEt5eioC1lXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "wGn0I71yvJPeDoQkV6YaDdKP0ls=", "udZnnnzwiQLEt5eioC1lXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "zSv3hJ/DeQ0C400sr9yRzLEw+Q4=", "udZnnnzwiQLEt5eioC1lXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "KPEZVlXXBF8iYDRxYYxy6xNKWZQ=", "udZnnnzwiQLEt5eioC1lXg==" });

            migrationBuilder.CreateIndex(
                name: "IX_EstateStatuses_EstateId",
                table: "EstateStatuses",
                column: "EstateId");

            migrationBuilder.CreateIndex(
                name: "IX_EstateStatuses_UserId",
                table: "EstateStatuses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstateStatuses");

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    RentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateId = table.Column<int>(type: "int", nullable: false),
                    Months = table.Column<int>(type: "int", nullable: false),
                    OccupiedSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OccupiedTill = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.RentId);
                    table.ForeignKey(
                        name: "FK_Rents_Estates_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estates",
                        principalColumn: "EstateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rents_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 14, 44, 12, 361, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 14, 44, 12, 367, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 14, 44, 12, 367, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 6, 13, 14, 44, 12, 368, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Tt0/yF7zmRLfgD//V6vBtaMpmu0=", "2S3HGMdTSvzkplt8WNJCuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "4lbxM9BdVmIjEuAj5PAU8ZV2t0A=", "2S3HGMdTSvzkplt8WNJCuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "rKfSKHtsGafKHYwIWcenBB88QQo=", "2S3HGMdTSvzkplt8WNJCuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "QXWlDhe5mpb1tB4lXj2EwAsJ65w=", "2S3HGMdTSvzkplt8WNJCuQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Rents_EstateId",
                table: "Rents",
                column: "EstateId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_UserId",
                table: "Rents",
                column: "UserId");
        }
    }
}
