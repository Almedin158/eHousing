using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "EstateStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2021, 6, 18, 13, 55, 13, 427, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2021, 6, 18, 13, 55, 13, 433, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2021, 6, 18, 13, 55, 13, 434, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Estates",
                keyColumn: "EstateId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2021, 6, 18, 13, 55, 13, 434, DateTimeKind.Local).AddTicks(1452));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "EstateStatuses");

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
        }
    }
}
