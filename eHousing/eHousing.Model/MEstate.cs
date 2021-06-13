using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model
{
    public class MEstate
    {
        public int EstateId { get; set; }
        public int StreetId { get; set; }
        public MStreet Street { get; set; }
        public int EstateTypeId { get; set; }
        public MEstateType EstateType { get; set; }
        public int UserId { get; set; }
        public MUser User { get; set; }
        public int Price { get; set; }
        public string EstateName { get; set; }
        public string EstateDescription { get; set; }
        public int FloorSpace { get; set; }
        public int NumberOfRooms { get; set; }
        public bool PetsAllowed { get; set; }
        public DateTime CreationDate { get; set; }
        public List<MEstateStatus> Rents { get; set; }
        public byte[] Image { get; set; }
        public List<MPicture> Picture { get; set; }
        public bool IsOccupied { get; set; }
        public string Status { get; set; }
    }
}
