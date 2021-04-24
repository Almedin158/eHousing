using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class Picture
    {
        public int PictureId { get; set; }
        public int EstateId { get; set; }
        public Estate Estate { get; set; }
        public byte[] Image { get; set; }
    }
    //Zovi sacu
}
