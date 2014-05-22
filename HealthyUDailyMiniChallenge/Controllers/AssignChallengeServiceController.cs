using HealthyUDailyMiniChallenge.Domain.Concrete;
using HealthyUDailyMiniChallenge.Domain.Entities;
using HealthyUDailyMiniChallenge.Domain.Interfaces;
using HeathyUDailyMiniChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HeathyUDailyMiniChallenge.Controllers
{
    public class AssignChallengeServiceController : ApiController
    {
        private ChallengeStatusRepository challegeStatusRepository = new ChallengeStatusRepository();
        private ActivityStatusRepository activityStatusRepository = new ActivityStatusRepository();

        //private IChallengeRepository _challengeRepository;
        //public AssignChallengeController(IChallengeRepository challengeRepository)
        //{
        //    _challengeRepository = challengeRepository;
        //}

        public HttpResponseMessage Post(ChallengeUser challengeuser)
        {
            IList<ChallengeStatus> challengeStatusList = new List<ChallengeStatus>();
            IList<ActivityStatus> activityStatusList = new List<ActivityStatus>();

            foreach (var user in challengeuser.AssignedUsers)
            {
                foreach (var challenge in challengeuser.AssignedChallenges)
                {
                    ChallengeStatus challengeStatus = new ChallengeStatus() { ChallengeId = challenge.ChallengeId, UserId = user.UserId,Status=false, ChallengeStatusId = Guid.NewGuid() };

                    challengeStatusList.Add(challengeStatus);

                    foreach (var activity in challenge.Activities)
                    {
                        ActivityStatus activityStatus = new ActivityStatus { ActivityStatusId = Guid.NewGuid(), Status = "Jith", ChallengeStatusId = challengeStatus.ChallengeStatusId, ActivityId = activity.ActivityId};

                        activityStatusList.Add(activityStatus);
                    }
                    
                }
            }

            challegeStatusRepository.PostChallengeStatuses(challengeStatusList);
            activityStatusRepository.PostActivityStatuses(activityStatusList);
            
            //add to entity framework
            return Request.CreateResponse(HttpStatusCode.Created, challengeuser);
        }
        //
        // GET: /AssignChallenge/

    }
}
