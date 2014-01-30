using HealthyUDailyMiniChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Configurations
{
    public class ChallengeConfiguration: EntityTypeConfiguration<Challenge>
    {
        public ChallengeConfiguration()
        {
           //HasRequired(r => r.Activities).WithMany(r => r.).HasForeignKey(r => r.ChallengeId);
            //HasMany(r => r.Activities).WithRequired(r=>r.ActivityId).HasForeignKey(r => r.ChallengeId);
        }
    }
}
