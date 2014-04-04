using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthyUDailyMiniChallenge.Domain.Entities;

namespace HealthyUDailyMiniChallenge.Domain.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            MapToStoredProcedures();
        }
    }
}
