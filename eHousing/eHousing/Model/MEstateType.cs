using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Model
{
    public class MEstateType
    {
        public int EstateTypeId { get; set; }
        public string EstateTypeName { get; set; }
        public byte[] Image { get; set; }
    }
}
