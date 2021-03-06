using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Model
{
    public class MEstateStatus
    {
        public int EstateStatusId { get; set; }
        public int EstateId { get; set; }
        public MEstate Estate { get; set; }
        public DateTime OccupiedSince { get; set; }
        public DateTime OccupiedTill { get; set; }
        public bool IsOccupied { get; set; }
    }
}
