using HealthyUDailyMiniChallenge.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyUDailyMiniChallenge.Controllers
{
    public class ChallengeTrackerController : Controller
    {
        private IChallengeStatusRepository _challengeStatusRepository;
        //
        // GET: /ChallengeTracker/
        public ChallengeTrackerController(IChallengeStatusRepository challengeStatusRepository)
        {
            _challengeStatusRepository = challengeStatusRepository;
        }

        public ViewResult Index()
        {
            string username = "Eric";
            return View(_challengeStatusRepository.GetChallengeStatusesByUserName(username));
        }
    }
}
