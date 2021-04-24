using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Model
{
    public class MStreet
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public int CityId { get; set; }
        public MCity City { get; set; }
    }
}
