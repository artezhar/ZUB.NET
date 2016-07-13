using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZUB.Domain;

namespace ZUB.Models
{
    public class MainContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Problem> Problems { get; set; }

        public MainContext():base("DefaultConnection")
        {
            
        } 

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<Doctor>().HasRequired(d => d.Position).WithMany(p => p.Doctors);
            mb.Entity<Problem>().HasMany(p => p.Doctors).WithMany(d => d.Problems);
        }
    }
}