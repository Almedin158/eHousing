using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model
{
    public class MPicture
    {
        public int PictureId { get; set; }
        public int EstateId { get; set; }
        public MEstate Estate { get; set; }
        public byte[] Image { get; set; }
    }
}
