﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WSChina2020BaseComp20Entities2 : DbContext
    {
        public WSChina2020BaseComp20Entities2()
            : base("name=WSChina2020BaseComp20Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<All_Fields> All_Fields { get; set; }
        public virtual DbSet<Blocks> Blocks { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Competitions> Competitions { get; set; }
        public virtual DbSet<Coutry> Coutry { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SkillsShedule> SkillsShedule { get; set; }
        public virtual DbSet<Sponsorship> Sponsorship { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSkills> UserSkills { get; set; }
        public virtual DbSet<Volunteers> Volunteers { get; set; }
    }
}