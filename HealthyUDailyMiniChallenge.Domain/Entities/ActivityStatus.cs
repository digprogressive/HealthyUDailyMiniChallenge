using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class ActivityStatus
    {
        public Guid ActivityStatusId { get; set; }
        public string Status { get; set; }
        public Guid? ActivityId { get; set; }
        public virtual Activity AssignedActivity { get; set; }
        public Guid? ChallengeStatusId { get; set; }
        public virtual ChallengeStatus ChallengeStatus { get; set; }
       
    }
}
