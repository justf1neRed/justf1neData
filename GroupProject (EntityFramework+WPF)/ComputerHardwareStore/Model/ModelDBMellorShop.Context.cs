﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerHardwareStore.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MellorShopEntities1 : DbContext
    {
        public MellorShopEntities1()
            : base("name=MellorShopEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<OrderBuy> OrderBuy { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<UserBuyer> UserBuyer { get; set; }
        public virtual DbSet<v_ProductUser> v_ProductUser { get; set; }
        public virtual DbSet<v_InvoiceInfo> v_InvoiceInfo { get; set; }
        public virtual DbSet<v_UserData> v_UserData { get; set; }
    
        public virtual int stp_UserBuyerAdd(string nameUserBuyer, string contactPhone, ObjectParameter iD_UserBuyer)
        {
            var nameUserBuyerParameter = nameUserBuyer != null ?
                new ObjectParameter("NameUserBuyer", nameUserBuyer) :
                new ObjectParameter("NameUserBuyer", typeof(string));
    
            var contactPhoneParameter = contactPhone != null ?
                new ObjectParameter("ContactPhone", contactPhone) :
                new ObjectParameter("ContactPhone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_UserBuyerAdd", nameUserBuyerParameter, contactPhoneParameter, iD_UserBuyer);
        }
    }
}