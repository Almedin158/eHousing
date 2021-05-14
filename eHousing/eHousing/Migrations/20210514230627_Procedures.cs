using Microsoft.EntityFrameworkCore.Migrations;

namespace eHousing.Migrations
{
    public partial class Procedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure1 = @"CREATE PROCEDURE Top3EstatesWithMostRents
                                as 
                                Begin
                                select top 3 E.EstateName,U.FirstName+' '+U.LastName as Landlord,E.Price,E.CreationDate,COUNT(ES.EstateId) as 'Total Rents'
                                from EstateStatuses as ES inner join Estates as E
                                on ES.EstateId = E.EstateId inner join Users as U
                                on E.UserId = U.UserId
                                group by E.EstateName,U.FirstName + ' ' + U.LastName,E.Price,E.CreationDate
                                order by COUNT(ES.EstateId) desc
                                end";
            migrationBuilder.Sql(procedure1);

            string procedure2 = @"CREATE PROCEDURE Last5EstateRenters
                                (
                                @EstateId int
                                )
                                as
                                Begin
                                select top 5 U.FirstName+' '+U.LastName as 'User', ES.OccupiedSince, ES.OccupiedTill
                                from Estates as E inner join EstateStatuses as ES
                                on E.EstateId=ES.EstateId inner join Users as U
                                on ES.UserId=U.UserId
                                where ES.EstateId=@EstateId
                                order by ES.OccupiedTill desc
                                end";
            migrationBuilder.Sql(procedure2);

            string procedure3 = @"CREATE PROCEDURE EstateRentDetails
                                (
                                @EstateId int
                                )
                                as
                                Begin
                                select U.FirstName+' '+U.LastName as 'User', ET.EstateTypeName, C.CityName, S.StreetName, E.Price, SUM(ES.Months) as 'Total Months' ,SUM(ES.Months*E.Price) as 'Total Profit'
                                from Estates as E inner join Users as U
                                on E.UserId=U.UserId inner join Streets as S
                                on E.StreetId=S.StreetId inner join EstateTypes as ET
                                on E.EstateTypeId=ET.EstateTypeId inner join Cities as C
                                on S.CityId= C.CityId inner join EstateStatuses as ES
                                on E.EstateId=ES.EstateId
                                where ES.EstateId=@EstateId
                                group by U.FirstName+' '+U.LastName, ET.EstateTypeName, C.CityName, S.StreetName, E.Price
                                end";
            migrationBuilder.Sql(procedure3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "wbt1dI5LE35nLRpUg5XPxhRD4Qc=", "41rJCYoJZui/tkq4wXpqdg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure1 = @"create  PROCEDURE Top3EstatesWithMostRents";
            migrationBuilder.Sql(procedure1);

            string procedure2 = @"CREATE PROCEDURE Last5EstateRenters";
            migrationBuilder.Sql(procedure2);

            string procedure3 = @"CREATE PROCEDURE EstateRentDetails";
            migrationBuilder.Sql(procedure3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "OXiGq6sQCwNcasRkDjeLwTEgZI4=", "hG2BapBZgiBmRlvn1wrUXw==" });
        }
    }
}
