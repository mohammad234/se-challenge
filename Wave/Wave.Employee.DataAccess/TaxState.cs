//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wave.Employee.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaxState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaxState()
        {
            this.Expenses = new HashSet<Expense>();
        }
    
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
