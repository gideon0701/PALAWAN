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
    
    public partial class Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Items()
        {
            this.SalesItem = new HashSet<SalesItem>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<double> PRICE { get; set; }
        public Nullable<int> QTY { get; set; }
        public Nullable<double> WHOLESALEPRICE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesItem> SalesItem { get; set; }
    }
}
