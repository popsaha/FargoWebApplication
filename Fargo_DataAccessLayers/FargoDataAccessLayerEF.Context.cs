﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fargo_DataAccessLayers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbFargoApplicationEntities : DbContext
    {
        public DbFargoApplicationEntities()
            : base("name=DbFargoApplicationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOOKING_ORDER_DETAILS> BOOKING_ORDER_DETAILS { get; set; }
        public virtual DbSet<COUNTRY_MASTER> COUNTRY_MASTER { get; set; }
        public virtual DbSet<CREDIT_CUSTOMER> CREDIT_CUSTOMER { get; set; }
        public virtual DbSet<DENOMINATION_MASTER> DENOMINATION_MASTER { get; set; }
        public virtual DbSet<ROLE_MASTER> ROLE_MASTER { get; set; }
        public virtual DbSet<ROLE_MODULE_MAPPING> ROLE_MODULE_MAPPING { get; set; }
        public virtual DbSet<STATE_MASTER> STATE_MASTER { get; set; }
        public virtual DbSet<STORE_TRACKING_MASTER> STORE_TRACKING_MASTER { get; set; }
        public virtual DbSet<USERTYPE_MASTER> USERTYPE_MASTER { get; set; }
        public virtual DbSet<BOOKING_DAY_END_TRANSACTION_DETAILS> BOOKING_DAY_END_TRANSACTION_DETAILS { get; set; }
        public virtual DbSet<MENU_MASTER> MENU_MASTER { get; set; }
        public virtual DbSet<MODULE_MASTER> MODULE_MASTER { get; set; }
        public virtual DbSet<SUBMENU_MASTER> SUBMENU_MASTER { get; set; }
        public virtual DbSet<BOOKING_DAY_END_TRANSACTION> BOOKING_DAY_END_TRANSACTION { get; set; }
        public virtual DbSet<BOOKING_PAYMENT_DETAILS> BOOKING_PAYMENT_DETAILS { get; set; }
        public virtual DbSet<CANCELLATION_REASON> CANCELLATION_REASON { get; set; }
        public virtual DbSet<VOID_TRACKING_TRANSACTION> VOID_TRACKING_TRANSACTION { get; set; }
        public virtual DbSet<BOOKING_TRANSACTION_MASTER> BOOKING_TRANSACTION_MASTER { get; set; }
        public virtual DbSet<USER_MASTER> USER_MASTER { get; set; }
        public virtual DbSet<STORE_MASTER> STORE_MASTER { get; set; }
    
        public virtual int SP_GET_USER_MASTER_DATA(Nullable<long> uSER_ID)
        {
            var uSER_IDParameter = uSER_ID.HasValue ?
                new ObjectParameter("USER_ID", uSER_ID) :
                new ObjectParameter("USER_ID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GET_USER_MASTER_DATA", uSER_IDParameter);
        }
    }
}