using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHousing.Model.Model
{
    public class MRole
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MUserRoles> UserRoles { get; set; }
    }
}
