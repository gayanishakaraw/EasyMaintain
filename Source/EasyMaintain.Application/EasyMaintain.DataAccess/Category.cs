//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyMaintain.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.AircraftModels = new HashSet<AircraftModel>();
            this.SpareParts = new HashSet<SparePart>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string AdditionalData { get; set; }
    
        public virtual ICollection<AircraftModel> AircraftModels { get; set; }
        public virtual ICollection<SparePart> SpareParts { get; set; }
    }
}
