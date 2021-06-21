using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Model
{
    public class MStreet
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public int CityId { get; set; }
        public MCity City { get; set; }
    }
}
