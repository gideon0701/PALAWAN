//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS1
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesItem
    {
        public int Id { get; set; }
        public int quantitySold { get; set; }
        public decimal pricePerUnit { get; set; }
        public string itemsID { get; set; }
        public int SalesId { get; set; }
    
        public virtual Items Items { get; set; }
        public virtual Sales Sales { get; set; }
    }
}
