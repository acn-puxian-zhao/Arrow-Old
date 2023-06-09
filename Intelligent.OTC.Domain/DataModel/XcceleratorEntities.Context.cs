﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intelligent.OTC.Domain.DataModel
{
    using Intelligent.OTC.Common.Utils;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class XcceleratorEntities : DbContext
    {
        private static string connectionString = string.Format(ConfigurationManager.ConnectionStrings["XcceleratorEntities"].ConnectionString,
            AESUtil.AESDecrypt(ConfigurationManager.AppSettings["Xccelerator_Password"]));

        public XcceleratorEntities()
            : base(connectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<T_ORG_CENTER> T_ORG_CENTER { get; set; }
        public DbSet<T_ORG_DEAL> T_ORG_DEAL { get; set; }
        public DbSet<T_ORG_GROUP> T_ORG_GROUP { get; set; }
        public DbSet<T_ORG_REGION> T_ORG_REGION { get; set; }
        public DbSet<T_ORG_TEAM> T_ORG_TEAM { get; set; }
        public DbSet<T_USER_EMPLOYEE> T_USER_EMPLOYEE { get; set; }
        public DbSet<T_USERS> T_USERS { get; set; }
        public DbSet<T_MD_EXCEPTIONS> T_MD_EXCEPTIONS { get; set; }
        public DbSet<T_WORKING_CALENDAR> T_WORKING_CALENDAR { get; set; }
    }
}
