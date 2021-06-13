using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public partial class eHousingContext
    {
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {


            List<string> Salt = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Salt.Add(GenerateSalt());
            }
            modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    UserId = 1,
                    FirstName = "Admin",
                    LastName = "Admin",
                    Username = "Admin",
                    Email = "admin@ehousing.com",
                    PhoneNumber = "0600000000",
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "Admin123.")
                },
                new User
                {
                    UserId = 2,
                    FirstName = "Almedin",
                    LastName = "Alikadic",
                    Username = "Almedin",
                    Email = "almedinalikadic@ehousing.com",
                    PhoneNumber = "0600000000",
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "Almedin123.")
                },
                new User
                {
                    UserId = 3,
                    FirstName = "Eldin",
                    LastName = "Alikadic",
                    Username = "Eldin",
                    Email = "eldinalikadic@ehousing.com",
                    PhoneNumber = "0600000000",
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "Eldin123.")
                },
                new User
                {
                    UserId = 4,
                    FirstName = "Dino",
                    LastName = "Alikadic",
                    Username = "Dino",
                    Email = "dinoalikadic@ehousing.com",
                    PhoneNumber = "0600000000",
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "Dino123.")
                }
            );
            modelBuilder.Entity<Role>().HasData
            (
                new Role { RoleId = 1, Name = "Admin" },
                new Role { RoleId = 2, Name = "User" }
            );
            modelBuilder.Entity<UserRoles>().HasData(
                new UserRoles { UserRolesId = 1, UserId = 1, RoleId = 1 },
                new UserRoles { UserRolesId = 2, UserId = 1, RoleId = 2 },
                new UserRoles { UserRolesId = 3, UserId = 2, RoleId = 1 },
                new UserRoles { UserRolesId = 4, UserId = 3, RoleId = 1 },
                new UserRoles { UserRolesId = 5, UserId = 4, RoleId = 1 }
            );
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Sarajevo" },
                new City { CityId = 2, CityName = "Konjic" },
                new City { CityId = 3, CityName = "Mostar" },
                new City { CityId = 4, CityName = "Tuzla" }
            );
            modelBuilder.Entity<Street>().HasData(
                new Street { CityId = 1, StreetId = 1, StreetName = "Džemala Bijedića" },
                new Street { CityId = 1, StreetId = 2, StreetName = "Baščaršijski trg" },
                new Street { CityId = 1, StreetId = 3, StreetName = "Alipašina" },
                new Street { CityId = 1, StreetId = 4, StreetName = "Aščiluk" },
                new Street { CityId = 2, StreetId = 5, StreetName = "Maršala Tita" },
                new Street { CityId = 2, StreetId = 6, StreetName = "Trešanica" },
                new Street { CityId = 2, StreetId = 7, StreetName = "Luka" },
                new Street { CityId = 2, StreetId = 8, StreetName = "Varda" },
                new Street { CityId = 3, StreetId = 9, StreetName = "Zalik" },
                new Street { CityId = 3, StreetId = 10, StreetName = "Fejićeva" },
                new Street { CityId = 3, StreetId = 11, StreetName = "Adema Buće" },
                new Street { CityId = 3, StreetId = 12, StreetName = "Ale Cišica" },
                new Street { CityId = 4, StreetId = 13, StreetName = "Kicelj" },
                new Street { CityId = 4, StreetId = 14, StreetName = "Pazar" },
                new Street { CityId = 4, StreetId = 15, StreetName = "Franjevačka" },
                new Street { CityId = 4, StreetId = 16, StreetName = "Slatina" }
            );
            modelBuilder.Entity<EstateType>().HasData(
                new EstateType { EstateTypeId=1,EstateTypeName="Villa",Image= File.ReadAllBytes("Files/image.png") },
                new EstateType { EstateTypeId = 2, EstateTypeName = "Apartment", Image = File.ReadAllBytes("Files/image.png") },
                new EstateType { EstateTypeId = 3, EstateTypeName = "Motel", Image = File.ReadAllBytes("Files/image.png") }
            );
            modelBuilder.Entity<Estate>().HasData(
                new Estate { EstateId=1,
                    StreetId=1,
                    EstateTypeId=1,
                    EstateName= "Sarajevo Džemala Bijedića Villa 1",
                    PetsAllowed=true,
                    CreationDate=DateTime.Now,
                    EstateDescription="Description",
                    FloorSpace=80,
                    Image= File.ReadAllBytes("Files/image.png"),
                    IsOccupied=true,
                    NumberOfRooms=4,
                    Price=600,
                    UserId=2
                },
                new Estate
                {
                    EstateId = 2,
                    StreetId = 1,
                    EstateTypeId = 1,
                    EstateName = "Sarajevo Džemala Bijedića Villa 2",
                    PetsAllowed = false,
                    CreationDate = DateTime.Now,
                    EstateDescription = "Description",
                    FloorSpace = 80,
                    Image = File.ReadAllBytes("Files/image.png"),
                    IsOccupied = true,
                    NumberOfRooms = 4,
                    Price = 600,
                    UserId = 3
                },
                new Estate
                {
                    EstateId = 3,
                    StreetId = 1,
                    EstateTypeId = 1,
                    EstateName = "Sarajevo Džemala Bijedića Villa 3",
                    PetsAllowed = true,
                    CreationDate = DateTime.Now,
                    EstateDescription = "Description",
                    FloorSpace = 80,
                    Image = File.ReadAllBytes("Files/image.png"),
                    IsOccupied = false,
                    NumberOfRooms = 4,
                    Price = 600,
                    UserId = 4
                },
                new Estate
                {
                    EstateId = 4,
                    StreetId = 1,
                    EstateTypeId = 1,
                    EstateName = "Sarajevo Džemala Bijedića Villa 4",
                    PetsAllowed = false,
                    CreationDate = DateTime.Now,
                    EstateDescription = "Description",
                    FloorSpace = 80,
                    Image = File.ReadAllBytes("Files/image.png"),
                    IsOccupied = false,
                    NumberOfRooms = 4,
                    Price = 600,
                    UserId = 2
                }
            );
        }
    }
}
