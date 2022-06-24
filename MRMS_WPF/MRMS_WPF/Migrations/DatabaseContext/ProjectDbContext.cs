using MRMS_WPF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRMS_WPF.Migrations.DatabaseContext
{
    public class ProjectDbContext : DbContext 
    {
        public ProjectDbContext() : base("MSMSDbContext")
        {

        }
        public DbSet<Test> Tests { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectDbContext, Configuration>());
        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectDbContext, Configuration>());
        }
    }
}
