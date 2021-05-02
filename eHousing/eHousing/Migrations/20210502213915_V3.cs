using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Estates",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "HZ/AUZr4ZnJL46RA3nKPD/d7CV0=", "tmSrfm1I1Y/Z87ztWf8TOA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Estates");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Jmvv850fGtJGCKYmfMMs3qZIj84=", "7GwmsjTzfjWUfhV08LNmtw==" });
        }
    }
}
