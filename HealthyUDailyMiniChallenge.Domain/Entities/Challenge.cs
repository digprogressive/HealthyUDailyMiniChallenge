using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyUDailyMiniChallenge.Domain.Entities
{
    public partial class Challenge 
    {
        public Challenge()
        {
            this.Activities = new List<Activity>();
            this.ChallengeStatuses = new List<ChallengeStatus>();
        }
        public Guid ChallengeId { get; set; }
        public string ChallengeDescription { get; set; }
        public int MaxDurationInSeconds { get; set; }
        public Guid? UserID { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<ChallengeStatus> ChallengeStatuses { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}
