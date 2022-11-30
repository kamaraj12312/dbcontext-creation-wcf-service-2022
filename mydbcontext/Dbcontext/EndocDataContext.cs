using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mydbcontext
{
    public class EndocDataContext :DbContext
    {
         public EndocDataContext() : base("name=EndocDataContext")
        {
            
        }

        public EndocDataContext(string ConnectionString)
            : base(ConnectionString)
        {

        }
        public virtual DbSet<HolidaySetup> HolidaySetups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HolidaySetup>().ToTable("HolidaySetup", "Tenant2");
        }

    }

}