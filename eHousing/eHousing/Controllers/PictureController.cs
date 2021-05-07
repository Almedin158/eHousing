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
    public class PictureController : CRUDController<MPicture, PictureSearchRequest, PictureUpsertRequest, PictureUpsertRequest>
    {
        public PictureController(ICRUDService<MPicture, PictureSearchRequest, PictureUpsertRequest, PictureUpsertRequest> service) : base(service)
        {
        }
    }
}
