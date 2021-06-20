using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class V11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserEstateReviews",
                columns: table => new
                {
                    UserEstateReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EstateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEstateReviews", x => x.UserEstateReviewId);
                    table.ForeignKey(
                        name: "FK_UserEstateReviews_Estates_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estates",
                        principalColumn: "EstateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEstateReviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 20, 12, 43, 13, 967, DateTimeKind.Local).AddTicks(3112), "Sarajevo Džemala Bijedića" });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 20, 12, 43, 13, 974, DateTimeKind.Local).AddTicks(2560), "Sarajevo Grbavica" });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 20, 12, 43, 13, 974, DateTimeKind.Local).AddTicks(4211), "Sarajevo Skenderija" });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 20, 12, 43, 13, 974, DateTimeKind.Local).AddTicks(5431), "Sarajevo Alipasino" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IlXkDt9ehPitaGVoJLXRAyjTPvs=", "0xJlvd8haRzQ6oQ6Kcm50Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "luLYAEnIDseol6XsghN2EhO6QuM=", "0xJlvd8haRzQ6oQ6Kcm50Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kp2KFGB14oNFAVDtnNR+ZknFYsE=", "0xJlvd8haRzQ6oQ6Kcm50Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UziZxYxbi2W7SgS1gxfOe2Q4Ey8=", "0xJlvd8haRzQ6oQ6Kcm50Q==" });

            migrationBuilder.CreateIndex(
                name: "IX_UserEstateReviews_EstateId",
                table: "UserEstateReviews",
                column: "EstateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEstateReviews_UserId",
                table: "UserEstateReviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEstateReviews");

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 18, 13, 55, 13, 427, DateTimeKind.Local).AddTicks(5333), "Sarajevo Džemala Bijedića Villa 1" });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 18, 13, 55, 13, 433, DateTimeKind.Local).AddTicks(8554), "Sarajevo Džemala Bijedića Villa 2" });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 18, 13, 55, 13, 434, DateTimeKind.Local).AddTicks(250), "Sarajevo Džemala Bijedića Villa 3" });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4,
                columns: new[] { "CreationDate", "EstateName" },
                values: new object[] { new DateTime(2021, 6, 18, 13, 55, 13, 434, DateTimeKind.Local).AddTicks(1452), "Sarajevo Džemala Bijedića Villa 4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "YRhSvc1sMrcZA16iF+chB7O/Gjo=", "Xptdb5IBUOf/CEQ42tWqlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "3YJjlOj66xPBET+qMXJd90DurV4=", "Xptdb5IBUOf/CEQ42tWqlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "NCHS0dIztzaAPnHBhagH9d/gGrE=", "Xptdb5IBUOf/CEQ42tWqlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "DjKyRjt/jDiRPpO3brAdU3k15ls=", "Xptdb5IBUOf/CEQ42tWqlw==" });
        }
    }
}
