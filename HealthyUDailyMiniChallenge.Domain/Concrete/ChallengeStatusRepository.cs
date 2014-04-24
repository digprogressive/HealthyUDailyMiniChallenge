using HealthyUDailyMiniChallenge.Domain.Entities;
using HealthyUDailyMiniChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Concrete
{
    public class ChallengeStatusRepository : HealthyURepository, IChallengeStatusRepository
    {
        public IQueryable<ChallengeStatus> ChallengeStatuses()
        {
            return _healthyUEFDBContext.ChallengeStatuses;
        }

        public IQueryable<ChallengeStatus> GetChallengeStatusesByUserName(string userName)
        {
            return _healthyUEFDBContext.ChallengeStatuses.Select(r => r).Where(r => r.ChallengeUser.UserName.ToLower() == userName.ToLower());
        }

        public bool PostChallengeStatus(Guid userId, Guid challengeId)
        {
            return false;
 
        }

        public bool PostChallengeStatus(ChallengeStatus challengeStatus)
        {
            return false;

 
        }



        public void PostChallengeStatuses(IList<ChallengeStatus> challengeStatusList)
        {
            
            foreach (var entity in challengeStatusList)
            {

                if (_healthyUEFDBContext.ChallengeStatuses.Any(e => e.ChallengeId != entity.ChallengeId && e.UserId != entity.UserId))
                {
                    _healthyUEFDBContext.ChallengeStatuses.Add(entity);
                    _healthyUEFDBContext.SaveChanges();
                }
               
            }           

        }
    }
}
