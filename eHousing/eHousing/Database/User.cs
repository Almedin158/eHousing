using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public List<UserRoles> UserRoles { get; set; }
        public List<Estate> Estate { get; set; }
        public int FavoriteEstateId { get; set; }
        public List<FavoriteEstate> FavoriteEstate { get; set; }
        public List<EstateStatus> EstateStatus { get; set; }
        public List<UserEstateReview> UserEstateReviews { get; set; }
    }
}