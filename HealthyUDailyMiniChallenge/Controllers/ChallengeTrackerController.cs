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
        private IChallengeRepository _challengeRepository;
        //
        // GET: /ChallengeTracker/
        public ChallengeTrackerController(IChallengeRepository challengeRepository)
        {
            _challengeRepository = challengeRepository;
        }

        public ViewResult Index()
        {

            return View(_challengeRepository.Challenges());
        }
    }
}
