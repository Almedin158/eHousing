//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eHousing.WinUI.DataSources
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Last5EstateRentersEntities : DbContext
    {
        public Last5EstateRentersEntities()
            : base("name=Last5EstateRentersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Last5EstateRenters_Result> Last5EstateRenters(Nullable<int> estateId)
        {
            var estateIdParameter = estateId.HasValue ?
                new ObjectParameter("EstateId", estateId) :
                new ObjectParameter("EstateId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Last5EstateRenters_Result>("Last5EstateRenters", estateIdParameter);
        }
    }
}
