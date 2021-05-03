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
    public class EstateController : CRUDController<MEstate, EstateSearchRequest, EstateUpsertRequest, EstateUpsertRequest>
    {
        public EstateController(ICRUDService<MEstate, EstateSearchRequest, EstateUpsertRequest, EstateUpsertRequest> service) : base(service)
        {
        }
    }
}
