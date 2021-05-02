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
    public class StreetController : CRUDController<MStreet, StreetSearchRequest, StreetUpsertRequest, StreetUpsertRequest>
    {
        public StreetController(ICRUDService<MStreet, StreetSearchRequest, StreetUpsertRequest, StreetUpsertRequest> service) : base(service)
        {
        }

    }
}
