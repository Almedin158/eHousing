using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class EstateSearchRequest
    {
        public int CityId { get; set; }
        public int StreetId { get; set; }
        public int EstateTypeId { get; set; }
        public int UserId { get; set; }
        public int Price { get; set; }
        public string EstateName { get; set; }
        public int FloorSpace { get; set; }
        public int NumberOfRooms { get; set; }
        public bool PetsAllowed { get; set; }
        public bool IsOccupied { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
    }
}
