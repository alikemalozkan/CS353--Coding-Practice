﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS353.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBCS353Entities : DbContext
    {
        public DBCS353Entities()
            : base("name=DBCS353Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLChannel> TBLChannel { get; set; }
        public virtual DbSet<TBLComment> TBLComment { get; set; }
        public virtual DbSet<TBLEpisode> TBLEpisode { get; set; }
        public virtual DbSet<TBLFriend> TBLFriend { get; set; }
        public virtual DbSet<TBLGenre> TBLGenre { get; set; }
        public virtual DbSet<TBLMessage> TBLMessage { get; set; }
        public virtual DbSet<TBLMovie> TBLMovie { get; set; }
        public virtual DbSet<TBLSeries> TBLSeries { get; set; }
        public virtual DbSet<TBLUser> TBLUser { get; set; }
        public virtual DbSet<TBLWishlist> TBLWishlist { get; set; }
    }
}
