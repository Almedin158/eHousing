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
    public class PictureService : CRUDService<MPicture, PictureSearchRequest, Picture, PictureUpsertRequest, PictureUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;

        public PictureService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override async Task<List<MPicture>> Get(PictureSearchRequest request)
        {
            var query = _context.Pictures.AsQueryable().OrderBy(c=>c.PictureId);

            if (request.EstateId != 0)
            {
                query = (IOrderedQueryable<Picture>)query.Where(x => x.EstateId == request.EstateId);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<MPicture>>(list);
        }
    }
}
