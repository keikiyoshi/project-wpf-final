//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Distributor
    {
        public Distributor()
        {
            this.Debts = new HashSet<Debt>();
            this.FixedRegisters = new HashSet<FixedRegister>();
            this.Orders = new HashSet<Order>();
            this.Sales = new HashSet<Sale>();
            this.Stocks = new HashSet<Stock>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<int> TimeLimit { get; set; }
    
        public virtual ICollection<Debt> Debts { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<FixedRegister> FixedRegisters { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
