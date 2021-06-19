using AutoMapper;
using eHousing.Database;
using eHousing.Interface;
using eHousing.Model;
using eHousing.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Service
{
    public class UserService : CRUDService<MUser, UserSearchRequest, User, UserUpsertRequest, UserUpsertRequest>, IUserService
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;
        public UserService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async override Task<List<MUser>> Get(UserSearchRequest search)
        {
            var query = _context.Users.Include(x => x.UserRoles).AsQueryable().OrderBy(c => c.FirstName);

            if (!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                query = query.Where(x => x.Username.ToLower().StartsWith(search.FirstName.ToLower())).OrderBy(c => c.FirstName);
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<MUser>>(list);
        }

        public override async Task<MUser> GetById(int ID)
        {
            var entity = await _context.Set<User>()
                .Where(i => i.UserId == ID)
                .Include(i => i.UserRoles)
                .SingleOrDefaultAsync();

            return _mapper.Map<MUser>(entity);
        }
        public override async Task<MUser> Insert(UserUpsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            var entity = _mapper.Map<User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            foreach (var roleID in request.Roles)
            {
                var role = new UserRoles()
                {
                    UserId = entity.UserId,
                    RoleId = roleID
                };

                await _context.UserRoles.AddAsync(role);
            }

            await _context.SaveChangesAsync();

            return _mapper.Map<MUser>(entity);
        }
        public override async Task<MUser> Update(int ID, UserUpsertRequest request)
        {
            var entity = _context.Users.Find(ID);

            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwords do not match!");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            foreach (var RoleID in request.Roles)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleId == RoleID && i.UserId == ID)
                    .SingleOrDefaultAsync();

                if (userRole == null)
                {
                    var newRole = new UserRoles()
                    {
                        UserId = ID,
                        RoleId = RoleID
                    };
                    await _context.Set<UserRoles>().AddAsync(newRole);
                }
            }

            foreach (var RoleID in request.RolesToDelete)
            {
                var userRole = await _context.UserRoles
                    .Where(i => i.RoleId == RoleID && i.UserId == ID)
                    .SingleOrDefaultAsync();

                if (userRole != null)
                {
                    _context.Set<UserRoles>().Remove(userRole);
                }
            }

            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<MUser>(entity);
        }
        public async Task<MUser> Authenticate(UserAuthenticationRequest request)
        {
            var user = await _context.Users
                .Include(i => i.UserRoles)
                .ThenInclude(j => j.Role)
                .FirstOrDefaultAsync(i => i.Username == request.Username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, request.Password);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<MUser>(user);
                }
            }
            return null;
        }
        public async Task<MUser> Register(UserUpsertRequest request)
        {
            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }

            var entity = _mapper.Map<User>(request);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();

            var role = await _context.Roles
                .Where(i => i.Name == "User")
                .SingleAsync();

            var userRole = new UserRoles()
            {
                UserId = entity.UserId,
                RoleId = role.RoleId
            };

            await _context.UserRoles.AddAsync(userRole);
            await _context.SaveChangesAsync();

            return _mapper.Map<MUser>(entity);
        }
        public override async Task<bool> Delete(int ID)
        {
            var entity = await _context.Users.
                Include(i => i.UserRoles).
                FirstOrDefaultAsync(i => i.UserId == ID);

            if (entity.UserRoles.Count != 0)
                _context.UserRoles.RemoveRange(entity.UserRoles);

            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }
        
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public async Task <List<MEstate>> GetFavoriteEstates(int UserId)
        {
            var query = _context.FavoriteEstates
                 .Include(i => i.Estate)
                 .ThenInclude(i => i.User)
                 .Where(i => i.UserId == UserId)
                 .AsQueryable();

           
            var list = await query.ToListAsync();

            return _mapper.Map<List<MEstate>>(list.Select(i => i.Estate).ToList());
        }
        public async Task<MEstate> InsertFavoriteEstate(int UserId, int EstateId)
        {
            var entity = new FavoriteEstate()
            {
               UserId=UserId,
               EstateId=EstateId
            };

            await _context.FavoriteEstates.AddAsync(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<MEstate>(entity.Estate);
        }

        public async Task<MEstate> DeleteFavoriteEstate(int UserId, int EstateId)
        {
            var entity = await _context.FavoriteEstates
               .Where(i => i.UserId == UserId && i.EstateId == EstateId)
               .SingleOrDefaultAsync();
            if (entity != null)
            {
                _context.FavoriteEstates.Remove(entity);
                await _context.SaveChangesAsync();
            }
            return _mapper.Map<MEstate>(entity);
        }

        
    }
}
