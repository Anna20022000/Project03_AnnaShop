//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailImportBill
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    
        public virtual ImportBill ImportBill { get; set; }
        public virtual Product Product { get; set; }
    }
}
