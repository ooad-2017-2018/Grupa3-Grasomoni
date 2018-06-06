using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProASP.Models
{
    public class GrasomoniContext : DbContext
    {
        public GrasomoniContext() : base("AzureConnection")
        {

        }

        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Vozilo> Vozilo { get; set; }
        public DbSet<Stanica> Stanica { get; set; }
        public DbSet<Kartica> Kartica { get; set; }
        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}