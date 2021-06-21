using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class PictureSearchRequest
    {
        public int EstateId { get; set; }
        public byte[] Image { get; set; }
    }
}
