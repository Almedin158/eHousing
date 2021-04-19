using AutoMapper;
using eHousing.Database;
using eHousing.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Service
{
    public class RoleService : BaseService<MRole, object, Role>
    {
        public RoleService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
