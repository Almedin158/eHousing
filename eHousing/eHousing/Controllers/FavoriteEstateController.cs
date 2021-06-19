using eHousing.Interface;
using eHousing.Model;
using eHousing.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Controllers
{
    public class FavoriteEstateController : CRUDController<MFavoriteEstate, FavoriteEstateSearchRequest, FavoriteEstateUpsertRequest, FavoriteEstateUpsertRequest>
    {
        public FavoriteEstateController(ICRUDService<MFavoriteEstate, FavoriteEstateSearchRequest, FavoriteEstateUpsertRequest, FavoriteEstateUpsertRequest> service) : base(service)
        {
        }

    }
}
