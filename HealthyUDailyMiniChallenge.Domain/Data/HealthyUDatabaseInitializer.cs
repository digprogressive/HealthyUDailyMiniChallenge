using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HealthyUDailyMiniChallenge.Domain.Concrete;
using HealthyUDailyMiniChallenge.Domain.Entities;

namespace HealthyUDailyMiniChallenge.Domain.Data
{
    public class HealthyUDatabaseInitializer : DropCreateDatabaseAlways<HealthyUEFDbContext>
    {
        protected override void Seed(HealthyUEFDbContext context)
        {
            ICollection<Activity> ListOfActs = new List<Activity>() 
                    {
                        new Activity() { ActivityDesc = "Knee kicks", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 60, ActivityDistanceInFeet = 0, ActivityReps = 45, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "Shoulder shrugs", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 60, ActivityDistanceInFeet = 0, ActivityReps = 60, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "A round at Progressive (speed walking)", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 300, ActivityDistanceInFeet = 1000, ActivityReps = 0, ActivityImage = "picture of cool stuff" }
                    };
            Challenge newChallenge = new Challenge
            {
                ChallengeDescription = "7 Minute Challenge",
                ChallengeId = Guid.NewGuid(),
                CreatedBy = new User() { UserName = "Eric", UserId = Guid.NewGuid(), Name = "Eric Preston" },
                ListOfActivities = ListOfActs,
                MaxDurationInSeconds = 2000
            };
            ChallengeStatus newChallengeStatus = new ChallengeStatus
            {
                ChallengeStatusId = Guid.NewGuid(),
                AssignedChallenge = newChallenge,
                Status = true,
                ListOfActivityStatuses = new List<ActivityStatus>() 
                {
                    new ActivityStatus() {ActivityStatusId = Guid.NewGuid(), AssignedActivity = ListOfActs.First(), Status = "Done"
                    }
                }
            };


            context.Challenges.Add(newChallenge);
            context.ChallengeStatuses.Add(newChallengeStatus);
            context.SaveChanges();

        }

    }
}
