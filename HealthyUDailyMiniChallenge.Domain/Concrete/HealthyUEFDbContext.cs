using HealthyUDailyMiniChallenge.Domain.Data;
using HealthyUDailyMiniChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Concrete
{
    public class HealthyUEFDbContext: DbContext
    {
        public DbSet<ActivityStatus> ActivityStatuses { get; set; }
        public DbSet<ChallengeStatus> ChallengeStatuses { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<User> Users { get; set; }

        public HealthyUEFDbContext()
            : base(nameOrConnectionString: "HealthyUEFDbContext")
        {
            var initializer = new HealthyUDatabaseInitializer();
            Database.SetInitializer<HealthyUEFDbContext>(initializer);

            //.Database.ExecuteSqlCommand("ALTER DATABASE HealthyU SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
        }

        //static HealthyUEFDbContext()
        //{
        //    Database.SetInitializer<HealthyUEFDbContext>(new HealthyUDatabaseInitializer());
        //}
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Ent
        //}
    }
}
