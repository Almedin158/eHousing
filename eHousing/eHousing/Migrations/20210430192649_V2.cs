using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "EstateTypes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Jmvv850fGtJGCKYmfMMs3qZIj84=", "7GwmsjTzfjWUfhV08LNmtw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "EstateTypes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "CgaGn/TRnBEQPxOX4996cMZ9n4g=", "l6lY0A8T5qj/us/qNLzGLA==" });
        }
    }
}
