﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class Street
    {
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
    //CRUD Desktop
}
