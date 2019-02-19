using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Vidlz.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Vidlz.DAL
{
    public class MarkerContext : DbContext
    {
        public MarkerContext() : base("MarkerContext") { }
        public DbSet<Marker> Marker { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}