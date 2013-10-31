using HealthyUDailyMiniChallenge.Domain.Entities;
using HealthyUDailyMiniChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Concrete
{
    public class ActivityStatusRepository : HealthyURepository, IActivityStatusRepository
    {
        public IQueryable<ActivityStatus> ActivityStatuses()
        {
            return _healthyUEFDBContext.ActivityStatuses;
        }


    }
}
