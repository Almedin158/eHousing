using eHousing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Interface
{
    public interface IRecommendationService
    {
        Task<List<MEstate>> GetRecommendedEstates(int UserId);
    }
}
