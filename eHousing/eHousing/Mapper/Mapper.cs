using AutoMapper;
using eHousing.Database;
using eHousing.Model.Model;
using eHousing.Model.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {

            CreateMap<Role, MRole>();
            CreateMap<UserRoles, MUserRoles>();

            CreateMap<User, MUser>();
            CreateMap<User, UserUpsertRequest>().ReverseMap();
        }
    }
}
