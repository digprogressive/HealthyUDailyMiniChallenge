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
            User member1 = new User() { UserName = "Eric", UserId = Guid.NewGuid(), Name = "Eric Preston", Password = "ericp2014" };
            User admin = new User() { UserName = "Admin", UserId = Guid.NewGuid(), Name = "Administrator", Password = "@dm1n" };
            ICollection<Activity> ListOfActs = new List<Activity>() 
                    {
                        new Activity() { ActivityDesc = "Knee kicks", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 60, ActivityDistanceInFeet = 0, ActivityReps = 45, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "Shoulder shrugs", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 60, ActivityDistanceInFeet = 0, ActivityReps = 60, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "A round at Progressive (speed walking)", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 300, ActivityDistanceInFeet = 1000, ActivityReps = 0, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "Push-ups", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 60, ActivityDistanceInFeet = 0, ActivityReps = 10, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "Sit-ups", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 60, ActivityDistanceInFeet = 0, ActivityReps = 20, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "Bench press", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 600, ActivityDistanceInFeet = 0, ActivityReps = 200, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "Pull ups", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 600, ActivityDistanceInFeet = 0, ActivityReps = 100, ActivityImage = "picture of cool stuff" },
                        new Activity() { ActivityDesc = "Squats", ActivityId = Guid.NewGuid(), ActivityDurationInSeconds = 600, ActivityDistanceInFeet = 0, ActivityReps = 300, ActivityImage = "picture of cool stuff" },
                    };
            Challenge quickChallenge = new Challenge
            {
                ChallengeDescription = "7 Minute Beginner Challenge",
                ChallengeId = Guid.NewGuid(),
                CreatedBy = member1,
                Activities = new List<Activity> { ListOfActs.ElementAt(0), ListOfActs.ElementAt(1), ListOfActs.ElementAt(2) },
                MaxDurationInSeconds = 2000
            };
            Challenge beginnerChallenge = new Challenge
            {
                ChallengeDescription = "Intermediate Challenge 1",
                ChallengeId = Guid.NewGuid(),
                CreatedBy = admin,
                Activities = new List<Activity> { ListOfActs.ElementAt(3), ListOfActs.ElementAt(4) },
                MaxDurationInSeconds = 2000
            };
            Challenge advancedChallenge = new Challenge
            {
                ChallengeDescription = "Advanced Challenge 1",
                ChallengeId = Guid.NewGuid(),
                CreatedBy = admin,
                Activities = new List<Activity> { ListOfActs.ElementAt(5), ListOfActs.ElementAt(6) },
                MaxDurationInSeconds = 2000
            };

            ChallengeStatus newChallengeStatus = new ChallengeStatus
            {
                ChallengeStatusId = Guid.NewGuid(),
                AssignedChallenge = quickChallenge,
                Status = true,
                ListOfActivityStatuses = new List<ActivityStatus>() 
                {
                    new ActivityStatus() {ActivityStatusId = Guid.NewGuid(), AssignedActivity = ListOfActs.First(), Status = "Done"
                    }
                }
            };


            context.Challenges.Add(quickChallenge);
            context.Challenges.Add(beginnerChallenge);
            context.Challenges.Add(advancedChallenge);
            //context.ChallengeStatuses.Add(newChallengeStatus);
            context.SaveChanges();

        }

    }
}
