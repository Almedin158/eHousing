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
    public class EstateService : CRUDService<MEstate, EstateSearchRequest, Estate, EstateUpsertRequest, EstateUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;

        public EstateService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override async Task<List<MEstate>> Get(EstateSearchRequest request)
        {
            var query = _context.Estates.AsQueryable().OrderBy(c => c.EstateName);

            if (request.CityId != 0)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.Street.CityId == request.CityId);
            }
            if (request.StreetId != 0)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.StreetId == request.StreetId);
            }
            if (request.EstateTypeId != 0)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.EstateTypeId == request.EstateTypeId);
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<MEstate>>(list);
        }
    }
}
