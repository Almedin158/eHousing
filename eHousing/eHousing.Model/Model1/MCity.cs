using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Model
{
    public class MCity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public List<MStreet> Street { get; set; }
    }
}
