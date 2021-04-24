using AutoMapper;
using eHousing.Database;
using eHousing.Exceptions;
using eHousing.Model;
using eHousing.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Service
{
    public class CityService : CRUDService<MCity,CitySearchRequest,City,CityUpsertRequest,CityUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;

        public CityService(eHousingContext context,IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //public override async Task<List<MCity>> Get(CitySearchRequest request)
        //{
        //    var query = _context.Cities.AsQueryable().OrderBy(c => c.CityName);

        //    if (!string.IsNullOrWhiteSpace(request?.CityName))
        //    {
        //        query = query.Where(x => x.CityName.StartsWith(request.CityName)).OrderBy(c => c.CityName);
        //    }
        //    var list = await query.ToListAsync();

        //    return _mapper.Map<List<MCity>>(list);
        //}
        //public override async Task<MCity> GetById(int ID)
        //{
        //    var entity = await _context.Cities
        //        .Where(i => i.CityId == ID)
        //        .SingleOrDefaultAsync();

        //    return _mapper.Map<MCity>(entity);
        //}
        public override async Task<MCity> Insert(CityUpsertRequest request)
        {
            if (await _context.Cities.AnyAsync(i => i.CityName == request.CityName))
            {
                throw new UserException("City with that name already exists!");
            }
            var entity = _mapper.Map<City>(request);//Mapira sto sam poslao preko swaggera/winui forme u bazu podataka

            _context.Set<City>().Add(entity);//Dodaje u bazu pomocu .Set koji mora specificirati o kojoj klasi se radi
            await _context.SaveChangesAsync();//Isto kao i SaveChanges(); Sacuva podatke u bazu

            return _mapper.Map<MCity>(entity);//Mapira sta vraca swagger
        }
        //public override async Task<MCity> Update(int ID, CityUpsertRequest request)
        //{
        //    var category = await _context.Cities.FindAsync(ID);
        //    if (await _context.Cities.AnyAsync(i => i.CityName == request.CityName) && request.CityName != category.CityName)
        //    {
        //        throw new UserException("Category with that name already exists!");
        //    }

        //    var entity = _context.Set<City>().Find(ID);
        //    _context.Set<City>().Attach(entity);
        //    _context.Set<City>().Update(entity);

        //    _mapper.Map(request, entity);

        //    await _context.SaveChangesAsync();

        //    return _mapper.Map<MCity>(entity);
        //}
        //public override async Task<bool> Delete(int ID)
        //{
        //    var city = await _context.Cities.Where(i => i.CityId == ID).FirstOrDefaultAsync();
        //    var street = await _context.Streets.Where(i => i.CityId == ID).ToListAsync();
        //    var estate = await _context.Estates.Where(i => i.Street.CityId == ID).ToListAsync();

        //    if (street.Count > 0)
        //    {
        //        _context.Estates.RemoveRange(estate);
        //        _context.Streets.RemoveRange(street);
        //        await _context.SaveChangesAsync();
        //    }
        //    if (city != null)
        //    {
        //        _context.Cities.Remove(city);
        //        await _context.SaveChangesAsync();

        //        return true;
        //    }
        //    return false;
        //}
    }
}
