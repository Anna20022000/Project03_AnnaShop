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
    
    public partial class OderForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OderForm()
        {
            this.DetalOders = new HashSet<DetailOrder>();
        }
    
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public string Note { get; set; }
        public bool State { get; set; }
        public System.DateTime DateCreate { get; set; }
        public System.DateTime DateShip { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailOrder> DetalOders { get; set; }
        public virtual User User { get; set; }
    }
}
