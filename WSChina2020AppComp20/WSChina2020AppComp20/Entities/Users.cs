//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSChina2020AppComp20.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.UserSkills = new HashSet<UserSkills>();
        }
    
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public Nullable<int> CountryId { get; set; }
        public byte[] image { get; set; }
    
        public virtual Coutry Coutry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSkills> UserSkills { get; set; }
    }
}
