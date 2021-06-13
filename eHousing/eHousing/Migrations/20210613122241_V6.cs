using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 8,
                column: "StreetName",
                value: "Varda");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "P875A1S1oP7kO2Jj2kF+2QkeBzY=", "7bNjGmncNrZ9L3Oug7w9gA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "8smqLT/muwMVUwjCsb+8cKoRJd4=", "7bNjGmncNrZ9L3Oug7w9gA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "UeHNjjoenRtj+jRt8N1sPNsCmzw=", "7bNjGmncNrZ9L3Oug7w9gA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "jBjrllYVtackxRavpxwCa7B/kIY=", "7bNjGmncNrZ9L3Oug7w9gA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 8,
                column: "StreetName",
                value: " Varda");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Gjz72xZrpCNpRuP/Ow3qdo2MZDQ=", "KS3lbQPTYrPlah6yL3sMHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "fBIFnlTmO1huZVUqObSdT14Enzc=", "KS3lbQPTYrPlah6yL3sMHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "Wym9dNFHALTUynp118IM51Jb3/4=", "KS3lbQPTYrPlah6yL3sMHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "C5zWMgpxLuLlAKloi0MoUuWq/Vs=", "KS3lbQPTYrPlah6yL3sMHQ==" });
        }
    }
}
