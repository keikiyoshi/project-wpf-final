//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unilever.DTO.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Province
    {
        public Province()
        {
            this.Distributors = new HashSet<Distributor>();
        }
    
        public int Id { get; set; }
        public string ProvinceName { get; set; }
    
        public virtual ICollection<Distributor> Distributors { get; set; }
    }
}
