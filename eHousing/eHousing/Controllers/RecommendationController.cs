using eHousing.Interface;
using eHousing.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        private readonly IRecommendationService _service;
        public RecommendationController(IRecommendationService service)
        {
            _service = service;
        }
        [HttpGet("GetRecommendedEstates")]
        public Task<List<MEstate>> GetRecommendedCourses(int UserID)
        {
            return _service.GetRecommendedEstates(UserID);
        }
    }
}
