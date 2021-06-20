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
    public class UserEstateReviewService : CRUDService<MUserEstateReview, UserEstateReviewSearchRequest, UserEstateReview, UserEstateReviewUpsertRequest, UserEstateReviewUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;

        public UserEstateReviewService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MUserEstateReview>> Get(UserEstateReviewSearchRequest request)
        {
            var query = _context.UserEstateReviews.AsQueryable();

            if (request.UserId != 0)
            {
                query = (IOrderedQueryable<UserEstateReview>)query.Where(x => x.UserId == request.UserId);
            }
            if (request.EstateId != 0)
            {
                query = (IOrderedQueryable<UserEstateReview>)query.Where(x => x.EstateId == request.EstateId);
            }
            if (request.Rating != 0)
            {
                query = (IOrderedQueryable<UserEstateReview>)query.Where(x => x.Rating == request.Rating);
            }

            var list = await query.ToListAsync();

            return _mapper.Map<List<MUserEstateReview>>(list);
        }
        
    }
}
