using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMascotar.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace WebMascotar.DAL
{
    public class MascotarContext : DbContext
    {
        public MascotarContext() : base("MascotarContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Alert> Alerts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}