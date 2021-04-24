using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model
{
    public class MUserRoles
    {
        public int UserRolesId { get; set; }
        public int UserId { get; set; }
        public virtual MUser User { get; set; }
        public int RoleId { get; set; }
        public virtual MRole Role { get; set; }
    }
}
