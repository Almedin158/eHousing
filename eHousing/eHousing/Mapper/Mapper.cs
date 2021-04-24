﻿using AutoMapper;
using eHousing.Database;
using eHousing.Model;
using eHousing.Model.Request;
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
            CreateMap<City, MCity>();
            CreateMap<City, CityUpsertRequest>().ReverseMap();

            //CreateMap<Estate, MEstate>();
            //CreateMap<Estate, EstateUpsertRequest>().ReverseMap();

            CreateMap<Role, MRole>();
            CreateMap<UserRoles, MUserRoles>();

            CreateMap<User, MUser>();
            CreateMap<User, UserUpsertRequest>().ReverseMap();
        }
    }
}