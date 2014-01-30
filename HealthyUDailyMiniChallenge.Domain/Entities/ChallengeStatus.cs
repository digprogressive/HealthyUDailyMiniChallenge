using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public class ChallengeStatus
    {
        public virtual User ChallengeUser { get; set; }
        public Guid ChallengeStatusId { get; set; }
        public virtual Challenge AssignedChallenge { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<ActivityStatus> ListOfActivityStatuses { get; set; }
    }
}
