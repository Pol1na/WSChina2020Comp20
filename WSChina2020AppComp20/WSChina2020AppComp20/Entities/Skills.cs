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
    
    public partial class Skills
    {
        public int SkillID { get; set; }
        public int BlockID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual Blocks Blocks { get; set; }
    }
}