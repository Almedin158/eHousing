using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class StreetUpsertRequest
    {
        public string StreetName { get; set; }
        public int CityId { get; set; }
    }
}
