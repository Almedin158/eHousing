using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eHousing.Database
{
    public class EstateStatus
    {
        [Key]//Drugi nacin dodjeljivanja primarnog kljuca
        public int EstateStatusId { get; set; }
        public int EstateId { get; set; }
        public Estate Estate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OccupiedSince { get; set; }
        public DateTime OccupiedTill { get; set; }
        public bool IsOccupied { get; set; }
    }
}
