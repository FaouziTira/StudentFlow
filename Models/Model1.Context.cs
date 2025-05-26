

namespace WebApplication44.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lindaaEntities : DbContext
    {
        public lindaaEntities()
            : base("name=lindaaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<batch> batches { get; set; }
        public virtual DbSet<course> courses { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<registation> registations { get; set; }
    }
}
