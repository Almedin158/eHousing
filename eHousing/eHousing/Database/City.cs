using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public List<Street> Street { get; set; }
    }
    //CRUD Desktop
}
