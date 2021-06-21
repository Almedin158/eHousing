using AutoMapper;
using eHousing.Database;
using eHousing.Model;
using eHousing.Model.Request;
using Microsoft.EntityFrameworkCore;
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
        public override async Task<List<MEstateType>> Get(EstateTypeSearchRequest request)
        {
            var query = _context.EstateTypes.AsQueryable().OrderBy(c => c.EstateTypeName);

            if (!string.IsNullOrWhiteSpace(request?.EstateTypeName))
            {
                query = query.Where(x => x.EstateTypeName.ToUpper().Contains(request.EstateTypeName.ToUpper())).OrderBy(c => c.EstateTypeName);
            }
            var list = await query.ToListAsync();

            return _mapper.Map<List<MEstateType>>(list);
        }
    }
}
