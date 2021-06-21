using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Model.Request
{
    public class FavoriteEstateUpsertRequest
    {
        public int UserId { get; set; }
        public int EstateId { get; set; }
    }
}
