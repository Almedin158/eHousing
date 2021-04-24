using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class EstateStatus
    {
        public int EstateStatusId { get; set; }
        public int EstateId { get; set; }
        public Estate Estate { get; set; }
        public DateTime OccupiedSince { get; set; }
        public DateTime OccupiedTill { get; set; }
        public bool IsOccupied { get; set; }
    }
}
