﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCanine.AdminPortal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProjectCanine2Entities : DbContext
    {
        public ProjectCanine2Entities()
            : base("name=ProjectCanine2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CertificationType> CertificationTypes { get; set; }
        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<EquipmentRestriction> EquipmentRestrictions { get; set; }
        public virtual DbSet<Examiner> Examiners { get; set; }
        public virtual DbSet<Handler> Handlers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<TestResult> TestResults { get; set; }
        public virtual DbSet<TestResultsAnswer> TestResultsAnswers { get; set; }
        public virtual DbSet<TestResultsSection> TestResultsSections { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<vwUserList> vwUserLists { get; set; }
        public virtual DbSet<vwUserRole> vwUserRoles { get; set; }
    
        public virtual int InsertTestResults(string json)
        {
            var jsonParameter = json != null ?
                new ObjectParameter("json", json) :
                new ObjectParameter("json", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertTestResults", jsonParameter);
        }
    }
}
