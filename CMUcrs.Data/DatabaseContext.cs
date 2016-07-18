using CMUcrs.Data.Core;
using CMUcrs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CMUcrs.Data
{
    public class DatabaseContext : BaseContext
    {
        //public DatabaseContext() : base("DefaultConnection")
        //{
        //}
        public DatabaseContext(string connectionStringName)
            : base(connectionStringName) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}