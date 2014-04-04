using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class ChallengeStatus
    {
         public ChallengeStatus()
        {
            this.ActivityStatus = new List<ActivityStatus>();
        }

        public Guid ChallengeStatusId { get; set; }
        public bool Status { get; set; }
        public Guid? ChallengeId { get; set; }
        public Guid? UserId { get; set; }
        public virtual User ChallengeUser { get; set; }
        public virtual Challenge AssignedChallenge { get; set; } 
        public virtual ICollection<ActivityStatus> ActivityStatus { get; set; }
    }
}
