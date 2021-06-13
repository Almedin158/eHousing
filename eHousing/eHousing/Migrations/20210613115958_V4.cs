using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[,]
                {
                    { 1, "Sarajevo" },
                    { 2, "Konjic" },
                    { 3, "Mostar" },
                    { 4, "Tuzla" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "eAn94TnO0rxUgtkXKIw0OmcHuTM=", "r8u6uS+70RDdVoaqQGH/Ng==", "0600000000" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FavoriteEstateId", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 2, "almedinalikadic@ehousing.com", 0, "Almedin", "Alikadic", "Dp1IkPN2nCG4+xksCpqtXRHOgt8=", "r8u6uS+70RDdVoaqQGH/Ng==", "0600000000", "Almedin" },
                    { 3, "eldinalikadic@ehousing.com", 0, "Eldin", "Alikadic", "uyXNv/M4NDrC2Wc02eYaw4K5wT0=", "r8u6uS+70RDdVoaqQGH/Ng==", "0600000000", "Eldin" },
                    { 4, "dinoalikadic@ehousing.com", 0, "Dino", "Alikadic", "MpIyZebSqceQkcoVA58OyDFnnEI=", "r8u6uS+70RDdVoaqQGH/Ng==", "0600000000", "Dino" }
                });

            migrationBuilder.InsertData(
                table: "Streets",
                columns: new[] { "StreetId", "CityId", "StreetName" },
                values: new object[,]
                {
                    { 1, 1, "Džemala Bijedića" },
                    { 16, 4, "Slatina" },
                    { 15, 4, "Franjevačka" },
                    { 14, 4, "Pazar" },
                    { 13, 4, "Kicelj" },
                    { 12, 3, "Ale Cišica" },
                    { 11, 3, "Adema Buće" },
                    { 9, 3, "Zalik" },
                    { 10, 3, "Fejićeva" },
                    { 7, 2, "Luka" },
                    { 6, 2, "Trešanica" },
                    { 5, 2, "Maršala Tita" },
                    { 4, 1, "Aščiluk" },
                    { 3, 1, "Alipašina" },
                    { 2, 1, "Baščaršijski trg" },
                    { 8, 2, " Varda" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRolesId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 4, 1, 3 },
                    { 3, 1, 2 },
                    { 5, 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Streets",
                keyColumn: "StreetId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRolesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRolesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRolesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "PhoneNumber" },
                values: new object[] { "oTOjhhSu++qE+caR6E1VOigZeVs=", "LmJMhEBLwUuoZZLqSbmwZg==", "0603317627" });
        }
    }
}
