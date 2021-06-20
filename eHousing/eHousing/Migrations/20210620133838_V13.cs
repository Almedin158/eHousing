using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class V13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 38, 36, 111, DateTimeKind.Local).AddTicks(5883), false });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 38, 36, 119, DateTimeKind.Local).AddTicks(4872), false });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 15, 38, 36, 119, DateTimeKind.Local).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 15, 38, 36, 119, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 5,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 38, 36, 120, DateTimeKind.Local).AddTicks(450), false });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 6,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 38, 36, 120, DateTimeKind.Local).AddTicks(1993), false });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 7,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 38, 36, 120, DateTimeKind.Local).AddTicks(3433), false });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 8,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 38, 36, 120, DateTimeKind.Local).AddTicks(4965), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "5zZKHkUmL0Il7qBHrqX85tdpzCM=", "8sSc24cb582MVcwdf7NsvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "U+263n2g7scXiu27tB2Gp3x8/Nc=", "8sSc24cb582MVcwdf7NsvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "GiUbDLdLDCuLuWs1l00t46Ywxvg=", "8sSc24cb582MVcwdf7NsvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ukkOc07s283Y6qtRkZZhGhlK3mg=", "8sSc24cb582MVcwdf7NsvA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 34, 50, 8, DateTimeKind.Local).AddTicks(6284), true });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 34, 50, 11, DateTimeKind.Local).AddTicks(9246), true });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 15, 34, 50, 12, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 15, 34, 50, 12, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 5,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 34, 50, 12, DateTimeKind.Local).AddTicks(1186), true });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 6,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 34, 50, 12, DateTimeKind.Local).AddTicks(1695), true });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 7,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 34, 50, 12, DateTimeKind.Local).AddTicks(2212), true });

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 8,
                columns: new[] { "CreationDate", "IsOccupied" },
                values: new object[] { new DateTime(2021, 6, 20, 15, 34, 50, 12, DateTimeKind.Local).AddTicks(2773), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IHxx9Ka03x3SsOpMl9yqFcQy7ME=", "2Mr5YlYURi/NDtB9kwbTRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "/tRezAZd6BDc3f1WCRQPuxWSmxA=", "2Mr5YlYURi/NDtB9kwbTRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IrW36KpWLJVc3Kqje5QCxP8tvHI=", "2Mr5YlYURi/NDtB9kwbTRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "m1xtW1+Jz6icKonIbhFX72Ry3Eg=", "2Mr5YlYURi/NDtB9kwbTRA==" });
        }
    }
}
