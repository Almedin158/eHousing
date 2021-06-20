using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class UserEstateReview
    {
        [Key]
        public int UserEstateReviewId { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int EstateId { get; set; }
        public Estate Estate { get; set; }
    }
}
