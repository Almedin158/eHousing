using eHousing.Interface;
using eHousing.Model.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Controllers
{
    public class RoleController : BaseController<MRole, object>
    {
        public RoleController(IBaseService<MRole, object> service) : base(service)
        {
        }
    }
}
