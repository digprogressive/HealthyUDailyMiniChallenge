using HealthyUDailyMiniChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Interfaces
{
    public interface IActivityStatusRepository
    {
        IQueryable<ActivityStatus> ActivityStatuses();
    }
}
