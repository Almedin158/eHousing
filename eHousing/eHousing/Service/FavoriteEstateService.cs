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
    public class FavoriteEstateService : CRUDService<MFavoriteEstate, FavoriteEstateSearchRequest, FavoriteEstate, FavoriteEstateUpsertRequest, FavoriteEstateUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;

        public FavoriteEstateService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override async Task<List<MFavoriteEstate>> Get(FavoriteEstateSearchRequest request)
        {
            var query = _context.FavoriteEstates.Include(x => x.User).Include(x => x.Estate).ThenInclude(x => x.Street).ThenInclude(x => x.City).AsQueryable();

            if (request.UserId != 0)
            {
                query = (IOrderedQueryable<FavoriteEstate>)query.Where(x => x.UserId == request.UserId );
            }

            if (request.UserId != 0&&request.EstateId!=0)
            {
                query = (IOrderedQueryable<FavoriteEstate>)query.Where(x => x.UserId == request.UserId&&x.EstateId==request.EstateId);
            }


          

            var list = await query.ToListAsync();
            return _mapper.Map<List<MFavoriteEstate>>(list);
        }
        public override async Task<MFavoriteEstate> Update(int ID, FavoriteEstateUpsertRequest request)
        {
            var entity = _context.Set<FavoriteEstate>().Find(ID);
            _context.Set<FavoriteEstate>().Attach(entity);
            _context.Set<FavoriteEstate>().Update(entity);

           _mapper.Map(request, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<MFavoriteEstate>(entity);
        }
      
    }
}
