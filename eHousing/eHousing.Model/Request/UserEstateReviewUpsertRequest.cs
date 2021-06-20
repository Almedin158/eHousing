using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class UserEstateReviewUpsertRequest
    {
        public float Rating { get; set; }
        public int UserId { get; set; }
        public int EstateId { get; set; }
    }
}
