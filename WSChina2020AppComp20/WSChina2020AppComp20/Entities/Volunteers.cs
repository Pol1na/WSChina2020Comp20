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
    
    public partial class Volunteers
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public int genderId { get; set; }
        public int manageCityId { get; set; }
        public int cityId { get; set; }
        public int skillsId { get; set; }
    
        public virtual City City { get; set; }
        public virtual Genders Genders { get; set; }
        public virtual Skills Skills { get; set; }
    }
}