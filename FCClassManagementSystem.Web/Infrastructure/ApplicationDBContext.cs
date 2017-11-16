using FCCClassManagementSystem.Domain.Entities;
using FCClassManagementSystem.Web.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FCClassManagementSystem.Web.Infrastructure
{
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        public ApplicationDBContext() : base("FCCMSystem") { }

        static ApplicationDBContext()
        {
           // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDBContext>(new FCCDbInit());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ApplicationDBContext>());
        }

        public DbSet<FitnessClass> FitnessClass { get; set; }
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Schedule> Schedule { get; set; }

        public static ApplicationDBContext Create()
        {
            return new ApplicationDBContext();
        }

    }
}

public class FCCDbInit: NullDatabaseInitializer<ApplicationDBContext>
{

}