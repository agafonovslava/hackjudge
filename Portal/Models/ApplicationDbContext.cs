using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Portal.Migrations;

namespace Portal.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Judge> Judges { get; set; }

        public DbSet<Opinion> Opinions { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new JudgeDbInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<Portal.Models.Membership> Memberships { get; set; }
    }
}