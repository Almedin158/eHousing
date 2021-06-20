using eHousing.Interface;
using eHousing.Model;
using eHousing.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Controllers
{
    public class UserEstateReviewController : CRUDController<MUserEstateReview, UserEstateReviewSearchRequest, UserEstateReviewUpsertRequest, UserEstateReviewUpsertRequest>
    {
        public UserEstateReviewController(ICRUDService<MUserEstateReview, UserEstateReviewSearchRequest, UserEstateReviewUpsertRequest, UserEstateReviewUpsertRequest> service) : base(service)
        {
        }

    }
}
