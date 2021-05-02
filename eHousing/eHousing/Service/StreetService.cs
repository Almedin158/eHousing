using AutoMapper;
using eHousing.Database;
using eHousing.Exceptions;
using eHousing.Interface;
using eHousing.Model;
using eHousing.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Service
{
    public class StreetService : CRUDService<MStreet, StreetSearchRequest, Street, StreetUpsertRequest, StreetUpsertRequest>
    {
        private readonly eHousingContext _context;
        private readonly IMapper _mapper;
    
        public StreetService(eHousingContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<MStreet>> Get(StreetSearchRequest request)
        {
            var query = _context.Streets.AsQueryable().OrderBy(c => c.StreetName);

            if (request.CityId!=0)
            {
                query = (IOrderedQueryable<Street>)query.Where(x => x.CityId==request.CityId);
            }
            var list = await query.ToListAsync();

            return _mapper.Map<List<MStreet>>(list);
        }

        public override async Task<MStreet> Insert(StreetUpsertRequest request)
        {
            if (await _context.Streets.AnyAsync(i => i.StreetName == request.StreetName))
            {
                throw new UserException("Street with that name already exists!");
            }
            var entity = _mapper.Map<Street>(request);//Mapira sto sam poslao preko swaggera/winui forme u bazu podataka

            _context.Set<Street>().Add(entity);//Dodaje u bazu pomocu .Set koji mora specificirati o kojoj klasi se radi
            await _context.SaveChangesAsync();//Isto kao i SaveChanges(); Sacuva podatke u bazu

            return _mapper.Map<MStreet>(entity);//Mapira sta vraca swagger
        }
        public override async Task<bool> Delete(int ID)
        {
            var street = await _context.Streets.Where(i => i.StreetId == ID).FirstOrDefaultAsync();
            var estate = await _context.Estates.Where(i => i.StreetId == ID).ToListAsync();

            if (estate.Count > 0)
            {
                _context.Estates.RemoveRange(estate);
                await _context.SaveChangesAsync();
            }
            if (street != null)
            {
                _context.Streets.Remove(street);
                await _context.SaveChangesAsync();

                return true;
            }
            return false;
        }
        public override async Task<MStreet> Update(int ID, StreetUpsertRequest request)
        {
            var street = await _context.Streets.FindAsync(ID);
            request.CityId = street.CityId;
            if (await _context.Streets.AnyAsync(i => i.StreetName == request.StreetName) && request.StreetName != street.StreetName)
            {
                throw new UserException("Street with that name already exists!");
            }

            var entity = _context.Set<Street>().Find(ID);
            _context.Set<Street>().Attach(entity);
            _context.Set<Street>().Update(entity);

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<MStreet>(entity);
        }
    }
}
