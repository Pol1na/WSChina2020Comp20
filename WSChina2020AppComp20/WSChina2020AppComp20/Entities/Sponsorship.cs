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
    
    public partial class Sponsorship
    {
        public int id { get; set; }
        public string name { get; set; }
        public string item { get; set; }
        public byte[] photo { get; set; }
        public int amount { get; set; }
        public int eventId { get; set; }
        public Nullable<int> skillId { get; set; }
    
        public virtual Events Events { get; set; }
        public virtual Skills Skills { get; set; }
    }
}
