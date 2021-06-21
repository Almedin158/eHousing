using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class EstateStatusUpsertRequest
    {
        public int EstateId { get; set; }
        public MEstate Estate { get; set; }
        public int UserId { get; set; }
        public MUser User { get; set; }
        public int Months { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OccupiedSince { get; set; } //Set to date of moving into estate
        public DateTime OccupiedTill { get; set; } //Set to date of moving out of estate
    }
}
