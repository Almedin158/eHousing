using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class StreetSearchRequest
    {
        public string StreetName { get; set; }
        public int CityId { get; set; }
    }
}
