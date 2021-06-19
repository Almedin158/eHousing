using eHousing.Model;
using eHousing.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Interface
{
    public interface IUserService : ICRUDService<MUser, UserSearchRequest, UserUpsertRequest, UserUpsertRequest>
    {
        Task<MUser> Authenticate(UserAuthenticationRequest request);
        Task<MUser> Register(UserUpsertRequest request);
        Task<List<MEstate>> GetFavoriteEstates(int UserId);
        Task<MEstate> InsertFavoriteEstate(int UserId, int EstateId);
        Task<MEstate> DeleteFavoriteEstate(int UserId, int EstateId);
    }
}
