﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WSChina2020BaseComp20Entity : DbContext
    {
        public WSChina2020BaseComp20Entity()
            : base("name=WSChina2020BaseComp20Entity")
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
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SkillsShedule> SkillsShedule { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSkills> UserSkills { get; set; }
    }
}