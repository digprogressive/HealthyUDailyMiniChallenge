using HealthyUDailyMiniChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Interfaces
{
    public interface IChallengeRepository
    {
        IQueryable<Challenge> Challenges();

    }
}
