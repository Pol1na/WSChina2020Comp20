//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSChina2020AppComp20.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Events()
        {
            this.Sponsorship = new HashSet<Sponsorship>();
            this.UserSkills = new HashSet<UserSkills>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string province { get; set; }
        public Nullable<System.DateTime> start_event { get; set; }
        public Nullable<System.DateTime> end_event { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sponsorship> Sponsorship { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSkills> UserSkills { get; set; }
    }
}
