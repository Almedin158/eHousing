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
    public class EstateStatusService : CRUDService<MEstateStatus, EstateStatusSearchRequest, EstateStatus, EstateStatusUpsertRequest, EstateStatusUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;

        public EstateStatusService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override async Task<List<MEstateStatus>> Get(EstateStatusSearchRequest request)
        {
            var query = _context.EstateStatuses.Include(x=>x.Estate).ThenInclude(x=>x.Street).ThenInclude(x=>x.City).AsQueryable().OrderByDescending(x=>x.OccupiedTill);


            if (request.UserId != 0)
            {
                query = (IOrderedQueryable<EstateStatus>)query.Where(x => x.UserId == request.UserId);
            }

            if (request.EstateId != 0)
            {
                query = (IOrderedQueryable<EstateStatus>)query.Where(x => x.EstateId == request.EstateId);
            }

            var list = await query.ToListAsync();
            return _mapper.Map<List<MEstateStatus>>(list);
        }
    }
}
