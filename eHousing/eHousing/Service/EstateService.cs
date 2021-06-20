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
            var query = _context.Estates.Include(x=>x.EstateType).Include(x=>x.User).Include(c => c.Picture).Include(i => i.Street).ThenInclude(i => i.City).AsQueryable().OrderBy(c => c.EstateName);


            if (request.UserId != 0)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.UserId == request.UserId);
            }

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
            if (request?.PetsAllowed == true)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.PetsAllowed == request.PetsAllowed);
            }
            if (request?.PetsAllowed == false)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.PetsAllowed == request.PetsAllowed);
            }
            if (request?.IsOccupied == true)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.IsOccupied == request.IsOccupied);
            }
            if (request?.IsOccupied == false)
            {
                query = (IOrderedQueryable<Estate>)query.Where(x => x.IsOccupied == request.IsOccupied);
            }

            if (request?.MaxPrice != 0 && request?.MinPrice == 0)
                query = (IOrderedQueryable<Estate>)query.Where(x => x.Price <= request.MaxPrice);

            if (request?.MaxPrice == 0 && request?.MinPrice != 0)
                query = (IOrderedQueryable<Estate>)query.Where(x => x.Price >= request.MinPrice);

            if (request?.MaxPrice!=null && request?.MinPrice!=null)
                query = (IOrderedQueryable<Estate>)query.Where(x => x.Price >= request.MinPrice && x.Price <= request.MaxPrice);

            var list = await query.ToListAsync();
            return _mapper.Map<List<MEstate>>(list);
        }
        public override async Task<MEstate> Update(int ID, EstateUpsertRequest request)
        {
            var entity = _context.Set<Estate>().Find(ID);
            _context.Set<Estate>().Attach(entity);
            _context.Set<Estate>().Update(entity);

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<MEstate>(entity);
        }
    }
}
