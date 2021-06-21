using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Model
{
    public class MUserEstateReview
    {
        public int UserEstateReviewId { get; set; }
        public float Rating { get; set; }
        public int UserId { get; set; }
        public MUser User { get; set; }
        public int EstateId { get; set; }
        public MEstate Estate { get; set; }
    }
}
