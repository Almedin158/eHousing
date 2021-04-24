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
    public class CityController : CRUDController<MCity,CitySearchRequest,CityUpsertRequest,CityUpsertRequest>
    {
        public CityController(ICRUDService<MCity, CitySearchRequest, CityUpsertRequest, CityUpsertRequest> service) : base(service)
        {
        }

    }
}
