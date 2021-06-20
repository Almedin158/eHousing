using AutoMapper;
using eHousing.Database;
using eHousing.Interface;
using eHousing.Mobile;
using eHousing.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Service
{
    public class RecommendationService : IRecommendationService
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;
        private readonly APIService estateService = new APIService("Estate");
        public RecommendationService(eHousingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<MEstate>> GetRecommendedEstates(int UserId)
        {
            try
            {
                if (UserId == 0)
                {
                    throw new Exception();
                }
                List<UserEstateReview> userReviews = await _context.UserEstateReviews.Where(x => x.UserId == UserId)
                    .Include(x => x.User)
                    .Include(x => x.Estate.User)
                    .Include(x => x.Estate)
                    .ThenInclude(x=>x.Street)
                    .ThenInclude(x=>x.City)
                    .ToListAsync();

                List<UserEstateReview> bestUserReviews = userReviews
                    .Where(x => x.Rating >= 3)
                    .ToList();

                if (bestUserReviews.Count > 0)
                {
                    List<EstateType> types = new List<EstateType>();

                    foreach (var type in bestUserReviews)
                    {
                        var estateTypes = await _context.Estates.Where(m => m.EstateTypeId == type.Estate.EstateTypeId&&m.Street.CityId==type.Estate.Street.CityId)
                           .Select(s => s.EstateType)
                           .ToListAsync();

                        foreach (var x in estateTypes)
                        {
                            bool add = true;
                            for (int i = 0; i < types.Count; i++)
                            {
                                if (x.EstateTypeName == types[i].EstateTypeName)
                                {
                                    add = false;
                                }
                            }
                            if (add)
                            {
                                types.Add(x);
                            }
                        }
                    }


                    List<Estate> final = new List<Estate>();
                    var userRentedEstates = await _context.EstateStatuses.Where(i => i.UserId == UserId).ToListAsync();
                    foreach (var item in types)
                    {
                        var typeEstates = await _context.Estates
                            .Where(s => s.EstateTypeId == item.EstateTypeId)
                            .Include(x => x.EstateType)
                            .Include(i => i.User)
                            .Include(i=>i.Street)
                            .ThenInclude(i=>i.City)
                            .ToListAsync();

                        foreach (var estate in typeEstates)
                        {
                            bool add = true;
                            var DoesItContain = userRentedEstates.Where(m => m.EstateId == estate.EstateId).Any();
                            if (DoesItContain == false)
                            {
                                for (int i = 0; i < final.Count; i++)
                                {
                                    if (estate.EstateName == final[i].EstateName)
                                    {
                                        add = false;
                                    }
                                }
                                foreach (var rate in userReviews)
                                {
                                    if (estate.EstateName == rate.Estate.EstateName)
                                    {
                                        add = false;
                                    }
                                }
                                if (add)
                                {
                                    final.Add(estate);
                                }
                            }


                        }
                    }


                    final = final.OrderBy(x => Guid.NewGuid()).Take(6).ToList();

                    return _mapper.Map<List<MEstate>>(final);
                }
                throw new Exception();
            }
            catch
            {
                return _mapper.Map<List<MEstate>>(null);
            }
        }
    }
}
