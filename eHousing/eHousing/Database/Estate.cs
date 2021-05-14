using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class Estate
    {
        public int EstateId { get; set; }
        public int StreetId { get; set; }
        public Street Street { get; set; }
        public int EstateTypeId { get; set; }
        public EstateType EstateType { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Price { get; set; }
        public string EstateName { get; set; }
        public string EstateDescription { get; set; }
        public int FloorSpace { get; set; }
        public int NumberOfRooms { get; set; }
        public bool PetsAllowed { get; set; }
        public DateTime CreationDate { get; set; }
        public List<EstateStatus> EstateStatus { get; set; }
        public byte[] Image { get; set; }
        public List<Picture> Picture { get; set; }
        public bool IsOccupied { get; set; }
    }
}
