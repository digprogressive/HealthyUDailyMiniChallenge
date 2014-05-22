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


        public void PostActivityStatuses(IList<ActivityStatus> activityStatusList)
        {

            foreach (var entity in activityStatusList)
            {

                if (_healthyUEFDBContext.ActivityStatuses.Where(e => e.ActivityId != entity.ActivityId && e.ChallengeStatusId != entity.ChallengeStatusId).Count()==0)
                {
                    _healthyUEFDBContext.ActivityStatuses.Add(entity);
                    _healthyUEFDBContext.SaveChanges();
                }

            }

        }

    }
}
