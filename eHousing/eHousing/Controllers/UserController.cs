using eHousing.Interface;
using eHousing.Model;
using eHousing.Model.Request;
using Microsoft.AspNetCore.Authorization;
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
    public class UserController : CRUDController<MUser, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        private readonly IUserService _service;
        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }
        [HttpPost("Authenticate")]
        public async Task<MUser> Authenticate(UserAuthenticationRequest request)
        {
            return await _service.Authenticate(request);
        }
        [HttpPost("Register")]
        public async Task<MUser> Register(UserUpsertRequest request)
        {
            return await _service.Insert(request);

        }
        [HttpGet("FavoriteEstate")]
        [Authorize]
        public async Task<List<MEstate>> GetFavoriteEstates(int UserId)
        {
            return await _service.GetFavoriteEstates(UserId);
        }
        [HttpPost("FavoriteEstate/{EstateId}")]
        [Authorize]
        public async Task<MEstate> InsertFavoriteEstate(int UserId, int EstateId)
        {
            return await _service.InsertFavoriteEstate(UserId, EstateId);
        }
        [HttpDelete("FavoriteEstate/{EstateId}")]
        [Authorize]
        public async Task<MEstate> DeleteFavoriteEstate(int UserId, int EstateId)
        {
            return await _service.DeleteFavoriteEstate(UserId, EstateId);
        }
    }
}
