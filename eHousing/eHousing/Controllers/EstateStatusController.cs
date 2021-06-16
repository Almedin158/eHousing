using eHousing.Database;
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
    public class EstateStatusController : CRUDController<MEstateStatus, EstateStatusSearchRequest, EstateStatusUpsertRequest, EstateStatusUpsertRequest>
    {
        public EstateStatusController(ICRUDService<MEstateStatus, EstateStatusSearchRequest, EstateStatusUpsertRequest, EstateStatusUpsertRequest> service) : base(service)
        {
        }

    }
}
