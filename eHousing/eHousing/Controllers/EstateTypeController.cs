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
    public class EstateTypeController : CRUDController<MEstateType, EstateTypeSearchRequest, EstateTypeUpsertRequest, EstateTypeUpsertRequest>
    {
        public EstateTypeController(ICRUDService<MEstateType, EstateTypeSearchRequest, EstateTypeUpsertRequest, EstateTypeUpsertRequest> service) : base(service)
        {
        }
    }
}
