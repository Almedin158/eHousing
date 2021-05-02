using AutoMapper;
using eHousing.Database;
using eHousing.Model;
using eHousing.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Service
{
    public class EstateTypeService : CRUDService<MEstateType, EstateTypeSearchRequest, EstateType, EstateTypeUpsertRequest, EstateTypeUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;
        public EstateTypeService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
