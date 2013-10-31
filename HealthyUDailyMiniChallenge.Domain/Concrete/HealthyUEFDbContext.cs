﻿using HealthyUDailyMiniChallenge.Domain.Entities;
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
    }
}
