using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class PictureUpsertRequest
    {
        public int EstateId { get; set; }
        public byte[] Image { get; set; }
    }
}
