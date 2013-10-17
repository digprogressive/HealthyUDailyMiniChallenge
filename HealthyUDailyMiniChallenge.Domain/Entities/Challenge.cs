using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class Challenge
    {
        public int ChallengeId { get; set; }
        public string ChallengeDescription { get; set; }
        public int MaxDurationInSeconds { get; set; }
        public IEnumerable<Activity> ListOfActivities { get; set; }
        public string CreatedBy { get; set; }
    }
}
