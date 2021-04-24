using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class FavoriteEstate
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int EstateId { get; set; }
        public Estate Estate { get; set; }
    }
}
